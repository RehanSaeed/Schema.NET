using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Schema.NET
{

    public class WrapperConverter : JsonConverter
    {
        private const string NamespacePrefix = "Schema.NET.";

        private Dictionary<Type, Dictionary<Type, Type>> interfaceImplementors = new Dictionary<Type, Dictionary<Type, Type>>();

        public override bool CanConvert(Type objectType) => objectType == typeof(IWrapper);
        
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var tokenType = reader.TokenType;
            var value = SanitizeReaderValue(reader, tokenType);

            //find out which object implement this Wrapper
            if (!interfaceImplementors.TryGetValue(objectType, out Dictionary<Type, Type> impl))
            {
                Assembly schemaTypes = typeof(Thing).Assembly;
                interfaceImplementors[objectType] = impl = new Dictionary<Type, Type>();
                var allImplementations = schemaTypes.GetTypes().Where(p => objectType.IsAssignableFrom(p) && !p.IsInterface);
                foreach (var implType in allImplementations)
                {
                    var interfaceType = implType.GetInterfaces().First(p => p.GetGenericArguments().Any()).GetGenericArguments().First();
                    impl[interfaceType] = implType;
                }
            }

            var token = JToken.Load(reader);
            foreach (var implType in impl)
            {
                var type = implType.Key;
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
                        var arrayType = typeof(List<>).MakeGenericType(type);
                        args = token.ToObject(arrayType);
                    }
                    else
                    {
                        if (type.IsPrimitiveType())
                        {
                            args = value;
                        }
                        else if (type == typeof(decimal))
                        {
                            args = Convert.ToDecimal(value);
                        }
                        else
                        {
                            args = token.ToObject(type); // This is expected to throw on some case
                        }
                    }
                     
                    if (args != null)
                        return Activator.CreateInstance(implType.Value, args);
                }
                catch (Exception e)
                {
                    // Nasty, but we're trying brute force as a last resort, to
                    // see which type has the right constructor for this value
                    Console.WriteLine(e);
                }
            }

            return null;
        }

       
        /// <summary>
        /// Writes the specified <see cref="IValue"/> object using the JSON writer.
        /// </summary>
        /// <param name="writer">The JSON writer.</param>
        /// <param name="value">The <see cref="IValue"/> object.</param>
        /// <param name="serializer">The JSON serializer.</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var values = (IWrapper)value;
            var obj = values.Data;

            var token = JToken.FromObject(obj, serializer);
            token.WriteTo(writer);
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
