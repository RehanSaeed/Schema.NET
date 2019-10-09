namespace Schema.NET
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Globalization;
    using System.Linq;
    using System.Reflection;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Converts a <see cref="IValues"/> object to and from JSON.
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
            if (reader == null)
            {
                throw new ArgumentNullException(nameof(reader));
            }

            if (objectType == null)
            {
                throw new ArgumentNullException(nameof(objectType));
            }

            if (serializer == null)
            {
                throw new ArgumentNullException(nameof(serializer));
            }

            var mainType = objectType.GetUnderlyingTypeFromNullable();

            object argument = null;

            var tokenType = reader.TokenType;
            var value = reader.Value;

            var token = JToken.Load(reader);
            var count = token.Children().Count();

#pragma warning disable CA1062 // Validate arguments of public methods
            if (mainType.GenericTypeArguments.Length == 1)
#pragma warning restore CA1062 // Validate arguments of public methods
            {
                var type = mainType.GenericTypeArguments[0];
                if (tokenType == JsonToken.StartArray)
                {
                    var unwrappedType = type.GetUnderlyingTypeFromNullable();
                    argument = ReadJsonArray(token, unwrappedType);
                }
                else
                {
                    argument = ParseTokenArguments(token, tokenType, type, value);
                }
            }
            else
            {
                if (tokenType == JsonToken.StartArray)
                {
                    var total = 0;
                    var items = new List<object>();
                    for (var i = mainType.GenericTypeArguments.Length - 1; i >= 0; i--)
                    {
                        var type = mainType.GenericTypeArguments[i];
                        var unwrappedType = type.GetUnderlyingTypeFromNullable();
                        // only read as many items as there are tokens left
                        var args = ReadJsonArray(token, unwrappedType, count - total);

                        if (args != null && args.Count > 0)
                        {
                            var genericType = typeof(OneOrMany<>).MakeGenericType(type);
                            var item = (IValues)Activator.CreateInstance(genericType, args);
                            items.Add(item);

                            total += args.Count;

                            if (total >= count)
                            {
                                // if we have deserialized enough items as there are tokens, break
                                break;
                            }
                        }
                    }

                    argument = items;
                }
                else
                {
                    for (var i = mainType.GenericTypeArguments.Length - 1; i >= 0; i--)
                    {
                        var type = mainType.GenericTypeArguments[i];

                        try
                        {
                            var args = ParseTokenArguments(token, tokenType, type, value);

                            if (args != null)
                            {
                                var genericType = typeof(OneOrMany<>).MakeGenericType(type);
                                argument = Activator.CreateInstance(genericType, args);
                            }
                        }
#pragma warning disable CA1031 // Do not catch general exception types
                        catch (Exception e)
                        {
                            // Nasty, but we're trying brute force as a last resort, to
                            // see which type has the right constructor for this value
                            Debug.WriteLine(e);
                        }
#pragma warning restore CA1031 // Do not catch general exception types

                        if (argument != null)
                        {
                            // return first valid argument, going from right to left in generic type arguments
                            break;
                        }
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
            if (writer == null)
            {
                throw new ArgumentNullException(nameof(writer));
            }

            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            if (serializer == null)
            {
                throw new ArgumentNullException(nameof(serializer));
            }

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
        public virtual void WriteObject(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (writer == null)
            {
                throw new ArgumentNullException(nameof(writer));
            }

            if (serializer == null)
            {
                throw new ArgumentNullException(nameof(serializer));
            }

            serializer.Serialize(writer, value);
        }

        private static object ParseTokenArguments(JToken token, JsonToken tokenType, Type type, object value)
        {
            const string SCHEMA_ORG = "http://schema.org/";
            const int SCHEMA_ORG_LENGTH = 18; // equivalent to "http://schema.org/".Length
            const string SCHEMA_ORG_HTTPS = "https://schema.org/";
            const int SCHEMA_ORG_HTTPS_LENGTH = 19; // equivalent to "https://schema.org/".Length
            object args;
            var unwrappedType = type.GetUnderlyingTypeFromNullable();
            if (unwrappedType.GetTypeInfo().IsEnum)
            {
                var en = token.ToString();
                var enumString = en.Contains(SCHEMA_ORG) ? en.Substring(SCHEMA_ORG_LENGTH) :
                    en.Contains(SCHEMA_ORG_HTTPS) ? en.Substring(SCHEMA_ORG_HTTPS_LENGTH) : en;
                args = Enum.Parse(unwrappedType, enumString);
            }
            else
            {
                if (tokenType == JsonToken.StartObject)
                {
                    args = ParseTokenObjectArguments(token, type, unwrappedType);
                }
                else
                {
                    args = ParseTokenValueArguments(token, tokenType, type, unwrappedType, value);
                }
            }

            return args;
        }

        private static object ParseTokenObjectArguments(JToken token, Type type, Type unwrappedType)
        {
            object args = null;
            var typeName = GetTypeNameFromToken(token);
            if (string.IsNullOrEmpty(typeName))
            {
                args = token.ToObject(unwrappedType);
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
            }

            return args;
        }

        private static object ParseTokenValueArguments(JToken token, JsonToken tokenType, Type type, Type unwrappedType, object value)
        {
            object args = null;
            if (unwrappedType.IsPrimitiveType())
            {
                if (value is string)
                {
                    if (unwrappedType == typeof(string))
                    {
                        args = value;
                    }
                    else if (unwrappedType == typeof(int))
                    {
                        if (int.TryParse((string)value, NumberStyles.Integer, CultureInfo.InvariantCulture, out var i))
                        {
                            args = i;
                        }
                    }
                    else if (unwrappedType == typeof(long))
                    {
                        if (long.TryParse((string)value, NumberStyles.Integer, CultureInfo.InvariantCulture, out var i))
                        {
                            args = i;
                        }
                    }
                    else if (unwrappedType == typeof(float))
                    {
                        if (float.TryParse((string)value, NumberStyles.Float, CultureInfo.InvariantCulture, out var i))
                        {
                            args = i;
                        }
                    }
                    else if (unwrappedType == typeof(double))
                    {
                        if (double.TryParse((string)value, NumberStyles.Float, CultureInfo.InvariantCulture, out var i))
                        {
                            args = i;
                        }
                    }
                    else if (unwrappedType == typeof(bool))
                    {
                        if (bool.TryParse((string)value, out var i))
                        {
                            args = i;
                        }
                    }
                }
                else if (value is short || value is int || value is long || value is float || value is double)
                {
                    // Can safely convert between numeric types
                    if (unwrappedType == typeof(short) || unwrappedType == typeof(int) || unwrappedType == typeof(long) || unwrappedType == typeof(float) || unwrappedType == typeof(double))
                    {
                        args = Convert.ChangeType(value, unwrappedType, CultureInfo.InvariantCulture);
                    }
                }
                else if (value is bool)
                {
                    if (unwrappedType == typeof(bool))
                    {
                        args = value;
                    }
                }
                else if (value is DateTime || value is DateTimeOffset)
                {
                    // NO-OP: can't put a date into a primitive type
                }
                else
                {
                    args = value;
                }
            }
            else if (unwrappedType == typeof(decimal))
            {
                if (value is string)
                {
                    if (decimal.TryParse((string)value, NumberStyles.Currency, CultureInfo.InvariantCulture, out var i))
                    {
                        args = i;
                    }
                }
                else
                {
                    args = Convert.ToDecimal(value, CultureInfo.InvariantCulture);
                }
            }
            else if (unwrappedType == typeof(DateTime))
            {
                if (value is string)
                {
                    if (DateTime.TryParse((string)value, CultureInfo.InvariantCulture, DateTimeStyles.None, out var i))
                    {
                        args = i;
                    }
                }
                else if (value is DateTime)
                {
                    args = value;
                }
                else if (value is DateTimeOffset)
                {
                    args = ((DateTimeOffset)value).DateTime;
                }
                else if (value is short || value is int || value is long || value is float || value is double)
                {
                    // NO-OP: can't put a primitive type into a date
                }
                else
                {
                    args = Convert.ToDateTime(value, CultureInfo.InvariantCulture);
                }
            }
            else if (unwrappedType == typeof(DateTimeOffset))
            {
                if (value is string)
                {
                    if (DateTimeOffset.TryParse((string)value, CultureInfo.InvariantCulture, DateTimeStyles.None, out var i))
                    {
                        args = i;
                    }
                }
                else if (value is DateTime)
                {
                    args = new DateTimeOffset((DateTime)value);
                }
                else if (value is DateTimeOffset)
                {
                    args = value;
                }
                else
                {
                    args = Convert.ToDateTime(value, CultureInfo.InvariantCulture);
                }
            }
            else
            {
                var classType = ToClass(type);
                if (tokenType == JsonToken.String)
                {
                    if (classType == typeof(Uri))
                    {
                        // REVIEW: Avoid invalid URIs being assigned as URI (Should we only allow absolute URIs?)
                        if (Uri.TryCreate((string)value, UriKind.Absolute, out var i))
                        {
                            args = i;
                        }
                    }
                }

                // REVIEW: If argument still not assigned, only use ToObject if not casting primitive to interface or class
                if (args == null)
                {
                    if (!type.GetTypeInfo().IsInterface && !type.GetTypeInfo().IsClass)
                    {
                        args = token.ToObject(classType); // This is expected to throw on some case
                    }
                }
            }

            return args;
        }

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

        private static IList ReadJsonArray(JToken token, Type type, int? count = null)
        {
            var classType = ToClass(type);
            var listType = typeof(List<>).MakeGenericType(type); // always read into list of interfaces
            var list = Activator.CreateInstance(listType);
            var i = 0;

            if (count == null)
            {
                // if maximum item count not assigned, set to count of child tokens
                count = token.Children().Count();
            }

            foreach (var childToken in token.Children())
            {
                var typeName = GetTypeNameFromToken(childToken);
                if (string.IsNullOrEmpty(typeName))
                {
                    var child = childToken.ToObject(classType);
                    var method = listType.GetRuntimeMethod(nameof(List<object>.Add), new[] { classType });

                    if (method != null)
                    {
                        method.Invoke(list, new object[] { child });

                        i++;
                    }
                }
                else
                {
                    var builtType = Type.GetType($"{NamespacePrefix}{typeName}");
                    if (builtType != null && type.GetTypeInfo().IsAssignableFrom(builtType.GetTypeInfo()))
                    {
                        var child = (Thing)childToken.ToObject(builtType);
                        var method = listType.GetRuntimeMethod(nameof(List<object>.Add), new[] { classType });

                        if (method != null)
                        {
                            method.Invoke(list, new object[] { child });

                            i++;
                        }
                    }
                }

                if (i == count)
                {
                    break;
                }
            }

            return (IList)list;
        }

        private static string GetTypeNameFromToken(JToken token)
        {
            var o = token as JObject;
            return o?.SelectToken("@type")?.ToString();
        }
    }
}
