namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A musical composition.
    /// </summary>
    public partial interface IMusicComposition : ICreativeWork
    {
        /// <summary>
        /// The person or organization who wrote a composition, or who is the composer of a work performed at some event.
        /// </summary>
        Values<IOrganization, IPerson> Composer { get; set; }

        /// <summary>
        /// The date and place the work was first performed.
        /// </summary>
        OneOrMany<IEvent> FirstPerformance { get; set; }

        /// <summary>
        /// Smaller compositions included in this work (e.g. a movement in a symphony).
        /// </summary>
        OneOrMany<IMusicComposition> IncludedComposition { get; set; }

        /// <summary>
        /// The International Standard Musical Work Code for the composition.
        /// </summary>
        OneOrMany<string> IswcCode { get; set; }

        /// <summary>
        /// The person who wrote the words.
        /// </summary>
        OneOrMany<IPerson> Lyricist { get; set; }

        /// <summary>
        /// The words in the song.
        /// </summary>
        OneOrMany<ICreativeWork> Lyrics { get; set; }

        /// <summary>
        /// The key, mode, or scale this composition uses.
        /// </summary>
        OneOrMany<string> MusicalKey { get; set; }

        /// <summary>
        /// An arrangement derived from the composition.
        /// </summary>
        OneOrMany<IMusicComposition> MusicArrangement { get; set; }

        /// <summary>
        /// The type of composition (e.g. overture, sonata, symphony, etc.).
        /// </summary>
        OneOrMany<string> MusicCompositionForm { get; set; }

        /// <summary>
        /// An audio recording of the work.
        /// </summary>
        OneOrMany<IMusicRecording> RecordedAs { get; set; }
    }

    /// <summary>
    /// A musical composition.
    /// </summary>
    [DataContract]
    public partial class MusicComposition : CreativeWork, IMusicComposition, IEquatable<MusicComposition>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MusicComposition";

        /// <summary>
        /// The person or organization who wrote a composition, or who is the composer of a work performed at some event.
        /// </summary>
        [DataMember(Name = "composer", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Composer { get; set; }

        /// <summary>
        /// The date and place the work was first performed.
        /// </summary>
        [DataMember(Name = "firstPerformance", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IEvent> FirstPerformance { get; set; }

        /// <summary>
        /// Smaller compositions included in this work (e.g. a movement in a symphony).
        /// </summary>
        [DataMember(Name = "includedComposition", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMusicComposition> IncludedComposition { get; set; }

        /// <summary>
        /// The International Standard Musical Work Code for the composition.
        /// </summary>
        [DataMember(Name = "iswcCode", Order = 209)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> IswcCode { get; set; }

        /// <summary>
        /// The person who wrote the words.
        /// </summary>
        [DataMember(Name = "lyricist", Order = 210)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Lyricist { get; set; }

        /// <summary>
        /// The words in the song.
        /// </summary>
        [DataMember(Name = "lyrics", Order = 211)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ICreativeWork> Lyrics { get; set; }

        /// <summary>
        /// The key, mode, or scale this composition uses.
        /// </summary>
        [DataMember(Name = "musicalKey", Order = 212)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> MusicalKey { get; set; }

        /// <summary>
        /// An arrangement derived from the composition.
        /// </summary>
        [DataMember(Name = "musicArrangement", Order = 213)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMusicComposition> MusicArrangement { get; set; }

        /// <summary>
        /// The type of composition (e.g. overture, sonata, symphony, etc.).
        /// </summary>
        [DataMember(Name = "musicCompositionForm", Order = 214)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> MusicCompositionForm { get; set; }

        /// <summary>
        /// An audio recording of the work.
        /// </summary>
        [DataMember(Name = "recordedAs", Order = 215)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMusicRecording> RecordedAs { get; set; }

        /// <inheritdoc/>
        public bool Equals(MusicComposition other)
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
                this.Composer == other.Composer &&
                this.FirstPerformance == other.FirstPerformance &&
                this.IncludedComposition == other.IncludedComposition &&
                this.IswcCode == other.IswcCode &&
                this.Lyricist == other.Lyricist &&
                this.Lyrics == other.Lyrics &&
                this.MusicalKey == other.MusicalKey &&
                this.MusicArrangement == other.MusicArrangement &&
                this.MusicCompositionForm == other.MusicCompositionForm &&
                this.RecordedAs == other.RecordedAs &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as MusicComposition);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.Composer)
            .And(this.FirstPerformance)
            .And(this.IncludedComposition)
            .And(this.IswcCode)
            .And(this.Lyricist)
            .And(this.Lyrics)
            .And(this.MusicalKey)
            .And(this.MusicArrangement)
            .And(this.MusicCompositionForm)
            .And(this.RecordedAs)
            .And(base.GetHashCode());
    }
}
