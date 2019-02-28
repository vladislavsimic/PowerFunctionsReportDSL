using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode.Converters
{
	public static class VerticalAlignmentConverter
	{
		public static string Convert(VerticalAlignment alignment)
		{
			switch (alignment)
			{
				case VerticalAlignment.Center:
					return "Center";
				case VerticalAlignment.Bottom:
					return "Bottom";
				case VerticalAlignment.Stretch:
					return "Stretch";
				case VerticalAlignment.Top:
					return "Top";
				default:
					return "Unknown";
			}
		}
	}
}
