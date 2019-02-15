using SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode.Converters;
using SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode.Helpers
{
	public static class UIHelper
	{
		internal static string GetUsings(JMSModel jmsModel)
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine("using System;");
			sb.AppendLine("using TelventDMS.Common.Platform.Logger;");
			sb.AppendLine("using TelventDMS.Common.Component.Utils;");
			sb.AppendLine("using TelventDMS.Common.DMS.Common;");
			sb.AppendLine("using TelventDMS.UI.Components.CompositeCommon;");
			sb.AppendLine("using TelventDMS.UI.Components.CompositeCommon.Converters;");
			sb.AppendLine("using TelventDMS.UI.Components.CompositeCommon.Interfaces;");
			sb.AppendLine("using TelventDMS.UI.Components.CompositeCommon.ViewModels;");
			sb.AppendLine("using TelventDMS.UI.Model.Electrical;");
			sb.AppendLine("using TelventDMS.UI.ServiceProxies;");
			sb.AppendLine("using TelventDMS.Common.DMS.Common.Converters;");

			return sb.ToString();
		}

		internal static string GetXamlCode(DataGrid dataGrid)
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine("<UserControl x:Class=\"TelventDMS.UI.Components." + dataGrid.ModelRoot.Name + ".View." + dataGrid.Name + "View\"");
			sb.AppendLine(Resources.Tab3 + "xmlns=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation\"");
			sb.AppendLine(Resources.Tab3 + "xmlns:x=\"http://schemas.microsoft.com/winfx/2006/xaml\"");
			sb.AppendLine(Resources.Tab3 + "xmlns:mc=\"http://schemas.openxmlformats.org/markup-compatibility/2006\"");
			sb.AppendLine(Resources.Tab3 + "xmlns:d=\"http://schemas.microsoft.com/expression/blend/2008\"");

			sb.AppendLine(GetAdditionalLibraries(dataGrid));

			sb.AppendLine(Resources.Tab3 + ">");

			sb.AppendLine(GetControlResources(dataGrid));

			sb.AppendLine(GetDataGridContent(dataGrid));

			sb.AppendLine("</UserControl>");

			return sb.ToString();
		}

		private static string GetDataGridContent(DataGrid dataGrid)
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine(Resources.Tab1 + "<Grid>");
			sb.AppendLine(Resources.Tab1 + "</Grid>");

			return sb.ToString();
		}

		private static string GetAdditionalLibraries(DataGrid dataGrid)
		{
			StringBuilder sb = new StringBuilder();

			string projectName = dataGrid.ModelRoot.Name;

			sb.AppendLine(Resources.Tab3 + "xmlns:local=\"clr -namespace:TelventDMS.UI.Components." + projectName + ".View\"");
			sb.AppendLine(Resources.Tab3 + "xmlns:localization = \"clr-namespace:TelventDMS.UI.Components." + projectName + "\"");


			return sb.ToString();
		}

		private static string GetControlResources(DataGrid dataGrid)
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine(Resources.Tab1 + "<UserControl.Resources>");
			sb.AppendLine(Resources.Tab2 + "<ResourceDictionary>");
			sb.AppendLine(Resources.Tab3 + "<localization:LocalizedStrings x:Key=\"LocalizedStrings\" />");
			sb.AppendLine(Resources.Tab2 + "</ResourceDictionary>");
			sb.AppendLine(Resources.Tab1 + "</UserControl.Resources>");

			return sb.ToString();
		}

		internal static string GetViewModelFields(JMSModel jmsModel)
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine(Resources.Tab2 + "private " + jmsModel.Name + " reportRecord;");
			sb.AppendLine();
			sb.AppendLine(Resources.Tab2 + "private DMSType recordType;");
			sb.AppendLine();
			sb.AppendLine(Resources.Tab2 + "private bool rowIsNotVisible;");
			sb.AppendLine();
			sb.AppendLine(Resources.Tab2 + "private bool tabularViewIsActive;");

			return sb.ToString();
		}

		internal static string GetViewModelProperties(JMSModel jmsModel)
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine(Resources.DetailsElementGid);

			sb.AppendLine(Resources.DataGridTreeViewItemInfo);

			sb.AppendLine(Resources.RecordType);

			sb.AppendLine(Resources.Title);

			sb.AppendLine(Resources.GetReportRecordFor(jmsModel));

			sb.AppendLine(Resources.TabularViewIsActive);

			sb.AppendLine(Resources.RowIsNotVisible);

			foreach (ClassAttribute attribute in jmsModel.Attributes)
			{
				sb.AppendLine(Resources.Tab2 + "public " + TypesToCSharpType.Convert(attribute) + " " + attribute.Name[0].ToString().ToUpper() + attribute.Name.Substring(1));
				sb.AppendLine(Resources.Tab2 + "{");
				sb.AppendLine(Resources.Tab3 + "get");
				sb.AppendLine(Resources.Tab3 + "{");
				if(attribute.MeasurementType != MeasurementType.None)
				{
					sb.AppendLine(Resources.Tab4 + "return UnitConverterHelper.ConvertFromDMS(MeasurementType." + attribute.MeasurementType.ToString() + ", reportRecord." + attribute.Name[0].ToString().ToUpper() + attribute.Name.Substring(1) + ");");
				}
				else
				{
					sb.AppendLine(Resources.Tab4 + "return reportRecord." + attribute.Name[0].ToString().ToUpper() + attribute.Name.Substring(1) + ";");
				}
				sb.AppendLine(Resources.Tab3 + "}");
				sb.AppendLine(Resources.Tab2 + "}");
				sb.AppendLine();
			}

			return sb.ToString();
		}

		internal static string GetViewModelConstructor(JMSModel jmsModel)
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine(Resources.Tab2 + "public " + jmsModel.Name + "ViewModel(" + jmsModel.Name + " reportRecord, bool tabularViewActive)");
			sb.AppendLine(Resources.Tab2 + "{");
			sb.AppendLine(Resources.Tab3 + "if (reportRecord == null)");
			sb.AppendLine(Resources.Tab3 + "{");
			sb.AppendLine(Resources.Tab4 + "DMSLogger.Log(DMSLogger.LogLevel.Error, \"Parameter reportRecord passed to " + jmsModel.Name + "ViewModel(), should not be null.\");");
			sb.AppendLine(Resources.Tab4 + "return;");
			sb.AppendLine(Resources.Tab3 + "}");
			sb.AppendLine(Resources.Tab3 + "this.reportRecord = reportRecord;");
			sb.AppendLine(Resources.Tab3 + "recordType = (DMSType)ModelCodeHelper.ExtractTypeFromGlobalId(reportRecord.Lid);");
			sb.AppendLine(Resources.Tab3 + "DataGridTreeViewItemInfo = new HierarchicalReportRecord();");
			sb.AppendLine(Resources.Tab3 + "DataGridTreeViewItemInfo.Lid = reportRecord.Lid;");
			sb.AppendLine(Resources.Tab3 + "DataGridTreeViewItemInfo.Level = reportRecord.Level;");
			sb.AppendLine(Resources.Tab3 + "DataGridTreeViewItemInfo.ElementIsShownInTabularView = reportRecord.ElementIsShownInTabularView;");
			sb.AppendLine(Resources.Tab3 + "tabularViewIsActive = tabularViewActive;");
			sb.AppendLine(Resources.Tab3 + "if (tabularViewActive && !this.reportRecord.ElementIsShownInTabularView)");
			sb.AppendLine(Resources.Tab3 + "{");
			sb.AppendLine(Resources.Tab4 + "rowIsNotVisible = true;");
			sb.AppendLine(Resources.Tab3 + "}");
			sb.AppendLine(Resources.Tab2 + "}");

			return sb.ToString();
		}

		internal static string GetDefaultViewModelConstructor(JMSModel jmsModel)
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine(Resources.Tab2 + "public " + jmsModel.Name + "ViewModel()");
			sb.AppendLine(Resources.Tab2 + "{");
			sb.AppendLine(Resources.Tab2 + "}");

			return sb.ToString();
		}

		internal static string GetNamespace(JMSModel jmsModel)
		{
			StringBuilder sb = new StringBuilder();

			sb.Append("namespace TelventDMS.UI.Components." + jmsModel.ModelRoot.Name + ".ViewModels");

			return sb.ToString();
		}
	}
}
