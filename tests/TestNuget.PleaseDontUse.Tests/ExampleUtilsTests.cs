using FluentAssertions;
using TestNuget.PleaseDontUse;
using Xunit;
using Xunit.Abstractions;

namespace TestProject.Utils.Tests
{
    public class ExampleUtilsTests
    {
        private readonly ITestOutputHelper _output;

        public ExampleUtilsTests(ITestOutputHelper output)
            => _output = output;

        [Fact]
        public void Request_GetAssemblyVersion_String()
        {
            // Arrange && Act
            var act = ExampleUtils.GetCustomVersion();


            // Assert
            _output.WriteLine($"{nameof(ExampleUtils.GetCustomVersion)}: {act}");

            act.Should()
                .NotBeNullOrWhiteSpace();
        }


        [Fact]
        public void Request_GetCustomFrameworkVersion_String()
        {
            // Arrange && Act
            var act = ExampleUtils.GetCustomFrameworkVersion();


            // Assert
            _output.WriteLine($"{nameof(ExampleUtils.GetCustomFrameworkVersion)}: {act}");

            act.Should()
                .NotBeNullOrWhiteSpace();
        }
    }
}
