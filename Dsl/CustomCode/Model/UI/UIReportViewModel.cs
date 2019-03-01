using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode.Model
{
	public class UIReportViewModel : ICodeHandler
	{
		private ModelRoot root;

		private Dictionary<string, string> generatedCode;

		public UIReportViewModel(ModelRoot root)
		{
			this.root = root;
		}

		public Dictionary<string,string> GeneratedCode
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
			GeneratedCode = new Dictionary<string, string>();
			GeneratedCode.Add("usings", GetUsings());
			GeneratedCode.Add("classNamespace", GetNamespace());
			GeneratedCode.Add("fields", GetViewModelFields());
			GeneratedCode.Add("constructor", GetViewModelConstructor());
			GeneratedCode.Add("properties", GetViewModelProperties());
			GeneratedCode.Add("methods", GetMethods());
		}

		private string GetMethods()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine(Resources.Tab2 + "protected internal void HierarchyTreeViewRefreshed()");
			sb.AppendLine(Resources.Tab2 + "{");
			sb.AppendLine(Resources.Tab3 + "DataProvider.Refresh();");
			sb.AppendLine(Resources.Tab2 + "}");

			return sb.ToString();
		}

		private string GetViewModelProperties()
		{
			StringBuilder sb = new StringBuilder();

			return sb.ToString();
		}

		private string GetViewModelConstructor()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine(Resources.Tab2 + "public " + root.Name + "ReportViewModel(" + root.Name + "ReportView reportView) : base(reportView)");
			sb.AppendLine(Resources.Tab2 + "{");
			sb.AppendLine(Resources.Tab3 + "this.reportView = reportView;");
			sb.AppendLine(Resources.Tab3 + "this.reportView.CommonHtv.HierarchyTreeViewRefreshed += HierarchyTreeViewRefreshed;");
			sb.AppendLine(Resources.Tab3 + "TreeDataProvider = new HierarchyTreeDataProvider(new List<DMSType>() { DMSType.SOURCE }, HierarchyNetworkType.EMS);");
			sb.AppendLine(Resources.Tab3 + "TreeDataProvider.ExpandTreeOnOpenEventHandler += TreeDataProvider_ExpandTreeOnReportEventHandler;");
			sb.AppendLine(Resources.Tab3 + "hierarchyType = HierarchyType.Container;");
			sb.AppendLine(Resources.Tab3 + "this.reportView.Loaded += ReportView_Loaded;");
			sb.AppendLine(Resources.Tab3 + "SummaryUniqueName = " + root.Name + "ModuleCommands.ShowReport;");
			sb.AppendLine(Resources.Tab2 + "}");

			return sb.ToString();
		}

		private string GetViewModelFields()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine(Resources.Tab2 + "private " + root.Name + "ReportView reportView;" );
			sb.AppendLine(Resources.Tab2 + "private HierarchyType hierarchyType;");
			sb.AppendLine(Resources.Tab2 + "private RelayCommand refreshCommand;");

			return sb.ToString();
		}

		private string GetNamespace()
		{
			return "TelventDMS.UI.Components." + root.Name + ".ViewModels";
		}

		private string GetUsings()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine("using System;");
			sb.AppendLine("using System.Collections.Generic;");
			sb.AppendLine("using System.Globalization;");
			sb.AppendLine("using System.Windows;");
			sb.AppendLine("using System.Windows.Controls;");
			sb.AppendLine("using System.Windows.Input;");
			sb.AppendLine("using TelventDMS.Common.Components.Utils;");
			sb.AppendLine("using TelventDMS.Common.DMS.Common;");
			sb.AppendLine("using TelventDMS.UI.Components.CompositeCommon.Commands;");
			sb.AppendLine("using TelventDMS.UI.Components.CompositeCommon.Converters;");
			sb.AppendLine("using TelventDMS.UI.Components.CompositeCommon.Licence;");
			sb.AppendLine("using TelventDMS.UI.Components.CompositeCommon.ViewModels;");
			sb.AppendLine("using TelventDMS.UI.Components.CustomControls.HierarchyTreeViewControl.DataProvider;");
			sb.AppendLine("using TelventDMS.UI.Components.CustomControls.ReportGeneralInfoControl;");
			sb.AppendLine("using TelventDMS.UI.Components.CustomControls.ReportGeneralInfoControl.Models;");
			sb.AppendLine("using TelventDMS.UI.Components.EMSLoadFlow.Models;");
			sb.AppendLine("using TelventDMS.UI.Components.EMSLoadFlow.View;");
			sb.AppendLine("using TelventDMS.UI.Components.FunctionCommon;");
			sb.AppendLine("using TelventDMS.UI.Model.Electrical;");
			sb.AppendLine("using TelventDMS.UI.ServiceProxies;");

			return sb.ToString();
		}
	}
}
