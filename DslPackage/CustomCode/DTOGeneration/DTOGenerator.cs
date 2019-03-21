using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode.DTOGeneration
{
	public class DTOGenerator
	{
		private DTOGeneratorParam dtoGeneratorParam;

		private AssemblyResolver assemblyResolver = new AssemblyResolver();

		private List<Type> serviceContracts = new List<Type>();

		public DTOGenerator(DTOGeneratorParam param)
		{
			this.dtoGeneratorParam = param;
		}

		public static Type[] FindServiceContracts(Assembly assembly)
		{
			Dictionary<string, Type> serviceContracts = new Dictionary<string, Type>();

			foreach (Type type in assembly.GetTypes())
			{
				if (type.IsInterface && type.IsDefined(typeof(ServiceContractAttribute), false))
				{
					serviceContracts.Add(type.FullName, type);
				}
			}

			foreach (Type serviceContract in serviceContracts.Values.ToList())
			{
				Type callbackContract = GetServiceContractCallbackContract(serviceContract);
				if (callbackContract != null)
				{
					serviceContracts.Remove(callbackContract.FullName);
				}
			}

			return serviceContracts.Values.ToArray();
		}

		public static Type GetServiceContractCallbackContract(Type serviceContract)
		{
			return ((ServiceContractAttribute)serviceContract.GetCustomAttributes(typeof(ServiceContractAttribute), false)[0]).CallbackContract;
		}

		private void GenerateCode()
		{
			try
			{
				if (File.Exists(dtoGeneratorParam.ServiceContractAssembly))
				{
					assemblyResolver.SetSingleAdditionalDirectory(System.IO.Path.GetDirectoryName(dtoGeneratorParam.ServiceContractAssembly));
				}
				Assembly assembly = Assembly.LoadFrom(dtoGeneratorParam.ServiceContractAssembly);
				serviceContracts = new List<Type>(FindServiceContracts(assembly));
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message, "Error occured");
				return;
			}

			List<Type> selectedTypes = new List<Type>();
			for (int i = 0; i < serviceContracts.Count; i++)
			{
				selectedTypes.Add(serviceContracts[i]);
			}

			if (!File.Exists(this.dtoGeneratorParam.ServiceContractAssembly))
			{
				MessageBox.Show("Proxy service contract assembly does not exist.", "Error");
				return;
			}

			if (!Directory.Exists(this.dtoGeneratorParam.OutputFolder))
			{
				MessageBox.Show("Data contracts output folder does not exist.", "Error");
				return;
			}

			try
			{

				System.Environment.CurrentDirectory = System.IO.Path.GetDirectoryName(dtoGeneratorParam.ServiceContractAssembly);

				/*DTOGenerator.GenerateServiceContracts(selectedTypes.ToArray(), dtoGeneratorParam.OutputFolder,
					dtoGeneratorParam.ContractNamespace, dtoGeneratorParam.ContractNamespace, string.Empty);*/

			}
			catch (Exception ex)
			{
				MessageBox.Show("Error occurred: " + ex.Message);
			}
		}
	}
}
