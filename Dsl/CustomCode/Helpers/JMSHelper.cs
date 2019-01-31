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

		public static string GetKnownTypes(JMSModel jmsModel)
		{
			StringBuilder sb = new StringBuilder();

			foreach(Generalization generalization in Generalization.GetLinksToSubclasses(jmsModel))
			{
				sb.AppendLine("[KnownType(typeof(" + generalization.Subclasses.Name + "))]");
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
	}
}
