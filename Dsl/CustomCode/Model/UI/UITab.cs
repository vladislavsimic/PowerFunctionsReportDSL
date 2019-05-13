using SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode.Model
{
	public class UITab
	{
		private Tab tab;

		private Dictionary<string, string> generatedCode;

		public UITab(Tab tab)
		{
			this.tab = tab;
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

		public string GetXaml()
		{
			return UIHelper.GetXamlCode(tab.ModelRoot);
		}

		public void GenerateXamlCs()
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

			sb.AppendLine(GetHierarhyTreeViewMethod());
			sb.AppendLine();
            sb.AppendLine(GetSetHeaderNameMethod());
			sb.AppendLine(GetMainTabControlSelectionChanged());
			sb.AppendLine(GetTabControlsSelectionChangedMethods());
			sb.AppendLine(GetTabControlUpdateMethods());
			sb.AppendLine();
			sb.AppendLine(GetDispose());


			return sb.ToString();
		}

		private string GetSetHeaderNameMethod()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine(Resources.Tab2 + "private void SetHeader()");
			sb.AppendLine(Resources.Tab2 + "{");
			List<DataGrid> dataGrids = new List<DataGrid>();
			foreach (ModelType type in this.tab.ModelRoot.Types)
			{
				if (!(type is DataGrid))
				{
					continue;
				}
				dataGrids.Add(type as DataGrid);
			}
			foreach (DataGrid dg in dataGrids)
			{
				if (dg.Tab == null)
				{
					continue;
				}
				foreach (ColumnAttribute column in dg.Columns)
				{
					if (column.MeasurementType == MeasurementType.None && column.UnitSymbol == UnitSymbol.None)
					{
						continue;
					}

					string columnHeader = string.Empty;
					if (!string.IsNullOrEmpty(column.Header))
					{
						columnHeader = column.Header;
					}
					else
					{
						columnHeader = column.Name;
					}

					string key = ResxManager.Manager.AddResourceWithMeasUnit(columnHeader);

					if(column.MeasurementType != MeasurementType.None)
					{
						sb.AppendLine(Resources.Tab3 + "Col" + dg.Name + column.Name + ".Header += String.Format(Properties." + tab.ModelRoot.Name + "ResourcesGenerated." + tab.ModelRoot.Name + "_" + key + ", UnitConverterHelper.GetUnitSymbol(MeasurementType." + column.MeasurementType + "));");
					}
					else
					{
						sb.AppendLine(Resources.Tab3 + "Col" + dg.Name + column.Name + ".Header += String.Format(Properties." + tab.ModelRoot.Name + "ResourcesGenerated." + tab.ModelRoot.Name + "_" + key + ", UnitConverterHelper.GetUnitSymbol(UnitSymbol." + column.UnitSymbol + "));");
					}
				}
			}
			sb.AppendLine(Resources.Tab2 + "}");

			return sb.ToString();
		}

		private string GetTabControlUpdateMethods()
		{
			StringBuilder sb = new StringBuilder();

			List<Tab> tabControls = new List<Tab>();
			foreach (ModelType type in tab.ModelRoot.Types)
			{
				if (!(type is Tab))
				{
					continue;
				}
				Tab tempTab = type as Tab;
				if (tempTab.TargetTabbed.Count != 0)
				{
					tabControls.Add(tempTab);
				}
			}

			foreach(Tab tempTab in tabControls)
			{
				sb.AppendLine(Resources.Tab2 + "protected internal void " + tempTab.Name + "TabControlUpdate(TabControl tc)");
				sb.AppendLine(Resources.Tab2 + "{");
				sb.AppendLine(Resources.Tab3 + "if (tc == null || tc.SelectedItem == null || reportViewModel.DataProvider == null) return;");
				sb.AppendLine(Resources.Tab3 + "TabItem selectedTabItem = tc.SelectedItem as TabItem;");

				string condition = "if";
				foreach(Tab targetTab in tempTab.TargetTabbed)
				{
					if(targetTab.TargetTabbed.Count == 0)
					{
						sb.AppendLine(Resources.Tab3 + condition + " (Equals(selectedTabItem, " + targetTab.Name + ") && reportViewModel.DataProvider.ReportParameter.ReportType != ServiceProxies." + tab.ModelRoot.Name + "ReportType." + targetTab.Name + ")");
						sb.AppendLine(Resources.Tab3 + "{");
						sb.AppendLine(Resources.Tab4 + "reportViewModel.DataProvider.ReportParameter.ReportType = ServiceProxies." + tab.ModelRoot.Name + "ReportType." + targetTab.Name + ";");
						sb.AppendLine(Resources.Tab4 + "reportViewModel.DataProvider.ReportParameter.HierarchyType = reportViewModel.HierarchyType;");
						sb.AppendLine(Resources.Tab4 + "reportViewModel.DataProvider.ProvideRecords(visibleItemsIds);");
						sb.AppendLine(Resources.Tab3 + "}");
					}
					else
					{
						sb.AppendLine(Resources.Tab3 + condition + " (Equals(selectedTabItem, " + targetTab.Name + ")");
						sb.AppendLine(Resources.Tab3 + "{");
						sb.AppendLine(Resources.Tab4 + targetTab.Name + "TabControlUpdate(" + targetTab.Name +"TabControl);");
						sb.AppendLine(Resources.Tab3 + "}");
					}
					condition = "else if";
				}

				sb.AppendLine(Resources.Tab2 + "}");
			}

			return sb.ToString();
		}

		private string GetTabControlsSelectionChangedMethods()
		{
			StringBuilder sb = new StringBuilder();

			List<Tab> tabControls = new List<Tab>();
			foreach (ModelType type in tab.ModelRoot.Types)
			{
				if (!(type is Tab))
				{
					continue;
				}
				Tab tempTab = type as Tab;
				if (tempTab.TargetTabbed.Count != 0)
				{
					tabControls.Add(tempTab);
				}
			}
			foreach(Tab tempTab in tabControls)
			{
				sb.AppendLine(Resources.Tab2 + "private void " + tempTab.Name +"TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)");
				sb.AppendLine(Resources.Tab2 + "{");
				sb.AppendLine(Resources.Tab3 + "if (!(e.Source is TabControl) || e.Source != sender) return;");
				sb.AppendLine(Resources.Tab3 + "TabControl tc = sender as TabControl;");
				sb.AppendLine(Resources.Tab3 + tempTab.Name + "TabControlUpdate(tc);");
				sb.AppendLine(Resources.Tab2 + "}");
			}

			return sb.ToString();
		}

		private string GetDispose()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine(Resources.Tab2 + "public void Dispose()");
			sb.AppendLine(Resources.Tab2 + "{");
			sb.AppendLine(Resources.Tab3 + "reportViewModel.Dispose();");
			sb.AppendLine(Resources.Tab2 + "}");

			return sb.ToString();
		}

		private string GetMainTabControlSelectionChanged()
		{
			StringBuilder sb = new StringBuilder();

			List<Tab> tabs = new List<Tab>();
			List<Tab> tabControls = new List<Tab>();
			foreach (ModelType type in tab.ModelRoot.Types)
			{
				if (!(type is Tab))
				{
					continue;
				}
				Tab tab = type as Tab;
				if (tab.TargetTabbed.Count == 0 && tab.SourceTabbed.Count == 0)
				{
					tabs.Add(type as Tab);
				}
				else if(tab.TargetTabbed.Count != 0 && tab.SourceTabbed.Count == 0)
				{
					tabControls.Add(type as Tab);
				}
			}

			sb.AppendLine(Resources.Tab2 + "private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)");
			sb.AppendLine(Resources.Tab2 + "{");
			sb.AppendLine(Resources.Tab3 + "TabControl tc = sender as TabControl;");
			sb.AppendLine(Resources.Tab3 + "if (tc != null)");
			sb.AppendLine(Resources.Tab3 + "{");
			sb.AppendLine(Resources.Tab4 + "var selectedTabItem = tc.SelectedItem as TabItem;");
			sb.AppendLine(Resources.Tab4 + "if (!(e.Source is TabControl) || e.Source != sender || selectedTabItem == null || reportViewModel.DataProvider == null)");
			sb.AppendLine(Resources.Tab4 + "{");
			sb.AppendLine(Resources.Tab5 + "return;");
			sb.AppendLine(Resources.Tab4 + "}");

			string condition = "if";
			foreach (Tab tempTab in tabs)
			{
				sb.AppendLine(Resources.Tab4 +  condition + " (Equals(selectedTabItem, " + tempTab.Name + ") && reportViewModel.DataProvider.ReportParameter.ReportType != ServiceProxies." + tab.ModelRoot.Name + "ReportType." + tempTab.Name + ")");
				sb.AppendLine(Resources.Tab4 + "{");
				sb.AppendLine(Resources.Tab5 + "reportViewModel.DataProvider.ReportParameter.ReportType = ServiceProxies." + tab.ModelRoot.Name + "ReportType." + tempTab.Name + ";");
				sb.AppendLine(Resources.Tab5 + "reportViewModel.DataProvider.ReportParameter.HierarchyType = reportViewModel.HierarchyType;");
				sb.AppendLine(Resources.Tab5 + "reportViewModel.DataProvider.ProvideRecords(visibleItemsIds);");
				sb.AppendLine(Resources.Tab4 + "}");
				condition = "else if";
			}

			foreach(Tab tempTab in tabControls)
			{
				sb.AppendLine(Resources.Tab4 + condition + " (Equals(selectedTabItem, " + tempTab.Name + "))");
				sb.AppendLine(Resources.Tab4 + "{");
				sb.AppendLine(Resources.Tab5 + tempTab.Name + "TabControlUpdate(" + tempTab.Name + "TabControl);");
				sb.AppendLine(Resources.Tab4 + "}");
				condition = "else if";
			}

			sb.AppendLine(Resources.Tab3 + "}");
			sb.AppendLine(Resources.Tab2 + "}");

			return sb.ToString();
		}

		private string GetHierarhyTreeViewMethod()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine(Resources.Tab2 + "protected internal void HTV_SelectedItemChanged(HierarchyTreeView sender)");
			sb.AppendLine(Resources.Tab2 + "{");
			sb.AppendLine(Resources.Tab3 + "List<long> tempItems = sender.GetVisibleItemsIds();");
			sb.AppendLine(Resources.Tab3 + "if (!visibleItemsIds.SequenceEqual(tempItems))");
			sb.AppendLine(Resources.Tab3 + "{");
			sb.AppendLine(Resources.Tab4 + "visibleItemsIds = tempItems;");
			sb.AppendLine(Resources.Tab4 + "reportViewModel.DataProvider.ProvideRecords(visibleItemsIds);");
			sb.AppendLine(Resources.Tab3 + "}");
			sb.AppendLine(Resources.Tab2 + "}");

			return sb.ToString();
		}

		private string GetConstructor()
		{
			StringBuilder sb = new StringBuilder();

			ModelRoot root = tab.ModelRoot;

			sb.AppendLine(Resources.Tab2 + "public " + root.Name + "ReportView(IShellView shellView)");
			sb.AppendLine(Resources.Tab2 + "{");
			sb.AppendLine(Resources.Tab3 + "InitializeComponent();");
            sb.AppendLine(Resources.Tab3 + "SetHeader();");

            sb.AppendLine(Resources.Tab3 + "InitSummaryConfig(null, new ReportDocumentConfig(SummaryType.BaseSummary, PersistFilterMode.PersistFilters, null, true, true));");
			sb.AppendLine(Resources.Tab3 + "HelpProvider.SetContextHelpId(this, \"" + root.Name + " Report\");");
			sb.AppendLine(Resources.Tab3 + "this.shellView = shellView;");
			sb.AppendLine(Resources.Tab3 + "this.reportViewModel = new " + root.Name +"ReportViewModel(this);");
			sb.AppendLine(Resources.Tab3 + "moduleEnvironment = ServiceLocator.Current.GetInstance<IModuleEnvironment>();");
			sb.AppendLine(Resources.Tab3 + "DataContext = reportViewModel;");
			sb.AppendLine(Resources.Tab3 + "tabControl.SelectionChanged += TabControl_SelectionChanged;");
			sb.AppendLine(GetTabControls());
			sb.AppendLine(Resources.Tab3 + "CommonHtv.SelectedItemChanged += HTV_SelectedItemChanged;");
			sb.AppendLine(Resources.Tab3 + "CommonHtv.ExpandedCollapsed += HTV_SelectedItemChanged;");
			sb.AppendLine();
			sb.AppendLine(Resources.Tab3 + "Title = \"" + root.Name +" Report\";");  //Properties." + root.Name + "ResourcesGenerated." + root.Name + "_" + root.Name + ";");
			sb.AppendLine(Resources.Tab3 + "InfoTip = \"" + root.Name + " Report\";");  //Properties." + root.Name + "ResourcesGenerated." + root.Name + "_" + root.Name + ";");
			sb.AppendLine();
			sb.AppendLine(Resources.Tab3 + "this.workspaceManager = moduleEnvironment.WorkspaceManager;");

			sb.AppendLine(Resources.Tab2 + "}");


			return sb.ToString();
		}

		private string GetTabControls()
		{
			StringBuilder sb = new StringBuilder();

			List<Tab> tabControls = new List<Tab>();
			foreach(ModelType type in tab.ModelRoot.Types)
			{
				if(!(type is Tab))
				{
					continue;
				}
				Tab tempTab = type as Tab;
				if (tempTab.TargetTabbed.Count != 0)
				{
					tabControls.Add(tempTab);
				}
			}
			foreach(Tab tempTab in tabControls)
			{
				sb.AppendLine(Resources.Tab3 + tempTab.Name + "TabControl.SelectionChanged += " + tempTab.Name + "TabControl_SelectionChanged;");

			}

			return sb.ToString();
		}

		private string GetPrivateFields()
		{
			StringBuilder sb = new StringBuilder();

			ModelRoot root = tab.ModelRoot;

			sb.AppendLine(Resources.Tab2 + "private IShellView shellView;");
			sb.AppendLine(Resources.Tab2 + "private " + root.Name + "ReportViewModel reportViewModel;");
			sb.AppendLine(Resources.Tab2 + "private List<long> visibleItemsIds = new List<long>();");
			sb.AppendLine(Resources.Tab2 + "private IWorkspaceManager workspaceManager;");
			sb.AppendLine(Resources.Tab2 + "private IModuleEnvironment moduleEnvironment;");

			return sb.ToString();
		}

		private string GetClassNamespace()
		{
			return "TelventDMS.UI.Components." + tab.ModelRoot.Name + ".View";
		}

		private string GetUsings()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine("using Microsoft.Practices.ServiceLocation;");
			sb.AppendLine("using System;");
			sb.AppendLine("using System.Collections.Generic;");
			sb.AppendLine("using System.Linq;");
			sb.AppendLine("using System.Text;");
			sb.AppendLine("using System.Threading.Tasks;");
			sb.AppendLine("using System.Windows;");
			sb.AppendLine("using System.Windows.Controls;");
			sb.AppendLine("using System.Windows.Data;");
			sb.AppendLine("using System.Windows.Documents;");
			sb.AppendLine("using System.Windows.Input;");
			sb.AppendLine("using System.Windows.Media;");
			sb.AppendLine("using System.Windows.Media.Imaging;");
			sb.AppendLine("using System.Windows.Navigation;");
			sb.AppendLine("using System.Windows.Shapes;");
			sb.AppendLine("using TelventDMS.UI.Components.CompositeCommon.AvalonDocument;");
			sb.AppendLine("using TelventDMS.UI.Components.CompositeCommon.Help;");
			sb.AppendLine("using TelventDMS.UI.Components.CompositeCommon.Interfaces;");
			sb.AppendLine("using TelventDMS.UI.Components.CustomControls.HierarchyTreeViewControl;");
			sb.AppendLine("using TelventDMS.UI.Components.EMSLoadFlow.ViewModels;");
			sb.AppendLine("using TelventDMS.Common.DMS.Common;");
			sb.AppendLine("using TelventDMS.UI.Model.Electrical;");

			return sb.ToString();
		}
	}
}
