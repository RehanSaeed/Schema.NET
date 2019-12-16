namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A short radio program or a segment/part of a radio program.
    /// </summary>
    public partial interface IRadioClip : IClip
    {
    }

    /// <summary>
    /// A short radio program or a segment/part of a radio program.
    /// </summary>
    [DataContract]
    public partial class RadioClip : Clip, IRadioClip, IEquatable<RadioClip>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "RadioClip";

        /// <inheritdoc/>
        public bool Equals(RadioClip other)
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
        public override bool Equals(object obj) => this.Equals(obj as RadioClip);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
