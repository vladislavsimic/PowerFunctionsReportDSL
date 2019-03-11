using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode.Model
{
	public class UIReportDataProvider : ICodeHandler
	{
		private ModelRoot root;

		private Dictionary<string, string> generatedCode;

		public UIReportDataProvider(ModelRoot root)
		{
			this.root = root;
			generatedCode = new Dictionary<string, string>();
		}


		public Dictionary<string, string> GeneratedCode
		{
			get
			{
				return generatedCode;
			}
			set
			{
				generatedCode = value;
			}
		}

		public void ObtainCode()
		{
			GeneratedCode.Add("usings", GetUsings());
			GeneratedCode.Add("classNamespace", GetClassNamespace());
			GeneratedCode.Add("fields", GetPrivateFields());
			GeneratedCode.Add("constructor", GetConstructor());
			GeneratedCode.Add("methods", GetMethods());
		}

		private string GetMethods()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine(GetResultsHandlerMethod());
			sb.AppendLine(GetFillingResultsMethods());

			return sb.ToString();
		}

		private string GetFillingResultsMethods()
		{
			StringBuilder sb = new StringBuilder();

			List<Tab> tabs = new List<Tab>();
			foreach (ModelType type in root.Types)
			{
				if (!(type is Tab))
				{
					continue;
				}
				Tab tab = type as Tab;
				if (tab.TargetTabbed.Count == 0)
				{
					tabs.Add(type as Tab);
				}
			}

			foreach (Tab tab in tabs)
			{
				if (tab.DataGrid != null )
				{
					DataGrid model = tab.DataGrid;

					sb.AppendLine(Resources.Tab2 + "internal void Fill" + model.Name + "Results(" + model.Name + "Results result)");
					sb.AppendLine(Resources.Tab2 + "{");

					sb.AppendLine(Resources.Tab3 + "List<" + model.Name + "ViewModel> records = new List<" + model.Name + "ViewModel>();");
					sb.AppendLine(Resources.Tab3 + "foreach (" + model.Name + "Record record in result.Records)");
					sb.AppendLine(Resources.Tab3 + "{");
					sb.AppendLine(Resources.Tab4 + "records.Add(new " + model.Name + "ViewModel(record, isTabularViewActive));");
					sb.AppendLine(Resources.Tab3 + "}");
					sb.AppendLine(Resources.Tab3 + "if (records.Count > 0)");
					sb.AppendLine(Resources.Tab3 + "{");
					sb.AppendLine(Resources.Tab4 + "byte minLevel = records.Min(rec => rec.DataGridTreeViewItemInfo.Level);");
					sb.AppendLine(Resources.Tab4 + "if (minLevel > 0)");
					sb.AppendLine(Resources.Tab4 + "{");
					sb.AppendLine(Resources.Tab5 + "foreach (" + model.Name + "ViewModel record in records)");
					sb.AppendLine(Resources.Tab5 + "{");
					sb.AppendLine(Resources.Tab6 + "record.DataGridTreeViewItemInfo.Level = (byte)(record.DataGridTreeViewItemInfo.Level - minLevel);");
					sb.AppendLine(Resources.Tab5 + "}");
					sb.AppendLine(Resources.Tab4 + "}");
					sb.AppendLine(Resources.Tab3 + "}");

					sb.AppendLine(Resources.Tab3 + "reportView." + tab.DataGrid.Name + "DataGrid.ItemsSource = records;");

					sb.AppendLine(Resources.Tab2 + "}");
					sb.AppendLine();
				}
			}
			return sb.ToString();
		}

		private string GetResultsHandlerMethod()
		{
			StringBuilder sb = new StringBuilder();

			List<Tab> tabs = new List<Tab>();
			foreach (ModelType type in root.Types)
			{
				if (!(type is Tab))
				{
					continue;
				}
				Tab tab = type as Tab;
				if (tab.TargetTabbed.Count == 0)
				{
					tabs.Add(type as Tab);
				}
			}

			sb.AppendLine(Resources.Tab2 + "protected internal void ResultHandler(JobResult result)");
			sb.AppendLine(Resources.Tab2 + "{");
			sb.AppendLine(Resources.Tab3 + "messageHelper.HideMessage();");
			sb.AppendLine(Resources.Tab3 + "if (result is EMSLoadFlowReportResult)");
			sb.AppendLine(Resources.Tab3 + "{");
			sb.AppendLine(Resources.Tab4 + root.Name + "ReportResult reportResult = (" + root.Name +"ReportResult)result;");
			sb.AppendLine(Resources.Tab4 + "switch (reportResult." + root.Name + "ReportType)");
			sb.AppendLine(Resources.Tab4 + "{");

			foreach (Tab tab in tabs)
			{
				if (tab.DataGrid != null )
				{
					DataGrid model = tab.DataGrid;

					sb.AppendLine(Resources.Tab5 + "case " + root.Name + "ReportType." + tab.Name + ":");
					sb.AppendLine(Resources.Tab6 + "{");
					sb.AppendLine(Resources.Tab7 + model.Name + "Results results = reportResult as " + model.Name + "Results;");
					sb.AppendLine(Resources.Tab7 + "if (results != null && results.Records.Count != 0)");
					sb.AppendLine(Resources.Tab7 + "{");
					sb.AppendLine(Resources.Tab8 + "Fill" + model.Name + "Results(results);");
					sb.AppendLine(Resources.Tab7 + "}");
					sb.AppendLine(Resources.Tab7 + "break;");
					sb.AppendLine(Resources.Tab6 + "}");
				}
				
			}

			sb.AppendLine(Resources.Tab5 + "case " + root.Name + "ReportType.NoResults:");
			sb.AppendLine(Resources.Tab6 + "break;");
			sb.AppendLine(Resources.Tab5 + "default:");
			sb.AppendLine(Resources.Tab6 + "break;");

			sb.AppendLine(Resources.Tab4 + "}");
			sb.AppendLine(Resources.Tab3 + "}");
			sb.AppendLine(Resources.Tab2 + "}");

			return sb.ToString();
		}

		private string GetConstructor()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine(Resources.Tab2 + "public " + root.Name + "ReportDataProvider(" + root.Name + "ReportView reportView)");
			sb.AppendLine(Resources.Tab2 + "{");
			sb.AppendLine(Resources.Tab3 + "this.reportView = reportView;");
			sb.AppendLine(Resources.Tab3 + "jobGuid = Guid.NewGuid().ToString();");
			sb.AppendLine(Resources.Tab3 + "jobManager = ServiceLocator.Current.GetInstance<IJobManager>();");
			sb.AppendLine(Resources.Tab3 + "job = new " + root.Name + "ReportJob();");
			sb.AppendLine(Resources.Tab3 + "ReportParameter = new EMSLoadFlowReportJobParam();");
			sb.AppendLine(Resources.Tab3 + "ReportParameter.HierarchyType = HierarchyType.Container;");
			sb.AppendLine(Resources.Tab3 + "electricProvider = ServiceLocator.Current.GetInstance<IElectricsProvider>();");
			sb.AppendLine(Resources.Tab3 + "ReportParameter.HierarchyNetworkType = HierarchyNetworkType.EMS;");
			sb.AppendLine(Resources.Tab3 + "IsInitialized = false;");
			sb.AppendLine(Resources.Tab3 + "messageHelper = new GrayableWindowMessageHelper(\"Please Wait\", \"" + root.Name +" Report: " + root.Name + "ReportJob\");");
			sb.AppendLine(Resources.Tab2 + "}");

			return sb.ToString();
		}

		private string GetPrivateFields()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine(Resources.Tab2 + "private IJobManager jobManager;");
			sb.AppendLine(Resources.Tab2 + "private string jobGuid;");
			sb.AppendLine(Resources.Tab2 + "private EMSLoadFlowReportJob job;");
			sb.AppendLine(Resources.Tab2 + "private EMSLoadFlowReportView reportView;");
			sb.AppendLine(Resources.Tab2 + "private IElectricsProvider electricProvider;");
			sb.AppendLine(Resources.Tab2 + "private bool isTabularViewActive;");
			sb.AppendLine(Resources.Tab2 + "private GrayableWindowMessageHelper messageHelper;");

			return sb.ToString();
		}

		private string GetClassNamespace()
		{
			return "TelventDMS.UI.Components." + root.Name + ".Models";
		}

		private string GetUsings()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine("using Microsoft.Practices.ServiceLocation;");
			sb.AppendLine("using System;");
			sb.AppendLine("using System.Collections.Generic;");
			sb.AppendLine("using System.ComponentModel;");
			sb.AppendLine("using System.Linq;");
			sb.AppendLine("using System.ServiceModel;");
			sb.AppendLine("using System.Windows;");
			sb.AppendLine("using System.Windows.Controls;");
			sb.AppendLine("using System.Windows.Data;");
			sb.AppendLine("using TelventDMS.Common.Platform.Logger;");
			sb.AppendLine("using TelventDMS.Common.DMS.Common;");
			sb.AppendLine("using TelventDMS.UI.Components.CompositeCommon;");
			sb.AppendLine("using TelventDMS.UI.Components.CompositeCommon.Interfaces;");
			sb.AppendLine("using TelventDMS.UI.Components.EMSLoadFlow.Properties;");
			sb.AppendLine("using TelventDMS.UI.Components.EMSLoadFlow.View;");
			sb.AppendLine("using TelventDMS.UI.Components.EMSLoadFlow.ViewModels;");
			sb.AppendLine("using TelventDMS.UI.Resources;");
			sb.AppendLine("using TelventDMS.UI.ServiceProxies;");
			sb.AppendLine("using TelventDMS.UI.Components.CoreInterfaces.Interfaces;");
			sb.AppendLine("using TelventDMS.Common.Platform.ETWPerformance;");

			return sb.ToString();
		}
	}
}
