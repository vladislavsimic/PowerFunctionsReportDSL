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
			sb.AppendLine(GetTabControlSelectionChanged());


			return sb.ToString();
		}

		private string GetTabControlSelectionChanged()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine(Resources.Tab2 + "private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)");
			sb.AppendLine(Resources.Tab2 + "{");
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
			sb.AppendLine(Resources.Tab4 + "reportWindowVM.DataProvider.ProvideRecords(visibleItemsIds, true);");
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
			sb.AppendLine(Resources.Tab3 + "CanSaveLayout = true;");
			sb.AppendLine(Resources.Tab3 + "ShouldPersistFilter = true;");
			sb.AppendLine(Resources.Tab3 + "HelpProvider.SetContextHelpId(this, \"" + root.Name + " Report\");");
			sb.AppendLine(Resources.Tab3 + "this.shellView = shellView;");
			sb.AppendLine(Resources.Tab3 + "this.reportViewModel = new " + root.Name +"ReportViewModel(this);");
			sb.AppendLine(Resources.Tab3 + "moduleEnvironment = ServiceLocator.Current.GetInstance<IModuleEnvironment>();");
			sb.AppendLine(Resources.Tab3 + "DataContext = reportViewModel;");
			sb.AppendLine(Resources.Tab3 + "tabControl.SelectionChanged += TabControl_SelectionChanged;");
			sb.AppendLine(Resources.Tab3 + "CommonHtv.SelectedItemChanged += HTV_SelectedItemChanged;");
			sb.AppendLine(Resources.Tab3 + "CommonHtv.ExpandedCollapsed += HTV_SelectedItemChanged;");
			sb.AppendLine();
			sb.AppendLine(Resources.Tab3 + "Title = Properties." + root.Name + "ResourcesGenerated." + root.Name + "_" + root.Name + ";");
			sb.AppendLine(Resources.Tab3 + "InfoTip = Properties." + root.Name + "ResourcesGenerated." + root.Name + "_" + root.Name + ";");
			sb.AppendLine();
			sb.AppendLine(Resources.Tab3 + "this.workspaceManager = moduleEnvironment.WorkspaceManager;");

			sb.AppendLine(Resources.Tab2 + "}");


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

			/*foreach(ModelType type in root.Types)
			{
				if(type is DataGrid)
				{
					DataGrid dg = type as DataGrid;
					string propertyName = string.Format("{0}ReportGridVisibilityControl{1}", root.Name, dg.Name);
					sb.AppendLine(Resources.Tab2 + "private DataGridColumnVisibilityControl " + propertyName + ";");
				}
			}*/

			return sb.ToString();
		}

		private string GetClassNamespace()
		{
			return "TelventDMS.UI.Components." + tab.ModelRoot.Name + ".View";
		}

		private string GetUsings()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine("using System");
			sb.AppendLine("using System.Collections.Generic");
			sb.AppendLine("using System.Linq");
			sb.AppendLine("using System.Text");
			sb.AppendLine("using System.Threading.Tasks");
			sb.AppendLine("using System.Windows");
			sb.AppendLine("using System.Windows.Controls");
			sb.AppendLine("using System.Windows.Data");
			sb.AppendLine("using System.Windows.Documents");
			sb.AppendLine("using System.Windows.Input");
			sb.AppendLine("using System.Windows.Media");
			sb.AppendLine("using System.Windows.Media.Imaging");
			sb.AppendLine("using System.Windows.Navigation");
			sb.AppendLine("using System.Windows.Shapes");

			return sb.ToString();
		}
	}
}
