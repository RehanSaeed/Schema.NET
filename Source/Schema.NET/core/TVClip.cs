namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A short TV program or a segment/part of a TV program.
    /// </summary>
    public partial interface ITVClip : IClip
    {
    }

    /// <summary>
    /// A short TV program or a segment/part of a TV program.
    /// </summary>
    [DataContract]
    public partial class TVClip : Clip, ITVClip, IEquatable<TVClip>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TVClip";

        /// <inheritdoc/>
        public bool Equals(TVClip other)
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
        public override bool Equals(object obj) => this.Equals(obj as TVClip);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
