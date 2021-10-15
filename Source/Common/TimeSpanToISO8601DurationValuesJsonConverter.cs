namespace Schema.NET
{
    using System;
    using System.Xml;
    using Newtonsoft.Json;

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
        /// <param name="serializer">The JSON serializer.</param>
        public override void WriteObject(JsonWriter writer, object? value, JsonSerializer serializer)
        {
#if NET6_0_OR_GREATER
            ArgumentNullException.ThrowIfNull(writer);
            ArgumentNullException.ThrowIfNull(value);
            ArgumentNullException.ThrowIfNull(serializer);
#else
            if (writer is null)
            {
                throw new ArgumentNullException(nameof(writer));
            }

            if (value is null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            if (serializer is null)
            {
                throw new ArgumentNullException(nameof(serializer));
            }
#endif

            if (value is TimeSpan duration)
            {
                writer.WriteValue(XmlConvert.ToString(duration));
            }
            else
            {
                base.WriteObject(writer, value, serializer);
            }
        }
    }
}
