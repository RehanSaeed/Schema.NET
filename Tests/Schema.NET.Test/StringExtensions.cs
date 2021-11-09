#if NET472 || NET461
namespace Schema.NET.Test;

using System;

#pragma warning disable IDE0060 // Remove unused parameter
#pragma warning disable CA1801 // Remove unused parameter

public static class StringExtensions
{
    public static int GetHashCode(this string target, StringComparison stringComparison) => target.GetHashCode();
}
#endif
