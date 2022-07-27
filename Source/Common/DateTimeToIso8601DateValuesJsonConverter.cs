namespace Schema.NET;

using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

/// <summary>
/// Converts an <see cref="IValues"/> object to JSON. If the <see cref="IValues"/> contains a
/// <see cref="DateTime"/>, converts it to an ISO 8601 format date first.
/// </summary>
/// <seealso cref="JsonConverter" />
/// <seealso cref="ValuesJsonConverter" />
public class DateTimeToIso8601DateValuesJsonConverter : ValuesJsonConverter
{
    private const string DateFormat = "yyyy-MM-dd";

    /// <summary>
    /// Writes the object retrieved from <see cref="IValues" /> when one is found.
    /// </summary>
    /// <param name="writer">The JSON writer.</param>
    /// <param name="value">The value to write.</param>
    /// <param name="options">The JSON serializer options.</param>
    public override void WriteObject(Utf8JsonWriter writer, object? value, JsonSerializerOptions options)
    {
#if NET6_0_OR_GREATER
        ArgumentNullException.ThrowIfNull(writer);
        ArgumentNullException.ThrowIfNull(options);
#else
        if (writer is null)
        {
            throw new ArgumentNullException(nameof(writer));
        }

        if (options is null)
        {
            throw new ArgumentNullException(nameof(options));
        }
#endif

        if (value is DateTime dateTimeType)
        {
            writer.WriteStringValue(dateTimeType.ToString(DateFormat, CultureInfo.InvariantCulture));
        }
        else
        {
            base.WriteObject(writer, value, options);
        }
    }
}
