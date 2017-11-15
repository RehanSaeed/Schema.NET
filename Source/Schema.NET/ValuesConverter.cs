namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
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
            JsonSerializer serializer)
        {
            var mainType = objectType.GetTypeInfo().IsGenericType && objectType.GetGenericTypeDefinition() == typeof(Nullable<>)
                ? Nullable.GetUnderlyingType(objectType)
                : objectType;

            object argument = null;

            var tokenType = reader.TokenType;
            JToken token = JToken.Load(reader);
            if (mainType.GenericTypeArguments.Length == 1)
            {
                var type = mainType.GenericTypeArguments[0];
                if (tokenType == JsonToken.StartArray)
                {
                    argument = token.ToObject(typeof(List<>).MakeGenericType(type));
                }
                else if (type.GetTypeInfo().IsPrimitive || type == typeof(string))
                {
                    argument = reader.Value;
                }
                else
                {
                    argument = token.ToObject(type);
                }
            }
            else
            {
                foreach (var type in mainType.GenericTypeArguments)
                {
                    try
                    {
                        object args;
                        if (reader.Value == null)
                        {
                            if (type.Name != token["@type"].ToString())
                            {
                                continue;
                            }

                            args = token.ToObject(type);
                        }
                        else
                        {
                            if (type.GetTypeInfo().IsPrimitive || type == typeof(string))
                            {
                                args = reader.Value;
                            }
                            else
                            {
                                args = Activator.CreateInstance(type, tokenType == JsonToken.Integer ? Convert.ToInt32(reader.Value) : reader.Value);
                            }
                        }

                        var genericType = typeof(Values<>).MakeGenericType(type);
                        argument = Activator.CreateInstance(genericType, args);
                        break;
                    }
                    catch
                    {
                        // Nasty, but we're trying to see which Activator instance is the right one...
                    }
                }
            }

            object instance = null;
            try
            {
                instance = Activator.CreateInstance(mainType, argument);
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }

            return instance;
        }

        /// <summary>
        /// Writes the specified <see cref="IValue"/> object using the JSON writer.
        /// </summary>
        /// <param name="writer">The JSON writer.</param>
        /// <param name="value">The <see cref="IValue"/> object.</param>
        /// <param name="serializer">The JSON serializer.</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var values = (IValue)value;
            var obj = values.Value;
            if (obj == null)
            {
                writer.WriteNull();
            }
            else
            {
                this.WriteObject(writer, obj, serializer);
            }
        }

        /// <summary>
        /// Writes the object retrieved from <see cref="IValue"/> when one is found.
        /// </summary>
        /// <param name="writer">The JSON writer.</param>
        /// <param name="value">The value to write.</param>
        /// <param name="serializer">The JSON serializer.</param>
        public virtual void WriteObject(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var token = JToken.FromObject(value, serializer);
            token.WriteTo(writer);
        }
    }
}
