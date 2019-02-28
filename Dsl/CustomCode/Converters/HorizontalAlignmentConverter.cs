using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode.Converters
{
	public static class HorizontalAlignmentConverter
	{
		public static string Convert(HorizontalAlignment alignment)
		{
			switch (alignment)
			{
				case HorizontalAlignment.Center:
					return "Center";
				case HorizontalAlignment.Left:
					return "Left";
				case HorizontalAlignment.Right:
					return "Right";
				case HorizontalAlignment.Stretch:
					return "Stretch";
				default:
					return "Unknown";
			}
		}
	}
}
