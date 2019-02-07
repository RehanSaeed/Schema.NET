namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A financial product for the loaning of an amount of money under agreed terms and charges.
    /// </summary>
    [DataContract]
    public partial class LoanOrCredit : FinancialProduct
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

        public interface ICurrency : IValue {}
        public interface ICurrency<T> : ICurrency { new T Value { get; } }
        public class OneOrManyCurrency : OneOrMany<ICurrency>
        {
            public OneOrManyCurrency(ICurrency item) : base(item) { }
            public OneOrManyCurrency(IEnumerable<ICurrency> items) : base(items) { }
            public static implicit operator OneOrManyCurrency (string value) { return new OneOrManyCurrency (new Currencystring (value)); }
            public static implicit operator OneOrManyCurrency (string[] values) { return new OneOrManyCurrency (values.Select(v => (ICurrency) new Currencystring (v))); }
            public static implicit operator OneOrManyCurrency (List<string> values) { return new OneOrManyCurrency (values.Select(v => (ICurrency) new Currencystring (v))); }
        }
        public struct Currencystring : ICurrency<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Currencystring (string value) { Value = value; }
            public static implicit operator Currencystring (string value) { return new Currencystring (value); }
        }

        public interface IGracePeriod : IValue {}
        public interface IGracePeriod<T> : IGracePeriod { new T Value { get; } }
        public class OneOrManyGracePeriod : OneOrMany<IGracePeriod>
        {
            public OneOrManyGracePeriod(IGracePeriod item) : base(item) { }
            public OneOrManyGracePeriod(IEnumerable<IGracePeriod> items) : base(items) { }
            public static implicit operator OneOrManyGracePeriod (TimeSpan value) { return new OneOrManyGracePeriod (new GracePeriodTimeSpan (value)); }
            public static implicit operator OneOrManyGracePeriod (TimeSpan[] values) { return new OneOrManyGracePeriod (values.Select(v => (IGracePeriod) new GracePeriodTimeSpan (v))); }
            public static implicit operator OneOrManyGracePeriod (List<TimeSpan> values) { return new OneOrManyGracePeriod (values.Select(v => (IGracePeriod) new GracePeriodTimeSpan (v))); }
        }
        public struct GracePeriodTimeSpan : IGracePeriod<TimeSpan>
        {
            object IValue.Value => this.Value;
            public TimeSpan Value { get; }
            public GracePeriodTimeSpan (TimeSpan value) { Value = value; }
            public static implicit operator GracePeriodTimeSpan (TimeSpan value) { return new GracePeriodTimeSpan (value); }
        }

        public interface ILoanTerm : IValue {}
        public interface ILoanTerm<T> : ILoanTerm { new T Value { get; } }
        public class OneOrManyLoanTerm : OneOrMany<ILoanTerm>
        {
            public OneOrManyLoanTerm(ILoanTerm item) : base(item) { }
            public OneOrManyLoanTerm(IEnumerable<ILoanTerm> items) : base(items) { }
            public static implicit operator OneOrManyLoanTerm (QuantitativeValue value) { return new OneOrManyLoanTerm (new LoanTermQuantitativeValue (value)); }
            public static implicit operator OneOrManyLoanTerm (QuantitativeValue[] values) { return new OneOrManyLoanTerm (values.Select(v => (ILoanTerm) new LoanTermQuantitativeValue (v))); }
            public static implicit operator OneOrManyLoanTerm (List<QuantitativeValue> values) { return new OneOrManyLoanTerm (values.Select(v => (ILoanTerm) new LoanTermQuantitativeValue (v))); }
        }
        public struct LoanTermQuantitativeValue : ILoanTerm<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public LoanTermQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator LoanTermQuantitativeValue (QuantitativeValue value) { return new LoanTermQuantitativeValue (value); }
        }

        public interface ILoanType : IValue {}
        public interface ILoanType<T> : ILoanType { new T Value { get; } }
        public class OneOrManyLoanType : OneOrMany<ILoanType>
        {
            public OneOrManyLoanType(ILoanType item) : base(item) { }
            public OneOrManyLoanType(IEnumerable<ILoanType> items) : base(items) { }
            public static implicit operator OneOrManyLoanType (string value) { return new OneOrManyLoanType (new LoanTypestring (value)); }
            public static implicit operator OneOrManyLoanType (string[] values) { return new OneOrManyLoanType (values.Select(v => (ILoanType) new LoanTypestring (v))); }
            public static implicit operator OneOrManyLoanType (List<string> values) { return new OneOrManyLoanType (values.Select(v => (ILoanType) new LoanTypestring (v))); }
            public static implicit operator OneOrManyLoanType (Uri value) { return new OneOrManyLoanType (new LoanTypeUri (value)); }
            public static implicit operator OneOrManyLoanType (Uri[] values) { return new OneOrManyLoanType (values.Select(v => (ILoanType) new LoanTypeUri (v))); }
            public static implicit operator OneOrManyLoanType (List<Uri> values) { return new OneOrManyLoanType (values.Select(v => (ILoanType) new LoanTypeUri (v))); }
        }
        public struct LoanTypestring : ILoanType<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public LoanTypestring (string value) { Value = value; }
            public static implicit operator LoanTypestring (string value) { return new LoanTypestring (value); }
        }
        public struct LoanTypeUri : ILoanType<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public LoanTypeUri (Uri value) { Value = value; }
            public static implicit operator LoanTypeUri (Uri value) { return new LoanTypeUri (value); }
        }

        public interface IRecourseLoan : IValue {}
        public interface IRecourseLoan<T> : IRecourseLoan { new T Value { get; } }
        public class OneOrManyRecourseLoan : OneOrMany<IRecourseLoan>
        {
            public OneOrManyRecourseLoan(IRecourseLoan item) : base(item) { }
            public OneOrManyRecourseLoan(IEnumerable<IRecourseLoan> items) : base(items) { }
            public static implicit operator OneOrManyRecourseLoan (bool value) { return new OneOrManyRecourseLoan (new RecourseLoanbool (value)); }
            public static implicit operator OneOrManyRecourseLoan (bool[] values) { return new OneOrManyRecourseLoan (values.Select(v => (IRecourseLoan) new RecourseLoanbool (v))); }
            public static implicit operator OneOrManyRecourseLoan (List<bool> values) { return new OneOrManyRecourseLoan (values.Select(v => (IRecourseLoan) new RecourseLoanbool (v))); }
        }
        public struct RecourseLoanbool : IRecourseLoan<bool>
        {
            object IValue.Value => this.Value;
            public bool Value { get; }
            public RecourseLoanbool (bool value) { Value = value; }
            public static implicit operator RecourseLoanbool (bool value) { return new RecourseLoanbool (value); }
        }

        public interface IRenegotiableLoan : IValue {}
        public interface IRenegotiableLoan<T> : IRenegotiableLoan { new T Value { get; } }
        public class OneOrManyRenegotiableLoan : OneOrMany<IRenegotiableLoan>
        {
            public OneOrManyRenegotiableLoan(IRenegotiableLoan item) : base(item) { }
            public OneOrManyRenegotiableLoan(IEnumerable<IRenegotiableLoan> items) : base(items) { }
            public static implicit operator OneOrManyRenegotiableLoan (bool value) { return new OneOrManyRenegotiableLoan (new RenegotiableLoanbool (value)); }
            public static implicit operator OneOrManyRenegotiableLoan (bool[] values) { return new OneOrManyRenegotiableLoan (values.Select(v => (IRenegotiableLoan) new RenegotiableLoanbool (v))); }
            public static implicit operator OneOrManyRenegotiableLoan (List<bool> values) { return new OneOrManyRenegotiableLoan (values.Select(v => (IRenegotiableLoan) new RenegotiableLoanbool (v))); }
        }
        public struct RenegotiableLoanbool : IRenegotiableLoan<bool>
        {
            object IValue.Value => this.Value;
            public bool Value { get; }
            public RenegotiableLoanbool (bool value) { Value = value; }
            public static implicit operator RenegotiableLoanbool (bool value) { return new RenegotiableLoanbool (value); }
        }

        public interface IRequiredCollateral : IValue {}
        public interface IRequiredCollateral<T> : IRequiredCollateral { new T Value { get; } }
        public class OneOrManyRequiredCollateral : OneOrMany<IRequiredCollateral>
        {
            public OneOrManyRequiredCollateral(IRequiredCollateral item) : base(item) { }
            public OneOrManyRequiredCollateral(IEnumerable<IRequiredCollateral> items) : base(items) { }
            public static implicit operator OneOrManyRequiredCollateral (string value) { return new OneOrManyRequiredCollateral (new RequiredCollateralstring (value)); }
            public static implicit operator OneOrManyRequiredCollateral (string[] values) { return new OneOrManyRequiredCollateral (values.Select(v => (IRequiredCollateral) new RequiredCollateralstring (v))); }
            public static implicit operator OneOrManyRequiredCollateral (List<string> values) { return new OneOrManyRequiredCollateral (values.Select(v => (IRequiredCollateral) new RequiredCollateralstring (v))); }
            public static implicit operator OneOrManyRequiredCollateral (Thing value) { return new OneOrManyRequiredCollateral (new RequiredCollateralThing (value)); }
            public static implicit operator OneOrManyRequiredCollateral (Thing[] values) { return new OneOrManyRequiredCollateral (values.Select(v => (IRequiredCollateral) new RequiredCollateralThing (v))); }
            public static implicit operator OneOrManyRequiredCollateral (List<Thing> values) { return new OneOrManyRequiredCollateral (values.Select(v => (IRequiredCollateral) new RequiredCollateralThing (v))); }
        }
        public struct RequiredCollateralstring : IRequiredCollateral<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public RequiredCollateralstring (string value) { Value = value; }
            public static implicit operator RequiredCollateralstring (string value) { return new RequiredCollateralstring (value); }
        }
        public struct RequiredCollateralThing : IRequiredCollateral<Thing>
        {
            object IValue.Value => this.Value;
            public Thing Value { get; }
            public RequiredCollateralThing (Thing value) { Value = value; }
            public static implicit operator RequiredCollateralThing (Thing value) { return new RequiredCollateralThing (value); }
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
        public OneOrManyAmount Amount { get; set; }

        /// <summary>
        /// The currency in which the monetary amount is expressed (in 3-letter &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217&lt;/a&gt; format).
        /// </summary>
        [DataMember(Name = "currency", Order = 407)]
        public OneOrManyCurrency Currency { get; set; }

        /// <summary>
        /// The period of time after any due date that the borrower has to fulfil its obligations before a default (failure to pay) is deemed to have occurred.
        /// </summary>
        [DataMember(Name = "gracePeriod", Order = 408)]
        public OneOrManyGracePeriod GracePeriod { get; set; }

        /// <summary>
        /// The duration of the loan or credit agreement.
        /// </summary>
        [DataMember(Name = "loanTerm", Order = 409)]
        public OneOrManyLoanTerm LoanTerm { get; set; }

        /// <summary>
        /// The type of a loan or credit.
        /// </summary>
        [DataMember(Name = "loanType", Order = 410)]
        public OneOrManyLoanType LoanType { get; set; }

        /// <summary>
        /// The only way you get the money back in the event of default is the security. Recourse is where you still have the opportunity to go back to the borrower for the rest of the money.
        /// </summary>
        [DataMember(Name = "recourseLoan", Order = 411)]
        public OneOrManyRecourseLoan RecourseLoan { get; set; }

        /// <summary>
        /// Whether the terms for payment of interest can be renegotiated during the life of the loan.
        /// </summary>
        [DataMember(Name = "renegotiableLoan", Order = 412)]
        public OneOrManyRenegotiableLoan RenegotiableLoan { get; set; }

        /// <summary>
        /// Assets required to secure loan or credit repayments. It may take form of third party pledge, goods, financial instruments (cash, securities, etc.)
        /// </summary>
        [DataMember(Name = "requiredCollateral", Order = 413)]
        public OneOrManyRequiredCollateral RequiredCollateral { get; set; }
    }
}
