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
		internal static string GetUsings(DataGrid dg)
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine("using System;");
			sb.AppendLine("using TelventDMS.Common.Platform.Logger;");
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

			sb.AppendLine("<ad:ReportDocument x:Class=\"TelventDMS.UI.Components." + modelRoot.Name + ".View." + modelRoot.Name + "ReportView\"");
			sb.AppendLine(Resources.Tab3 + "xmlns=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation\"");
			sb.AppendLine(Resources.Tab3 + "xmlns:x=\"http://schemas.microsoft.com/winfx/2006/xaml\"");
			sb.AppendLine(Resources.Tab3 + "xmlns:mc=\"http://schemas.openxmlformats.org/markup-compatibility/2006\"");
			sb.AppendLine(Resources.Tab3 + "xmlns:d=\"http://schemas.microsoft.com/expression/blend/2008\"");

			sb.AppendLine(GetAdditionalLibraries(modelRoot));

			sb.AppendLine(Resources.Tab3 + ">");

			sb.AppendLine(GetControlResources(modelRoot));

			sb.AppendLine(Resources.Tab1 + "<Grid>");

			sb.AppendLine(Resources.Tab2 + "<Grid.RowDefinitions>");
			sb.AppendLine(Resources.Tab3 + "<RowDefinition Height=\"Auto\" />");
			sb.AppendLine(Resources.Tab3 + "<RowDefinition Height=\" * \" />");
			sb.AppendLine(Resources.Tab2 + "</Grid.RowDefinitions>");

			sb.AppendLine(Resources.Tab2 + "<reportGeneralInfoControl:GeneralInfo Grid.Row=\"0\"  FunctionReportName=\"{ Binding ElementName = EMSLoadFlowReport, Path = Title}\"");
			sb.AppendLine(Resources.Tab3 + "Name = \"genInfo\" HaveSelectedButton = \"False\" HaveOptionButton = \"False\" HasMessages = \"false\"  HasStatus = \"false\"  HaveTreeView = \"true\" /> ");

			sb.AppendLine(Resources.Tab2 + "<Grid Grid.Row=\"1\">");

			sb.AppendLine(Resources.Tab3 + "<Grid.ColumnDefinitions>");
			sb.AppendLine(Resources.Tab4 + "<ColumnDefinition Width=\"250\" MinWidth=\"200\" />");
			sb.AppendLine(Resources.Tab4 + "<ColumnDefinition Width=\"Auto\" />");
			sb.AppendLine(Resources.Tab4 + "<ColumnDefinition Width=\" * \" />");
			sb.AppendLine(Resources.Tab3 + "</Grid.ColumnDefinitions>");

			sb.AppendLine(Resources.Tab3 + "<Grid Grid.Column=\"0\">");
			sb.AppendLine(Resources.Tab4 + "<Grid.RowDefinitions>");
			sb.AppendLine(Resources.Tab5 + "<RowDefinition Height=\"*\" />");
			sb.AppendLine(Resources.Tab4 + "</Grid.RowDefinitions>");
			sb.AppendLine(Resources.Tab4 + "<htv:HierarchyTreeView Grid.Row=\"0\" Name=\"CommonHtv\" HierarchyTreeDataProvider=\"{ Binding Path = TreeDataProvider}\"/>");
			sb.AppendLine(Resources.Tab3 + "</Grid>");

			sb.AppendLine(Resources.Tab3 + "<GridSplitter x:Name=\"GridSplitter\" ResizeDirection=\"Columns\" ResizeBehavior=\"PreviousAndNext\" Grid.Column=\"1\"");
			sb.AppendLine(Resources.Tab4 + "custCtrl:GridExpander.Direction=\"Previous\" custCtrl:GridExpander.Header=\"{ Binding Path = ResourcesGenerated.EMSLoadFlow_NETWORK_TREE, Source = { StaticResource LocalizedStrings }}\" />");
			ResxManager.Manager.AddResource("NETWORK_TREE");


			sb.AppendLine(Resources.Tab2 + "<TabControl Name=\"tabControl\" Grid.Column=\"2\">");

			foreach(Tab tab in tabs)
			{
				sb.AppendLine(GetTabXaml(tab));
			}

			sb.AppendLine(Resources.Tab2 + "</TabControl>");

			sb.AppendLine(Resources.Tab2 + "</Grid>");
			sb.AppendLine(Resources.Tab1 + "</Grid>");
			sb.AppendLine("</ad:ReportDocument>");

			return sb.ToString();
		}

		private static string GetTabXaml(Tab tab)
		{
			StringBuilder sb = new StringBuilder();

            ModelRoot root = tab.ModelRoot;

			string tabHeader = string.Empty;
			if (tab.Header != null)
			{
                
                tabHeader = "{Binding Path=ResourcesGenerated." + root.Name + "_" + tab.Header.Trim().Replace(" ", "_") + ", Source={ StaticResource LocalizedStrings} }";
				ResxManager.Manager.AddResource(tab.Header);
			}
			else
			{
				tabHeader = "{Binding Path=ResourcesGenerated." + root.Name + "_" + tab.Name.Trim().Replace(" ", "_") + ", Source={ StaticResource LocalizedStrings} }";
				ResxManager.Manager.AddResource(tab.Name);
			}

			sb.AppendLine(Resources.Tab3 + "<TabItem Name=\"" + tab.Name + "\" Header=\"" + tabHeader + "\">");
			sb.AppendLine(Resources.Tab4 + "<Grid>");
			

			if (tab.TargetTabbed.Count == 0)
			{
				sb.AppendLine(Resources.Tab5 + "<Grid x:Name=\"NoResults" + tab.Name + "\" Visibility=\"Collapsed\">");
				sb.AppendLine(Resources.Tab6 + "<ScrollViewer VerticalScrollBarVisibility=\"Auto\" HorizontalScrollBarVisibility=\"Auto\">");
				sb.AppendLine(Resources.Tab7 + "<TextBlock Style=\"{DynamicResource HeaderTextBlockStyle}\" Opacity=\"0.3\" Text=\"{Binding Path=ResourcesGenerated.NO_RESULTS, Source={StaticResource LocalizedStrings} }\" VerticalAlignment=\"Center\" HorizontalAlignment=\"Center\" />");
				ResxManager.Manager.AddResource("NO_RESULTS");
				sb.AppendLine(Resources.Tab6 + "</ScrollViewer>");
				sb.AppendLine(Resources.Tab5 + "</Grid>");

				if (tab.DataGrid != null)
				{
					DataGrid dg = tab.DataGrid;

					sb.AppendLine(Resources.Tab5 + "<Grid Margin=\"0 5 0 0 \" Name=\"" + tab.Name + "DataGridHeader\">");

					if (dg.SuperHeaders.Count > 0)
					{
						sb.AppendLine(Resources.Tab6 + "<Grid.RowDefinitions>");
						sb.AppendLine(Resources.Tab7 + "<RowDefinition Height=\"Auto\"/>");
						sb.AppendLine(Resources.Tab7 + "<RowDefinition Height=\"*\"/>");
						sb.AppendLine(Resources.Tab6 + "</Grid.RowDefinitions>");

						sb.AppendLine(Resources.Tab6 + "<ScrollViewer x:Name=\"Header" + dg.Name +"\" Grid.Row=\"0\" HorizontalScrollBarVisibility=\"Hidden\" VerticalScrollBarVisibility=\"Disabled\" HorizontalAlignment=\"Left\" HorizontalContentAlignment=\"Left\">");
						sb.AppendLine(Resources.Tab7 + "<Grid Name=\"Button" + dg.Name +"Grid\" Margin=\"-2,0,0,0\">");
						sb.AppendLine(Resources.Tab8 + "<Grid.ColumnDefinitions>");
						sb.AppendLine(Resources.Tab9 + "<ColumnDefinition Width=\"{ Binding ElementName = EMSLoadFlowNodeDataGrid, Path = RowHeaderWidth}\" />");
						sb.AppendLine(Resources.Tab9 + "<ColumnDefinition Width=\"{ Binding ElementName = EMSLoadFlowNodeTree, Path = ActualWidth}\" />");
						foreach(ColumnAttribute column in dg.Columns)
						{
							sb.AppendLine(Resources.Tab9 + "<ColumnDefinition Width=\"{ Binding ElementName = Col" + dg.Name + column.Name + ", Path = ActualWidth}\"/>");
						}
						sb.AppendLine(Resources.Tab9 + "<ColumnDefinition Width=\"100\"/>");
						sb.AppendLine(Resources.Tab8 + "</Grid.ColumnDefinitions>");

						foreach(DataGridSuperHeader sh in dg.SuperHeaders)
						{
							string shColumn = "0";
							for (int i = 0; i < dg.Columns.Count; i++)
							{
								if(dg.Columns[i].Name == sh.Column)
								{
									shColumn = (i + 2).ToString(); 
								}
							}

							sb.AppendLine(Resources.Tab8 + "<Button x:Name=\"" + sh.Name +"\" Grid.Column=\"" + shColumn + "\" Grid.ColumnSpan=\"" + sh.ColumnSpan +"\" Style=\"{ StaticResource SuperHeaderStyle}\">");
							sb.AppendLine(Resources.Tab9 + "<Button.Content>");
							sb.AppendLine(Resources.Tab10 + "<StackPanel Orientation=\"Horizontal\">");
							sb.AppendLine(Resources.Tab11 + "<TextBlock VerticalAlignment=\"Center\" Text=\"" + sh.Text + "\" />");
							sb.AppendLine(Resources.Tab10 + "</StackPanel>");
							sb.AppendLine(Resources.Tab9 + "</Button.Content>");
							sb.AppendLine(Resources.Tab8 + "</Button>");
						}

						sb.AppendLine(Resources.Tab7 + "</Grid>");
						sb.AppendLine(Resources.Tab6 + "</ScrollViewer>");
					}

					string dgGridRow = string.Empty;
					if (dg.SuperHeaders.Count > 0)
					{
						dgGridRow = "Grid.Row=\"1\"";
					}

					sb.AppendLine(Resources.Tab6 + "<DataGrid Name=\"" + dg.Name + "DataGrid\" " + dgGridRow + " HorizontalScrollBarVisibility=\"Auto\" SelectionMode=\"Single\" SelectionUnit=\"FullRow\" IsSynchronizedWithCurrentItem=\"True\"");
					sb.AppendLine(Resources.Tab7 + "CanUserAddRows=\"False\" CanUserDeleteRows=\"False\" CanUserResizeRows=\"False\" CanUserSortColumns=\"False\" AutoGenerateColumns=\"False\" IsReadOnly=\"True\">");

					if (dg.Columns.Count > 0)
					{
						sb.AppendLine(Resources.Tab7 + "<DataGrid.Columns>");
						sb.AppendLine(Resources.Tab8 + "<DataGridTemplateColumn Header=\"{ Binding Path = ResourcesGenerated.ELEMENT, Source = { StaticResource LocalizedStrings } }\" Width=\"Auto\" MinWidth=\"200\"  x:Name=\"" + dg.Name + "Tree\" SortMemberPath=\"Title\">");
						ResxManager.Manager.AddResource("ELEMENT");
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
                                header = " Header=\"{Binding Path=ResourcesGenerated." + root.Name + "_" + attr.Header.Trim().Replace(" ", "_") + ", Source={StaticResource LocalizedStrings} }\"";
                                ResxManager.Manager.AddResource(attr.Header.Trim().Replace(" ", "_"));
							}
							else
							{
                                header = " Header=\"{Binding Path=ResourcesGenerated." + root.Name + "_" + attr.Name.Trim().Replace(" ", "_") + ", Source={StaticResource LocalizedStrings} }\"";
                                ResxManager.Manager.AddResource(attr.Name.Trim().Replace(" ", "_"));
							}
							string binding = string.Empty;
							if (string.IsNullOrEmpty(attr.BindingName))
							{
								binding = " Binding=\"{Binding Path=" + attr.Name + "}\"";
							}
							else
							{
								binding = " Binding=\"{Binding Path=" + attr.BindingName + "}\"";
							}
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
				sb.AppendLine(Resources.Tab5 + "<TabControl Name=\"" + tab.Name +"TabControl\">");
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

			sb.AppendLine(Resources.Tab3 + "x:Name = \"" + projectName + "Report\"");
			sb.AppendLine(Resources.Tab3 + "xmlns:local=\"clr-namespace:TelventDMS.UI.Components." + projectName + ".View\"");
			sb.AppendLine(Resources.Tab3 + "xmlns:localization = \"clr-namespace:TelventDMS.UI.Components." + projectName + "\"");
			sb.AppendLine(Resources.Tab3 + "xmlns:htv = \"clr-namespace:TelventDMS.UI.Components.CustomControls.HierarchyTreeViewControl;assembly=TelventDMS.UI.Components.CustomControls\"");
			sb.AppendLine(Resources.Tab3 + "xmlns:dgtvi = \"clr-namespace:TelventDMS.UI.Components.CustomControls.DataGridTreeViewItemControl;assembly=TelventDMS.UI.Components.CustomControls\"");
			sb.AppendLine(Resources.Tab3 + "xmlns:cc = \"clr-namespace:TelventDMS.UI.Resources.Controls;assembly=TelventDMS.UI.Resources\"");
			sb.AppendLine(Resources.Tab3 + "xmlns:custCtrl = \"clr-namespace:TelventDMS.UI.Components.CustomControls;assembly=TelventDMS.UI.Components.CustomControls\"");
			sb.AppendLine(Resources.Tab3 + "xmlns:con = \"clr-namespace:TelventDMS.UI.Components.CustomControls.GridFilterControl;assembly=TelventDMS.UI.Components.CustomControls\"");
			sb.AppendLine(Resources.Tab3 + "xmlns:ad = \"clr-namespace:TelventDMS.UI.Components.CompositeCommon.AvalonDocument;assembly=TelventDMS.UI.Components.CompositeCommon\"");
			sb.AppendLine(Resources.Tab3 + "xmlns:ext = \"clr-namespace:TelventDMS.UI.Components.CompositeCommon.AttachedProperties;assembly=TelventDMS.UI.Components.CompositeCommon\"");
			sb.AppendLine(Resources.Tab3 + "xmlns:reportGeneralInfoControl = \"clr-namespace:TelventDMS.UI.Components.CustomControls.ReportGeneralInfoControl.Views;assembly=TelventDMS.UI.Components.CustomControls\"");
			sb.AppendLine(Resources.Tab3 + "xmlns:common = \"clr-namespace:TelventDMS.Common.DMS.Common;assembly=TelventDMS.Common.DMS.Common\"");
			sb.AppendLine(Resources.Tab3 + "xmlns:i = \"http://schemas.microsoft.com/expression/2010/interactivity\"");
			sb.AppendLine(Resources.Tab3 + "Title = \"" + modelRoot.Name + " report\"");


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

		internal static string GetViewModelFields(DataGrid dg)
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine(Resources.Tab2 + "private " + dg.Name + "Record reportRecord;");
			sb.AppendLine();
			sb.AppendLine(Resources.Tab2 + "private DMSType recordType;");
			sb.AppendLine();
			sb.AppendLine(Resources.Tab2 + "private bool rowIsNotVisible;");
			sb.AppendLine();
			sb.AppendLine(Resources.Tab2 + "private bool tabularViewIsActive;");

			return sb.ToString();
		}

		internal static string GetViewModelProperties(DataGrid dg)
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine(Resources.DetailsElementGid);

			sb.AppendLine(Resources.DataGridTreeViewItemInfo);

			sb.AppendLine(Resources.RecordType);

			sb.AppendLine(Resources.Title);

			sb.AppendLine(Resources.GetReportRecordFor(dg));

			sb.AppendLine(Resources.TabularViewIsActive);

			sb.AppendLine(Resources.RowIsNotVisible);

			foreach (ColumnAttribute attribute in dg.Columns)
			{
				if (!attribute.ShouldGenerate)
				{
					continue;
				}
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

		internal static string GetViewModelConstructor(DataGrid dg)
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine(Resources.Tab2 + "public " + dg.Name + "ViewModel(" + dg.Name + "Record reportRecord, bool tabularViewActive)");
			sb.AppendLine(Resources.Tab2 + "{");
			sb.AppendLine(Resources.Tab3 + "if (reportRecord == null)");
			sb.AppendLine(Resources.Tab3 + "{");
			sb.AppendLine(Resources.Tab4 + "DMSLogger.Log(DMSLogger.LogLevel.Error, \"Parameter reportRecord passed to " + dg.Name + "ViewModel(), should not be null.\");");
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

		internal static string GetDefaultViewModelConstructor(DataGrid dg)
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine(Resources.Tab2 + "public " + dg.Name + "ViewModel()");
			sb.AppendLine(Resources.Tab2 + "{");
			sb.AppendLine(Resources.Tab2 + "}");

			return sb.ToString();
		}

		internal static string GetNamespace(DataGrid dg)
		{
			StringBuilder sb = new StringBuilder();

			sb.Append("namespace TelventDMS.UI.Components." + dg.ModelRoot.Name + ".ViewModels");

			return sb.ToString();
		}
	}
}
