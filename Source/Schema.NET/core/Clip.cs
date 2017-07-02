namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A short TV or radio program or a segment/part of a program.
    /// </summary>
    [DataContract]
    public partial class Clip : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Clip";

        /// <summary>
        /// An actor, e.g. in tv, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "actor", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person>? Actor { get; set; }

        /// <summary>
        /// Position of the clip within an ordered group of clips.
        /// </summary>
        [DataMember(Name = "clipNumber", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<int?, string>? ClipNumber { get; set; }

        /// <summary>
        /// A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "director", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person>? Director { get; set; }

        /// <summary>
        /// The composer of the soundtrack.
        /// </summary>
        [DataMember(Name = "musicBy", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MusicGroup, Person>? MusicBy { get; set; }

        /// <summary>
        /// The episode to which this clip belongs.
        /// </summary>
        [DataMember(Name = "partOfEpisode", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Episode>? PartOfEpisode { get; set; }

        /// <summary>
        /// The season to which this episode belongs.
        /// </summary>
        [DataMember(Name = "partOfSeason", Order = 211)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<CreativeWorkSeason>? PartOfSeason { get; set; }

        /// <summary>
        /// The series to which this episode or season belongs.
        /// </summary>
        [DataMember(Name = "partOfSeries", Order = 212)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<CreativeWorkSeries>? PartOfSeries { get; set; }
    }
}
