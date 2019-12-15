namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The artwork on the cover of a comic.
    /// </summary>
    public partial interface IComicCoverArt : IComicStoryAndCoverArt
    {
    }

    /// <summary>
    /// The artwork on the cover of a comic.
    /// </summary>
    [DataContract]
    public partial class ComicCoverArt : ComicStoryAndCoverArt, IComicCoverArt, IEquatable<ComicCoverArt>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ComicCoverArt";

        /// <inheritdoc/>
        public bool Equals(ComicCoverArt other)
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
        public override bool Equals(object obj) => this.Equals(obj as ComicCoverArt);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
