using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode.Model
{
	public class JMSReportType : JMSModelBase, ICodeHandler
	{
		public JMSReportType(JMSModel model) : base(model)
		{

		}

		public void ObtainCode()
		{
			GeneratedCode.Add("classNamespace", GetClassNamespace());
			GeneratedCode.Add("enumAttributes", GetJMSClassAttributes());
		}

		protected override string GetClassNamespace()
		{
			return "TelventDMS.Services.JobManagerService." + JmsModel.ModelRoot.Name + "Report";
		}

		protected override string GetDefaultConstructor()
		{
			throw new NotImplementedException();
		}

		protected override string GetJMSClassAttributes()
		{
			StringBuilder sb = new StringBuilder();

			foreach (ModelType type in JmsModel.ModelRoot.Types)
			{
				if (!(type is JMSModel))
				{
					continue;
				}
				JMSModel model = type as JMSModel;
				if (!model.ShouldGenerate)
				{
					continue;
				}
				sb.AppendLine(Resources.Tab2 + model.Name + ",");
			}
			sb.AppendLine(Resources.Tab2 + "NoResults,");

			return sb.ToString();
		}

		protected override string GetSuperClass()
		{
			throw new NotImplementedException();
		}

		protected override string GetUsings()
		{
			throw new NotImplementedException();
		}

		protected override string IsDataContractString()
		{
			throw new NotImplementedException();
		}
	}
}
