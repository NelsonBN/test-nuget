namespace TestProject.Utils.Tests;

public class ExampleUtilsTests
{
    [Fact]
    public void Request_GetAssemblyVersion_AssemblyVersion()
    {
        // Arrange && Act
        var act = ExampleUtils.GetCustomVersion();


        // Assert
        act.Should()
            .NotBeNullOrWhiteSpace();
    }
}
