namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A unique instance of a radio BroadcastService on a CableOrSatelliteService lineup.
    /// </summary>
    public partial interface IRadioChannel : IBroadcastChannel
    {
    }

    /// <summary>
    /// A unique instance of a radio BroadcastService on a CableOrSatelliteService lineup.
    /// </summary>
    [DataContract]
    public partial class RadioChannel : BroadcastChannel, IRadioChannel, IEquatable<RadioChannel>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "RadioChannel";

        /// <inheritdoc/>
        public bool Equals(RadioChannel other)
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
        public override bool Equals(object obj) => this.Equals(obj as RadioChannel);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
