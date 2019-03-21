using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SchneiderElectricDMS.PowerFunctionsReportDSL.CustomCode.DTOGeneration
{
	public class AssemblyResolver
	{
		#region Fields        
		private HashSet<string> additionalDirectories;
		#endregion

		#region Properties        
		public ICollection<string> AdditionalDirectories { get { return additionalDirectories; } }
		#endregion

		public AssemblyResolver()
		{
			additionalDirectories = new HashSet<String>();
		}

		#region Public methods

		/// <summary>
		///  Type.GetType() method gets types from assemblies loaded in load context (using Assembly.Load() method), 
		///  but no in load-from (using Assembly.LoadFrom() method) and no-context (using Assembly.LoadFile() method) contexts. 
		///  This handler is called when assembly is not found in load context and it resolves assemblies loaded in any context.
		///  If requested assembly is not loaded, the handler will attempt to load it from specified additional directories.
		/// </summary>
		public Assembly AllAssembliesResolveHandler(object sender, ResolveEventArgs args)
		{
			//Console.WriteLine(args.Name);
			string assemblyName = args.Name.Contains(',') ? args.Name.Substring(0, args.Name.IndexOf(',')) : args.Name;
			Assembly assembly = ResolveFromLoadedAssemblies(assemblyName);
			if (assembly == null)
			{
				assembly = ResolveFromAdditionalDirectories(assemblyName);
			}

			return assembly;
		}

		public void SetSingleAdditionalDirectory(string additionalDirectory)
		{
			additionalDirectories.Clear();
			additionalDirectories.Add(additionalDirectory);
		}

		#endregion

		#region Private methods

		/// <summary>
		///  Gets assembly loaded in any context.
		/// </summary>
		private Assembly ResolveFromLoadedAssemblies(String assemblyName)
		{
			if (string.IsNullOrEmpty(assemblyName))
				return null;

			return AppDomain.CurrentDomain.GetAssemblies().Where(a => a.GetName().Name == assemblyName).FirstOrDefault();
		}

		/// <summary>
		///  Loads assembly (with '.dll' or '.exe' extensions) from specified directories. 
		/// </summary>
		private Assembly ResolveFromAdditionalDirectories(String assemblyName)
		{
			if (string.IsNullOrEmpty(assemblyName))
				return null;

			foreach (string additionalDirectory in additionalDirectories)
			{
				if (string.IsNullOrEmpty(additionalDirectory) || !Directory.Exists(additionalDirectory))
				{
					continue;
				}

				string dllFullPath = string.Format("{0}.dll", Path.Combine(additionalDirectory, assemblyName));
				if (File.Exists(dllFullPath))
					return Assembly.LoadFrom(dllFullPath);

				string exeFullPath = string.Format("{0}.exe", Path.Combine(additionalDirectory, assemblyName));
				if (File.Exists(exeFullPath))
					return Assembly.LoadFrom(exeFullPath);
			}

			return null;
		}

		#endregion
	}
}
