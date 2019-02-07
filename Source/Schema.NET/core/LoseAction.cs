namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of being defeated in a competitive activity.
    /// </summary>
    [DataContract]
    public partial class LoseAction : AchieveAction
    {
        public interface IWinner : IValue {}
        public interface IWinner<T> : IWinner { new T Value { get; } }
        public class OneOrManyWinner : OneOrMany<IWinner>
        {
            public OneOrManyWinner(IWinner item) : base(item) { }
            public OneOrManyWinner(IEnumerable<IWinner> items) : base(items) { }
            public static implicit operator OneOrManyWinner (Person value) { return new OneOrManyWinner (new WinnerPerson (value)); }
            public static implicit operator OneOrManyWinner (Person[] values) { return new OneOrManyWinner (values.Select(v => (IWinner) new WinnerPerson (v))); }
            public static implicit operator OneOrManyWinner (List<Person> values) { return new OneOrManyWinner (values.Select(v => (IWinner) new WinnerPerson (v))); }
        }
        public struct WinnerPerson : IWinner<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public WinnerPerson (Person value) { Value = value; }
            public static implicit operator WinnerPerson (Person value) { return new WinnerPerson (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "LoseAction";

        /// <summary>
        /// A sub property of participant. The winner of the action.
        /// </summary>
        [DataMember(Name = "winner", Order = 306)]
        public OneOrManyWinner Winner { get; set; }
    }
}
