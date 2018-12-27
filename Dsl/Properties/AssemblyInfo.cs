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
[assembly: AssemblyCompany(@"Company")]
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
[assembly: InternalsVisibleTo(@"Company.PowerFunctionsReportDSL.DslPackage, PublicKey=002400000480000094000000060200000024000052534131000400000100010087314733DD03E69361E1B94B6B3DB7F97F5EE0003D8674BB8BED77A88D59BA8343403F8D6A8A3F7678C4AF7362E06DB66B7E497FC87728532CD89DEAD9C933863CBA3B69F1579A7BE3F8F63FA9C1D7F8231C1ABB4ACAAAAA76B41BA6A97BA8C7A5CEFCE4F60FA71D46430F1D45BE10748FF5B7E5CE19708443CCAAB389990EC6")]