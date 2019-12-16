namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Event type: Sports event.
    /// </summary>
    public partial interface ISportsEvent : IEvent
    {
        /// <summary>
        /// The away team in a sports event.
        /// </summary>
        Values<IPerson, ISportsTeam> AwayTeam { get; set; }

        /// <summary>
        /// A competitor in a sports event.
        /// </summary>
        Values<IPerson, ISportsTeam> Competitor { get; set; }

        /// <summary>
        /// The home team in a sports event.
        /// </summary>
        Values<IPerson, ISportsTeam> HomeTeam { get; set; }
    }

    /// <summary>
    /// Event type: Sports event.
    /// </summary>
    [DataContract]
    public partial class SportsEvent : Event, ISportsEvent, IEquatable<SportsEvent>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SportsEvent";

        /// <summary>
        /// The away team in a sports event.
        /// </summary>
        [DataMember(Name = "awayTeam", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IPerson, ISportsTeam> AwayTeam { get; set; }

        /// <summary>
        /// A competitor in a sports event.
        /// </summary>
        [DataMember(Name = "competitor", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IPerson, ISportsTeam> Competitor { get; set; }

        /// <summary>
        /// The home team in a sports event.
        /// </summary>
        [DataMember(Name = "homeTeam", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IPerson, ISportsTeam> HomeTeam { get; set; }

        /// <inheritdoc/>
        public bool Equals(SportsEvent other)
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
                this.AwayTeam == other.AwayTeam &&
                this.Competitor == other.Competitor &&
                this.HomeTeam == other.HomeTeam &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as SportsEvent);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.AwayTeam)
            .And(this.Competitor)
            .And(this.HomeTeam)
            .And(base.GetHashCode());
    }
}
