using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchneiderElectricDMS.DMSFunctionsDSL.DslPackage.CustomCode.CodeGeneration.Model
{
	public class SCGTemplate
	{
		private byte[] template;
		private string folderPath;
		private string extension;
		private string classNameExtension;

		public SCGTemplate(byte[] template, string folderPath, string extension, string classNameExtension = "") 
		{
			this.template = template;
			this.folderPath = folderPath;
			this.extension = extension;
			this.classNameExtension = classNameExtension;
		}

		public byte[] Template 
		{
			get 
			{ 
				return template; 
			}
		}

		public string FolderPath 
		{
			get 
			{
				return folderPath;
			}
		}

		public string Extension 
		{
			get 
			{
				return extension;
			}
		}

		public string ClassNameExtendsion 
		{
			get 
			{
				return classNameExtension;
			}
		}

		public virtual string GetFileName(string className) 
		{
			return className + classNameExtension;
		}
	}
}
