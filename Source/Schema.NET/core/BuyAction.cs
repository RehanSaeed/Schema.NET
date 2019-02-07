namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of giving money to a seller in exchange for goods or services rendered. An agent buys an object, product, or service from a seller for a price. Reciprocal of SellAction.
    /// </summary>
    [DataContract]
    public partial class BuyAction : TradeAction
    {
        public interface ISeller : IValue {}
        public interface ISeller<T> : ISeller { new T Value { get; } }
        public class OneOrManySeller : OneOrMany<ISeller>
        {
            public OneOrManySeller(ISeller item) : base(item) { }
            public OneOrManySeller(IEnumerable<ISeller> items) : base(items) { }
            public static implicit operator OneOrManySeller (Organization value) { return new OneOrManySeller (new SellerOrganization (value)); }
            public static implicit operator OneOrManySeller (Organization[] values) { return new OneOrManySeller (values.Select(v => (ISeller) new SellerOrganization (v))); }
            public static implicit operator OneOrManySeller (List<Organization> values) { return new OneOrManySeller (values.Select(v => (ISeller) new SellerOrganization (v))); }
            public static implicit operator OneOrManySeller (Person value) { return new OneOrManySeller (new SellerPerson (value)); }
            public static implicit operator OneOrManySeller (Person[] values) { return new OneOrManySeller (values.Select(v => (ISeller) new SellerPerson (v))); }
            public static implicit operator OneOrManySeller (List<Person> values) { return new OneOrManySeller (values.Select(v => (ISeller) new SellerPerson (v))); }
        }
        public struct SellerOrganization : ISeller<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public SellerOrganization (Organization value) { Value = value; }
            public static implicit operator SellerOrganization (Organization value) { return new SellerOrganization (value); }
        }
        public struct SellerPerson : ISeller<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public SellerPerson (Person value) { Value = value; }
            public static implicit operator SellerPerson (Person value) { return new SellerPerson (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BuyAction";

        /// <summary>
        /// An entity which offers (sells / leases / lends / loans) the services / goods.  A seller may also be a provider.
        /// </summary>
        [DataMember(Name = "seller", Order = 306)]
        public OneOrManySeller Seller { get; set; }
    }
}
