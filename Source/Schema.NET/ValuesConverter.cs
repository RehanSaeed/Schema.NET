namespace Schema.NET
{
    using System;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Converts an <see cref="IValue"/> object to JSON.
    /// </summary>
    /// <seealso cref="JsonConverter" />
    public class ValuesConverter : JsonConverter
    {
        /// <summary>
        /// Determines whether this instance can convert the specified object type.
        /// </summary>
        /// <param name="objectType">Type of the object.</param>
        /// <returns>
        /// <c>true</c> if this instance can convert the specified object type; otherwise, <c>false</c>.
        /// </returns>
        public override bool CanConvert(Type objectType) => objectType == typeof(IValue);

        /// <summary>
        /// Throws <see cref="NotImplementedException"/>.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <param name="objectType">Type of the object.</param>
        /// <param name="existingValue">The existing value.</param>
        /// <param name="serializer">The serializer.</param>
        /// <returns>Never returns. Throws <see cref="NotImplementedException"/>.</returns>
        public override object ReadJson(
            JsonReader reader,
            Type objectType,
            object existingValue,
            JsonSerializer serializer) =>
            throw new NotImplementedException();

        /// <summary>
        /// Writes the specified <see cref="IValue"/> object using the JSON writer.
        /// </summary>
        /// <param name="writer">The JSON writer.</param>
        /// <param name="value">The <see cref="IValue"/> object.</param>
        /// <param name="serializer">The JSON serializer.</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is IValue values)
            {
                var obj = values.Value;
                if (obj == null)
                {
                    writer.WriteNull();
                }
                else
                {
                    var token = JToken.FromObject(obj, serializer);
                    token.WriteTo(writer);
                }
            }
        }
    }
}
