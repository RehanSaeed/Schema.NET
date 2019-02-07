namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of expressing a preference from a fixed/finite/structured set of choices/options.
    /// </summary>
    [DataContract]
    public partial class VoteAction : ChooseAction
    {
        public interface ICandidate : IValue {}
        public interface ICandidate<T> : ICandidate { new T Value { get; } }
        public class OneOrManyCandidate : OneOrMany<ICandidate>
        {
            public OneOrManyCandidate(ICandidate item) : base(item) { }
            public OneOrManyCandidate(IEnumerable<ICandidate> items) : base(items) { }
            public static implicit operator OneOrManyCandidate (Person value) { return new OneOrManyCandidate (new CandidatePerson (value)); }
            public static implicit operator OneOrManyCandidate (Person[] values) { return new OneOrManyCandidate (values.Select(v => (ICandidate) new CandidatePerson (v))); }
            public static implicit operator OneOrManyCandidate (List<Person> values) { return new OneOrManyCandidate (values.Select(v => (ICandidate) new CandidatePerson (v))); }
        }
        public struct CandidatePerson : ICandidate<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public CandidatePerson (Person value) { Value = value; }
            public static implicit operator CandidatePerson (Person value) { return new CandidatePerson (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "VoteAction";

        /// <summary>
        /// A sub property of object. The candidate subject of this action.
        /// </summary>
        [DataMember(Name = "candidate", Order = 406)]
        public OneOrManyCandidate Candidate { get; set; }
    }
}
