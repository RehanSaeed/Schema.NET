namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Reflection;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Converts an <see cref="IValue"/> object to JSON.
    /// </summary>
    /// <seealso cref="JsonConverter" />
    public class ValuesConverter : JsonConverter
    {
        private const string NamespacePrefix = "Schema.NET.";

        /// <summary>
        /// Determines whether this instance can convert the specified object type.
        /// </summary>
        /// <param name="objectType">Type of the object.</param>
        /// <returns>
        /// <c>true</c> if this instance can convert the specified object type; otherwise, <c>false</c>.
        /// </returns>
        public override bool CanConvert(Type objectType) => objectType == typeof(IValue);

        /// <summary>
        /// Reads the JSON representation of the object.
        /// </summary>
        /// <param name="reader">The <see cref="JsonReader"/> to read from.</param>
        /// <param name="objectType">Type of the object.</param>
        /// <param name="existingValue">The existing value of object being read.</param>
        /// <param name="serializer">The calling serializer.</param>
        /// <returns>The object value.</returns>
        public override object ReadJson(
            JsonReader reader,
            Type objectType,
            object existingValue,
            JsonSerializer serializer)
        {
            var mainType = objectType.GetUnderlyingTypeFromNullable();

            object argument = null;

            var tokenType = reader.TokenType;
            var value = SanitizeReaderValue(reader, tokenType);

            var token = JToken.Load(reader);
            if (mainType.GenericTypeArguments.Length == 1)
            {
                var type = mainType.GenericTypeArguments[0].GetUnderlyingTypeFromNullable();
                if (tokenType == JsonToken.StartArray)
                {
                    argument = ReadJsonArray(token, type);
                }
                else if (type.IsPrimitiveType())
                {
                    argument = value;
                }
                else if (type == typeof(decimal))
                {
                    argument = Convert.ToDecimal(value);
                }
                else
                {
                    if (type.GetTypeInfo().IsEnum)
                    {
                        var enumString = token.ToString().Substring("http://schema.org/".Length);
                        argument = Enum.Parse(type, enumString);
                    }
                    else
                    {
                        var typeName = GetTypeNameFromToken(token);
                        if (string.IsNullOrEmpty(typeName))
                        {
                            argument = token.ToObject(type);
                        }
                        else
                        {
                            var builtType = Type.GetType($"{NamespacePrefix}{typeName}");
                            argument = token.ToObject(builtType);
                        }
                    }
                }
            }
            else
            {
                foreach (var type in mainType.GenericTypeArguments)
                {
                    try
                    {
                        object args;
                        if (tokenType == JsonToken.StartObject)
                        {
                            var typeName = GetTypeNameFromToken(token);
                            if (string.IsNullOrEmpty(typeName))
                            {
                                args = token.ToObject(type);
                            }
                            else if (typeName == type.Name)
                            {
                                args = token.ToObject(type);
                            }
                            else
                            {
                                var builtType = Type.GetType($"{NamespacePrefix}{typeName}");
                                if (builtType != null && type.GetTypeInfo().IsAssignableFrom(builtType.GetTypeInfo()))
                                {
                                    args = token.ToObject(builtType);
                                }
                                else
                                {
                                    continue;
                                }
                            }
                        }
                        else if (tokenType == JsonToken.StartArray)
                        {
                            args = ReadJsonArray(token, type);
                        }
                        else
                        {
                            var unwrappedType = type.GetUnderlyingTypeFromNullable();
                            if (unwrappedType.IsPrimitiveType())
                            {
                                args = value;
                            }
                            else if (unwrappedType == typeof(decimal))
                            {
                                args = Convert.ToDecimal(value);
                            }
                            else
                            {
                                args = token.ToObject(type); // This is expected to throw on some case
                            }
                        }

                        var genericType = typeof(OneOrMany<>).MakeGenericType(type);
                        argument = Activator.CreateInstance(genericType, args);
                    }
                    catch
                    {
                        // Nasty, but we're trying brute force as a last resort, to
                        // see which type has the right constructor for this value
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
                Debug.WriteLine(e);
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

        private static object ReadJsonArray(JToken token, Type type)
        {
            var listType = typeof(List<>).MakeGenericType(type);
            var list = Activator.CreateInstance(listType);

            foreach (var childToken in token.Children())
            {
                var typeName = GetTypeNameFromToken(childToken);
                if (string.IsNullOrEmpty(typeName))
                {
                    var item = childToken.ToObject(type);
                    listType
                        .GetRuntimeMethod(nameof(List<object>.Add), new[] { type })
                        .Invoke(list, new object[] { item });
                }
                else
                {
                    var builtType = Type.GetType($"{NamespacePrefix}{typeName}");
                    if (builtType != null && GetTypeHierarchy(builtType).Any(x => x == type))
                    {
                        var child = (Thing)childToken.ToObject(builtType);
                        listType
                            .GetRuntimeMethod(nameof(List<object>.Add), new[] { type })
                            .Invoke(list, new object[] { child });
                    }
                }
            }

            return list;
        }

        private static IEnumerable<Type> GetTypeHierarchy(Type type)
        {
            if (type == null)
            {
                yield break;
            }

            yield return type;

            var baseType = type.GetTypeInfo().BaseType;
            while (baseType != null)
            {
                yield return baseType;
                baseType = baseType.GetTypeInfo().BaseType;
            }
        }

        private static object SanitizeReaderValue(JsonReader reader, JsonToken tokenType) =>
            tokenType == JsonToken.Integer ? Convert.ToInt32(reader.Value) : reader.Value;

        private static string GetTypeNameFromToken(JToken token)
        {
            var typeNameToken = token.Values().FirstOrDefault(t => t.Path.EndsWith("@type"));
            return typeNameToken?.Value<string>();
        }
    }
}
