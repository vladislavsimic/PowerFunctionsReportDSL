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

		internal static string GetXamlCode(ModelRoot modelRoot)
		{
			StringBuilder sb = new StringBuilder();

			List<Tab> tabs = new List<Tab>();

			foreach (ModelType type in modelRoot.Types)
			{
				if (type is Tab)
				{
					Tab tab = type as Tab;
					if (tab.SourceTabbed.Count == 0)
					{
						tabs.Add(tab);
					}
				}
			}

			sb.AppendLine("<ad:ReportDocument x:Class=\"TelventDMS.UI.Components." + modelRoot.Name + ".View." + modelRoot.Name + "View\"");
			sb.AppendLine(Resources.Tab3 + "xmlns=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation\"");
			sb.AppendLine(Resources.Tab3 + "xmlns:x=\"http://schemas.microsoft.com/winfx/2006/xaml\"");
			sb.AppendLine(Resources.Tab3 + "xmlns:mc=\"http://schemas.openxmlformats.org/markup-compatibility/2006\"");
			sb.AppendLine(Resources.Tab3 + "xmlns:d=\"http://schemas.microsoft.com/expression/blend/2008\"");

			sb.AppendLine(GetAdditionalLibraries(modelRoot));

			sb.AppendLine(Resources.Tab3 + ">");

			sb.AppendLine(GetControlResources(modelRoot));

			sb.AppendLine(Resources.Tab1 + "<Grid>");
			sb.AppendLine(Resources.Tab2 + "<TabControl Name=\"tabControl\">");

			foreach(Tab tab in tabs)
			{
				sb.AppendLine(GetTabXaml(tab));
			}

			sb.AppendLine(Resources.Tab2 + "<TabControl>");
			sb.AppendLine(Resources.Tab1 + "</Grid>");
			sb.AppendLine("</UserControl>");

			return sb.ToString();
		}

		private static string GetTabXaml(Tab tab)
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine(Resources.Tab3 + "<TabItem Name=\"" + tab.Name + "\" Header=\"Test\">");
			sb.AppendLine(Resources.Tab4 + "<Grid>");
			

			if (tab.TargetTabbed.Count == 0)
			{
				sb.AppendLine(Resources.Tab5 + "<Grid x:Name=\"NoResults" + tab.Name + "\" Visibility=\"Collapsed\">");
				sb.AppendLine(Resources.Tab6 + "<ScrollViewer VerticalScrollBarVisibility=\"Auto\" HorizontalScrollBarVisibility=\"Auto\">");
				sb.AppendLine(Resources.Tab7 + "<TextBlock Style=\"{DynamicResource HeaderTextBlockStyle}\" Opacity=\"0.3\" Text=\"{Binding Path=Resources.NO_RESULTS, Source={StaticResource LocalizedStrings} }\" VerticalAlignment=\"Center\" HorizontalAlignment=\"Center\" />");
				sb.AppendLine(Resources.Tab6 + "</ScrollViewer>");
				sb.AppendLine(Resources.Tab5 + "</Grid>");

				if (tab.DataGrid != null)
				{
					sb.AppendLine(Resources.Tab5 + "<Grid Margin=\"0 5 0 0 \" Name=\"" + tab.Name + "DataGridHeader\">");
					sb.AppendLine(Resources.Tab6 + "<DataGrid Name=\"" + tab.Name + "DataGrid\"  HorizontalScrollBarVisibility=\"Auto\" SelectionMode=\"Single\" SelectionUnit=\"FullRow\" IsSynchronizedWithCurrentItem=\"True\"");
					sb.AppendLine(Resources.Tab7 + "CanUserAddRows=\"False\" CanUserDeleteRows=\"False\" CanUserResizeRows=\"False\" CanUserSortColumns=\"False\" AutoGenerateColumns=\"False\" IsReadOnly=\"True\">");

					if (tab.DataGrid.Columns.Count > 0)
					{
						DataGrid dg = tab.DataGrid;

						sb.AppendLine(Resources.Tab7 + "<DataGrid.Columns>");

						sb.AppendLine(Resources.Tab8 + "<DataGridTemplateColumn Header=\"{ Binding Path = Resources.ELEMENT, Source = { StaticResource LocalizedStrings } }\" Width=\"Auto\" MinWidth=\"200\"  x:Name=\"" + dg.Name + "Tree\" SortMemberPath=\"Title\">");
						sb.AppendLine(Resources.Tab9 + "<DataGridTemplateColumn.CellTemplate>");
						sb.AppendLine(Resources.Tab10 + "<DataTemplate>");
						sb.AppendLine(Resources.Tab11 + "<dgtvi:DataGridTreeViewItem DataContext=\"{ Binding DataGridTreeViewItemInfo}\" VerticalAlignment=\"Center\" NoLevel=\"{ Binding DataContext.TabularViewIsActive, RelativeSource ={ RelativeSource AncestorType = Grid} }\">");
						sb.AppendLine(Resources.Tab11 + "</dgtvi:DataGridTreeViewItem>");
						sb.AppendLine(Resources.Tab10 + "</DataTemplate>");
						sb.AppendLine(Resources.Tab9 + "</DataGridTemplateColumn.CellTemplate>");
						sb.AppendLine(Resources.Tab8 + "</DataGridTemplateColumn>");

						foreach(ColumnAttribute attr in dg.Columns)
						{
							string name = string.Format("x:Name=\"Col{0}{1}\"", dg.Name ,attr.Name);

							string header = string.Empty;
							if (attr.Header != null)
							{
								header = " Header=\"" + attr.Header + "\"";
							}
							else
							{
								header = " Header=\"" + attr.Name + "\"";
							}
							string binding = " Binding=\"{Binding Path=" + attr.Binding + "}\"";
							string width = string.Format(" Width=\"{0}\"", attr.Width);
							string horizontalAlignment = string.Format(" HorizontalAlignment=\"{0}\"", HorizontalAlignmentConverter.Convert(attr.HorizontalAlignment));
							string verticalAlignment = string.Format(" VerticalAlignment=\"{0}\"", VerticalAlignmentConverter.Convert(attr.VerticalAlignment));

							sb.AppendLine(Resources.Tab8 + "<cc:ExtendedDataGridTextColumn " + name + header + width + horizontalAlignment + verticalAlignment + binding +" />");
						}

						sb.AppendLine(Resources.Tab7 + "</DataGrid.Columns>");
					}

					sb.AppendLine(Resources.Tab6 + "</DataGrid>");
					sb.AppendLine(Resources.Tab5 + "</Grid>");
				}
			}
			else
			{
				sb.AppendLine(Resources.Tab5 + "<TabControl>");
				foreach(Tab tagetTab in tab.TargetTabbed)
				{
					sb.AppendLine(GetTabXaml(tagetTab));
				}
				sb.AppendLine(Resources.Tab5 + "</TabControl>");
			}

			sb.AppendLine(Resources.Tab4 + "</Grid>");
			sb.AppendLine(Resources.Tab3 + "</TabItem>");

			return sb.ToString();
		}

		private static string GetDataGridContent(Tab tab)
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine(Resources.Tab1 + "<Grid>");
			sb.AppendLine(Resources.Tab1 + "</Grid>");

			return sb.ToString();
		}

		private static string GetAdditionalLibraries(ModelRoot modelRoot)
		{
			StringBuilder sb = new StringBuilder();

			string projectName = modelRoot.Name;

			sb.AppendLine(Resources.Tab3 + "xmlns:local=\"clr -namespace:TelventDMS.UI.Components." + projectName + ".View\"");
			sb.AppendLine(Resources.Tab3 + "xmlns:localization = \"clr-namespace:TelventDMS.UI.Components." + projectName + "\"");


			return sb.ToString();
		}

		private static string GetControlResources(ModelRoot modelRoot)
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine(Resources.Tab1 + "<ad:ReportDocument.Resources>");
			sb.AppendLine(Resources.Tab2 + "<ResourceDictionary>");
			sb.AppendLine(Resources.Tab3 + "<localization:LocalizedStrings x:Key=\"LocalizedStrings\" />");
			sb.AppendLine(Resources.Tab2 + "</ResourceDictionary>");
			sb.AppendLine(Resources.Tab1 + "</ad:ReportDocument.Resources>");

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
			sb.AppendLine(Resources.Tab3 + "if (String.IsNullOrEmpty(reportRecord.Title))");
			sb.AppendLine(Resources.Tab3 + "{");
			sb.AppendLine(Resources.Tab4 + "DataGridTreeViewItemInfo.Title = DmsTypeToEntityNameMapper.GetAutomatedName((DMSType)ModelCodeHelper.ExtractTypeFromGlobalId(reportRecord.Lid), reportRecord.Lid);");
			sb.AppendLine(Resources.Tab3 + "}");
			sb.AppendLine(Resources.Tab3 + "else");
			sb.AppendLine(Resources.Tab3 + "{");
			sb.AppendLine(Resources.Tab4 + "DataGridTreeViewItemInfo.Title = reportRecord.Title;");
			sb.AppendLine(Resources.Tab3 + "}");
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
