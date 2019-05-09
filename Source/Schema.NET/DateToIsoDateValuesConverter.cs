namespace Schema.NET
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// Converts an <see cref="IValue"/> object to JSON. If the <see cref="IValue"/> contains a Date, converts it
    /// to Date object which handles ISO 8601 format for dates.
    /// </summary>
    public class DateToIsoDateValuesConverter : ValuesConverter
    {
        /// <inheritdoc />
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var valuesType = objectType.GetUnderlyingTypeFromNullable();

            if (valuesType.GenericTypeArguments.Length == 1)
            {
                var mainType = valuesType.GenericTypeArguments[0];
                var genericType = typeof(OneOrMany<IsoDate>);
                if (mainType.IsNullable())
                {
                    mainType = Nullable.GetUnderlyingType(mainType);
                    genericType = typeof(OneOrMany<IsoDate>);
                }

                if (mainType == typeof(IsoDate))
                {
                    var dateType = new IsoDate(reader.Value.ToString());
                    var instance = Activator.CreateInstance(genericType, dateType);
                    return instance;
                }
            }

            return base.ReadJson(reader, objectType, existingValue, serializer);
        }

        /// <summary>
        /// Writes the object retrieved from <see cref="IValue" /> when one is found.
        /// </summary>
        /// <param name="writer">The JSON writer.</param>
        /// <param name="value">The value to write.</param>
        /// <param name="serializer">The JSON serializer.</param>
        public override void WriteObject(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is IsoDate dateType)
            {
                writer.WriteValue(dateType.ToString());
            }
            else
            {
                base.WriteObject(writer, value, serializer);
            }
        }
    }
}