namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A file containing a note, primarily for the author.
    /// </summary>
    public partial interface INoteDigitalDocument : IDigitalDocument
    {
    }

    /// <summary>
    /// A file containing a note, primarily for the author.
    /// </summary>
    [DataContract]
    public partial class NoteDigitalDocument : DigitalDocument, INoteDigitalDocument, IEquatable<NoteDigitalDocument>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "NoteDigitalDocument";

        /// <inheritdoc/>
        public bool Equals(NoteDigitalDocument other)
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
        public override bool Equals(object obj) => this.Equals(obj as NoteDigitalDocument);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
