using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A financial product for the loaning of an amount of money under agreed terms and charges.
    /// </summary>
    [DataContract]
    public partial class LoanOrCredit : FinancialProduct
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


        public interface ILoanType : IWrapper { }
        public interface ILoanType<T> : ILoanType { new T Data { get; set; } }
        public class LoanTypestring : ILoanType<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public LoanTypestring () { }
            public LoanTypestring (string data) { Data = data; }
            public static implicit operator LoanTypestring (string data) { return new LoanTypestring (data); }
        }

        public class LoanTypeUri : ILoanType<Uri>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Uri) value; } }
            public virtual Uri Data { get; set; }
            public LoanTypeUri () { }
            public LoanTypeUri (Uri data) { Data = data; }
            public static implicit operator LoanTypeUri (Uri data) { return new LoanTypeUri (data); }
        }


        public interface IRequiredCollateral : IWrapper { }
        public interface IRequiredCollateral<T> : IRequiredCollateral { new T Data { get; set; } }
        public class RequiredCollateralstring : IRequiredCollateral<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public RequiredCollateralstring () { }
            public RequiredCollateralstring (string data) { Data = data; }
            public static implicit operator RequiredCollateralstring (string data) { return new RequiredCollateralstring (data); }
        }

        public class RequiredCollateralThing : IRequiredCollateral<Thing>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Thing) value; } }
            public virtual Thing Data { get; set; }
            public RequiredCollateralThing () { }
            public RequiredCollateralThing (Thing data) { Data = data; }
            public static implicit operator RequiredCollateralThing (Thing data) { return new RequiredCollateralThing (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "LoanOrCredit";

        /// <summary>
        /// The amount of money.
        /// </summary>
        [DataMember(Name = "amount", Order = 406)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IAmount>? Amount { get; set; } //MonetaryAmount, decimal?

        /// <summary>
        /// The period of time after any due date that the borrower has to fulfil its obligations before a default (failure to pay) is deemed to have occurred.
        /// </summary>
        [DataMember(Name = "gracePeriod", Order = 407)]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesConverter))]
        public Values<TimeSpan>? GracePeriod { get; set; } 

        /// <summary>
        /// The duration of the loan or credit agreement.
        /// </summary>
        [DataMember(Name = "loanTerm", Order = 408)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<QuantitativeValue>? LoanTerm { get; set; } 

        /// <summary>
        /// The type of a loan or credit.
        /// </summary>
        [DataMember(Name = "loanType", Order = 409)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ILoanType>? LoanType { get; set; } //string, Uri

        /// <summary>
        /// The only way you get the money back in the event of default is the security. Recourse is where you still have the opportunity to go back to the borrower for the rest of the money.
        /// </summary>
        [DataMember(Name = "recourseLoan", Order = 410)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<bool>? RecourseLoan { get; set; } 

        /// <summary>
        /// Whether the terms for payment of interest can be renegotiated during the life of the loan.
        /// </summary>
        [DataMember(Name = "renegotiableLoan", Order = 411)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<bool>? RenegotiableLoan { get; set; } 

        /// <summary>
        /// Assets required to secure loan or credit repayments. It may take form of third party pledge, goods, financial instruments (cash, securities, etc.)
        /// </summary>
        [DataMember(Name = "requiredCollateral", Order = 412)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IRequiredCollateral>? RequiredCollateral { get; set; } //string, Thing
    }
}
