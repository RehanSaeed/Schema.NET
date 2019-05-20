namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// CreativeWorkSeries dedicated to TV broadcast and associated online delivery.
    /// </summary>
    public partial interface ITVSeries : ICreativeWorkSeries
    {
        /// <summary>
        /// An actor, e.g. in tv, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        OneOrMany<IPerson>? Actor { get; set; }

        /// <summary>
        /// A season that is part of the media series.
        /// </summary>
        OneOrMany<ICreativeWorkSeason>? ContainsSeason { get; set; }

        /// <summary>
        /// The country of the principal offices of the production company or individual responsible for the movie or program.
        /// </summary>
        OneOrMany<ICountry>? CountryOfOrigin { get; set; }

        /// <summary>
        /// A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        OneOrMany<IPerson>? Director { get; set; }

        /// <summary>
        /// An episode of a tv, radio or game media within a series or season.
        /// </summary>
        OneOrMany<IEpisode>? Episode { get; set; }

        /// <summary>
        /// The composer of the soundtrack.
        /// </summary>
        Values<IMusicGroup, IPerson>? MusicBy { get; set; }

        /// <summary>
        /// The number of episodes in this season or series.
        /// </summary>
        OneOrMany<int?>? NumberOfEpisodes { get; set; }

        /// <summary>
        /// The number of seasons in this series.
        /// </summary>
        OneOrMany<int?>? NumberOfSeasons { get; set; }

        /// <summary>
        /// The production company or studio responsible for the item e.g. series, video game, episode etc.
        /// </summary>
        OneOrMany<IOrganization>? ProductionCompany { get; set; }

        /// <summary>
        /// The trailer of a movie or tv/radio series, season, episode, etc.
        /// </summary>
        OneOrMany<IVideoObject>? Trailer { get; set; }
    }

    /// <summary>
    /// CreativeWorkSeries dedicated to TV broadcast and associated online delivery.
    /// </summary>
    [DataContract]
    public partial class TVSeries : CreativeWorkSeries, ITVSeries
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TVSeries";

        /// <summary>
        /// An actor, e.g. in tv, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "actor", Order = 406)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IPerson>? Actor { get; set; }

        /// <summary>
        /// A season that is part of the media series.
        /// </summary>
        [DataMember(Name = "containsSeason", Order = 407)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<ICreativeWorkSeason>? ContainsSeason { get; set; }

        /// <summary>
        /// The country of the principal offices of the production company or individual responsible for the movie or program.
        /// </summary>
        [DataMember(Name = "countryOfOrigin", Order = 408)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<ICountry>? CountryOfOrigin { get; set; }

        /// <summary>
        /// A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "director", Order = 409)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IPerson>? Director { get; set; }

        /// <summary>
        /// An episode of a tv, radio or game media within a series or season.
        /// </summary>
        [DataMember(Name = "episode", Order = 410)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IEpisode>? Episode { get; set; }

        /// <summary>
        /// The composer of the soundtrack.
        /// </summary>
        [DataMember(Name = "musicBy", Order = 411)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IMusicGroup, IPerson>? MusicBy { get; set; }

        /// <summary>
        /// The number of episodes in this season or series.
        /// </summary>
        [DataMember(Name = "numberOfEpisodes", Order = 412)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<int?>? NumberOfEpisodes { get; set; }

        /// <summary>
        /// The number of seasons in this series.
        /// </summary>
        [DataMember(Name = "numberOfSeasons", Order = 413)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<int?>? NumberOfSeasons { get; set; }

        /// <summary>
        /// The production company or studio responsible for the item e.g. series, video game, episode etc.
        /// </summary>
        [DataMember(Name = "productionCompany", Order = 414)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IOrganization>? ProductionCompany { get; set; }

        /// <summary>
        /// The trailer of a movie or tv/radio series, season, episode, etc.
        /// </summary>
        [DataMember(Name = "trailer", Order = 415)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IVideoObject>? Trailer { get; set; }
    }
}
