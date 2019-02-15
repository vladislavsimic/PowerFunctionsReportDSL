using SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode.Model
{
	public class DataGridCSharp
	{
		private DataGrid dataGrid;

		public DataGridCSharp()
		{

		}

		public DataGridCSharp(DataGrid dataGrid)
		{
			this.dataGrid = dataGrid;
		}

		public string GetXamlCode()
		{
			return UIHelper.GetXamlCode(dataGrid);
		}
	}
}
