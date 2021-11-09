namespace Schema.NET;

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml;

/// <summary>
/// Converts an <see cref="IValues"/> object to JSON. If the <see cref="IValues"/> contains a
/// <see cref="TimeSpan"/>, converts it to ISO 8601 format first.
/// </summary>
/// <seealso cref="JsonConverter" />
/// <seealso cref="ValuesJsonConverter" />
public class TimeSpanToISO8601DurationValuesJsonConverter : ValuesJsonConverter
{
    /// <summary>
    /// Writes the object retrieved from <see cref="IValues"/> when one is found.
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

        if (value is TimeSpan duration)
        {
            writer.WriteStringValue(XmlConvert.ToString(duration));
        }
        else
        {
            base.WriteObject(writer, value, options);
        }
    }
}
