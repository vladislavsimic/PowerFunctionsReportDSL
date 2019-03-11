using SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode.Converters;
using SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode.Helpers
{
	public static class JMSHelper
	{
		public static string GetJMSEnumAttributes(Enum enumClass)
		{
			StringBuilder sb = new StringBuilder();

			foreach(EnumAttribute attr in enumClass.Values)
			{
				sb.AppendLine(Resources.Tab2 +  attr.Name + ",");
			}

			return sb.ToString();
		}

		private static void CreateFolder(string path)
		{
			bool exists = System.IO.Directory.Exists(path);
			if (!exists)
				System.IO.Directory.CreateDirectory(path);
		}
	}
}
