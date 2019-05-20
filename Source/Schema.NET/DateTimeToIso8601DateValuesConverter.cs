namespace Schema.NET
{
    using System;
    using System.Globalization;
    using Newtonsoft.Json;

    /// <summary>
    /// Converts an <see cref="IValue"/> object to JSON. If the <see cref="IValue"/> contains a DateTime, converts it
    /// to ISO 8601 format for date without time.
    /// </summary>
    public class DateTimeToIso8601DateValuesConverter : ValuesConverter
    {
        /// <summary>
        /// Writes the object retrieved from <see cref="IValue" /> when one is found.
        /// </summary>
        /// <param name="writer">The JSON writer.</param>
        /// <param name="value">The value to write.</param>
        /// <param name="serializer">The JSON serializer.</param>
        public override void WriteObject(JsonWriter writer, object value, JsonSerializer serializer)
        {
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