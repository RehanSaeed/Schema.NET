namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of taking money from a buyer in exchange for goods or services rendered. An agent sells an object, product, or service to a buyer for a price. Reciprocal of BuyAction.
    /// </summary>
    [DataContract]
    public partial class SellAction : TradeAction
    {
        public interface IBuyer : IValue {}
        public interface IBuyer<T> : IBuyer { new T Value { get; } }
        public class OneOrManyBuyer : OneOrMany<IBuyer>
        {
            public OneOrManyBuyer(IBuyer item) : base(item) { }
            public OneOrManyBuyer(IEnumerable<IBuyer> items) : base(items) { }
            public static implicit operator OneOrManyBuyer (Person value) { return new OneOrManyBuyer (new BuyerPerson (value)); }
            public static implicit operator OneOrManyBuyer (Person[] values) { return new OneOrManyBuyer (values.Select(v => (IBuyer) new BuyerPerson (v))); }
            public static implicit operator OneOrManyBuyer (List<Person> values) { return new OneOrManyBuyer (values.Select(v => (IBuyer) new BuyerPerson (v))); }
        }
        public struct BuyerPerson : IBuyer<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public BuyerPerson (Person value) { Value = value; }
            public static implicit operator BuyerPerson (Person value) { return new BuyerPerson (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SellAction";

        /// <summary>
        /// A sub property of participant. The participant/person/organization that bought the object.
        /// </summary>
        [DataMember(Name = "buyer", Order = 306)]
        public OneOrManyBuyer Buyer { get; set; }
    }
}
