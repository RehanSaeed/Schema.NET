namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// An agent approves/certifies/likes/supports/sanction an object.
    /// </summary>
    [DataContract]
    public partial class EndorseAction : ReactAction
    {
        public interface IEndorsee : IValue {}
        public interface IEndorsee<T> : IEndorsee { new T Value { get; } }
        public class OneOrManyEndorsee : OneOrMany<IEndorsee>
        {
            public OneOrManyEndorsee(IEndorsee item) : base(item) { }
            public OneOrManyEndorsee(IEnumerable<IEndorsee> items) : base(items) { }
            public static implicit operator OneOrManyEndorsee (Organization value) { return new OneOrManyEndorsee (new EndorseeOrganization (value)); }
            public static implicit operator OneOrManyEndorsee (Organization[] values) { return new OneOrManyEndorsee (values.Select(v => (IEndorsee) new EndorseeOrganization (v))); }
            public static implicit operator OneOrManyEndorsee (List<Organization> values) { return new OneOrManyEndorsee (values.Select(v => (IEndorsee) new EndorseeOrganization (v))); }
            public static implicit operator OneOrManyEndorsee (Person value) { return new OneOrManyEndorsee (new EndorseePerson (value)); }
            public static implicit operator OneOrManyEndorsee (Person[] values) { return new OneOrManyEndorsee (values.Select(v => (IEndorsee) new EndorseePerson (v))); }
            public static implicit operator OneOrManyEndorsee (List<Person> values) { return new OneOrManyEndorsee (values.Select(v => (IEndorsee) new EndorseePerson (v))); }
        }
        public struct EndorseeOrganization : IEndorsee<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public EndorseeOrganization (Organization value) { Value = value; }
            public static implicit operator EndorseeOrganization (Organization value) { return new EndorseeOrganization (value); }
        }
        public struct EndorseePerson : IEndorsee<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public EndorseePerson (Person value) { Value = value; }
            public static implicit operator EndorseePerson (Person value) { return new EndorseePerson (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "EndorseAction";

        /// <summary>
        /// A sub property of participant. The person/organization being supported.
        /// </summary>
        [DataMember(Name = "endorsee", Order = 406)]
        public OneOrManyEndorsee Endorsee { get; set; }
    }
}
