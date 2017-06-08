namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// CreativeWorkSeries dedicated to TV broadcast and associated online delivery.
    /// </summary>
    [DataContract]
    public class TVSeries : CreativeWorkSeries
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "TVSeries";

        /// <summary>
        /// An actor, e.g. in tv, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "actor")]
        public Person Actor { get; set; }

        /// <summary>
        /// The number of episodes in this season or series.
        /// </summary>
        [DataMember(Name = "numberOfEpisodes")]
        public int NumberOfEpisodes { get; set; }

        /// <summary>
        /// The trailer of a movie or tv/radio series, season, episode, etc.
        /// </summary>
        [DataMember(Name = "trailer")]
        public VideoObject Trailer { get; set; }

        /// <summary>
        /// The country of the principal offices of the production company or individual responsible for the movie or program.
        /// </summary>
        [DataMember(Name = "countryOfOrigin")]
        public Country CountryOfOrigin { get; set; }

        /// <summary>
        /// The composer of the soundtrack.
        /// </summary>
        [DataMember(Name = "musicBy")]
        public object MusicBy { get; protected set; }

        /// <summary>
        /// The composer of the soundtrack.
        /// </summary>
        [IgnoreDataMember]
        public Person MusicByPerson
        {
            get => this.MusicBy as Person;
            set => this.MusicBy = value;
        }

        /// <summary>
        /// The composer of the soundtrack.
        /// </summary>
        [IgnoreDataMember]
        public MusicGroup MusicByMusicGroup
        {
            get => this.MusicBy as MusicGroup;
            set => this.MusicBy = value;
        }

        /// <summary>
        /// A season that is part of the media series.
        /// </summary>
        [DataMember(Name = "containsSeason")]
        public CreativeWorkSeason ContainsSeason { get; set; }

        /// <summary>
        /// The number of seasons in this series.
        /// </summary>
        [DataMember(Name = "numberOfSeasons")]
        public int NumberOfSeasons { get; set; }

        /// <summary>
        /// A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "director")]
        public Person Director { get; set; }

        /// <summary>
        /// The production company or studio responsible for the item e.g. series, video game, episode etc.
        /// </summary>
        [DataMember(Name = "productionCompany")]
        public Organization ProductionCompany { get; set; }

        /// <summary>
        /// An episode of a tv, radio or game media within a series or season.
        /// </summary>
        [DataMember(Name = "episode")]
        public Episode Episode { get; set; }
    }
}
