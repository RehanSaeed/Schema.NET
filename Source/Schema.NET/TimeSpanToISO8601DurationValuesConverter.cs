using System;
using System.Reflection;
using System.Xml;
using Newtonsoft.Json;

/// <summary>
/// TODO, might not work with the changes made
/// </summary>

namespace Schema.NET
{
    /// <summary>
    /// Converts an <see cref="IValue"/> object to JSON. If the <see cref="IValue"/> contains a TimeSpan, converts it
    /// to ISO 8601 format first.
    /// </summary>
    /// <seealso cref="JsonConverter" />
    public class TimeSpanToISO8601DurationValuesConverter : ValuesConverter
    {
        /// <inheritdoc />
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var valuesType = objectType.GetUnderlyingTypeFromNullable();

            if (valuesType.GenericTypeArguments.Length == 1)
            {
                var mainType = valuesType.GenericTypeArguments[0];
                var genericType = typeof(Values<TimeSpan>);
                if (mainType.IsNullable())
                {
                    mainType = Nullable.GetUnderlyingType(mainType);
                    genericType = typeof(Values<TimeSpan?>);
                }

                if (mainType == typeof(TimeSpan))
                {
                    if (reader.Value != null)
                    {
                        var timespan = reader.Value.ToString();
                        if (!string.IsNullOrEmpty(timespan))
                        {
                            var timeSpan = XmlConvert.ToTimeSpan(timespan);
                            var instance = Activator.CreateInstance(genericType, timeSpan);
                            return instance;
                        }
                    }
                    return null;
                }
            }

            return base.ReadJson(reader, objectType, existingValue, serializer);
        }

        /// <summary>
        /// Writes the object retrieved from <see cref="IValue"/> when one is found.
        /// </summary>
        /// <param name="writer">The JSON writer.</param>
        /// <param name="value">The value to write.</param>
        /// <param name="serializer">The JSON serializer.</param>
        public override void WriteObject(JsonWriter writer, object value, JsonSerializer serializer)
        {
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
