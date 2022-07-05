namespace TestProject.Utils
{
    public static class ExampleUtils
    {
        /// <summary>
        /// Get assembly version
        /// </summary>
        /// <returns>Assembly version</returns>
        public static string GetCustomVersion()
            => "1.1.2";

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
