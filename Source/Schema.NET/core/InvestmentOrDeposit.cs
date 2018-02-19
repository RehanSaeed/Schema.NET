using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A type of financial product that typically requires the client to transfer funds to a financial service in return for potential beneficial financial return.
    /// </summary>
    [DataContract]
    public partial class InvestmentOrDeposit : FinancialProduct
    {
        public interface IAmount : IWrapper { }
        public interface IAmount<T> : IAmount { new T Data { get; set; } }
        public class AmountMonetaryAmount : IAmount<MonetaryAmount>
        {
            object IWrapper.Data { get { return Data; } set { Data = (MonetaryAmount) value; } }
            public virtual MonetaryAmount Data { get; set; }
            public AmountMonetaryAmount () { }
            public AmountMonetaryAmount (MonetaryAmount data) { Data = data; }
            public static implicit operator AmountMonetaryAmount (MonetaryAmount data) { return new AmountMonetaryAmount (data); }
        }

        public class Amountdecimal : IAmount<decimal>
        {
            object IWrapper.Data { get { return Data; } set { Data = (decimal) value; } }
            public virtual decimal Data { get; set; }
            public Amountdecimal () { }
            public Amountdecimal (decimal data) { Data = data; }
            public static implicit operator Amountdecimal (decimal data) { return new Amountdecimal (data); }
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
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IAmount>? Amount { get; set; } //MonetaryAmount, decimal?
    }
}
