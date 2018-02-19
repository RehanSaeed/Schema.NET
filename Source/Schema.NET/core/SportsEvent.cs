using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// Event type: Sports event.
    /// </summary>
    [DataContract]
    public partial class SportsEvent : Event
    {
        public interface IAwayTeam : IWrapper { }
        public interface IAwayTeam<T> : IAwayTeam { new T Data { get; set; } }
        public class AwayTeamPerson : IAwayTeam<Person>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Person) value; } }
            public virtual Person Data { get; set; }
            public AwayTeamPerson () { }
            public AwayTeamPerson (Person data) { Data = data; }
            public static implicit operator AwayTeamPerson (Person data) { return new AwayTeamPerson (data); }
        }

        public class AwayTeamSportsTeam : IAwayTeam<SportsTeam>
        {
            object IWrapper.Data { get { return Data; } set { Data = (SportsTeam) value; } }
            public virtual SportsTeam Data { get; set; }
            public AwayTeamSportsTeam () { }
            public AwayTeamSportsTeam (SportsTeam data) { Data = data; }
            public static implicit operator AwayTeamSportsTeam (SportsTeam data) { return new AwayTeamSportsTeam (data); }
        }


        public interface ICompetitor : IWrapper { }
        public interface ICompetitor<T> : ICompetitor { new T Data { get; set; } }
        public class CompetitorPerson : ICompetitor<Person>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Person) value; } }
            public virtual Person Data { get; set; }
            public CompetitorPerson () { }
            public CompetitorPerson (Person data) { Data = data; }
            public static implicit operator CompetitorPerson (Person data) { return new CompetitorPerson (data); }
        }

        public class CompetitorSportsTeam : ICompetitor<SportsTeam>
        {
            object IWrapper.Data { get { return Data; } set { Data = (SportsTeam) value; } }
            public virtual SportsTeam Data { get; set; }
            public CompetitorSportsTeam () { }
            public CompetitorSportsTeam (SportsTeam data) { Data = data; }
            public static implicit operator CompetitorSportsTeam (SportsTeam data) { return new CompetitorSportsTeam (data); }
        }


        public interface IHomeTeam : IWrapper { }
        public interface IHomeTeam<T> : IHomeTeam { new T Data { get; set; } }
        public class HomeTeamPerson : IHomeTeam<Person>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Person) value; } }
            public virtual Person Data { get; set; }
            public HomeTeamPerson () { }
            public HomeTeamPerson (Person data) { Data = data; }
            public static implicit operator HomeTeamPerson (Person data) { return new HomeTeamPerson (data); }
        }

        public class HomeTeamSportsTeam : IHomeTeam<SportsTeam>
        {
            object IWrapper.Data { get { return Data; } set { Data = (SportsTeam) value; } }
            public virtual SportsTeam Data { get; set; }
            public HomeTeamSportsTeam () { }
            public HomeTeamSportsTeam (SportsTeam data) { Data = data; }
            public static implicit operator HomeTeamSportsTeam (SportsTeam data) { return new HomeTeamSportsTeam (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SportsEvent";

        /// <summary>
        /// The away team in a sports event.
        /// </summary>
        [DataMember(Name = "awayTeam", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IAwayTeam>? AwayTeam { get; set; } //Person, SportsTeam

        /// <summary>
        /// A competitor in a sports event.
        /// </summary>
        [DataMember(Name = "competitor", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ICompetitor>? Competitor { get; set; } //Person, SportsTeam

        /// <summary>
        /// The home team in a sports event.
        /// </summary>
        [DataMember(Name = "homeTeam", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IHomeTeam>? HomeTeam { get; set; } //Person, SportsTeam
    }
}
