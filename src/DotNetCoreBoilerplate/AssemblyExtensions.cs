namespace PulsarBlow.DotNetCoreBoilerplate
{
    using System.Reflection;

    public static class AssemblyExtensions
    {
        // internal for testing purpose
        internal const string UnknownVersion = "0.0.0";

        public static string GetInformationalVersion(this Assembly assembly)
        {
            return assembly
                       .GetCustomAttribute<AssemblyInformationalVersionAttribute>()?
                       .InformationalVersion
                   ?? UnknownVersion;
        }
    }
}
