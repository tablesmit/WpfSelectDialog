using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;

#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif

[assembly: AssemblyTrademark("Awesome Incremented")]
[assembly: AssemblyProduct("WPF Select Dialogs")]

[assembly: AssemblyDescription(@"© Awesome Incremented")]
[assembly: AssemblyCompany("Awesome Incremented")]
[assembly: AssemblyCopyright("Copyright © Awesome Incremented")]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]
[assembly: NeutralResourcesLanguage("en", UltimateResourceFallbackLocation.MainAssembly)]
