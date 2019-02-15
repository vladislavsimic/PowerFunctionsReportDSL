using SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode.Model
{
	public class UIViewModel : CodeHandler
	{
		private JMSModel jmsModel;

		private Dictionary<string, string> properties = new Dictionary<string, string>();

		public UIViewModel()
		{

		}

		public UIViewModel(JMSModel jmsModel)
		{
			this.jmsModel = jmsModel;
		}

		public JMSModel JmsModel
		{
			get
			{
				return this.jmsModel;
			}
			set
			{
				jmsModel = value;
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
			Properties.Add("usings", UIHelper.GetUsings(jmsModel));
			Properties.Add("classNamespace", UIHelper.GetNamespace(jmsModel));
			Properties.Add("fields", UIHelper.GetViewModelFields(jmsModel));
			Properties.Add("defaultConstructor", UIHelper.GetDefaultViewModelConstructor(jmsModel));
			Properties.Add("constructor", UIHelper.GetViewModelConstructor(jmsModel));
			Properties.Add("properties", UIHelper.GetViewModelProperties(jmsModel));
		}
	}
}
