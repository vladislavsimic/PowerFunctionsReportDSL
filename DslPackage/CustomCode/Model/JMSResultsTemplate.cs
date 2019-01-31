namespace SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode.Model
{
	public class JMSResultsTemplate : SCGTemplate
	{
		public JMSResultsTemplate(byte[] template, string folderPath, string extension, string classNameExtension = "") 
			: base(template, folderPath, extension, classNameExtension)
		{

		}

		public override string GetFileName(string className)
		{
			return className.Replace("Record", "") + this.ClassNameExtendsion;
		}
	}
}
