using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode.Model
{
	public class ModelClassCSharp
	{
		private ModelClass mClass;

		private Dictionary<string, string> properties = new Dictionary<string, string>();

		public ModelClassCSharp(ModelClass modelClass)
		{
			this.mClass = modelClass;
		}

		public ModelClass Class
		{
			get
			{
				return this.mClass;
			}
			set
			{
				this.mClass = value;
			}
		}
		
		public Dictionary<string, string> Properties
		{
			get
			{
				return this.properties;
			}
			set
			{
				this.properties = value;
			}
		} 
	}
}
