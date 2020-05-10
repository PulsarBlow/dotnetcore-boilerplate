namespace PulsarBlow.DotNetCoreBoilerplate.Tests.Unit
{
    using System;
    using System.Reflection;
    using System.Reflection.Emit;
    using Xunit;
    using AssemblyExtensions = AssemblyExtensions;

    public class AssemblyExtensionsTest
    {
        [Fact]
        public void GetInformationalVersion_Returns_UnknownVersion()
        {
            Assembly asm = GetTestAssembly();
            Assert.Equal(AssemblyExtensions.UnknownVersion,asm.GetInformationalVersion());
        }

        [Theory]
        [InlineData("1.0.0")]
        [InlineData("1.0.0-alpha")]
        public void GetInformationalVersion_Returns_InformationalVersion(string version)
        {
            Assembly asm = GetTestAssembly(version);
            Assert.Equal(version, asm.GetInformationalVersion());
        }

        private Assembly GetTestAssembly(string informationalVersion = null)
        {
            AssemblyName aName = new AssemblyName("DotNetCoreBoilerplateEmitTest");
            var builder = AssemblyBuilder.DefineDynamicAssembly(
                    aName,
                    AssemblyBuilderAccess.Run);

            if (string.IsNullOrEmpty(informationalVersion))
            {
                return builder;
            }

            builder.SetCustomAttribute(CreateVersionAttributeBuilder(informationalVersion));
            return builder;
        }

        private CustomAttributeBuilder CreateVersionAttributeBuilder(string version)
        {
            var attributeType = typeof(AssemblyInformationalVersionAttribute);
            ConstructorInfo constructorInfo = attributeType.GetConstructor(new Type[1] { typeof(string) });
            CustomAttributeBuilder attributeBuilder =
                new CustomAttributeBuilder(constructorInfo, new object[] { version });
            return attributeBuilder;
        }
    }
}
