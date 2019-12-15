﻿namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A unique instance of a BroadcastService on a CableOrSatelliteService lineup.
    /// </summary>
    public partial interface IBroadcastChannel : IIntangible
    {
        /// <summary>
        /// The unique address by which the BroadcastService can be identified in a provider lineup. In US, this is typically a number.
        /// </summary>
        OneOrMany<string> BroadcastChannelId { get; set; }

        /// <summary>
        /// The frequency used for over-the-air broadcasts. Numeric values or simple ranges e.g. 87-99. In addition a shortcut idiom is supported for frequences of AM and FM radio channels, e.g. "87 FM".
        /// </summary>
        Values<IBroadcastFrequencySpecification, string> BroadcastFrequency { get; set; }

        /// <summary>
        /// The type of service required to have access to the channel (e.g. Standard or Premium).
        /// </summary>
        OneOrMany<string> BroadcastServiceTier { get; set; }

        /// <summary>
        /// Genre of the creative work, broadcast channel or group.
        /// </summary>
        Values<string, Uri> Genre { get; set; }

        /// <summary>
        /// The CableOrSatelliteService offering the channel.
        /// </summary>
        OneOrMany<ICableOrSatelliteService> InBroadcastLineup { get; set; }

        /// <summary>
        /// The BroadcastService offered on this channel.
        /// </summary>
        OneOrMany<IBroadcastService> ProvidesBroadcastService { get; set; }
    }

    /// <summary>
    /// A unique instance of a BroadcastService on a CableOrSatelliteService lineup.
    /// </summary>
    [DataContract]
    public partial class BroadcastChannel : Intangible, IBroadcastChannel, IEquatable<BroadcastChannel>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BroadcastChannel";

        /// <summary>
        /// The unique address by which the BroadcastService can be identified in a provider lineup. In US, this is typically a number.
        /// </summary>
        [DataMember(Name = "broadcastChannelId", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> BroadcastChannelId { get; set; }

        /// <summary>
        /// The frequency used for over-the-air broadcasts. Numeric values or simple ranges e.g. 87-99. In addition a shortcut idiom is supported for frequences of AM and FM radio channels, e.g. "87 FM".
        /// </summary>
        [DataMember(Name = "broadcastFrequency", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IBroadcastFrequencySpecification, string> BroadcastFrequency { get; set; }

        /// <summary>
        /// The type of service required to have access to the channel (e.g. Standard or Premium).
        /// </summary>
        [DataMember(Name = "broadcastServiceTier", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> BroadcastServiceTier { get; set; }

        /// <summary>
        /// Genre of the creative work, broadcast channel or group.
        /// </summary>
        [DataMember(Name = "genre", Order = 209)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> Genre { get; set; }

        /// <summary>
        /// The CableOrSatelliteService offering the channel.
        /// </summary>
        [DataMember(Name = "inBroadcastLineup", Order = 210)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ICableOrSatelliteService> InBroadcastLineup { get; set; }

        /// <summary>
        /// The BroadcastService offered on this channel.
        /// </summary>
        [DataMember(Name = "providesBroadcastService", Order = 211)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IBroadcastService> ProvidesBroadcastService { get; set; }

        /// <inheritdoc/>
        public bool Equals(BroadcastChannel other)
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
                this.BroadcastChannelId == other.BroadcastChannelId &&
                this.BroadcastFrequency == other.BroadcastFrequency &&
                this.BroadcastServiceTier == other.BroadcastServiceTier &&
                this.Genre == other.Genre &&
                this.InBroadcastLineup == other.InBroadcastLineup &&
                this.ProvidesBroadcastService == other.ProvidesBroadcastService &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as BroadcastChannel);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.BroadcastChannelId)
            .And(this.BroadcastFrequency)
            .And(this.BroadcastServiceTier)
            .And(this.Genre)
            .And(this.InBroadcastLineup)
            .And(this.ProvidesBroadcastService)
            .And(base.GetHashCode());
    }
}
