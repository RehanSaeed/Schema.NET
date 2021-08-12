namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The base JSON-LD object.
    /// See https://json-ld.org/spec/latest/json-ld
    /// </summary>
    public class JsonLdObject : IEquatable<JsonLdObject>
    {
        /// <summary>
        /// Gets the context used to define the short-hand names that are used throughout a JSON-LD document.
        /// These short-hand names are called terms and help developers to express specific identifiers in a compact
        /// manner.
        /// When two people communicate with one another, the conversation takes place in a shared environment,
        /// typically called "the context of the conversation". This shared context allows the individuals to use
        /// shortcut terms, like the first name of a mutual friend, to communicate more quickly but without losing
        /// accuracy. A context in JSON-LD works in the same way. It allows two applications to use shortcut terms to
        /// communicate with one another more efficiently, but without losing accuracy.
        /// Simply speaking, a context is used to map terms to IRIs. Terms are case sensitive and any valid string that
        /// is not a reserved JSON-LD keyword can be used as a term.
        /// </summary>
        [JsonPropertyName("@context")]
        [JsonPropertyOrder(0)]
        [JsonConverter(typeof(ContextJsonConverter))]
        public virtual JsonLdContext Context { get; internal set; } = new JsonLdContext();

        /// <summary>
        /// Gets the type, used to uniquely identify things that are being described in the document with IRIs or
        /// blank node identifiers.
        /// </summary>
        [JsonPropertyName("@type")]
        [JsonPropertyOrder(1)]
        public virtual string? Type { get; }

        /// <summary>
        /// Gets or sets the identifier used to uniquely identify things that are being described in the document with
        /// IRIs or blank node identifiers.
        /// To be able to externally reference nodes in a graph, it is important that nodes have an identifier. IRIs
        /// are a fundamental concept of Linked Data, for nodes to be truly linked, dereferencing the identifier should
        /// result in a representation of that node.This may allow an application to retrieve further information about
        /// a node. In JSON-LD, a node is identified using the @id keyword:
        /// </summary>
        [JsonPropertyName("@id")]
        [JsonPropertyOrder(2)]
        public virtual Uri? Id { get; set; }

        /// <summary>
        /// Attempts to set the Schema.org <paramref name="property"/> on the current object with the specified <paramref name="value"/>.
        /// </summary>
        /// <param name="property">The property to set the value on.</param>
        /// <param name="value">The value to set on the property</param>
        /// <returns><see langword="true"/> when the value has successfully been set; otherwise, <see langword="false"/>.</returns>
        public virtual bool TrySetValue(string property, IEnumerable<object> value) => false;

        /// <summary>
        /// Attempts to retrieve the value for <paramref name="property"/>.
        /// </summary>
        /// <param name="property">The property to get the value from.</param>
        /// <param name="result">The value on the property.</param>
        /// <returns><see langword="true"/> when the value has successfully been retrieved; otherwise, <see langword="false"/>.</returns>
        public virtual bool TryGetValue(string property, out IValues? result)
        {
            result = default;
            return false;
        }

        /// <summary>
        /// Attempts to retrieve the <typeparamref name="TValue"/> from <paramref name="property"/>.
        /// </summary>
        /// <typeparam name="TValue">The type of value you want to retrieve.</typeparam>
        /// <param name="property">The property to get the value from.</param>
        /// <param name="result">The value on the property.</param>
        /// <returns><see langword="true"/> when the value has successfully been retrieved; otherwise, <see langword="false"/>.</returns>
        public virtual bool TryGetValue<TValue>(string property, out OneOrMany<TValue> result)
        {
            result = default;
            return false;
        }

        /// <inheritdoc/>
        public bool Equals(JsonLdObject? other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Context == other.Context &&
                this.Type == other.Type &&
                this.Id == other.Id;
        }

        /// <inheritdoc/>
        public override bool Equals(object? obj) => this.Equals(obj as JsonLdObject);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Context)
                .And(this.Type)
                .And(this.Id);
    }
}
