using SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode.Model
{
	public class UIViewModel : ICodeHandler
	{
		private DataGrid dg;

		private Dictionary<string, string> properties = new Dictionary<string, string>();

		public UIViewModel()
		{

		}

		public UIViewModel(DataGrid dg)
		{
			this.dg = dg;
		}

		public DataGrid DataGrid
		{
			get
			{
				return this.dg;
			}
			set
			{
				dg = value;
			}
		}

		public Dictionary<string, string> Properties
		{
			get
			{
				return properties;
			}
			set
			{
				this.properties = value;
			}
		}

		public void ObtainCode()
		{
			Properties.Add("usings", UIHelper.GetUsings(dg));
			Properties.Add("classNamespace", UIHelper.GetNamespace(dg));
			Properties.Add("fields", UIHelper.GetViewModelFields(dg));
			Properties.Add("defaultConstructor", UIHelper.GetDefaultViewModelConstructor(dg));
			Properties.Add("constructor", UIHelper.GetViewModelConstructor(dg));
			Properties.Add("properties", UIHelper.GetViewModelProperties(dg));
		}
	}
}
