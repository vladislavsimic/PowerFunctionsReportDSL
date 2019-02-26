using SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode.Converters;
using SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode.Model
{
	public class JMSRecord : JMSModelBase, ICodeHandler
	{
		#region Constructor

		public JMSRecord(JMSModel model): base(model)
		{
		}

		#endregion Constructor

		#region Methods

		public void ObtainCode()
		{
			GeneratedCode.Add("usings", GetUsings());
			GeneratedCode.Add("classNamespace", GetClassNamespace());
			GeneratedCode.Add("superclass",GetSuperClass());
			GeneratedCode.Add("dataContract", IsDataContractString());
			GeneratedCode.Add("defaultConstructor", GetDefaultConstructor());
			GeneratedCode.Add("attributes", GetJMSClassAttributes());
			GeneratedCode.Add("associationProperties", GetJMSModelAssociationProperties());
		}

		protected override string GetClassNamespace()
		{
			return "TelventDMS.Services.JobManagerService." + JmsModel.ModelRoot.Name + "Report";
		}

		protected override string GetDefaultConstructor()
		{
			StringBuilder sb = new StringBuilder();

			if (JmsModel.HasDefaultConstructor)
			{
				sb.AppendLine(Resources.Tab2 + "public " + JmsModel.Name + "Record()");
				sb.AppendLine(Resources.Tab2 + "{");
				sb.AppendLine(Resources.Tab2 + "}");
			}

			return sb.ToString();
		}

		protected override string GetJMSClassAttributes()
		{
			StringBuilder sb = new StringBuilder();

			foreach (ClassAttribute attr in JmsModel.Attributes)
			{
				string customType = TypesToCSharpType.Convert(attr);
				if (attr.IsDataMember)
				{
					sb.AppendLine(Resources.Tab2 + "[DataMember]");
				}
				sb.AppendLine(Resources.Tab2 + "public " + customType + " " + attr.Name + " { get; set; }");
				sb.AppendLine();
			}

			return sb.ToString();
		}

		protected override string GetSuperClass()
		{
			return " : HierarchicalReportRecord";
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
			string dataContract = string.Empty;

			if (JmsModel.IsDataContract)
			{
				dataContract = "[DataContract]";
			}

			return dataContract;
		}

		protected string GetJMSModelAssociationProperties()
		{
			StringBuilder sb = new StringBuilder();
			string assName = string.Empty;
			string accModifier = string.Empty;

			foreach (Association association in Association.GetLinksToTargets(JmsModel))
			{
				accModifier = AccessModifierConverter.ConvertModifier(association);
				if (String.IsNullOrEmpty(association.TargetRoleName))
				{
					assName = association.Target.Name.First().ToString().ToUpper() + association.Target.Name.Substring(1);
				}
				else
				{
					assName = association.TargetRoleName.First().ToString().ToUpper() + association.TargetRoleName.Substring(1);
				}

				if (association.IsDataMember)
				{
					sb.AppendLine(Resources.Tab2 + "[DataMember]");
				}

				switch (association.TargetMultiplicity)
				{
					case Multiplicity.One:
					case Multiplicity.ZeroOne:
						sb.AppendLine(Resources.Tab2 + accModifier + " " + association.Target.Name + " " + assName + " { get; set; }");
						break;
					case Multiplicity.OneMany:
					case Multiplicity.ZeroMany:
						sb.AppendLine(Resources.Tab2 + accModifier + " List<" + association.Target.Name + "> " + assName + " { get; set; }");
						break;
					default:
						break;
				}

				sb.AppendLine();
			}


			return sb.ToString();
		}

		#endregion Methods
	}
}
