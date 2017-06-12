namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Event type: Sports event.
    /// </summary>
    [DataContract]
    public partial class SportsEvent : Event
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SportsEvent";

        /// <summary>
        /// The away team in a sports event.
        /// </summary>
        [DataMember(Name = "awayTeam", Order = 2)]
        public object AwayTeam { get; protected set; }

        /// <summary>
        /// The away team in a sports event.
        /// </summary>
        [IgnoreDataMember]
        public SportsTeam AwayTeamSportsTeam
        {
            get => this.AwayTeam as SportsTeam;
            set => this.AwayTeam = value;
        }

        /// <summary>
        /// The away team in a sports event.
        /// </summary>
        [IgnoreDataMember]
        public Person AwayTeamPerson
        {
            get => this.AwayTeam as Person;
            set => this.AwayTeam = value;
        }

        /// <summary>
        /// A competitor in a sports event.
        /// </summary>
        [DataMember(Name = "competitor", Order = 3)]
        public object Competitor { get; protected set; }

        /// <summary>
        /// A competitor in a sports event.
        /// </summary>
        [IgnoreDataMember]
        public Person CompetitorPerson
        {
            get => this.Competitor as Person;
            set => this.Competitor = value;
        }

        /// <summary>
        /// A competitor in a sports event.
        /// </summary>
        [IgnoreDataMember]
        public SportsTeam CompetitorSportsTeam
        {
            get => this.Competitor as SportsTeam;
            set => this.Competitor = value;
        }

        /// <summary>
        /// The home team in a sports event.
        /// </summary>
        [DataMember(Name = "homeTeam", Order = 4)]
        public object HomeTeam { get; protected set; }

        /// <summary>
        /// The home team in a sports event.
        /// </summary>
        [IgnoreDataMember]
        public Person HomeTeamPerson
        {
            get => this.HomeTeam as Person;
            set => this.HomeTeam = value;
        }

        /// <summary>
        /// The home team in a sports event.
        /// </summary>
        [IgnoreDataMember]
        public SportsTeam HomeTeamSportsTeam
        {
            get => this.HomeTeam as SportsTeam;
            set => this.HomeTeam = value;
        }
    }
}
