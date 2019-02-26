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
