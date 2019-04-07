using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;

namespace SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode.Helpers
{
    public sealed class ResxManager
    {
        private static ResxManager manager;

        private HashSet<string> resources;

        public ResxManager()
        {
            this.resources = new HashSet<string>();
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
            this.resources.Add(value);
        }

        public void GenerateResxFile(string filePath, string fileName)
        {
            if (System.IO.Directory.Exists(filePath))
            {
                string fullPath = filePath + "\\" + fileName + ".resx";
                using (ResXResourceWriter resx = new ResXResourceWriter(fullPath))
                {
                    foreach (string str in resources)
                    {
                        resx.AddResource("EMSLoadFlow_" + str, str);
                    }
                }
            }
        }
    }
}
