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
		public JMSJob(DataGrid dg) : base(dg)
		{

		}

		public void ObtainCode()
		{
			GeneratedCode.Add("usings", GetUsings());
			GeneratedCode.Add("classNamespace", GetClassNamespace());
			GeneratedCode.Add("superclass", GetSuperClass());
			GeneratedCode.Add("dataContract", IsDataContractString());
			GeneratedCode.Add("declarations", GetJmsJobDeclarations());
			GeneratedCode.Add("properties", GetJmsJobProperties());
			GeneratedCode.Add("jobMethods", GetJMSJobMethods());
		}

		private string GetJmsJobProperties()
		{
			StringBuilder sb = new StringBuilder();

			return sb.ToString();
		}

		private string GetJmsJobDeclarations()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine(Resources.Tab2 + "private HierarchyType hierarchyType;");
			sb.AppendLine(Resources.Tab2 + "private " + DataGrid.ModelRoot.Name + "ReportType reportType;");
			sb.AppendLine(Resources.Tab2 + "private List<long> selectedRecords;");
			sb.AppendLine(Resources.Tab2 + "private Dictionary<long, HierarchicalRecordData> hierarchicalRecordData;");
			sb.AppendLine(Resources.Tab2 + "private Dictionary<long, MeasurementValueQuality> lfMeasureQuality;");
			sb.AppendLine(Resources.Tab2 + "private HierarchicalFilter containerHierarchyTree;");
			sb.AppendLine(Resources.Tab2 + "private HierarchicalFilter hierarchyTreeFilter;");
			sb.AppendLine(Resources.Tab2 + "private HierarchyNetworkType hierarchyNetworkType;");

			return sb.ToString();
		}

		private string GetJMSJobMethods()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine(CreateReportResultsMethod());
			sb.AppendLine(CreateRecordsMethod());

			return sb.ToString();
		}

		private string CreateRecordsMethod()
		{
			StringBuilder sb = new StringBuilder();

			foreach (ModelType type in DataGrid.ModelRoot.Types)
			{
				if (!(type is Tab))
				{
					continue;
				}
				Tab tab = type as Tab;
				if (tab.TargetTabbed.Count > 0 || tab.DataGrid == null)
				{
					continue;
				}
				string rootName = DataGrid.ModelRoot.Name;
				string recordName = tab.DataGrid.Name + "Record";
				DataGrid dg = tab.DataGrid;

				//create records methods
				sb.AppendLine();
				sb.AppendLine(Resources.Tab2 + "#region " + recordName);
				sb.AppendLine();

				sb.AppendLine(Resources.Tab2 + "private List<" + recordName + "> Create" + dg.Name + "Records()");
				sb.AppendLine(Resources.Tab2 + "{");
				sb.AppendLine(Resources.Tab3 + "List<"+ recordName + "> records = new List<"+ recordName + ">();");
				//try
				sb.AppendLine(Resources.Tab3 + "try");
				sb.AppendLine(Resources.Tab3 + "{");
				sb.AppendLine(Resources.Tab4 + "List<long> gids = GetElementsForSelectedCircuits(selectedRecords, ModelCode." + dg.ModelCodeResultsType + ", ModelCode.TARESVAL_PARENTCIRCUIT);");
				sb.AppendLine(Resources.Tab4 + "Fill" + dg.Name + "Properties(gids);");
				sb.AppendLine(Resources.Tab4 + "GetElementsNames(gids);");
				//foreach
				sb.AppendLine(Resources.Tab4 + "foreach (long id in selectedRecords)");
				sb.AppendLine(Resources.Tab4 + "{");
				sb.AppendLine(Resources.Tab5 + recordName + " circuitRecord = Create" + recordName + "(hierarchyTreeFilter, id);");
				sb.AppendLine(Resources.Tab5 + "records.Add(circuitRecord);");
				sb.AppendLine(Resources.Tab5 + "if (hierarchyTreeFilter.GetNodeByLid(id).Children == null) continue;");
				sb.AppendLine(Resources.Tab5 + "foreach (HierarchicalFilterNode childNode in hierarchyTreeFilter.GetNodeByLid(id).Children)");
				sb.AppendLine(Resources.Tab5 + "{");
				sb.AppendLine(Resources.Tab6 + "if ((DMSType)ModelCodeHelper.ExtractTypeFromGlobalId(childNode.Lid) != DMSType." + dg.DMSType + ") continue;");
				sb.AppendLine(Resources.Tab6 + "MeasurementValueQuality lfQuality;");
				sb.AppendLine(Resources.Tab6 + "if (!lfMeasureQuality.TryGetValue(id, out lfQuality) || CheckIsLFStatusDisabled(lfQuality))");
				sb.AppendLine(Resources.Tab6 + "{");
				sb.AppendLine(Resources.Tab7 + "continue;");
				sb.AppendLine(Resources.Tab6 + "}");
				sb.AppendLine(Resources.Tab6 + "records.Add(Create" + recordName + "(hierarchyTreeFilter, childNode.Lid));");
				sb.AppendLine(Resources.Tab5 + "}");
				sb.AppendLine(Resources.Tab4 + "}");
				//end for each
				sb.AppendLine(Resources.Tab3 + "}");
				//endtry
				sb.AppendLine(Resources.Tab3 + "catch (Exception)");
				sb.AppendLine(Resources.Tab3 + "{");
				sb.AppendLine(Resources.Tab4 + "DMSLogger.Log(DMSLogger.LogLevel.Error, \"[" + rootName + "]: Error occurred while creating " + dg.Name + " records.\");");
				sb.AppendLine(Resources.Tab4 + "throw;");
				sb.AppendLine(Resources.Tab3 + "}");
				sb.AppendLine(Resources.Tab3 + "return records;");
				sb.AppendLine(Resources.Tab2 + "}");

				sb.AppendLine();

				//Create record methods
				sb.AppendLine(Resources.Tab2 + "private " + recordName + " Create" + recordName + "(HierarchicalFilter hierarchyTree, long id)");
				sb.AppendLine(Resources.Tab2 + "{");
				sb.AppendLine(Resources.Tab3 + recordName +" rec = new " + recordName + "();");
				sb.AppendLine(Resources.Tab3 + "HierarchicalRecordData recordData;");
				sb.AppendLine(Resources.Tab3 + "if (!hierarchicalRecordData.TryGetValue(id, out recordData))");
				sb.AppendLine(Resources.Tab3 + "{");
				sb.AppendLine(Resources.Tab4 + "DMSLogger.Log(DMSLogger.LogLevel.DebugLog, \"[" + rootName + "]: Record { 0:X} does not exists in hierarchical record data dictionary.\", id);");
				sb.AppendLine(Resources.Tab4 + "return rec;");
				sb.AppendLine(Resources.Tab3 + "}");
				sb.AppendLine(Resources.Tab3 + "if (recordData.Name != null && !recordData.Name.Equals(string.Empty))");
				sb.AppendLine(Resources.Tab3 + "{");
				sb.AppendLine(Resources.Tab4 + "rec.Title = string.Format(\"{0}\", recordData.Name);");
				sb.AppendLine(Resources.Tab3 + "}");
				sb.AppendLine(Resources.Tab3 + "else");
				sb.AppendLine(Resources.Tab3 + "{");
				sb.AppendLine(Resources.Tab4 + "rec.Title = string.Empty;");
				sb.AppendLine(Resources.Tab3 + "}");
				sb.AppendLine(Resources.Tab3 + "rec.Lid = id;");
				sb.AppendLine(Resources.Tab3 + "rec.Level = (byte)hierarchyTreeFilter.GetNodeByLid(id).Level;");
				sb.AppendLine(Resources.Tab3 + rootName + "RecordBean data = recordData as " + rootName + "RecordBean;");
				sb.AppendLine(Resources.Tab3 + "if (data != null && (DMSType)ModelCodeHelper.ExtractTypeFromGlobalId(id) == DMSType." + dg.DMSType + ")");
				sb.AppendLine(Resources.Tab3 + "{");
				foreach(ColumnAttribute attr in dg.Columns)
				{
					sb.AppendLine(Resources.Tab4 + "rec." + attr.Name + " = data." + attr.Name + ";");
				}
				sb.AppendLine(Resources.Tab3 + "}");
				sb.AppendLine(Resources.Tab3 + "return rec;");
				sb.AppendLine(Resources.Tab2 + "}");

				sb.AppendLine();

				//Filling records methods
				sb.AppendLine(Resources.Tab2 + "private void Fill" + dg.Name + "Properties(List<long> gids)");
				sb.AppendLine(Resources.Tab2 + "{");
				sb.AppendLine(Resources.Tab3 + "long mdc = 0;");
				sb.AppendLine(Resources.Tab3 + "if (gids.Count <= 0) return;");
				sb.AppendLine(Resources.Tab3 + "var iteratorId = GdaQuery.GetDescendentValues(0,");
				sb.AppendLine(Resources.Tab4 + "new List<ModelCode> {");
				sb.AppendLine(GetAttributesModelCodes(dg));
				sb.AppendLine(Resources.Tab4 + "}, new List<Association>(), gids, new List<Association>(), ref mdc);");
				sb.AppendLine(Resources.Tab3 + "var count = GdaQuery.IteratorResourcesLeft(iteratorId);");
				sb.AppendLine(Resources.Tab3 + "while (count > 0)");
				sb.AppendLine(Resources.Tab3 + "{");
				sb.AppendLine(Resources.Tab4 + "List<ResourceDescription> rds = GdaQuery.IteratorNext(50000, iteratorId);");
				sb.AppendLine(Resources.Tab4 + "for (int i = 0; i < rds.Count; i++)");
				sb.AppendLine(Resources.Tab4 + "{");
				sb.AppendLine(Resources.Tab5 + rootName + "RecordBean data = (hierarchicalRecordData[rds[i].Id] as " + rootName + "RecordBean);");
				sb.AppendLine(Resources.Tab5 + "if (data == null)");
				sb.AppendLine(Resources.Tab5 + "{");
				sb.AppendLine(Resources.Tab6 + "DMSLogger.Log(DMSLogger.LogLevel.Error, \"[" + rootName + "]: Error occurred while collecting " + dg.Name + ". Record data is null!\");");
				sb.AppendLine(Resources.Tab6 + "throw new ArgumentNullException(\"gids\");");
				sb.AppendLine(Resources.Tab5 + "}");
				sb.AppendLine(FillRecordData(dg));
				sb.AppendLine(Resources.Tab4 + "}");
				sb.AppendLine(Resources.Tab4 + "count -= rds.Count;");
				sb.AppendLine(Resources.Tab3 + "}");
				sb.AppendLine(Resources.Tab3 + "GdaQuery.IteratorClose(iteratorId);");
				sb.AppendLine(Resources.Tab2 + "}");

				sb.AppendLine();
				sb.AppendLine(Resources.Tab2 + "#endregion " + recordName);
				sb.AppendLine();
			}

			return sb.ToString();
		}

		private string CreateReportResultsMethod()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine(Resources.Tab2 + "private JobResult CreateReportResults()");
			sb.AppendLine(Resources.Tab2 + "{");
			sb.AppendLine(Resources.Tab3 + "switch (reportType)");
			sb.AppendLine(Resources.Tab3 + "{");
			foreach(ModelType type in DataGrid.ModelRoot.Types)
			{
				if (!(type is Tab))
				{
					continue;
				}
				Tab tab = type as Tab;
				if (tab.TargetTabbed.Count > 0)
				{
					continue;
				}
				sb.AppendLine(Resources.Tab4 + "case " + DataGrid.ModelRoot.Name + "ReportType." + tab.Name + ":");
				sb.AppendLine(Resources.Tab5 + "{");
				if (tab.DataGrid != null)
				{
					sb.AppendLine(Resources.Tab6 + "List<" + tab.DataGrid.Name + "Record> records = Create" + tab.DataGrid.Name + "Records();");
					sb.AppendLine(Resources.Tab6 +  tab.DataGrid.Name + "Results results = new " + tab.DataGrid.Name + "Results { Records = records };");
					sb.AppendLine(Resources.Tab6 + "return results;");
				}
				else
				{
					sb.AppendLine(Resources.Tab6 + "return new " + DataGrid.ModelRoot.Name + "ReportResult(reportType);");
				}
				sb.AppendLine(Resources.Tab5 + "}");
			}
			sb.AppendLine(Resources.Tab4 + "default:");
			sb.AppendLine(Resources.Tab5 + "{");
			sb.AppendLine(Resources.Tab6 + "DMSLogger.Log(DMSLogger.LogLevel.Error, \"[" + DataGrid.ModelRoot.Name +"]: Error while creating results for " + DataGrid.ModelRoot.Name +" Report." + DataGrid.ModelRoot.Name + "ReportType {0} is unsupported.\", reportType);");
			sb.AppendLine(Resources.Tab6 + "return new JobError(string.Format(\"Error while creating results for " + DataGrid.ModelRoot.Name +" Report." + DataGrid.ModelRoot.Name +"ReportType {0} is unsupported.\", reportType));");
			sb.AppendLine(Resources.Tab5 + "}");
			sb.AppendLine(Resources.Tab3 + "}");
			sb.AppendLine(Resources.Tab2 + "}");

			return sb.ToString();
		}

		private string FillRecordData(DataGrid model)
		{
			StringBuilder sb = new StringBuilder();

			string data = "data.";

			foreach (ColumnAttribute attr in model.Columns)
			{
				sb.AppendLine(Resources.Tab5 + data + attr.Name + " = rds[i].GetProperty(ModelCode." + attr.ModelCode + ")." + TypesToModelCodeCastConverter.Convert(attr) + ";");
			}
			/*foreach (Association association in Association.GetLinksToTargets(model))
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
			}*/

			return sb.ToString();
		}

		private string GetAttributesModelCodes(DataGrid model)
		{
			StringBuilder sb = new StringBuilder();

			foreach (ColumnAttribute attr in model.Columns)
			{
				sb.AppendLine(Resources.Tab5 + "ModelCode." + attr.ModelCode + ",");
			}
			/*foreach (Association association in Association.GetLinksToTargets(model))
			{
				sb.AppendLine(Resources.Tab5 + "ModelCode." + association.ModelCode + ",");
			}*/

			return sb.ToString();
		}

		protected override string GetClassNamespace()
		{
			return "TelventDMS.Services.JobManagerService." + DataGrid.ModelRoot.Name + "Report";
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
			sb.AppendLine("using System.Runtime.Serialization;");
			sb.AppendLine("using TelventDMS.Common.DMS.Common;");
			sb.AppendLine("using TelventDMS.Common.Platform.Logger;");
			sb.AppendLine("using TelventDMS.Common.Platform.Security.Config;");
			sb.AppendLine("using TelventDMS.Common.Platform.Utils;");

			return sb.ToString();
		}

		protected override string IsDataContractString()
		{
			return "[DataContract]";
		}
	}
}
