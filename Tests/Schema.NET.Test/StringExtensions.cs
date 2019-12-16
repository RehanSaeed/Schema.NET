#if NET472
namespace Schema.NET.Test
{
    using System;

#pragma warning disable IDE0060 // Remove unused parameter
#pragma warning disable CA1801 // Remove unused parameter

    public static class StringExtensions
    {
        public static string Replace(this string target, string oldValue, string newValue, StringComparison stringComparison) => target.Replace(oldValue, newValue);

        public static int GetHashCode(this string target, StringComparison stringComparison) => target.GetHashCode();
    }

#pragma warning restore CA1801 // Remove unused parameter
#pragma warning restore IDE0060 // Remove unused parameter
}
#endif
