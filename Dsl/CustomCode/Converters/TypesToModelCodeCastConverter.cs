using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode.Converters
{
	public static class TypesToModelCodeCastConverter
	{
		public static string Convert(ClassAttribute attr)
		{
			Types type = attr.Type;

			switch (type)
			{
				case Types.Bool:
					return "AsBool()";
				case Types.Byte:
					return "AsByte()";
				case Types.Char:
					return "AsString()";
				case Types.DateTime:
					return "AsTimeSpan()";
				case Types.Double:
					return "AsDouble()";
				case Types.Float:
					return "AsFloat()";
				case Types.Int:
					return "AsInt()";
				case Types.Long:
					return "AsLong()";
				case Types.GID:
					return "AsReference()";
				case Types.LID:
					return "AsReference()";
				case Types.String:
					return "string";
				case Types.Short:
				case Types.UShort:
				case Types.UInt:
					return "AsInt()";
				case Types.ULong:
					return "AsLong()";
				case Types.ELimitViolation:
					return "AsEnum()";
				default:
					return "unknown cast";
			}
		}
	}
}
