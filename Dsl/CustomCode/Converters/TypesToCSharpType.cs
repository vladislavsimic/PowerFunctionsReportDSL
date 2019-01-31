using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode.Converters
{
	public static class TypesToCSharpType
	{
		public static string Convert(ClassAttribute attr)
		{
			Types type = attr.Type;

			switch (type)
			{
				case Types.Bool:
					return "bool";
				case Types.Byte:
					return "byte";
				case Types.Char:
					return "char";
				case Types.DateTime:
					return "DateTime";
				case Types.Double:
					return "double";
				case Types.Float:
					return "float";
				case Types.Int:
					return "int";
				case Types.Long:
				case Types.GID:
					return "long";
				case Types.LID:
					return "long";
				case Types.String:
					return "string";
				case Types.Short:
					return "short";
				case Types.UShort:
					return "ushort";
				case Types.UInt:
					return "uint";
				case Types.ULong:
					return "ulong";
				case Types.ELimitViolation:
					return "ELimitViolation";
				default:
					return "unknown type";
			}
		}
	}
}
