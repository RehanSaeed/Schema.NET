namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A type of financial product that typically requires the client to transfer funds to a financial service in return for potential beneficial financial return.
    /// </summary>
    [DataContract]
    public partial class InvestmentOrDeposit : FinancialProduct
    {
        public interface IAmount : IValue {}
        public interface IAmount<T> : IAmount { new T Value { get; } }
        public class OneOrManyAmount : OneOrMany<IAmount>
        {
            public OneOrManyAmount(IAmount item) : base(item) { }
            public OneOrManyAmount(IEnumerable<IAmount> items) : base(items) { }
            public static implicit operator OneOrManyAmount (MonetaryAmount value) { return new OneOrManyAmount (new AmountMonetaryAmount (value)); }
            public static implicit operator OneOrManyAmount (MonetaryAmount[] values) { return new OneOrManyAmount (values.Select(v => (IAmount) new AmountMonetaryAmount (v))); }
            public static implicit operator OneOrManyAmount (List<MonetaryAmount> values) { return new OneOrManyAmount (values.Select(v => (IAmount) new AmountMonetaryAmount (v))); }
            public static implicit operator OneOrManyAmount (decimal value) { return new OneOrManyAmount (new Amountdecimal (value)); }
            public static implicit operator OneOrManyAmount (decimal[] values) { return new OneOrManyAmount (values.Select(v => (IAmount) new Amountdecimal (v))); }
            public static implicit operator OneOrManyAmount (List<decimal> values) { return new OneOrManyAmount (values.Select(v => (IAmount) new Amountdecimal (v))); }
        }
        public struct AmountMonetaryAmount : IAmount<MonetaryAmount>
        {
            object IValue.Value => this.Value;
            public MonetaryAmount Value { get; }
            public AmountMonetaryAmount (MonetaryAmount value) { Value = value; }
            public static implicit operator AmountMonetaryAmount (MonetaryAmount value) { return new AmountMonetaryAmount (value); }
        }
        public struct Amountdecimal : IAmount<decimal>
        {
            object IValue.Value => this.Value;
            public decimal Value { get; }
            public Amountdecimal (decimal value) { Value = value; }
            public static implicit operator Amountdecimal (decimal value) { return new Amountdecimal (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "InvestmentOrDeposit";

        /// <summary>
        /// The amount of money.
        /// </summary>
        [DataMember(Name = "amount", Order = 406)]
        public OneOrManyAmount Amount { get; set; }
    }
}
