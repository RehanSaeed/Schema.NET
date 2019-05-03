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
        public OneOrMany<Person>? Actor { get; set; }

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
        public OneOrMany<Person>? Director { get; set; }

        /// <summary>
        /// The end time of the clip expressed as the number of seconds from the beginning of the work.
        /// </summary>
        [DataMember(Name = "endOffset", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<double?>? EndOffset { get; set; }

        /// <summary>
        /// The composer of the soundtrack.
        /// </summary>
        [DataMember(Name = "musicBy", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MusicGroup, Person>? MusicBy { get; set; }

        /// <summary>
        /// The episode to which this clip belongs.
        /// </summary>
        [DataMember(Name = "partOfEpisode", Order = 211)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<Episode>? PartOfEpisode { get; set; }

        /// <summary>
        /// The season to which this episode belongs.
        /// </summary>
        [DataMember(Name = "partOfSeason", Order = 212)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<CreativeWorkSeason>? PartOfSeason { get; set; }

        /// <summary>
        /// The series to which this episode or season belongs.
        /// </summary>
        [DataMember(Name = "partOfSeries", Order = 213)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<CreativeWorkSeries>? PartOfSeries { get; set; }

        /// <summary>
        /// The start time of the clip expressed as the number of seconds from the beginning of the work.
        /// </summary>
        [DataMember(Name = "startOffset", Order = 214)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<double?>? StartOffset { get; set; }
    }
}
