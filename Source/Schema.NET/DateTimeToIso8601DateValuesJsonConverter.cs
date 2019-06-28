namespace Schema.NET
{
    using System;
    using System.Globalization;
    using Newtonsoft.Json;

    /// <summary>
    /// Converts an <see cref="IValues"/> object to JSON. If the <see cref="IValues"/> contains a
    /// <see cref="DateTime"/>, converts it to an ISO 8601 format date first.
    /// </summary>
    /// <seealso cref="JsonConverter" />
    /// <seealso cref="ValuesJsonConverter" />
    public class DateTimeToIso8601DateValuesJsonConverter : ValuesJsonConverter
    {
        /// <summary>
        /// Writes the object retrieved from <see cref="IValues" /> when one is found.
        /// </summary>
        /// <param name="writer">The JSON writer.</param>
        /// <param name="value">The value to write.</param>
        /// <param name="serializer">The JSON serializer.</param>
        public override void WriteObject(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (writer == null)
            {
                throw new ArgumentNullException(nameof(writer));
            }

            if (serializer == null)
            {
                throw new ArgumentNullException(nameof(serializer));
            }

            if (value is DateTime dateTimeType)
            {
                writer.WriteValue(dateTimeType.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
            }
            else
            {
                base.WriteObject(writer, value, serializer);
            }
        }
    }
}