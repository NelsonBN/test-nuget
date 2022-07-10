using System;
using TestNuget.PleaseDontUse;

namespace TestProject.Utils.Samples
{
    public static class Program
    {
        public static void Main(string[] _)
        {
            Console.WriteLine();
            Console.WriteLine($">>> {nameof(ExampleUtils.GetCustomFrameworkVersion)}: {ExampleUtils.GetCustomFrameworkVersion()}");
        }

    }
}
