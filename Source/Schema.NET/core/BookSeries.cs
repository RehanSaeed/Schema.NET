namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A series of books. Included books can be indicated with the hasPart property.
    /// </summary>
    public partial interface IBookSeries : ICreativeWorkSeries
    {
    }

    /// <summary>
    /// A series of books. Included books can be indicated with the hasPart property.
    /// </summary>
    [DataContract]
    public partial class BookSeries : CreativeWorkSeries, IBookSeries, IEquatable<BookSeries>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BookSeries";

        /// <inheritdoc/>
        public bool Equals(BookSeries other)
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
        public override bool Equals(object obj) => this.Equals(obj as BookSeries);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
