namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Globalization;
    using System.Linq;
    using System.Reflection;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Converts a <see cref="IValues"/> object to JSON.
    /// </summary>
    /// <seealso cref="JsonConverter" />
    public class ValuesJsonConverter : JsonConverter
    {
        private const string NamespacePrefix = "Schema.NET.";

        /// <summary>
        /// Determines whether this instance can convert the specified object type.
        /// </summary>
        /// <param name="objectType">Type of the object.</param>
        /// <returns>
        /// <c>true</c> if this instance can convert the specified object type; otherwise, <c>false</c>.
        /// </returns>
        public override bool CanConvert(Type objectType) => objectType == typeof(IValues);

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
                    argument = Convert.ToDecimal(value, CultureInfo.InvariantCulture);
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
                if (tokenType == JsonToken.StartArray)
                {
                    var items = new List<object>();
                    foreach (var type in mainType.GenericTypeArguments)
                    {
                        var args = ReadJsonArray(token, type);
                        var genericType = typeof(OneOrMany<>).MakeGenericType(type);
                        var item = (IValues)Activator.CreateInstance(genericType, args);
                        items.Add(item);
                    }

                    argument = items;
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
                            else
                            {
                                var unwrappedType = type.GetUnderlyingTypeFromNullable();
                                if (unwrappedType.IsPrimitiveType())
                                {
                                    args = value;
                                }
                                else if (unwrappedType == typeof(decimal))
                                {
                                    args = Convert.ToDecimal(value, CultureInfo.InvariantCulture);
                                }
                                else
                                {
                                    args = token.ToObject(ToClass(type)); // This is expected to throw on some case
                                }
                            }

                            var genericType = typeof(OneOrMany<>).MakeGenericType(type);
                            argument = Activator.CreateInstance(genericType, args);
                        }
#pragma warning disable CA1031 // Do not catch general exception types
                        catch (Exception e)
                        {
                            // Nasty, but we're trying brute force as a last resort, to
                            // see which type has the right constructor for this value
                            Debug.WriteLine(e);
                        }
#pragma warning restore CA1031 // Do not catch general exception types
                    }
                }
            }

            object instance = null;
            try
            {
                instance = Activator.CreateInstance(mainType, argument);
            }
#pragma warning disable CA1031 // Do not catch general exception types
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
#pragma warning restore CA1031 // Do not catch general exception types

            return instance;
        }

        /// <summary>
        /// Writes the specified <see cref="IValues"/> object using the JSON writer.
        /// </summary>
        /// <param name="writer">The JSON writer.</param>
        /// <param name="value">The <see cref="IValues"/> object.</param>
        /// <param name="serializer">The JSON serializer.</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var values = (IValues)value;
            if (values.Count == 0)
            {
                serializer.Serialize(writer, null);
            }
            else if (values.Count == 1)
            {
                var enumerator = values.GetEnumerator();
                enumerator.MoveNext();
                this.WriteObject(writer, enumerator.Current, serializer);
            }
            else
            {
                this.WriteObject(writer, values.Cast<object>().ToList(), serializer);
            }
        }

        /// <summary>
        /// Writes the object retrieved from <see cref="IValues"/> when one is found.
        /// </summary>
        /// <param name="writer">The JSON writer.</param>
        /// <param name="value">The value to write.</param>
        /// <param name="serializer">The JSON serializer.</param>
        public virtual void WriteObject(JsonWriter writer, object value, JsonSerializer serializer) =>
            serializer.Serialize(writer, value);

        /// <summary>
        /// Gets the class type definition.
        /// </summary>
        /// <param name="type">The type under consideration.</param>
        /// <returns>
        /// The implementing class for <paramref name="type" /> or <paramref name="type" /> if it is already a class.
        /// </returns>
        private static Type ToClass(Type type)
        {
            if (type.GetTypeInfo().IsInterface)
            {
                return Type.GetType($"{type.Namespace}.{type.Name.Substring(1)}");
            }

            return type;
        }

        private static object ReadJsonArray(JToken token, Type type)
        {
            var classType = ToClass(type);
            var listType = typeof(List<>).MakeGenericType(classType);
            var list = Activator.CreateInstance(listType);

            foreach (var childToken in token.Children())
            {
                var typeName = GetTypeNameFromToken(childToken);
                if (string.IsNullOrEmpty(typeName))
                {
                    var item = childToken.ToObject(classType);
                    listType
                        .GetRuntimeMethod(nameof(List<object>.Add), new[] { classType })
                        .Invoke(list, new object[] { item });
                }
                else
                {
                    var builtType = Type.GetType($"{NamespacePrefix}{typeName}");
                    if (builtType != null && GetTypeHierarchy(builtType).Any(x => x == classType))
                    {
                        var child = (Thing)childToken.ToObject(builtType);
                        listType
                            .GetRuntimeMethod(nameof(List<object>.Add), new[] { classType })
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
            tokenType == JsonToken.Integer ? Convert.ToInt32(reader.Value, CultureInfo.InvariantCulture) : reader.Value;

        private static string GetTypeNameFromToken(JToken token)
        {
            var typeNameToken = token.Values().FirstOrDefault(t => t.Path.EndsWith("@type", StringComparison.Ordinal));
            return typeNameToken?.Value<string>();
        }
    }
}
