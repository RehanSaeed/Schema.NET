namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A music video file.
    /// </summary>
    public partial interface IMusicVideoObject : IMediaObject
    {
    }

    /// <summary>
    /// A music video file.
    /// </summary>
    [DataContract]
    public partial class MusicVideoObject : MediaObject, IMusicVideoObject, IEquatable<MusicVideoObject>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MusicVideoObject";

        /// <inheritdoc/>
        public bool Equals(MusicVideoObject other)
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
        public override bool Equals(object obj) => this.Equals(obj as MusicVideoObject);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
