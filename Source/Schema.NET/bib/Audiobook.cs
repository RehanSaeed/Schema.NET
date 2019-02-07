namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// An audiobook.
    /// </summary>
    [DataContract]
    public partial class Audiobook : AudioObjectAndBook
    {
        public interface IReadBy : IValue {}
        public interface IReadBy<T> : IReadBy { new T Value { get; } }
        public class OneOrManyReadBy : OneOrMany<IReadBy>
        {
            public OneOrManyReadBy(IReadBy item) : base(item) { }
            public OneOrManyReadBy(IEnumerable<IReadBy> items) : base(items) { }
            public static implicit operator OneOrManyReadBy (Person value) { return new OneOrManyReadBy (new ReadByPerson (value)); }
            public static implicit operator OneOrManyReadBy (Person[] values) { return new OneOrManyReadBy (values.Select(v => (IReadBy) new ReadByPerson (v))); }
            public static implicit operator OneOrManyReadBy (List<Person> values) { return new OneOrManyReadBy (values.Select(v => (IReadBy) new ReadByPerson (v))); }
        }
        public struct ReadByPerson : IReadBy<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public ReadByPerson (Person value) { Value = value; }
            public static implicit operator ReadByPerson (Person value) { return new ReadByPerson (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Audiobook";

        /// <summary>
        /// A person who reads (performs) the audiobook.
        /// </summary>
        [DataMember(Name = "readBy", Order = 406)]
        public OneOrManyReadBy ReadBy { get; set; }
    }
}
