namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A sequential publication of comic stories under a
    ///         unifying title, for example "The Amazing Spider-Man" or "Groo the
    ///         Wanderer".
    /// </summary>
    public partial interface IComicSeries : IPeriodical
    {
    }

    /// <summary>
    /// A sequential publication of comic stories under a
    ///         unifying title, for example "The Amazing Spider-Man" or "Groo the
    ///         Wanderer".
    /// </summary>
    [DataContract]
    public partial class ComicSeries : Periodical, IComicSeries, IEquatable<ComicSeries>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ComicSeries";

        /// <inheritdoc/>
        public bool Equals(ComicSeries other)
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
        public override bool Equals(object obj) => this.Equals(obj as ComicSeries);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
