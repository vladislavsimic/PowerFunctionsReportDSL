using SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode.Model
{
	public class JMSBean : JMSModelBase, ICodeHandler
	{
		public JMSBean(DataGrid dg) : base(dg)
		{

		}

		public void ObtainCode()
		{
			GeneratedCode.Add("usings", GetUsings());
			GeneratedCode.Add("classNamespace", GetClassNamespace());
			GeneratedCode.Add("superclass", GetSuperClass());
			GeneratedCode.Add("defaultConstructor", GetDefaultConstructor());
			GeneratedCode.Add("attributes", GetJMSClassAttributes());
		}

		protected override string GetClassNamespace()
		{
			return "TelventDMS.Services.JobManagerService." + DataGrid.ModelRoot.Name + "Report";
		}

		protected override string GetDefaultConstructor()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine(Resources.Tab2 + "public " + DataGrid.ModelRoot.Name + "RecordBean()");
			sb.AppendLine(Resources.Tab2 + "{");
			sb.AppendLine(Resources.Tab2 + "}");

			return sb.ToString();
		}

		protected override string GetJMSClassAttributes()
		{
			StringBuilder sb = new StringBuilder();

			string assName = string.Empty;
			string accModifier = string.Empty;

			sb.AppendLine(Resources.Tab2 + "public MeasurementValueQuality Quality { get; set; }");

			foreach (ModelType type in DataGrid.ModelRoot.Types)
			{
				if (!(type is DataGrid))
				{
					continue;
				}
				DataGrid model = type as DataGrid;
				if (!model.ShouldGenerate)
				{
					continue;
				}

				foreach (ColumnAttribute attr in model.Columns)
				{
					string customType = TypesToCSharpType.Convert(attr);

					sb.AppendLine(Resources.Tab2 + "public " + customType + " " + attr.Name + " { get; set; }");
					sb.AppendLine();
				}
				/*foreach(Association association in Association.GetLinksToTargets(model))
				{
					accModifier = AccessModifierConverter.ConvertModifier(association);
					if (String.IsNullOrEmpty(association.TargetRoleName))
					{
						assName = association.Target.Name.First().ToString().ToUpper() + association.Target.Name.Substring(1);
					}
					else
					{
						assName = association.TargetRoleName.First().ToString().ToUpper() + association.TargetRoleName.Substring(1);
					}
					switch (association.TargetMultiplicity)
					{
						case Multiplicity.One:
						case Multiplicity.ZeroOne:
							sb.AppendLine(Resources.Tab2 + accModifier + " " + association.Target.Name + " " + assName + " { get; set; }");
							break;
						case Multiplicity.OneMany:
						case Multiplicity.ZeroMany:
							sb.AppendLine(Resources.Tab2 + accModifier + " List<" + association.Target.Name + "> " + assName + " { get; set; }");
							break;
						default:
							break;
					}
				}*/
			}

			return sb.ToString();
		}

		protected override string GetSuperClass()
		{
			return " : HierarchicalRecordData";
		}

		protected override string GetUsings()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine("using System;");
			sb.AppendLine("using System.Collections.Generic;");
			sb.AppendLine("using System.Linq;");
			sb.AppendLine("using TelventDMS.Common.DMS.Common;");
			sb.AppendLine("using System.Runtime.Serialization;");

			return sb.ToString();
		}

		protected override string IsDataContractString()
		{
			throw new NotImplementedException();
		}
	}
}
