using System;
using System.Collections.Generic;
using System.Resources;

namespace SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode.Helpers
{
	public class ResxManager
    {
        private static ResxManager manager;

        private static Dictionary<string, string> resources = new Dictionary<string, string>();

		private static Dictionary<string, string> specificResource = new Dictionary<string, string>();

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

        public string AddResource(string headerValue)
        {
			string resxKey = headerValue.Trim().Replace(" ", "_");

			string str;
			if(!resources.TryGetValue(resxKey, out str))
			{
				resources.Add(resxKey, headerValue);
			}
			return resxKey;
        }

		public string AddResourceWithMeasUnit(string headerValue)
		{
			string resxKey = "MEAS_UNIT_" + headerValue.Trim().Replace(" ", "_");

			headerValue = headerValue + " [{0}]";

			string str;
			if (!resources.TryGetValue(resxKey, out str))
			{
				resources.Add(resxKey, headerValue);
			}
			return resxKey;
		}

		public void GenerateResxFile(string projectPath, string rootName)
        {

			string resxPath = projectPath + "\\Properties";
			if (!System.IO.Directory.Exists(resxPath))
			{
				System.IO.Directory.CreateDirectory(resxPath);
			}

            string fullPath = resxPath + "\\" + rootName + "ResourcesGenerated.resx";

			ClearContent(fullPath);

            using (ResXResourceWriter resx = new ResXResourceWriter(fullPath))
            {
                foreach (KeyValuePair<string, string> keyPair in resources)
                {
                    resx.AddResource("EMSLoadFlow_" + keyPair.Key, keyPair.Value);
                }
            }
        }

		private void ClearContent(string path)
		{
			using (ResXResourceWriter resx = new ResXResourceWriter(path))
			{
			}
		}

		public void ClearResources()
		{
			resources.Clear();
		}
	}
}
