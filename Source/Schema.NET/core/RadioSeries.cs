namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// CreativeWorkSeries dedicated to radio broadcast and associated online delivery.
    /// </summary>
    public partial interface IRadioSeries : ICreativeWorkSeries
    {
        /// <summary>
        /// An actor, e.g. in tv, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        OneOrMany<IPerson> Actor { get; set; }

        /// <summary>
        /// A season that is part of the media series.
        /// </summary>
        OneOrMany<ICreativeWorkSeason> ContainsSeason { get; set; }

        /// <summary>
        /// A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        OneOrMany<IPerson> Director { get; set; }

        /// <summary>
        /// An episode of a tv, radio or game media within a series or season.
        /// </summary>
        OneOrMany<IEpisode> Episode { get; set; }

        /// <summary>
        /// The composer of the soundtrack.
        /// </summary>
        Values<IMusicGroup, IPerson> MusicBy { get; set; }

        /// <summary>
        /// The number of episodes in this season or series.
        /// </summary>
        OneOrMany<int?> NumberOfEpisodes { get; set; }

        /// <summary>
        /// The number of seasons in this series.
        /// </summary>
        OneOrMany<int?> NumberOfSeasons { get; set; }

        /// <summary>
        /// The production company or studio responsible for the item e.g. series, video game, episode etc.
        /// </summary>
        OneOrMany<IOrganization> ProductionCompany { get; set; }

        /// <summary>
        /// The trailer of a movie or tv/radio series, season, episode, etc.
        /// </summary>
        OneOrMany<IVideoObject> Trailer { get; set; }
    }

    /// <summary>
    /// CreativeWorkSeries dedicated to radio broadcast and associated online delivery.
    /// </summary>
    [DataContract]
    public partial class RadioSeries : CreativeWorkSeries, IRadioSeries, IEquatable<RadioSeries>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "RadioSeries";

        /// <summary>
        /// An actor, e.g. in tv, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "actor", Order = 406)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Actor { get; set; }

        /// <summary>
        /// A season that is part of the media series.
        /// </summary>
        [DataMember(Name = "containsSeason", Order = 407)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ICreativeWorkSeason> ContainsSeason { get; set; }

        /// <summary>
        /// A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "director", Order = 408)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Director { get; set; }

        /// <summary>
        /// An episode of a tv, radio or game media within a series or season.
        /// </summary>
        [DataMember(Name = "episode", Order = 409)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IEpisode> Episode { get; set; }

        /// <summary>
        /// The composer of the soundtrack.
        /// </summary>
        [DataMember(Name = "musicBy", Order = 410)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IMusicGroup, IPerson> MusicBy { get; set; }

        /// <summary>
        /// The number of episodes in this season or series.
        /// </summary>
        [DataMember(Name = "numberOfEpisodes", Order = 411)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<int?> NumberOfEpisodes { get; set; }

        /// <summary>
        /// The number of seasons in this series.
        /// </summary>
        [DataMember(Name = "numberOfSeasons", Order = 412)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<int?> NumberOfSeasons { get; set; }

        /// <summary>
        /// The production company or studio responsible for the item e.g. series, video game, episode etc.
        /// </summary>
        [DataMember(Name = "productionCompany", Order = 413)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOrganization> ProductionCompany { get; set; }

        /// <summary>
        /// The trailer of a movie or tv/radio series, season, episode, etc.
        /// </summary>
        [DataMember(Name = "trailer", Order = 414)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IVideoObject> Trailer { get; set; }

        /// <inheritdoc/>
        public bool Equals(RadioSeries other)
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
                this.Actor == other.Actor &&
                this.ContainsSeason == other.ContainsSeason &&
                this.Director == other.Director &&
                this.Episode == other.Episode &&
                this.MusicBy == other.MusicBy &&
                this.NumberOfEpisodes == other.NumberOfEpisodes &&
                this.NumberOfSeasons == other.NumberOfSeasons &&
                this.ProductionCompany == other.ProductionCompany &&
                this.Trailer == other.Trailer &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as RadioSeries);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.Actor)
            .And(this.ContainsSeason)
            .And(this.Director)
            .And(this.Episode)
            .And(this.MusicBy)
            .And(this.NumberOfEpisodes)
            .And(this.NumberOfSeasons)
            .And(this.ProductionCompany)
            .And(this.Trailer)
            .And(base.GetHashCode());
    }
}
