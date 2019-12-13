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

            var token = JToken.Load(reader);
            var items = new List<object>();

            if (token.Type == JTokenType.Array)
            {
                foreach (var childToken in token.Children())
                {
                    var item = ProcessToken(childToken, objectType.GenericTypeArguments, serializer);
                    items.Add(item);
                }
            }
            else
            {
                var item = ProcessToken(token, objectType.GenericTypeArguments, serializer);
                items.Add(item);
            }

            return Activator.CreateInstance(objectType, items);
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

        private static object ProcessToken(JToken token, Type[] targetTypes, JsonSerializer serializer)
        {
            if (token.Type == JTokenType.Object)
            {
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
            }

            for (var i = targetTypes.Length - 1; i >= 0; i--)
            {
                var underlyingTargetType = targetTypes[i].GetUnderlyingTypeFromNullable();
                if (TryProcessTokenAsType(token, underlyingTargetType, serializer, out var value))
                {
                    return value;
                }
            }

            return null;
        }

        private static bool TryProcessTokenAsType(JToken token, Type targetType, JsonSerializer serializer, out object value)
        {
            var success = false;
            object result = null;

            var tokenType = token.Type;
            if (tokenType == JTokenType.Null)
            {
                success = true;
            }
            else if (tokenType == JTokenType.Object)
            {
                if (targetType.IsPrimitiveType())
                {
                    success = false;
                }
                else
                {
                    try
                    {
                        // If the target is an interface, attempt to identify concrete target
                        var localTargetType = targetType;
                        var typeInfo = localTargetType.GetTypeInfo();
                        if (typeInfo.IsInterface && ThingTypeLookup.TryGetValue(typeInfo.Name.Substring(1), out var concreteTypeInfo))
                        {
                            localTargetType = concreteTypeInfo.AsType();
                        }

                        result = token.ToObject(localTargetType, serializer);
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
            }
            else if (tokenType == JTokenType.String)
            {
                var valueString = token.ToObject<string>();

                if (targetType.GetTypeInfo().IsEnum)
                {
                    const string SCHEMA_ORG = "http://schema.org/";
                    const int SCHEMA_ORG_LENGTH = 18; // equivalent to "http://schema.org/".Length
                    const string SCHEMA_ORG_HTTPS = "https://schema.org/";
                    const int SCHEMA_ORG_HTTPS_LENGTH = 19; // equivalent to "https://schema.org/".Length

                    var enumString = valueString.Contains(SCHEMA_ORG) ? valueString.Substring(SCHEMA_ORG_LENGTH) :
                        valueString.Contains(SCHEMA_ORG_HTTPS) ? valueString.Substring(SCHEMA_ORG_HTTPS_LENGTH) : valueString;

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
                else if (targetType.IsPrimitiveType())
                {
                    if (targetType == typeof(string))
                    {
                        success = true;
                        result = valueString;
                    }
                    else if (targetType == typeof(int))
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
            else if (tokenType == JTokenType.Integer || tokenType == JTokenType.Float)
            {
                if (targetType.GetTypeInfo().IsPrimitive || targetType == typeof(decimal))
                {
                    result = token.ToObject(targetType);
                    success = true;
                }
            }
            else if (tokenType == JTokenType.Date)
            {
                if (targetType == typeof(DateTime))
                {
                    result = token.ToObject(targetType);
                    success = true;
                }
                else if (targetType == typeof(DateTimeOffset))
                {
                    result = token.ToObject(targetType);
                    success = true;
                }
            }
            else if (tokenType == JTokenType.Boolean)
            {
                if (targetType == typeof(bool))
                {
                    result = token.ToObject(targetType);
                    success = true;
                }
            }

            value = result;
            return success;
        }
    }
}
