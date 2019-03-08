using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode.Model
{
	public class JMSReportType : ICodeHandler
	{
		private ModelRoot root;

		private Dictionary<string, string> generatedCode;

		public JMSReportType(ModelRoot root)
		{
			this.root = root;
			this.generatedCode = new Dictionary<string, string>();
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
			GeneratedCode.Add("classNamespace", GetClassNamespace());
			GeneratedCode.Add("enumAttributes", GetJMSClassAttributes());
		}

		protected string GetClassNamespace()
		{
			return "TelventDMS.Services.JobManagerService." + root.Name + "Report";
		}

		protected string GetJMSClassAttributes()
		{
			StringBuilder sb = new StringBuilder();

			foreach (ModelType type in root.Types)
			{
				if (!(type is Tab))
				{
					continue;
				}
				Tab tab = type as Tab;
				if (!tab.ShouldGenerate)
				{
					continue;
				}
				sb.AppendLine(Resources.Tab2 + tab.Name + ",");
			}
			sb.AppendLine(Resources.Tab2 + "NoResults,");

			return sb.ToString();
		}
	}
}
