using SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode.Model
{
	public class JMSJob : JMSModelBase, ICodeHandler
	{
		public JMSJob(JMSModel model) : base(model)
		{

		}

		public void ObtainCode()
		{
			GeneratedCode.Add("usings", GetUsings());
			GeneratedCode.Add("classNamespace", GetClassNamespace());
			GeneratedCode.Add("superclass", GetSuperClass());
			GeneratedCode.Add("dataContract", IsDataContractString());
			GeneratedCode.Add("jobData", GetJMSJobData());
		}

		private string GetJMSJobData()
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
				sb.AppendLine(Resources.Tab2 + "private void Fill" + model.Name + "Properties(List<long> gids)");
				sb.AppendLine(Resources.Tab2 + "{");
				sb.AppendLine(Resources.Tab3 + "long mdc = 0;");
				sb.AppendLine(Resources.Tab3 + "if (gids.Count <= 0) return;");
				sb.AppendLine(Resources.Tab3 + "var iteratorId = GdaQuery.GetDescendentValues(0,");
				sb.AppendLine(Resources.Tab4 + "new List<ModelCode> {");
				sb.AppendLine(GetAttributesModelCodes(model));
				sb.AppendLine(Resources.Tab4 + "}, new List<Association>(), busnodeGids, new List<Association>(), ref mdc);");
				sb.AppendLine(Resources.Tab3 + "var count = GdaQuery.IteratorResourcesLeft(iteratorId);");
				sb.AppendLine(Resources.Tab3 + "while (count > 0)");
				sb.AppendLine(Resources.Tab3 + "{");
				sb.AppendLine(Resources.Tab4 + "List<ResourceDescription> rds = GdaQuery.IteratorNext(50000, iteratorId);");
				sb.AppendLine(Resources.Tab4 + "for (int i = 0; i < rds.Count; i++)");
				sb.AppendLine(Resources.Tab4 + "{");
				sb.AppendLine(Resources.Tab5 + "EMSLoadFlowRecordBean data = (hierarhyRecordData[rds[i].Id] as EMSLoadFlowRecordBean)");
				sb.AppendLine(Resources.Tab5 + "if (data == null)");
				sb.AppendLine(Resources.Tab5 + "{");
				sb.AppendLine(Resources.Tab6 + "DMSLogger.Log(DMSLogger.LogLevel.Error, \"[EMSLF]: Error occurred while collecting" + model.Name + ". Record data is null!\");");
				sb.AppendLine(Resources.Tab6 + "throw new ArgumentNullException(\"busnodeGids\");");
				sb.AppendLine(Resources.Tab5 + "}");
				sb.AppendLine(FillRecordData(model));
				sb.AppendLine(Resources.Tab4 + "}");
				sb.AppendLine(Resources.Tab4 + "count -= rds.Count;");
				sb.AppendLine(Resources.Tab3 + "}");
				sb.AppendLine(Resources.Tab3 + "GdaQuery.IteratorClose(iteratorId);");
				sb.AppendLine(Resources.Tab2 + "}");
				sb.AppendLine();
			}

			return sb.ToString();
		}

		private string FillRecordData(JMSModel model)
		{
			StringBuilder sb = new StringBuilder();

			string data = "data.";

			foreach (ClassAttribute attr in model.Attributes)
			{
				sb.AppendLine(Resources.Tab5 + data + attr.Name + " = rds[i].GetProperty(ModelCode." + attr.ModelCode + ")." + TypesToModelCodeCastConverter.Convert(attr) + ";");
			}
			foreach (Association association in Association.GetLinksToTargets(model))
			{
				if (association.Target is Enum)
				{
					if (association.TargetMultiplicity == Multiplicity.One || association.TargetMultiplicity == Multiplicity.ZeroOne)
					{
						if (!string.IsNullOrEmpty(association.TargetRoleName))
						{
							sb.AppendLine(Resources.Tab5 + data + association.TargetRoleName + " = rds[i].GetProperty(ModelCode." + association.ModelCode + ").AsEnum();");
							continue;
						}
						sb.AppendLine(Resources.Tab5 + data + association.Target.Name + " = rds[i].GetProperty(ModelCode." + association.ModelCode + ").AsEnum();");
					}
					else if (association.TargetMultiplicity == Multiplicity.ZeroMany || association.TargetMultiplicity == Multiplicity.OneMany)
					{
						if (!string.IsNullOrEmpty(association.TargetRoleName))
						{
							sb.AppendLine(Resources.Tab5 + data + association.TargetRoleName + " = rds[i].GetProperty(ModelCode." + association.ModelCode + ").AsEnums();");
							continue;
						}
						sb.AppendLine(Resources.Tab5 + data + association.Target.Name + " = rds[i].GetProperty(ModelCode." + association.ModelCode + ").AsEnums();");
					}
				}
				else if (association.Target is JMSModel)
				{
					if (association.TargetMultiplicity == Multiplicity.One || association.TargetMultiplicity == Multiplicity.ZeroOne)
					{
						if (!string.IsNullOrEmpty(association.TargetRoleName))
						{
							sb.AppendLine(Resources.Tab5 + data + association.TargetRoleName + " = rds[i].GetProperty(ModelCode." + association.ModelCode + ").AsReference();");
							continue;
						}
						sb.AppendLine(Resources.Tab5 + data + association.Target.Name + " = rds[i].GetProperty(ModelCode." + association.ModelCode + ").AsReference();");
					}
					else if (association.TargetMultiplicity == Multiplicity.ZeroMany || association.TargetMultiplicity == Multiplicity.OneMany)
					{
						if (!string.IsNullOrEmpty(association.TargetRoleName))
						{
							sb.AppendLine(Resources.Tab5 + data + association.TargetRoleName + " = rds[i].GetProperty(ModelCode." + association.ModelCode + ").AsReferences();");
							continue;
						}
						sb.AppendLine(Resources.Tab5 + data + association.Target.Name + " = rds[i].GetProperty(ModelCode." + association.ModelCode + ").AsReferences();");
					}
				}
			}

			return sb.ToString();
		}

		private string GetAttributesModelCodes(JMSModel model)
		{
			StringBuilder sb = new StringBuilder();

			foreach (ClassAttribute attr in model.Attributes)
			{
				sb.AppendLine(Resources.Tab5 + "ModelCode." + attr.ModelCode + ",");
			}
			foreach (Association association in Association.GetLinksToTargets(model))
			{
				sb.AppendLine(Resources.Tab5 + "ModelCode." + association.ModelCode + ",");
			}

			return sb.ToString();
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
			throw new NotImplementedException();
		}

		protected override string GetSuperClass()
		{
			return " : AsyncJob";
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
			return "[DataContract]";
		}
	}
}
