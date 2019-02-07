namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of achieving victory in a competitive activity.
    /// </summary>
    [DataContract]
    public partial class WinAction : AchieveAction
    {
        public interface ILoser : IValue {}
        public interface ILoser<T> : ILoser { new T Value { get; } }
        public class OneOrManyLoser : OneOrMany<ILoser>
        {
            public OneOrManyLoser(ILoser item) : base(item) { }
            public OneOrManyLoser(IEnumerable<ILoser> items) : base(items) { }
            public static implicit operator OneOrManyLoser (Person value) { return new OneOrManyLoser (new LoserPerson (value)); }
            public static implicit operator OneOrManyLoser (Person[] values) { return new OneOrManyLoser (values.Select(v => (ILoser) new LoserPerson (v))); }
            public static implicit operator OneOrManyLoser (List<Person> values) { return new OneOrManyLoser (values.Select(v => (ILoser) new LoserPerson (v))); }
        }
        public struct LoserPerson : ILoser<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public LoserPerson (Person value) { Value = value; }
            public static implicit operator LoserPerson (Person value) { return new LoserPerson (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "WinAction";

        /// <summary>
        /// A sub property of participant. The loser of the action.
        /// </summary>
        [DataMember(Name = "loser", Order = 306)]
        public OneOrManyLoser Loser { get; set; }
    }
}
