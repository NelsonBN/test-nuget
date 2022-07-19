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
        public void Request_GetCustomFrameworkVersion_NotBeNullOrWhiteSpace()
        {
            // Arrange && Act
            var act = ExampleUtils.GetCustomFrameworkVersion("hello");


            // Assert
            _output.WriteLine($"{nameof(ExampleUtils.GetCustomFrameworkVersion)}: {act}");

            act.Should()
                .NotBeNullOrWhiteSpace();
        }

        [Fact]
        public void ThreeAndTwo_Sum_Five()
        {
            // Arrange && Act
            var act = ExampleUtils.Sum(3, 2);


            // Assert
            act.Should()
                .Be(5);
        }

        [Fact]
        public void ThreeAndTwoAndOne_Sum_Six()
        {
            // Arrange && Act
            var act = ExampleUtils.Sum(3, 2, 1);


            // Assert
            act.Should()
                .Be(6);
        }

        [Fact]
        public void ThreeAndTwo_Sub_One()
        {
            // Arrange && Act
            var act = ExampleUtils.Sub(3, 2);


            // Assert
            act.Should()
                .Be(1);
        }

        [Fact]
        public void ThreeAndTwoAndOne_Sub_Zero()
        {
            // Arrange && Act
            var act = ExampleUtils.Sub(3, 2, 1);


            // Assert
            act.Should()
                .Be(0);
        }

        [Fact]
        public void NegativeOnde_IsNegative_True()
        {
            // Arrange && Act
            var act = ExampleUtils.IsNegative(-1);


            // Assert
            act.Should()
                .BeTrue();
        }

        [Fact]
        public void Three_IsNegative_False()
        {
            // Arrange && Act
            var act = ExampleUtils.IsNegative(3);


            // Assert
            act.Should()
                .BeFalse();
        }

        [Fact]
        public void TwoAndTwo_Mult_Four()
        {
            // Arrange && Act
            var act = ExampleUtils.Mult(2, 2);


            // Assert
            act.Should()
                .Be(4);
        }

        [Fact]
        public void Two_Print_Two()
        {
            // Arrange && Act
            var act = ExampleUtils.Print(2);


            // Assert
            act.Should()
                .Be(2);
        }

        [Fact]
        public void Number_Print_SameNumber()
        {
            // Arrange
            var number = 1;


            // Act
            var act = ExampleUtils.Print(number);


            // Assert
            act.Should()
                .Be(number);
        }

        [Fact]
        public void Number_PrintToMD5_NoNull()
        {
            // Arrange
            var number = 1;


            // Act
            var act = ExampleUtils.PrintToMD5(number);


            // Assert
            act.Should()
                .NotBeNull();
        }

        [Fact]
        public void Call_PrintMyTest_Text()
        {
            // Arrange && Act
            var act = ExampleUtils.PrintMyTest();


            // Assert
            act.Should()
                .NotBeNull();
        }
    }
}
