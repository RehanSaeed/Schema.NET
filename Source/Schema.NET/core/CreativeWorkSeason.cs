namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A media season e.g. tv, radio, video game etc.
    /// </summary>
    public partial interface ICreativeWorkSeason : ICreativeWork
    {
        /// <summary>
        /// An actor, e.g. in tv, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        OneOrMany<IPerson> Actor { get; set; }

        /// <summary>
        /// A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        OneOrMany<IPerson> Director { get; set; }

        /// <summary>
        /// An episode of a tv, radio or game media within a series or season.
        /// </summary>
        OneOrMany<IEpisode> Episode { get; set; }

        /// <summary>
        /// The number of episodes in this season or series.
        /// </summary>
        OneOrMany<int?> NumberOfEpisodes { get; set; }

        /// <summary>
        /// The series to which this episode or season belongs.
        /// </summary>
        OneOrMany<ICreativeWorkSeries> PartOfSeries { get; set; }

        /// <summary>
        /// The production company or studio responsible for the item e.g. series, video game, episode etc.
        /// </summary>
        OneOrMany<IOrganization> ProductionCompany { get; set; }

        /// <summary>
        /// Position of the season within an ordered group of seasons.
        /// </summary>
        Values<int?, string>? SeasonNumber { get; set; }

        /// <summary>
        /// The start date and time of the item (in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;).
        /// </summary>
        Values<int?, DateTime?, DateTimeOffset?>? StartDate { get; set; }

        /// <summary>
        /// The end date and time of the item (in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;).
        /// </summary>
        Values<int?, DateTime?, DateTimeOffset?>? EndDate { get; set; }

        /// <summary>
        /// The trailer of a movie or tv/radio series, season, episode, etc.
        /// </summary>
        OneOrMany<IVideoObject> Trailer { get; set; }
    }

    /// <summary>
    /// A media season e.g. tv, radio, video game etc.
    /// </summary>
    [DataContract]
    public partial class CreativeWorkSeason : CreativeWork, ICreativeWorkSeason
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "CreativeWorkSeason";

        /// <summary>
        /// An actor, e.g. in tv, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "actor", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Actor { get; set; }

        /// <summary>
        /// A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "director", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Director { get; set; }

        /// <summary>
        /// An episode of a tv, radio or game media within a series or season.
        /// </summary>
        [DataMember(Name = "episode", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IEpisode> Episode { get; set; }

        /// <summary>
        /// The number of episodes in this season or series.
        /// </summary>
        [DataMember(Name = "numberOfEpisodes", Order = 209)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<int?> NumberOfEpisodes { get; set; }

        /// <summary>
        /// The series to which this episode or season belongs.
        /// </summary>
        [DataMember(Name = "partOfSeries", Order = 210)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ICreativeWorkSeries> PartOfSeries { get; set; }

        /// <summary>
        /// The production company or studio responsible for the item e.g. series, video game, episode etc.
        /// </summary>
        [DataMember(Name = "productionCompany", Order = 211)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOrganization> ProductionCompany { get; set; }

        /// <summary>
        /// Position of the season within an ordered group of seasons.
        /// </summary>
        [DataMember(Name = "seasonNumber", Order = 212)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<int?, string>? SeasonNumber { get; set; }

        /// <summary>
        /// The start date and time of the item (in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "startDate", Order = 213)]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?, DateTimeOffset?>? StartDate { get; set; }

        /// <summary>
        /// The end date and time of the item (in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "endDate", Order = 214)]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?, DateTimeOffset?>? EndDate { get; set; }

        /// <summary>
        /// The trailer of a movie or tv/radio series, season, episode, etc.
        /// </summary>
        [DataMember(Name = "trailer", Order = 215)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IVideoObject> Trailer { get; set; }
    }
}
