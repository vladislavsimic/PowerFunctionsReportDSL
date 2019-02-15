using SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode.Model
{
	public class JMSModelCSharp : ModelClassCSharp, CodeHandler
	{
		#region Fiels

		private JMSModel jmsModel;

		#endregion Fields

		#region Constructors

		public JMSModelCSharp(JMSModel jmsModel) : base(jmsModel)
		{
			this.jmsModel = jmsModel;
		}

		#endregion Constructors

		#region Properties

		public JMSModel JMSClass
		{
			get
			{
				return this.jmsModel;
			}
			set
			{
				this.jmsModel = value;
			}
		}

		#endregion Properties

		#region Methods

		public void ObtainCode()
		{
			Properties.Add("usings", JMSHelper.GetUsings(jmsModel));
			Properties.Add("classNamespace", JMSHelper.GetClassNamespace(jmsModel));
			Properties.Add("superclass", JMSHelper.GetSuperClass(jmsModel));
			Properties.Add("dataContract", JMSHelper.IsDataContractString(jmsModel));
			Properties.Add("defaultConstructor", JMSHelper.GetDefaultConstructor(jmsModel));
			Properties.Add("attributes", JMSHelper.GetJMSClassAttributes(jmsModel));
			Properties.Add("knownTypes", JMSHelper.GetKnownTypes(jmsModel));
			Properties.Add("associationProperties", JMSHelper.GetJMSModelAssociationProperties(jmsModel));
			Properties.Add("jobData", JMSHelper.GetJMSJobData(jmsModel));
		}

		#endregion Methods
	}
}
