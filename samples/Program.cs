using System;
using TestNuget.PleaseDontUse;

namespace TestProject.Utils.Samples
{
    public static class Program
    {
        public static void Main(string[] _)
        {
            Console.WriteLine($">>> {nameof(ExampleUtils.GetCustomVersion)}: {ExampleUtils.GetCustomVersion()}");
            Console.WriteLine($">>> {nameof(ExampleUtils.GetCustomFrameworkVersion)}: {ExampleUtils.GetCustomFrameworkVersion()}");
        }

    }
}
