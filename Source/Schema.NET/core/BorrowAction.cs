namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of obtaining an object under an agreement to return it at a later date. Reciprocal of LendAction.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/LendAction"&gt;LendAction&lt;/a&gt;: Reciprocal of BorrowAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class BorrowAction : TransferAction
    {
        public interface ILender : IValue {}
        public interface ILender<T> : ILender { new T Value { get; } }
        public class OneOrManyLender : OneOrMany<ILender>
        {
            public OneOrManyLender(ILender item) : base(item) { }
            public OneOrManyLender(IEnumerable<ILender> items) : base(items) { }
            public static implicit operator OneOrManyLender (Organization value) { return new OneOrManyLender (new LenderOrganization (value)); }
            public static implicit operator OneOrManyLender (Organization[] values) { return new OneOrManyLender (values.Select(v => (ILender) new LenderOrganization (v))); }
            public static implicit operator OneOrManyLender (List<Organization> values) { return new OneOrManyLender (values.Select(v => (ILender) new LenderOrganization (v))); }
            public static implicit operator OneOrManyLender (Person value) { return new OneOrManyLender (new LenderPerson (value)); }
            public static implicit operator OneOrManyLender (Person[] values) { return new OneOrManyLender (values.Select(v => (ILender) new LenderPerson (v))); }
            public static implicit operator OneOrManyLender (List<Person> values) { return new OneOrManyLender (values.Select(v => (ILender) new LenderPerson (v))); }
        }
        public struct LenderOrganization : ILender<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public LenderOrganization (Organization value) { Value = value; }
            public static implicit operator LenderOrganization (Organization value) { return new LenderOrganization (value); }
        }
        public struct LenderPerson : ILender<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public LenderPerson (Person value) { Value = value; }
            public static implicit operator LenderPerson (Person value) { return new LenderPerson (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BorrowAction";

        /// <summary>
        /// A sub property of participant. The person that lends the object being borrowed.
        /// </summary>
        [DataMember(Name = "lender", Order = 306)]
        public OneOrManyLender Lender { get; set; }
    }
}
