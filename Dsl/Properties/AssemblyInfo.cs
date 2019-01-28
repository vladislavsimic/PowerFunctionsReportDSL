#region Using directives

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.ConstrainedExecution;

#endregion

//
// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
//
[assembly: AssemblyTitle(@"")]
[assembly: AssemblyDescription(@"")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany(@"SchneiderElectricDMS")]
[assembly: AssemblyProduct(@"PowerFunctionsReportDSL")]
[assembly: AssemblyCopyright("")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: System.Resources.NeutralResourcesLanguage("en")]

//
// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Revision and Build Numbers 
// by using the '*' as shown below:

[assembly: AssemblyVersion(@"1.0.0.0")]
[assembly: ComVisible(false)]
[assembly: CLSCompliant(true)]
[assembly: ReliabilityContract(Consistency.MayCorruptProcess, Cer.None)]

//
// Make the Dsl project internally visible to the DslPackage assembly
//
[assembly: InternalsVisibleTo(@"SchneiderElectricDMS.PowerFunctionsReportDSL.DslPackage, PublicKey=002400000480000094000000060200000024000052534131000400000100010023ECBEADED50635DDA56550E9809407778A19F9102ED74AB02D97E10215075242568CB61D81F3E03A064499D0470DE6DCC5C177A218CB6FE25FC89C11F3CE763066EB49612B2A40D6BD29256D6B3013215A1437BA140C03CEB6AEEB26947BF66C049ADAEED405FB784A5991A2CD9C49DD47C43330C4A849AB5971763FECA16A0")]