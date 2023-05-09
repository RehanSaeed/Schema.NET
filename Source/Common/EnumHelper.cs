namespace Schema.NET;

using System;
using System.Diagnostics;
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
#if NET6_0_OR_GREATER
#pragma warning disable IDE0022 // Use expression body for methods
        return Enum.TryParse(enumType, value, out result);
#pragma warning restore IDE0022 // Use expression body for methods
#else
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
#endif
    }

    /// <summary>
    /// Converts the Schema URI representation of the enum type to an equivalent enumerated object.
    /// </summary>
    /// <param name="enumType">The enum type to use for parsing.</param>
    /// <param name="value">The string representation of the name or numeric value of one or more enumerated constants.</param>
    /// <param name="result">When this method returns true, an object containing an enumeration constant representing the parsed value.</param>
    /// <returns><see langword="true"/> if the conversion succeeded; <see langword="false"/> otherwise.</returns>
    public static bool TryParseEnumFromSchemaUri(
        Type enumType,
#if NETCOREAPP3_1_OR_GREATER
        [NotNullWhen(true)]
#endif
        string? value,
        out object? result)
    {
        string? enumString;
        if (value is not null && value.StartsWith(Constants.HttpSchemaOrgUrl, StringComparison.OrdinalIgnoreCase))
        {
#if NETCOREAPP3_0_OR_GREATER
            enumString = value[(Constants.HttpSchemaOrgUrl.Length + 1)..];
#else
            enumString = value.Substring(Constants.HttpSchemaOrgUrl.Length + 1);
#endif
        }
        else if (value is not null && value.StartsWith(Constants.HttpsSchemaOrgUrl, StringComparison.OrdinalIgnoreCase))
        {
#if NETCOREAPP3_0_OR_GREATER
            enumString = value[(Constants.HttpsSchemaOrgUrl.Length + 1)..];
#else
            enumString = value.Substring(Constants.HttpsSchemaOrgUrl.Length + 1);
#endif
        }
        else
        {
            enumString = value;
        }

        if (TryParse(enumType, enumString, out result))
        {
            return true;
        }
        else
        {
            Debug.WriteLine($"Unable to parse enumeration of type {enumType.FullName} with value {enumString}.");
            return false;
        }
    }
}
