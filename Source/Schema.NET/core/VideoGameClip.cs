namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A short segment/part of a video game.
    /// </summary>
    public partial interface IVideoGameClip : IClip
    {
    }

    /// <summary>
    /// A short segment/part of a video game.
    /// </summary>
    [DataContract]
    public partial class VideoGameClip : Clip, IVideoGameClip, IEquatable<VideoGameClip>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "VideoGameClip";

        /// <inheritdoc/>
        public bool Equals(VideoGameClip other)
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
        public override bool Equals(object obj) => this.Equals(obj as VideoGameClip);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
