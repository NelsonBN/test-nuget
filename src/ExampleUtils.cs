using System;

namespace TestNuget.PleaseDontUse
{
    public static class ExampleUtils
    {
        public static int Print(int num)
        {
            Console.WriteLine(num);
            return num;
        }
        public static int Sum(int num1, int num2, int num3)
            => num1 + num2 + num3;

        public static int Sum(int num1, int num2)
            => num1 + num2;

        public static int Mult(int num1, int num2)
            => num1 * num2;

        public static int Sub(int num1, int num2, int num3)
            => num1 - num2 - num3;

        public static int Sub(int num1, int num2)
            => num1 - num2;

        /// <summary>
        /// Chech if the number is negative
        /// </summary>
        public static bool IsNegative(int number)
        {
            if(number < 0)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Get custom framework version
        /// </summary>
        /// <returns>Custom framework version</returns>
        public static string GetCustomFrameworkVersion()
#if NET6_0_OR_GREATER
            => ".NET 6.0 or greater";
#elif NET5_0_OR_GREATER
        => ".NET 5.0";
#else
        => "Undefined";
#endif
    }
}
