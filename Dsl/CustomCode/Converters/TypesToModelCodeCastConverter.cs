using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode.Converters
{
	public static class TypesToModelCodeCastConverter
	{
		public static string Convert(ColumnAttribute attr)
		{
			Types type;
			if (System.Enum.TryParse(attr.Type, out type))
			{
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
					default:
						return "unknown cast";
				}
			}
			else
			{
				List<string> enums = new List<string>();
				foreach (ModelType modelType in attr.DataGrid.ModelRoot.Types)
				{
					if (!(modelType is ExternalType))
					{
						continue;
					}
					ExternalType typeEnum = modelType as ExternalType;
					enums.Add(typeEnum.Name);
				}
				if (enums.Contains(attr.Type))
				{
					return "AsEnum()";
				}
			}

			return "unknown cast";
		}
	}
}
