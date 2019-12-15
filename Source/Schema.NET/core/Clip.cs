namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A short TV or radio program or a segment/part of a program.
    /// </summary>
    public partial interface IClip : ICreativeWork
    {
        /// <summary>
        /// An actor, e.g. in tv, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        OneOrMany<IPerson> Actor { get; set; }

        /// <summary>
        /// Position of the clip within an ordered group of clips.
        /// </summary>
        Values<int?, string> ClipNumber { get; set; }

        /// <summary>
        /// A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        OneOrMany<IPerson> Director { get; set; }

        /// <summary>
        /// The end time of the clip expressed as the number of seconds from the beginning of the work.
        /// </summary>
        OneOrMany<double?> EndOffset { get; set; }

        /// <summary>
        /// The composer of the soundtrack.
        /// </summary>
        Values<IMusicGroup, IPerson> MusicBy { get; set; }

        /// <summary>
        /// The episode to which this clip belongs.
        /// </summary>
        OneOrMany<IEpisode> PartOfEpisode { get; set; }

        /// <summary>
        /// The season to which this episode belongs.
        /// </summary>
        OneOrMany<ICreativeWorkSeason> PartOfSeason { get; set; }

        /// <summary>
        /// The series to which this episode or season belongs.
        /// </summary>
        OneOrMany<ICreativeWorkSeries> PartOfSeries { get; set; }

        /// <summary>
        /// The start time of the clip expressed as the number of seconds from the beginning of the work.
        /// </summary>
        OneOrMany<double?> StartOffset { get; set; }
    }

    /// <summary>
    /// A short TV or radio program or a segment/part of a program.
    /// </summary>
    [DataContract]
    public partial class Clip : CreativeWork, IClip, IEquatable<Clip>
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
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Actor { get; set; }

        /// <summary>
        /// Position of the clip within an ordered group of clips.
        /// </summary>
        [DataMember(Name = "clipNumber", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<int?, string> ClipNumber { get; set; }

        /// <summary>
        /// A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "director", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Director { get; set; }

        /// <summary>
        /// The end time of the clip expressed as the number of seconds from the beginning of the work.
        /// </summary>
        [DataMember(Name = "endOffset", Order = 209)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<double?> EndOffset { get; set; }

        /// <summary>
        /// The composer of the soundtrack.
        /// </summary>
        [DataMember(Name = "musicBy", Order = 210)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IMusicGroup, IPerson> MusicBy { get; set; }

        /// <summary>
        /// The episode to which this clip belongs.
        /// </summary>
        [DataMember(Name = "partOfEpisode", Order = 211)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IEpisode> PartOfEpisode { get; set; }

        /// <summary>
        /// The season to which this episode belongs.
        /// </summary>
        [DataMember(Name = "partOfSeason", Order = 212)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ICreativeWorkSeason> PartOfSeason { get; set; }

        /// <summary>
        /// The series to which this episode or season belongs.
        /// </summary>
        [DataMember(Name = "partOfSeries", Order = 213)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ICreativeWorkSeries> PartOfSeries { get; set; }

        /// <summary>
        /// The start time of the clip expressed as the number of seconds from the beginning of the work.
        /// </summary>
        [DataMember(Name = "startOffset", Order = 214)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<double?> StartOffset { get; set; }

        /// <inheritdoc/>
        public bool Equals(Clip other)
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
                this.ClipNumber == other.ClipNumber &&
                this.Director == other.Director &&
                this.EndOffset == other.EndOffset &&
                this.MusicBy == other.MusicBy &&
                this.PartOfEpisode == other.PartOfEpisode &&
                this.PartOfSeason == other.PartOfSeason &&
                this.PartOfSeries == other.PartOfSeries &&
                this.StartOffset == other.StartOffset &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as Clip);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.Actor)
            .And(this.ClipNumber)
            .And(this.Director)
            .And(this.EndOffset)
            .And(this.MusicBy)
            .And(this.PartOfEpisode)
            .And(this.PartOfSeason)
            .And(this.PartOfSeries)
            .And(this.StartOffset)
            .And(base.GetHashCode());
    }
}
