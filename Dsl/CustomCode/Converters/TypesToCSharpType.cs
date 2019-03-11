using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode.Converters
{
	public static class TypesToCSharpType
	{
		public static string Convert(ColumnAttribute attr)
		{
			Types type;
			if(System.Enum.TryParse(attr.Type, out type))
			{
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
						return "long";
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
					default:
						return "unknown type";
				}
			}
			else
			{
				List<string> enums = new List<string>();
				foreach(ModelType modelType in attr.DataGrid.ModelRoot.Types)
				{
					if(!(modelType is Enum))
					{
						continue;
					}
					Enum typeEnum = modelType as Enum;
					enums.Add(typeEnum.Name);
				}
				if (enums.Contains(attr.Type))
				{
					return attr.Type;
				}
			}
			return "unknown type";

		}
	}
}
