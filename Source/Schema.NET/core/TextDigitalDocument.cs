namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A file composed primarily of text.
    /// </summary>
    public partial interface ITextDigitalDocument : IDigitalDocument
    {
    }

    /// <summary>
    /// A file composed primarily of text.
    /// </summary>
    [DataContract]
    public partial class TextDigitalDocument : DigitalDocument, ITextDigitalDocument, IEquatable<TextDigitalDocument>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TextDigitalDocument";

        /// <inheritdoc/>
        public bool Equals(TextDigitalDocument other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Type == other.Type &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as TextDigitalDocument);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
