namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A media episode (e.g. TV, radio, video game) which can be part of a series or season.
    /// </summary>
    [DataContract]
    public partial class Episode : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Episode";

        /// <summary>
        /// An actor, e.g. in tv, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "actor", Order = 205)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person>? Actor { get; set; }

        /// <summary>
        /// A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "director", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person>? Director { get; set; }

        /// <summary>
        /// Position of the episode within an ordered group of episodes.
        /// </summary>
        [DataMember(Name = "episodeNumber", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<int?, string>? EpisodeNumber { get; set; }

        /// <summary>
        /// The composer of the soundtrack.
        /// </summary>
        [DataMember(Name = "musicBy", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person, MusicGroup>? MusicBy { get; set; }

        /// <summary>
        /// The season to which this episode belongs.
        /// </summary>
        [DataMember(Name = "partOfSeason", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<CreativeWorkSeason>? PartOfSeason { get; set; }

        /// <summary>
        /// The series to which this episode or season belongs.
        /// </summary>
        [DataMember(Name = "partOfSeries", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<CreativeWorkSeries>? PartOfSeries { get; set; }

        /// <summary>
        /// The production company or studio responsible for the item e.g. series, video game, episode etc.
        /// </summary>
        [DataMember(Name = "productionCompany", Order = 211)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization>? ProductionCompany { get; set; }

        /// <summary>
        /// The trailer of a movie or tv/radio series, season, episode, etc.
        /// </summary>
        [DataMember(Name = "trailer", Order = 212)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<VideoObject>? Trailer { get; set; }
    }
}
