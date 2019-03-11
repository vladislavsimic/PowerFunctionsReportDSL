using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode.Model
{
	public class JMSResults : JMSModelBase, ICodeHandler
	{

		public JMSResults(DataGrid dg) : base(dg)
		{
		}

		public void ObtainCode()
		{
			GeneratedCode.Add("usings", GetUsings());
			GeneratedCode.Add("classNamespace", GetClassNamespace());
			GeneratedCode.Add("superclass", GetSuperClass());
			GeneratedCode.Add("dataContract", IsDataContractString());
			GeneratedCode.Add("defaultConstructor", GetDefaultConstructor());
			GeneratedCode.Add("attributes", GetJMSClassAttributes());
		}

		protected override string GetClassNamespace()
		{
			return "TelventDMS.Services.JobManagerService." + DataGrid.ModelRoot.Name + "Report";
		}

		protected override string GetDefaultConstructor()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine(Resources.Tab2 + "public " + DataGrid.Name + "Results()");
			sb.AppendLine(Resources.Tab2 + "{");
			sb.AppendLine(Resources.Tab3 + "ReportType = " + DataGrid.ModelRoot.Name + "ReportType." + DataGrid.Name + ";");
			sb.AppendLine(Resources.Tab2 + "}");

			return sb.ToString();
		}

		protected override string GetJMSClassAttributes()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine(Resources.Tab2 + "[DataMember]");
			sb.AppendLine(Resources.Tab2 + "public List<" + DataGrid.Name + "Record> Records { get; set; }");

			return sb.ToString();
		}

		protected override string GetSuperClass()
		{
			return DataGrid.Name + "ReportResult";
		}

		protected override string GetUsings()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine("using System;");
			sb.AppendLine("using System.Collections.Generic;");
			sb.AppendLine("using System.Linq;");
			sb.AppendLine("using TelventDMS.Common.DMS.Common;");
			sb.AppendLine("using System.Runtime.Serialization;");

			return sb.ToString();
		}

		protected override string IsDataContractString()
		{
			return "[DataContract]";
		}
	}
}
