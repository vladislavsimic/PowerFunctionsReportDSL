using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode.Model
{
	public class JMSReportResult : JMSModelBase, ICodeHandler
	{
		public JMSReportResult(JMSModel model):base(model)
		{

		}

		public void ObtainCode()
		{
			GeneratedCode.Add("usings", GetUsings());
			GeneratedCode.Add("classNamespace", GetClassNamespace());
			GeneratedCode.Add("superclass", GetSuperClass());
			GeneratedCode.Add("dataContract", IsDataContractString());
			GeneratedCode.Add("defaultConstructor", GetDefaultConstructor());
			GeneratedCode.Add("constructor", GetConstructor());
			GeneratedCode.Add("attributes", GetJMSClassAttributes());
			GeneratedCode.Add("knownTypes", GetKnownTypes());
		}

		private string GetKnownTypes()
		{
			StringBuilder sb = new StringBuilder();

			foreach(ModelType type in JmsModel.ModelRoot.Types)
			{
				if (!(type is JMSModel))
				{
					continue;
				}
				JMSModel model = type as JMSModel;
				if (!model.ShouldGenerate)
				{
					continue;
				}
				sb.AppendLine(Resources.Tab1 + "[KnownType(typeof(" + model.Name + "Results))]");
			}

			return sb.ToString();
		}

		private string GetConstructor()
		{
			StringBuilder sb = new StringBuilder();

			string modelRootName = JmsModel.ModelRoot.Name;

			sb.AppendLine(Resources.Tab2 + "public " + modelRootName + "ReportResult(" + modelRootName + "ReportType reportType)");
			sb.AppendLine(Resources.Tab2 + "{");
			sb.AppendLine(Resources.Tab3 + modelRootName + "ReportType = reportType;");
			sb.AppendLine(Resources.Tab2 + "}");

			return sb.ToString();
		}

		protected override string GetClassNamespace()
		{
			return "TelventDMS.Services.JobManagerService." + JmsModel.ModelRoot.Name + "Report";
		}

		protected override string GetDefaultConstructor()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine(Resources.Tab2 + "public " + JmsModel.ModelRoot.Name + "ReportResult()");
			sb.AppendLine(Resources.Tab2 + "{");
			sb.AppendLine(Resources.Tab2 + "}");

			return sb.ToString();
		}

		protected override string GetJMSClassAttributes()
		{
			StringBuilder sb = new StringBuilder();

			string rootName = JmsModel.ModelRoot.Name;

			sb.AppendLine(Resources.Tab2 + "[DataMember]");
			sb.AppendLine(Resources.Tab2 + "public " + rootName + "ReportType " + rootName + "ReportType { get; set; }");

			return sb.ToString();
		}

		protected override string GetSuperClass()
		{
			return " : JobResult";
		}

		protected override string GetUsings()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine("using System.Runtime.Serialization;");

			return sb.ToString();
		}

		protected override string IsDataContractString()
		{
			return Resources.Tab1 + "[DataContract]";
		}
	}
}
