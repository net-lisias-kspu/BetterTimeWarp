using System.Reflection;
using System.Runtime.CompilerServices;

// Information about this assembly is defined by the following attributes.
// Change them to the values specific to your project.
[assembly: AssemblyTitle ("BetterTimeWarp")]
[assembly: AssemblyDescription ("Better Time Warp adds the ability to customize your time warp.")]
[assembly: AssemblyConfiguration ("")]
[assembly: AssemblyCompany (BetterTimeWarp.LegalMamboJambo.Company)]
[assembly: AssemblyProduct (BetterTimeWarp.LegalMamboJambo.Product)]
[assembly: AssemblyCopyright (BetterTimeWarp.LegalMamboJambo.Copyright)]
[assembly: AssemblyTrademark (BetterTimeWarp.LegalMamboJambo.Trademark)]
[assembly: AssemblyCulture ("")]

// The assembly version has the format "{Major}.{Minor}.{Build}.{Revision}".
// The form "{Major}.{Minor}.*" will automatically update the build and revision,
// and "{Major}.{Minor}.{Build}.*" will update just the revision.
//[assembly: AssemblyVersion ("2.1.0.0")]
//[assembly: KSPAssembly("BetterTimeWarp", 2, 1)]
// The following attributes are used to specify the signing key for the assembly,
// if desired. See the Mono documentation for more information about signing.
//[assembly: AssemblyDelaySign(false)]
//[assembly: AssemblyKeyFile("")]

[assembly: AssemblyVersion(BetterTimeWarp.Version.Number)]
[assembly: AssemblyFileVersion(BetterTimeWarp.Version.Number)]
[assembly: KSPAssembly("BetterTimeWarp", BetterTimeWarp.Version.major, BetterTimeWarp.Version.minor)]

[assembly: KSPAssemblyDependency("KSPe", 2, 5)]
[assembly: KSPAssemblyDependency("KSPe.UI", 2, 5)]
