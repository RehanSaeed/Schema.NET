namespace Schema.NET;

using System.Text.Json;

/// <summary>
/// The most generic type of item.
/// </summary>
#pragma warning disable CA1040 // Avoid empty interfaces
public partial interface IThing
#pragma warning restore CA1040 // Avoid empty interfaces
{
}

/// <summary>
/// The most generic type of item.
/// </summary>
public partial class Thing : JsonLdObject
{
    /// <summary>
    /// Returns the JSON-LD representation of this instance.
    /// </summary>
    /// <returns>
    /// A <see cref="string" /> that represents the JSON-LD representation of this instance.
    /// </returns>
    public override string ToString() => SchemaSerializer.SerializeObject(this);

    /// <summary>
    /// Returns the JSON-LD representation of this instance.
    ///
    /// This method should be used when you want to embed the output raw (as-is) into a web
    /// page. It uses serializer settings with HTML escaping to avoid Cross-Site Scripting (XSS)
    /// vulnerabilities if the object was constructed from an untrusted source.
    /// </summary>
    /// <returns>
    /// A <see cref="string" /> that represents the JSON-LD representation of this instance.
    /// </returns>
    public string ToHtmlEscapedString() => SchemaSerializer.HtmlEscapedSerializeObject(this);

    /// <summary>
    /// Returns the JSON-LD representation of this instance using the <see cref="JsonSerializerOptions"/> provided.
    /// </summary>
    /// <param name="options">Serialization settings.</param>
    /// <returns>
    /// A <see cref="string" /> that represents the JSON-LD representation of this instance.
    /// </returns>
    public string ToString(JsonSerializerOptions options) =>
        SchemaSerializer.SerializeObject(this, options);
}
