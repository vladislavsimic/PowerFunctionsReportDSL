using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode.Model
{
	public class JMSJobParam : JMSModelBase, ICodeHandler
	{
		public JMSJobParam(JMSModel model):base(model)
		{
			
		}

		public void ObtainCode()
		{
			GeneratedCode.Add("usings", GetUsings());
			GeneratedCode.Add("classNamespace", GetClassNamespace());
			GeneratedCode.Add("superclass", GetSuperClass());
			GeneratedCode.Add("dataContract", IsDataContractString());
			GeneratedCode.Add("attributes", GetJMSClassAttributes());
		}

		protected override string GetClassNamespace()
		{
			return "TelventDMS.Services.JobManagerService." + JmsModel.ModelRoot.Name + "Report";
		}

		protected override string GetDefaultConstructor()
		{
			throw new NotImplementedException();
		}

		protected override string GetJMSClassAttributes()
		{
			StringBuilder sb = new StringBuilder();

			string dataMember = Resources.Tab2 + "[DataMember]";

			sb.AppendLine(dataMember);
			sb.AppendLine(Resources.Tab2 + "public List<long> SelectedRecords { get; set; }");
			sb.AppendLine(dataMember);
			sb.AppendLine(Resources.Tab2 + "public HierarchyType HierarchyType { get; set; }");
			sb.AppendLine(dataMember);
			sb.AppendLine(Resources.Tab2 + "public " + JmsModel.ModelRoot.Name + "ReportType ReportType { get; set; }");
			sb.AppendLine(dataMember);
			sb.AppendLine(Resources.Tab2 + "public HierarchyNetworkType HierarchyNetworkType { get; set; }");

			return sb.ToString();
		}

		protected override string GetSuperClass()
		{
			return ": JobParam";
		}

		protected override string GetUsings()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine("using System.Collections.Generic;");
			sb.AppendLine("using System.Runtime.Serialization;");

			return sb.ToString();
		}

		protected override string IsDataContractString()
		{
			return Resources.Tab1 + "[DataContract]";
		}
	}
}
