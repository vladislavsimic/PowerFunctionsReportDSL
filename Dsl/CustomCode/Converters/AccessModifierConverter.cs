using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode.Converters
{
	public static class AccessModifierConverter
	{
		public static string ConvertModifier(Association association)
		{
			TypeAccessModifier accModifier = (TypeAccessModifier)association.AccessModifier;

			switch (accModifier)
			{
				case TypeAccessModifier.Public:
					return "public";
				case TypeAccessModifier.Private:
					return "private";
				case TypeAccessModifier.Protected:
					return "protected";
				default:
					return "unknown type";
			}
		}
	}
}
