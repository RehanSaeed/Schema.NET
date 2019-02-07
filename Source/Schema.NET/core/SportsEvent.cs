namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// Event type: Sports event.
    /// </summary>
    [DataContract]
    public partial class SportsEvent : Event
    {
        public interface IAwayTeam : IValue {}
        public interface IAwayTeam<T> : IAwayTeam { new T Value { get; } }
        public class OneOrManyAwayTeam : OneOrMany<IAwayTeam>
        {
            public OneOrManyAwayTeam(IAwayTeam item) : base(item) { }
            public OneOrManyAwayTeam(IEnumerable<IAwayTeam> items) : base(items) { }
            public static implicit operator OneOrManyAwayTeam (Person value) { return new OneOrManyAwayTeam (new AwayTeamPerson (value)); }
            public static implicit operator OneOrManyAwayTeam (Person[] values) { return new OneOrManyAwayTeam (values.Select(v => (IAwayTeam) new AwayTeamPerson (v))); }
            public static implicit operator OneOrManyAwayTeam (List<Person> values) { return new OneOrManyAwayTeam (values.Select(v => (IAwayTeam) new AwayTeamPerson (v))); }
            public static implicit operator OneOrManyAwayTeam (SportsTeam value) { return new OneOrManyAwayTeam (new AwayTeamSportsTeam (value)); }
            public static implicit operator OneOrManyAwayTeam (SportsTeam[] values) { return new OneOrManyAwayTeam (values.Select(v => (IAwayTeam) new AwayTeamSportsTeam (v))); }
            public static implicit operator OneOrManyAwayTeam (List<SportsTeam> values) { return new OneOrManyAwayTeam (values.Select(v => (IAwayTeam) new AwayTeamSportsTeam (v))); }
        }
        public struct AwayTeamPerson : IAwayTeam<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public AwayTeamPerson (Person value) { Value = value; }
            public static implicit operator AwayTeamPerson (Person value) { return new AwayTeamPerson (value); }
        }
        public struct AwayTeamSportsTeam : IAwayTeam<SportsTeam>
        {
            object IValue.Value => this.Value;
            public SportsTeam Value { get; }
            public AwayTeamSportsTeam (SportsTeam value) { Value = value; }
            public static implicit operator AwayTeamSportsTeam (SportsTeam value) { return new AwayTeamSportsTeam (value); }
        }

        public interface ICompetitor : IValue {}
        public interface ICompetitor<T> : ICompetitor { new T Value { get; } }
        public class OneOrManyCompetitor : OneOrMany<ICompetitor>
        {
            public OneOrManyCompetitor(ICompetitor item) : base(item) { }
            public OneOrManyCompetitor(IEnumerable<ICompetitor> items) : base(items) { }
            public static implicit operator OneOrManyCompetitor (Person value) { return new OneOrManyCompetitor (new CompetitorPerson (value)); }
            public static implicit operator OneOrManyCompetitor (Person[] values) { return new OneOrManyCompetitor (values.Select(v => (ICompetitor) new CompetitorPerson (v))); }
            public static implicit operator OneOrManyCompetitor (List<Person> values) { return new OneOrManyCompetitor (values.Select(v => (ICompetitor) new CompetitorPerson (v))); }
            public static implicit operator OneOrManyCompetitor (SportsTeam value) { return new OneOrManyCompetitor (new CompetitorSportsTeam (value)); }
            public static implicit operator OneOrManyCompetitor (SportsTeam[] values) { return new OneOrManyCompetitor (values.Select(v => (ICompetitor) new CompetitorSportsTeam (v))); }
            public static implicit operator OneOrManyCompetitor (List<SportsTeam> values) { return new OneOrManyCompetitor (values.Select(v => (ICompetitor) new CompetitorSportsTeam (v))); }
        }
        public struct CompetitorPerson : ICompetitor<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public CompetitorPerson (Person value) { Value = value; }
            public static implicit operator CompetitorPerson (Person value) { return new CompetitorPerson (value); }
        }
        public struct CompetitorSportsTeam : ICompetitor<SportsTeam>
        {
            object IValue.Value => this.Value;
            public SportsTeam Value { get; }
            public CompetitorSportsTeam (SportsTeam value) { Value = value; }
            public static implicit operator CompetitorSportsTeam (SportsTeam value) { return new CompetitorSportsTeam (value); }
        }

        public interface IHomeTeam : IValue {}
        public interface IHomeTeam<T> : IHomeTeam { new T Value { get; } }
        public class OneOrManyHomeTeam : OneOrMany<IHomeTeam>
        {
            public OneOrManyHomeTeam(IHomeTeam item) : base(item) { }
            public OneOrManyHomeTeam(IEnumerable<IHomeTeam> items) : base(items) { }
            public static implicit operator OneOrManyHomeTeam (Person value) { return new OneOrManyHomeTeam (new HomeTeamPerson (value)); }
            public static implicit operator OneOrManyHomeTeam (Person[] values) { return new OneOrManyHomeTeam (values.Select(v => (IHomeTeam) new HomeTeamPerson (v))); }
            public static implicit operator OneOrManyHomeTeam (List<Person> values) { return new OneOrManyHomeTeam (values.Select(v => (IHomeTeam) new HomeTeamPerson (v))); }
            public static implicit operator OneOrManyHomeTeam (SportsTeam value) { return new OneOrManyHomeTeam (new HomeTeamSportsTeam (value)); }
            public static implicit operator OneOrManyHomeTeam (SportsTeam[] values) { return new OneOrManyHomeTeam (values.Select(v => (IHomeTeam) new HomeTeamSportsTeam (v))); }
            public static implicit operator OneOrManyHomeTeam (List<SportsTeam> values) { return new OneOrManyHomeTeam (values.Select(v => (IHomeTeam) new HomeTeamSportsTeam (v))); }
        }
        public struct HomeTeamPerson : IHomeTeam<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public HomeTeamPerson (Person value) { Value = value; }
            public static implicit operator HomeTeamPerson (Person value) { return new HomeTeamPerson (value); }
        }
        public struct HomeTeamSportsTeam : IHomeTeam<SportsTeam>
        {
            object IValue.Value => this.Value;
            public SportsTeam Value { get; }
            public HomeTeamSportsTeam (SportsTeam value) { Value = value; }
            public static implicit operator HomeTeamSportsTeam (SportsTeam value) { return new HomeTeamSportsTeam (value); }
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
        public OneOrManyAwayTeam AwayTeam { get; set; }

        /// <summary>
        /// A competitor in a sports event.
        /// </summary>
        [DataMember(Name = "competitor", Order = 207)]
        public OneOrManyCompetitor Competitor { get; set; }

        /// <summary>
        /// The home team in a sports event.
        /// </summary>
        [DataMember(Name = "homeTeam", Order = 208)]
        public OneOrManyHomeTeam HomeTeam { get; set; }
    }
}
