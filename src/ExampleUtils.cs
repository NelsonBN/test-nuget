namespace TestNuget.PleaseDontUse
{
    public static class ExampleUtils
    {
        /// <summary>
        /// Get custom version
        /// </summary>
        /// <returns>Assembly version</returns>
        public static string GetCustomVersion()
            => "1.2.2";

        /// <summary>
        /// Get custom framework version
        /// </summary>
        /// <returns></returns>
        public static string GetCustomFrameworkVersion()
#if NET6_0_OR_GREATER
            => ".NET 6.0 or greater";
#elif NET5_0
        => ".NET 5.0";
#else
        => "Undefined";
#endif
    }
}
