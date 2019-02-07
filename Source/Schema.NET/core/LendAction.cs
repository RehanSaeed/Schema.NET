namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of providing an object under an agreement that it will be returned at a later date. Reciprocal of BorrowAction.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/BorrowAction"&gt;BorrowAction&lt;/a&gt;: Reciprocal of LendAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class LendAction : TransferAction
    {
        public interface IBorrower : IValue {}
        public interface IBorrower<T> : IBorrower { new T Value { get; } }
        public class OneOrManyBorrower : OneOrMany<IBorrower>
        {
            public OneOrManyBorrower(IBorrower item) : base(item) { }
            public OneOrManyBorrower(IEnumerable<IBorrower> items) : base(items) { }
            public static implicit operator OneOrManyBorrower (Person value) { return new OneOrManyBorrower (new BorrowerPerson (value)); }
            public static implicit operator OneOrManyBorrower (Person[] values) { return new OneOrManyBorrower (values.Select(v => (IBorrower) new BorrowerPerson (v))); }
            public static implicit operator OneOrManyBorrower (List<Person> values) { return new OneOrManyBorrower (values.Select(v => (IBorrower) new BorrowerPerson (v))); }
        }
        public struct BorrowerPerson : IBorrower<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public BorrowerPerson (Person value) { Value = value; }
            public static implicit operator BorrowerPerson (Person value) { return new BorrowerPerson (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "LendAction";

        /// <summary>
        /// A sub property of participant. The person that borrows the object being lent.
        /// </summary>
        [DataMember(Name = "borrower", Order = 306)]
        public OneOrManyBorrower Borrower { get; set; }
    }
}
