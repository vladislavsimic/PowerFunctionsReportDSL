using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode.DTOGeneration
{
	public class DTOGeneratorParam
	{
		private string serviceContractAssembly = string.Empty;
		private string outputFolder = string.Empty;
		private string contractNamespace = string.Empty;
		private List<string> incomingContracts = new List<string>();
		private List<string> outgoingContracts = new List<string>();

		public DTOGeneratorParam()
		{

		}

		public DTOGeneratorParam(string serviceContractAssembly, string contractNamespace, string outputFolder, List<string> incomingContracts, List<string> outgoingContracts)
		{
			this.serviceContractAssembly = serviceContractAssembly;
			this.contractNamespace = contractNamespace;
			this.outputFolder = outputFolder;
			this.incomingContracts = incomingContracts;
			this.outgoingContracts = outgoingContracts;
		}

		public string ServiceContractAssembly
		{
			get { return serviceContractAssembly; }
			set { serviceContractAssembly = value; }
		}

		public string OutputFolder
		{
			get { return outputFolder; }
			set { outputFolder = value; }
		}

		public string ContractNamespace
		{
			get { return contractNamespace; }
			set { contractNamespace = value; }
		}
		
		public List<string> IncomingContracts
		{
			get { return incomingContracts; }
			set { incomingContracts = value; }
		}

		public List<string> OutgoingContracts
		{
			get { return outgoingContracts; }
			set { outgoingContracts = value; }
		}
	}
}
