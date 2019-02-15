using SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode.Converters;
using SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode.Helpers
{
	public static class JMSHelper
	{
		public static string GetJMSModelAssociationProperties(JMSModel jmsModel)
		{
			StringBuilder sb = new StringBuilder();
			string assName = string.Empty;
			string accModifier = string.Empty;

			foreach (Association association in Association.GetLinksToTargets(jmsModel))
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

				if (association.IsDataMember)
				{
					sb.AppendLine(Resources.Tab2 + "[DataMember]");
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
				
				sb.AppendLine();
			}


			return sb.ToString();
		}

		public static string GetJMSJobData(JMSModel jmsModel)
		{
			StringBuilder sb = new StringBuilder();

			foreach(ModelType type in jmsModel.ModelRoot.Types)
			{
				if(!(type is JMSModel))
				{
					continue;
				}
				JMSModel model = type as JMSModel;
				if (model.Type != JMSResultType.Record)
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

		public static string FillRecordData(JMSModel model)
		{
			StringBuilder sb = new StringBuilder();

			string data = "data.";

			foreach (ClassAttribute attr in model.Attributes)
			{
				sb.AppendLine(Resources.Tab5 + data + attr.Name + " = rds[i].GetProperty(ModelCode." + attr.ModelCode + ")." + TypesToModelCodeCastConverter.Convert(attr) + ";");
			}
			foreach(Association association in Association.GetLinksToTargets(model))
			{
				if(association.Target is Enum)
				{
					if(association.TargetMultiplicity == Multiplicity.One || association.TargetMultiplicity == Multiplicity.ZeroOne)
					{
						if (!string.IsNullOrEmpty(association.TargetRoleName))
						{
							sb.AppendLine(Resources.Tab5 + data + association.TargetRoleName + " = rds[i].GetProperty(ModelCode." + association.ModelCode + ").AsEnum();");
							continue;
						}
						sb.AppendLine(Resources.Tab5 + data + association.Target.Name + " = rds[i].GetProperty(ModelCode." + association.ModelCode + ").AsEnum();");
					}
					else if(association.TargetMultiplicity == Multiplicity.ZeroMany || association.TargetMultiplicity == Multiplicity.OneMany)
					{
						if (!string.IsNullOrEmpty(association.TargetRoleName))
						{
							sb.AppendLine(Resources.Tab5 + data + association.TargetRoleName + " = rds[i].GetProperty(ModelCode." + association.ModelCode + ").AsEnums();");
							continue;
						}
						sb.AppendLine(Resources.Tab5 + data + association.Target.Name + " = rds[i].GetProperty(ModelCode." + association.ModelCode + ").AsEnums();");
					}
				}
				else if(association.Target is JMSModel)
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

		public static string GetAttributesModelCodes(JMSModel model)
		{
			StringBuilder sb = new StringBuilder();

			foreach (ClassAttribute attr in model.Attributes)
			{
				sb.AppendLine(Resources.Tab5 + "ModelCode." + attr.ModelCode + ",");
			}
			foreach(Association association in Association.GetLinksToTargets(model))
			{
				sb.AppendLine(Resources.Tab5 + "ModelCode." + association.ModelCode + ",");
			}

			return sb.ToString();
		}

		public static string GetPropertiesFillingForRecord(JMSModel model)
		{
			StringBuilder sb = new StringBuilder();

			return sb.ToString();
		}

		public static string GetJMSClassAttributes(JMSModel jmsModel)
		{
			StringBuilder sb = new StringBuilder();

			foreach (ClassAttribute attr in jmsModel.Attributes)
			{
				string customType = TypesToCSharpType.Convert(attr);
				if (attr.IsDataMember)
				{
					sb.AppendLine(Resources.Tab2 + "[DataMember]");
				}
				sb.AppendLine(Resources.Tab2 + "public " + customType + " " + attr.Name + " { get; set; }");
				sb.AppendLine();
			}

			return sb.ToString();
		}

		public static string GetDefaultConstructor(JMSModel jmsModel)
		{
			StringBuilder sb = new StringBuilder();

			if (jmsModel.HasDefaultConstructor)
			{
				sb.AppendLine(Resources.Tab2 + "public " + jmsModel.Name + "()");
				sb.AppendLine(Resources.Tab2 + "{");
				sb.AppendLine(Resources.Tab2 + "}");
			}

			return sb.ToString();
		}

		public static string IsDataContractString(JMSModel jmsModel)
		{
			string dataContract = string.Empty;

			if (jmsModel.IsDataContract)
			{
				dataContract = "[DataContract]";
			}

			return dataContract;
		}

		public static string GetSuperClass(JMSModel jmsModel)
		{
			string superclass = string.Empty; ;

			if (jmsModel.Superclass != null)
			{
				superclass = " : " + jmsModel.Superclass.Name;

			}
			return superclass;
		}

		public static string GetClassNamespace(JMSModel jmsModel)
		{
			return "TelventDMS.Services.JobManagerService." + jmsModel.ModelRoot.Name + "Report";
		}

		public static string GetKnownTypes(JMSModel jmsModel)
		{
			StringBuilder sb = new StringBuilder();

			if (jmsModel.HasKnownTypes)
			{
				foreach (Generalization generalization in Generalization.GetLinksToSubclasses(jmsModel))
				{
					sb.AppendLine(Resources.Tab1 + "[KnownType(typeof(" + generalization.Subclasses.Name + "))]");
				}
			}
			
			return sb.ToString();
		}

		public static string GetJMSEnumAttributes(Enum enumClass)
		{
			StringBuilder sb = new StringBuilder();

			foreach(EnumAttribute attr in enumClass.Values)
			{
				sb.AppendLine(Resources.Tab2 +  attr.Name + ",");
			}

			return sb.ToString();
		}

		public static string GetUsings(JMSModel jmsModel)
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("using System;");
			sb.AppendLine("using System.Collections.Generic;");
			sb.AppendLine("using System.Linq;");
			sb.AppendLine("using TelventDMS.Common.DMS.Common;");
			sb.AppendLine("using System.Runtime.Serialization;");

			return sb.ToString();
		}

		private static void CreateFolder(string path)
		{
			bool exists = System.IO.Directory.Exists(path);
			if (!exists)
				System.IO.Directory.CreateDirectory(path);
		}
	}
}
