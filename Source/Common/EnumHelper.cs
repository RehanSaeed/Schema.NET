namespace Schema.NET
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Helper for parsing strings into Enum values.
    /// </summary>
    internal static class EnumHelper
    {
        /// <summary>
        /// Converts the string representation of the name or numeric value of one or more
        /// enumerated constants to an equivalent enumerated object.
        /// </summary>
        /// <param name="enumType">The enum type to use for parsing.</param>
        /// <param name="value">The string representation of the name or numeric value of one or more enumerated constants.</param>
        /// <param name="result">When this method returns true, an object containing an enumeration constant representing the parsed value.</param>
        /// <returns><see langword="true"/> if the conversion succeeded; <see langword="false"/> otherwise.</returns>
        public static bool TryParse(
            Type enumType,
#if NETCOREAPP3_1_OR_GREATER
            [NotNullWhen(true)]
#endif
            string? value,
            out object? result)
        {
#if NETSTANDARD2_0 || NET472
            try
            {
                result = Enum.Parse(enumType, value);
                return true;
            }
#pragma warning disable CA1031 // Do not catch general exception types
            catch
#pragma warning restore CA1031 // Do not catch general exception types
            {
                result = null;
                return false;
            }
#else
#pragma warning disable IDE0022 // Use expression body for methods
            return Enum.TryParse(enumType, value, out result);
#pragma warning restore IDE0022 // Use expression body for methods
#endif
        }
    }
}
