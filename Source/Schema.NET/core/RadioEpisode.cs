namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A radio episode which can be part of a series or season.
    /// </summary>
    public partial interface IRadioEpisode : IEpisode
    {
    }

    /// <summary>
    /// A radio episode which can be part of a series or season.
    /// </summary>
    [DataContract]
    public partial class RadioEpisode : Episode, IRadioEpisode, IEquatable<RadioEpisode>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "RadioEpisode";

        /// <inheritdoc/>
        public bool Equals(RadioEpisode other)
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
        public override bool Equals(object obj) => this.Equals(obj as RadioEpisode);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
