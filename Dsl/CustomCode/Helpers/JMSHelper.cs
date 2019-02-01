using SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode.Helpers
{
	public static class JMSHelper
	{
		public static string GetJMSModelAssociationProperties(JMSModel jmsModel)
		{
			StringBuilder sb = new StringBuilder();
			string assName = string.Empty;
			string accModifier = string.Empty;

			foreach (Association association in Association.GetLinksToTargets(jmsModel))
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
				switch (association.TargetMultiplicity)
				{
					case Multiplicity.One:
					case Multiplicity.ZeroOne:
						sb.AppendLine(accModifier + " " + association.Target.Name + " " + assName + " { get; set; }");
						break;
					case Multiplicity.OneMany:
					case Multiplicity.ZeroMany:
						sb.AppendLine(accModifier + " List<" + association.Target.Name + "> " + assName + " { get; set; }");
						break;
					default:
						break;
				}
				
				sb.AppendLine();
				sb.Append("\t\t");
			}


			return sb.ToString();
		}

		internal static string GetJMSClassAttributes(JMSModel jmsModel)
		{
			StringBuilder sb = new StringBuilder();

			foreach (ClassAttribute attr in jmsModel.Attributes)
			{
				string customType = TypesToCSharpType.Convert(attr);
				if (attr.IsDataMember)
				{
					sb.AppendLine("\t\t[DataMember]");
				}
				sb.AppendLine("\t\tpublic " + customType + " " + attr.Name + " { get; set; }");
				sb.AppendLine();
			}

			return sb.ToString();
		}

		internal static string GetDefaultConstructor(JMSModel jmsModel)
		{
			StringBuilder sb = new StringBuilder();

			if (jmsModel.HasDefaultConstructor)
			{
				sb.AppendLine("public " + jmsModel.Name + "()");
				sb.AppendLine("\t\t{");
				sb.AppendLine("\t\t}");
			}

			return sb.ToString();
		}

		internal static string IsDataContractString(JMSModel jmsModel)
		{
			string dataContract = string.Empty;

			if (jmsModel.IsDataContract)
			{
				dataContract = "[DataContract]";
			}

			return dataContract;
		}

		internal static string GetSuperClass(JMSModel jmsModel)
		{
			string superclass = string.Empty; ;

			if (jmsModel.Superclass != null)
			{
				superclass = " : " + jmsModel.Superclass.Name;

			}
			return superclass;
		}

		internal static string GetClassNamespace(JMSModel jmsModel)
		{
			return "TelventDMS.Services.JobManagerService." + jmsModel.ModelRoot.Name + "Report." + jmsModel.Name;
		}

		public static string GetKnownTypes(JMSModel jmsModel)
		{
			StringBuilder sb = new StringBuilder();

			if (jmsModel.MainReportClass)
			{
				foreach (Generalization generalization in Generalization.GetLinksToSubclasses(jmsModel))
				{
					sb.AppendLine("[KnownType(typeof(" + generalization.Subclasses.Name + "))]");
				}
			}
			
			return sb.ToString();
		}

		public static string GetJMSEnumAttributes(Enum enumClass)
		{
			StringBuilder sb = new StringBuilder();

			foreach(EnumAttribute attr in enumClass.Values)
			{
				sb.AppendLine(attr.Name + ",");
				sb.Append("\t\t");
			}

			return sb.ToString();
		}

		public static string GetUsings(JMSModel jmsModel)
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("using System.Runtime.Serialization;");
			sb.AppendLine("using TelventDMS.Common.DMS.Common;");

			return sb.ToString();
		}
	}
}
