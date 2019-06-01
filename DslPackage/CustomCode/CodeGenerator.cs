using Microsoft.VisualStudio.TextTemplating.VSHost;
using SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode.DTOGeneration;
using SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode.Helpers;
using SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode
{
	[ProvideCodeGenerator(typeof(CodeGenerator), "UIGenerator", "Custom tool that generates code for UI and JMS solutions.", true, ProjectSystem = ProvideCodeGeneratorAttribute.CSharpProjectGuid, RegisterCodeBase = false)]
	public class CodeGenerator : TemplatedCodeGenerator
	{
		protected override byte[] GenerateCode(string inputFileName, string inputFileContent)
		{
			FileInfo fi = new FileInfo(inputFileName);
			string fileName = fi.Name.Replace(".ui", "");

			//JMS code generation
			StringBuilder sb = new StringBuilder();
			string folderRelativePath = "..\\..\\..\\..\\Services\\JobManagerService\\" + fileName + "Report";
			sb.AppendLine("JMS ::::\n\n");

			SCGTemplate JMSModelTemplate = new SCGTemplate(CodeGenerationResource.JMSModelTemplate, folderRelativePath, ".cs", "Record");
			string genCode = GenerateCode(JMSModelTemplate, inputFileName, inputFileContent);
			sb.AppendLine(genCode);

			SCGTemplate JMSModelResultsTemplate = new SCGTemplate(CodeGenerationResource.JMSModelResultsTemplate, folderRelativePath, ".cs", "Results");
			genCode = GenerateCode(JMSModelResultsTemplate, inputFileName, inputFileContent);
			sb.AppendLine(genCode);

			SCGTemplate JMSJobTemplate = new SCGTemplate(CodeGenerationResource.JMSJobTemplate, folderRelativePath, ".cs", "ReportJob");
			genCode = GenerateCode(JMSJobTemplate, inputFileName, inputFileContent);
			sb.AppendLine(genCode);

			SCGTemplate JMSBeanTemplate = new SCGTemplate(CodeGenerationResource.JMSBeanTemplate, folderRelativePath, ".cs", "RecordBean");
			genCode = GenerateCode(JMSBeanTemplate, inputFileName, inputFileContent);
			sb.AppendLine(genCode);

			SCGTemplate JMSJobparamTemplate = new SCGTemplate(CodeGenerationResource.JMSJobParam, folderRelativePath, ".cs", "ReportJobParam");
			genCode = GenerateCode(JMSJobparamTemplate, inputFileName, inputFileContent);
			sb.AppendLine(genCode);

			SCGTemplate JMSReportResultTemplate = new SCGTemplate(CodeGenerationResource.JMSReportResult, folderRelativePath, ".cs", "ReportResult");
			genCode = GenerateCode(JMSReportResultTemplate, inputFileName, inputFileContent);
			sb.AppendLine(genCode);

			SCGTemplate JMSReportTypeTemplate = new SCGTemplate(CodeGenerationResource.JMSReportTypeTemplate, folderRelativePath, ".cs", "ReportType");
			genCode = GenerateCode(JMSReportTypeTemplate, inputFileName, inputFileContent);
			sb.AppendLine(genCode);

			/*SCGTemplate JMSEnumTemplate = new SCGTemplate(CodeGenerationResource.JMSEnumTemplate, folderRelativePath, ".cs");
			genCode = GenerateCode(JMSEnumTemplate, inputFileName, inputFileContent);
			sb.AppendLine(genCode);*/

			folderRelativePath = "\\";
			sb.AppendLine("UI ::::\n\n");

			SCGTemplate UILocalizedStringsTemplate = new SCGTemplate(CodeGenerationResource.UILocalizedStringsTemplate, folderRelativePath, ".cs", "");
			genCode = GenerateCode(UILocalizedStringsTemplate, inputFileName, inputFileContent);
			sb.AppendLine(genCode);

			SCGTemplate UIModuleCommandsTemplate = new SCGTemplate(CodeGenerationResource.UIModuleCommandsTemplate, folderRelativePath, ".cs", "ModuleCommands");
			genCode = GenerateCode(UIModuleCommandsTemplate, inputFileName, inputFileContent);
			sb.AppendLine(genCode);

			folderRelativePath = "\\Models";
			sb.AppendLine("UI Models ::::\n\n");

			SCGTemplate UIReportDataProviderTemplate = new SCGTemplate(CodeGenerationResource.UIReportDataProvider, folderRelativePath, ".cs", "ReportDataProvider");
			genCode = GenerateCode(UIReportDataProviderTemplate, inputFileName, inputFileContent);
			sb.AppendLine(genCode);

			folderRelativePath = "\\ViewModels";
			sb.AppendLine("UI View Model ::::\n\n");

			SCGTemplate UIViewModelTemplate = new SCGTemplate(CodeGenerationResource.UIViewModelTemplate, folderRelativePath, ".cs", "ViewModel");
			genCode = GenerateCode(UIViewModelTemplate, inputFileName, inputFileContent);
			sb.AppendLine(genCode);

			SCGTemplate UIReportViewModelTemplate = new SCGTemplate(CodeGenerationResource.UIReportViewModelTemplate, folderRelativePath, ".cs", "ReportViewModel");
			genCode = GenerateCode(UIReportViewModelTemplate, inputFileName, inputFileContent);
			sb.AppendLine(genCode);

			folderRelativePath = "\\View";
			sb.AppendLine("UI View ::::\n\n");

			SCGTemplate UIViewTemplate = new SCGTemplate(CodeGenerationResource.UIViewTemplate, folderRelativePath, ".xaml", "ReportView");
			genCode = GenerateCode(UIViewTemplate, inputFileName, inputFileContent);
			sb.AppendLine(genCode);

			SCGTemplate UIViewCsTemplate = new SCGTemplate(CodeGenerationResource.UIViewCsTemplate, folderRelativePath, ".xaml.cs", "ReportView");
			genCode = GenerateCode(UIViewCsTemplate, inputFileName, inputFileContent);
			sb.AppendLine(genCode);

			return Encoding.ASCII.GetBytes(sb.ToString());
		}

		private string GenerateCode(SCGTemplate template, string inputFileName, string inputFileContent)
		{
			StringBuilder sb = new StringBuilder();

			string path = Path.GetFullPath(Path.GetDirectoryName(this.InputFilePath) + template.FolderPath);
			CreateFolder(path);

			// Replace the supplied file contents with the template we want to run 
			inputFileContent = ASCIIEncoding.UTF8.GetString(template.Template);
			// Substitute the name of the current model file into the template. 
			FileInfo fi = new FileInfo(inputFileName);
			inputFileContent = inputFileContent.Replace("Sample.ui", fi.Name);
			inputFileContent = inputFileContent.Replace("namespace PowerFunctionsReportDSL", "namespace " + FileNamespace);

			// Pass parameter to new template:
			string delimiterGuid = Guid.NewGuid().ToString();
			string delimiter = "::::" + delimiterGuid + ":::";
			CallContext.LogicalSetData("delimiter", delimiter + "{0}:::");
			CallContext.LogicalSetData("inputFilePath", Path.GetFullPath(Path.GetDirectoryName(this.InputFilePath)));

			// Now just delegate the rest of the work to the base class 
			byte[] data;
			data = base.GenerateCode(inputFileName, inputFileContent);
			byte[] ascii = new byte[data.Length - 3];
			Array.Copy(data, 3, ascii, 0, data.Length - 3);


			string joinedFiles = Encoding.ASCII.GetString(ascii);
			string[] separateFiles = joinedFiles.Split(new string[] { delimiter }, StringSplitOptions.None);

			string filePath;
			foreach (string nameAndFile in separateFiles)
			{
				if (string.IsNullOrWhiteSpace(nameAndFile)) continue;
				string[] parts = nameAndFile.Split(new string[] { ":::" }, 2, StringSplitOptions.None);
				if (parts.Length < 2 || string.IsNullOrWhiteSpace(parts[1])) continue;
				filePath = path + "\\" + template.GetFileName(parts[0]) + template.Extension;
				sb.Append("Generate: [").Append(filePath + "] ").AppendLine(" [" + parts[0] + "]");
				// Generate a file from this item:
				File.WriteAllText(filePath, parts[1]);
			}


			return sb.ToString();
		}

		private void CreateFolder(string path)
		{
			bool exists = System.IO.Directory.Exists(path);
			if (!exists)
				System.IO.Directory.CreateDirectory(path);
		}
	}
}
