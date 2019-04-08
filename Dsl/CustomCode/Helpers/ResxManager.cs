using System.Collections.Generic;
using System.Resources;

namespace SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode.Helpers
{
	public class ResxManager
    {
        private static ResxManager manager;

        private static HashSet<string> resources = new HashSet<string>();

        public ResxManager()
        {
        }

		
		public static ResxManager Manager
        {
			get
            {
                if (manager == null)
                {
                    manager = new ResxManager();
                }
                return manager;
            }
        }

        public void AddResource(string value)
        {
            resources.Add(value);
        }

        public void GenerateResxFile(string projectPath, string rootName)
        {
			string resxPath = projectPath + "\\Properties";
			if (!System.IO.Directory.Exists(resxPath))
			{
				System.IO.Directory.CreateDirectory(resxPath);
			}

            string fullPath = resxPath + "\\" + rootName + "ResourcesGenerated.resx";
            using (ResXResourceWriter resx = new ResXResourceWriter(fullPath))
            {
                foreach (string str in resources)
                {
					string newString = str.Trim().Replace(" ", "_");
                    resx.AddResource("EMSLoadFlow_" + newString, str);
                }
            }
        }
    }
}
