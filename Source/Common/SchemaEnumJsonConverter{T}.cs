namespace Schema.NET;

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;

/// <summary>
/// Converts a Schema enumeration to and from JSON.
/// </summary>
/// <typeparam name="T">The enumeration type to convert.</typeparam>
public class SchemaEnumJsonConverter<T> : JsonConverter<T>
    where T : struct, Enum
{
    private readonly Dictionary<T, string> valueNameMap = new();

    /// <summary>
    /// Initializes a new instance of the <see cref="SchemaEnumJsonConverter{T}"/> class.
    /// </summary>
    public SchemaEnumJsonConverter()
    {
        var enumType = typeof(T);
        var values = Enum.GetValues(enumType);

        foreach (var value in values)
        {
            var enumMember = enumType.GetMember(value!.ToString()!)[0];
            var enumMemberAttribute = enumMember.GetCustomAttribute<EnumMemberAttribute>(false);
            this.valueNameMap[(T)value] = enumMemberAttribute!.Value!;
        }
    }

    /// <summary>
    /// Reads the JSON representation of the enumeration.
    /// </summary>
    /// <param name="reader">The <see cref="Utf8JsonReader"/> to read from.</param>
    /// <param name="typeToConvert">Type of the enumeration.</param>
    /// <param name="options">The serializer options.</param>
    /// <returns>The enumeration value.</returns>
    public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
#if NET6_0_OR_GREATER
        ArgumentNullException.ThrowIfNull(typeToConvert);
#else
        if (typeToConvert is null)
        {
            throw new ArgumentNullException(nameof(typeToConvert));
        }
#endif

        var valueString = reader.GetString();
        if (EnumHelper.TryParseEnumFromSchemaUri(typeToConvert, valueString, out var result))
        {
            return (T)result!;
        }

        return default;
    }

    /// <summary>
    /// Writes the specified enumeration using the JSON writer.
    /// </summary>
    /// <param name="writer">The JSON writer.</param>
    /// <param name="value">The enumeration value.</param>
    /// <param name="options">The JSON serializer options.</param>
    public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
    {
#if NET6_0_OR_GREATER
        ArgumentNullException.ThrowIfNull(writer);
        ArgumentNullException.ThrowIfNull(options);
#else
        if (writer is null)
        {
            throw new ArgumentNullException(nameof(writer));
        }

        if (options is null)
        {
            throw new ArgumentNullException(nameof(options));
        }
#endif

        writer.WriteStringValue(this.valueNameMap[value]);
    }
}
