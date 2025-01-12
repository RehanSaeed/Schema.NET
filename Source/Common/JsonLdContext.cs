namespace Schema.NET;

using System;
using System.Text.Json.Serialization;

/// <summary>
/// The @context for a JSON-LD document.
/// See https://w3c.github.io/json-ld-syntax
/// </summary>
public sealed class JsonLdContext : IEquatable<JsonLdContext>
{
    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    [JsonPropertyName("name")]
    [JsonPropertyOrder(0)]
    public string? Name { get; set; } = Constants.HttpsSchemaOrgUrl;

    /// <summary>
    /// Gets or sets the language.
    /// </summary>
    [JsonPropertyName("@language")]
    [JsonPropertyOrder(1)]
    public string? Language { get; set; }

    /// <summary>
    /// Performs an implicit conversion from <see cref="JsonLdContext"/> to <see cref="string"/>.
    /// </summary>
    /// <param name="context">The context.</param>
    /// <returns>The result of the conversion.</returns>
    public static implicit operator string?(JsonLdContext? context) => context?.Name;

    /// <summary>
    /// Implements the operator ==.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>
    /// The result of the operator.
    /// </returns>
    public static bool operator ==(JsonLdContext? left, JsonLdContext? right)
    {
        if (left is null)
        {
            return right is null;
        }

        return left.Equals(right);
    }

    /// <summary>
    /// Implements the operator !=.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>
    /// The result of the operator.
    /// </returns>
    public static bool operator !=(JsonLdContext? left, JsonLdContext? right) => !(left == right);

    /// <inheritdoc />
    public bool Equals(JsonLdContext? other)
    {
        if (other is null)
        {
            return false;
        }

        if (ReferenceEquals(this, other))
        {
            return true;
        }

        return this.Name == other.Name &&
            this.Language == other.Language;
    }

    /// <inheritdoc />
    public override bool Equals(object? obj) => this.Equals(obj as JsonLdContext);

    /// <inheritdoc />
    public override int GetHashCode() => HashCode.Of(this.Name).And(this.Language);

    /// <inheritdoc />
    public override string? ToString() => this.Name;
}
