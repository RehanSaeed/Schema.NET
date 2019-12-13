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
        private static readonly Dictionary<string, TypeInfo> ThingTypeLookup = new Dictionary<string, TypeInfo>();

        static ValuesJsonConverter()
        {
            var iThingTypeInfo = typeof(IThing).GetTypeInfo();
            var thisAssembly = iThingTypeInfo.Assembly;

            foreach (var type in thisAssembly.ExportedTypes)
            {
                var typeInfo = type.GetTypeInfo();
                if (iThingTypeInfo.IsAssignableFrom(typeInfo))
                {
                    ThingTypeLookup.Add(type.Name, typeInfo);
                }
            }
        }

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
            if (reader is null)
            {
                throw new ArgumentNullException(nameof(reader));
            }

            if (objectType is null)
            {
                throw new ArgumentNullException(nameof(objectType));
            }

            if (serializer is null)
            {
                throw new ArgumentNullException(nameof(serializer));
            }

            if (reader.TokenType == JsonToken.StartArray)
            {
                var items = new List<object>();

                while (reader.Read())
                {
                    if (reader.TokenType == JsonToken.EndArray)
                    {
                        break;
                    }

                    if (reader.TokenType == JsonToken.Null)
                    {
                        continue;
                    }

                    var item = ProcessToken(reader, objectType.GenericTypeArguments, serializer);
                    items.Add(item);
                }

                return Activator.CreateInstance(objectType, items);
            }
            else if (reader.TokenType != JsonToken.Null)
            {
                var item = ProcessToken(reader, objectType.GenericTypeArguments, serializer);
                return Activator.CreateInstance(objectType, (IEnumerable)new[] { item });
            }

            return default;
        }

        /// <summary>
        /// Writes the specified <see cref="IValues"/> object using the JSON writer.
        /// </summary>
        /// <param name="writer">The JSON writer.</param>
        /// <param name="value">The <see cref="IValues"/> object.</param>
        /// <param name="serializer">The JSON serializer.</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
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
                this.WriteObject(writer, values.Cast<object>(), serializer);
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
            if (writer is null)
            {
                throw new ArgumentNullException(nameof(writer));
            }

            if (serializer is null)
            {
                throw new ArgumentNullException(nameof(serializer));
            }

            serializer.Serialize(writer, value);
        }

        private static object ProcessToken(JsonReader reader, Type[] targetTypes, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.StartObject)
            {
                var token = JToken.ReadFrom(reader);

                // Use the type property (if provided) to identify the correct type
                var explicitTypeFromToken = token.SelectToken("@type")?.ToString();
                if (!string.IsNullOrEmpty(explicitTypeFromToken) && ThingTypeLookup.TryGetValue(explicitTypeFromToken, out var explicitTypeInfo))
                {
                    for (var i = 0; i < targetTypes.Length; i++)
                    {
                        var targetTypeInfo = targetTypes[i].GetTypeInfo();
                        if (targetTypeInfo.IsAssignableFrom(explicitTypeInfo))
                        {
                            return token.ToObject(explicitTypeInfo.AsType(), serializer);
                        }
                    }
                }

                // Brute force the type by checking against every possible target
                for (var i = targetTypes.Length - 1; i >= 0; i--)
                {
                    var underlyingTargetType = targetTypes[i].GetUnderlyingTypeFromNullable();
                    if (!underlyingTargetType.IsPrimitiveType())
                    {
                        try
                        {
                            // If the target is an interface, attempt to identify concrete target
                            var localTargetType = underlyingTargetType;
                            var typeInfo = localTargetType.GetTypeInfo();
                            if (typeInfo.IsInterface && ThingTypeLookup.TryGetValue(typeInfo.Name.Substring(1), out var concreteTypeInfo))
                            {
                                localTargetType = concreteTypeInfo.AsType();
                            }

                            return token.ToObject(localTargetType, serializer);
                        }
#pragma warning disable CA1031 // Do not catch general exception types
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex.Message);
                        }
#pragma warning restore CA1031 // Do not catch general exception types
                    }
                }
            }
            else
            {
                // Brute force the type by checking against every possible target
                for (var i = targetTypes.Length - 1; i >= 0; i--)
                {
                    var underlyingTargetType = targetTypes[i].GetUnderlyingTypeFromNullable();
                    if (TryProcessTokenAsType(reader, underlyingTargetType, out var value))
                    {
                        return value;
                    }
                }
            }

            return null;
        }

        private static bool TryProcessTokenAsType(JsonReader reader, Type targetType, out object value)
        {
            var success = false;
            object result = null;

            var tokenType = reader.TokenType;
            if (reader.ValueType == targetType)
            {
                result = reader.Value;
                success = true;
            }
            else if (tokenType == JsonToken.String)
            {
                var valueString = (string)reader.Value;
                if (targetType.GetTypeInfo().IsPrimitive)
                {
                    if (targetType == typeof(int))
                    {
                        success = int.TryParse(valueString, NumberStyles.Integer, CultureInfo.InvariantCulture, out var localResult);
                        result = localResult;
                    }
                    else if (targetType == typeof(long))
                    {
                        success = long.TryParse(valueString, NumberStyles.Integer, CultureInfo.InvariantCulture, out var localResult);
                        result = localResult;
                    }
                    else if (targetType == typeof(float))
                    {
                        success = float.TryParse(valueString, NumberStyles.Float, CultureInfo.InvariantCulture, out var localResult);
                        result = localResult;
                    }
                    else if (targetType == typeof(double))
                    {
                        success = double.TryParse(valueString, NumberStyles.Float, CultureInfo.InvariantCulture, out var localResult);
                        result = localResult;
                    }
                    else if (targetType == typeof(bool))
                    {
                        success = bool.TryParse(valueString, out var localResult);
                        result = localResult;
                    }
                }
                else if (targetType == typeof(decimal))
                {
                    success = decimal.TryParse(valueString, NumberStyles.Float, CultureInfo.InvariantCulture, out var localResult);
                    result = localResult;
                }
                else if (targetType.GetTypeInfo().IsEnum)
                {
                    const string SCHEMA_ORG = "http://schema.org/";
                    const int SCHEMA_ORG_LENGTH = 18; // equivalent to "http://schema.org/".Length
                    const string SCHEMA_ORG_HTTPS = "https://schema.org/";
                    const int SCHEMA_ORG_HTTPS_LENGTH = 19; // equivalent to "https://schema.org/".Length

                    string enumString;
                    if (valueString.StartsWith(SCHEMA_ORG, StringComparison.OrdinalIgnoreCase))
                    {
                        enumString = valueString.Substring(SCHEMA_ORG_LENGTH);
                    }
                    else if (valueString.StartsWith(SCHEMA_ORG_HTTPS, StringComparison.OrdinalIgnoreCase))
                    {
                        enumString = valueString.Substring(SCHEMA_ORG_HTTPS_LENGTH);
                    }
                    else
                    {
                        enumString = valueString;
                    }

                    try
                    {
                        result = Enum.Parse(targetType, enumString);
                        success = true;
                    }
#pragma warning disable CA1031 // Do not catch general exception types
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                        success = false;
                    }
#pragma warning restore CA1031 // Do not catch general exception types
                }
                else if (targetType == typeof(DateTime))
                {
                    success = DateTime.TryParse(valueString, CultureInfo.InvariantCulture, DateTimeStyles.None, out var localResult);
                    result = localResult;
                }
                else if (targetType == typeof(DateTimeOffset))
                {
                    success = DateTimeOffset.TryParse(valueString, CultureInfo.InvariantCulture, DateTimeStyles.None, out var localResult);
                    result = localResult;
                }
                else if (targetType == typeof(Uri))
                {
                    success = Uri.TryCreate(valueString, UriKind.Absolute, out var localResult);
                    result = localResult;
                }
            }
            else if (tokenType == JsonToken.Integer || tokenType == JsonToken.Float)
            {
                if (targetType.GetTypeInfo().IsPrimitive || targetType == typeof(decimal))
                {
                    result = Convert.ChangeType(reader.Value, targetType, CultureInfo.InvariantCulture);
                    success = true;
                }
            }
            else if (tokenType == JsonToken.Date)
            {
                if (targetType == typeof(DateTime) && reader.Value is DateTimeOffset dateTimeOffset)
                {
                    result = dateTimeOffset.UtcDateTime;
                    success = true;
                }
                else if (targetType == typeof(DateTimeOffset) && reader.Value is DateTime dateTime)
                {
                    result = new DateTimeOffset(dateTime);
                    success = true;
                }
            }

            value = result;
            return success;
        }
    }
}
