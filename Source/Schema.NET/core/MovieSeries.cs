namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A series of movies. Included movies can be indicated with the hasPart property.
    /// </summary>
    public partial interface IMovieSeries : ICreativeWorkSeries
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
        /// The composer of the soundtrack.
        /// </summary>
        Values<IMusicGroup, IPerson> MusicBy { get; set; }

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
    /// A series of movies. Included movies can be indicated with the hasPart property.
    /// </summary>
    [DataContract]
    public partial class MovieSeries : CreativeWorkSeries, IMovieSeries, IEquatable<MovieSeries>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MovieSeries";

        /// <summary>
        /// An actor, e.g. in tv, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "actor", Order = 406)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Actor { get; set; }

        /// <summary>
        /// A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "director", Order = 407)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Director { get; set; }

        /// <summary>
        /// The composer of the soundtrack.
        /// </summary>
        [DataMember(Name = "musicBy", Order = 408)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IMusicGroup, IPerson> MusicBy { get; set; }

        /// <summary>
        /// The production company or studio responsible for the item e.g. series, video game, episode etc.
        /// </summary>
        [DataMember(Name = "productionCompany", Order = 409)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOrganization> ProductionCompany { get; set; }

        /// <summary>
        /// The trailer of a movie or tv/radio series, season, episode, etc.
        /// </summary>
        [DataMember(Name = "trailer", Order = 410)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IVideoObject> Trailer { get; set; }

        /// <inheritdoc/>
        public bool Equals(MovieSeries other)
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
                this.Director == other.Director &&
                this.MusicBy == other.MusicBy &&
                this.ProductionCompany == other.ProductionCompany &&
                this.Trailer == other.Trailer &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as MovieSeries);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.Actor)
            .And(this.Director)
            .And(this.MusicBy)
            .And(this.ProductionCompany)
            .And(this.Trailer)
            .And(base.GetHashCode());
    }
}
