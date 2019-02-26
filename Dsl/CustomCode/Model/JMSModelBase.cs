using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode.Model
{
	public abstract class JMSModelBase
	{

		#region Fields

		private JMSModel model;

		private Dictionary<string, string> generatedCode;

		#endregion Fields

		#region Constructor

		public JMSModelBase(JMSModel model)
		{
			this.model = model;
			this.generatedCode = new Dictionary<string, string>();
		}

		#endregion Constructor

		#region Properties

		public JMSModel JmsModel
		{
			get
			{
				return model;
			}
			set
			{
				model = value;
			}
		}

		public Dictionary<string,string> GeneratedCode
		{
			get
			{
				return generatedCode;
			}
			set
			{
				generatedCode = value;
			}
		}

		#endregion Properties

		#region Methods

		protected abstract string GetUsings();

		protected abstract string GetClassNamespace();

		protected abstract string GetSuperClass();

		protected abstract string IsDataContractString();

		protected abstract string GetDefaultConstructor();

		protected abstract string GetJMSClassAttributes();

		#endregion Methods
	}
}
