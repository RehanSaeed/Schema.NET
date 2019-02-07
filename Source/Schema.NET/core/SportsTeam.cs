namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// Organization: Sports team.
    /// </summary>
    [DataContract]
    public partial class SportsTeam : SportsOrganization
    {
        public interface IAthlete : IValue {}
        public interface IAthlete<T> : IAthlete { new T Value { get; } }
        public class OneOrManyAthlete : OneOrMany<IAthlete>
        {
            public OneOrManyAthlete(IAthlete item) : base(item) { }
            public OneOrManyAthlete(IEnumerable<IAthlete> items) : base(items) { }
            public static implicit operator OneOrManyAthlete (Person value) { return new OneOrManyAthlete (new AthletePerson (value)); }
            public static implicit operator OneOrManyAthlete (Person[] values) { return new OneOrManyAthlete (values.Select(v => (IAthlete) new AthletePerson (v))); }
            public static implicit operator OneOrManyAthlete (List<Person> values) { return new OneOrManyAthlete (values.Select(v => (IAthlete) new AthletePerson (v))); }
        }
        public struct AthletePerson : IAthlete<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public AthletePerson (Person value) { Value = value; }
            public static implicit operator AthletePerson (Person value) { return new AthletePerson (value); }
        }

        public interface ICoach : IValue {}
        public interface ICoach<T> : ICoach { new T Value { get; } }
        public class OneOrManyCoach : OneOrMany<ICoach>
        {
            public OneOrManyCoach(ICoach item) : base(item) { }
            public OneOrManyCoach(IEnumerable<ICoach> items) : base(items) { }
            public static implicit operator OneOrManyCoach (Person value) { return new OneOrManyCoach (new CoachPerson (value)); }
            public static implicit operator OneOrManyCoach (Person[] values) { return new OneOrManyCoach (values.Select(v => (ICoach) new CoachPerson (v))); }
            public static implicit operator OneOrManyCoach (List<Person> values) { return new OneOrManyCoach (values.Select(v => (ICoach) new CoachPerson (v))); }
        }
        public struct CoachPerson : ICoach<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public CoachPerson (Person value) { Value = value; }
            public static implicit operator CoachPerson (Person value) { return new CoachPerson (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SportsTeam";

        /// <summary>
        /// A person that acts as performing member of a sports team; a player as opposed to a coach.
        /// </summary>
        [DataMember(Name = "athlete", Order = 306)]
        public OneOrManyAthlete Athlete { get; set; }

        /// <summary>
        /// A person that acts in a coaching role for a sports team.
        /// </summary>
        [DataMember(Name = "coach", Order = 307)]
        public OneOrManyCoach Coach { get; set; }
    }
}
