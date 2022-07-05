namespace TestNuget.PleaseDontUse
{
    public static class ExampleUtils
    {
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
        /// Get custom version
        /// </summary>
        /// <returns>Assembly version</returns>
        public static string GetCustomVersion()
            => "1.4.3";

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
