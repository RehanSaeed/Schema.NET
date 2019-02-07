namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A product provided to consumers and businesses by financial institutions such as banks, insurance companies, brokerage firms, consumer finance companies, and investment companies which comprise the financial services industry.
    /// </summary>
    [DataContract]
    public partial class FinancialProduct : Service
    {
        public interface IAnnualPercentageRate : IValue {}
        public interface IAnnualPercentageRate<T> : IAnnualPercentageRate { new T Value { get; } }
        public class OneOrManyAnnualPercentageRate : OneOrMany<IAnnualPercentageRate>
        {
            public OneOrManyAnnualPercentageRate(IAnnualPercentageRate item) : base(item) { }
            public OneOrManyAnnualPercentageRate(IEnumerable<IAnnualPercentageRate> items) : base(items) { }
            public static implicit operator OneOrManyAnnualPercentageRate (double value) { return new OneOrManyAnnualPercentageRate (new AnnualPercentageRatedouble (value)); }
            public static implicit operator OneOrManyAnnualPercentageRate (double[] values) { return new OneOrManyAnnualPercentageRate (values.Select(v => (IAnnualPercentageRate) new AnnualPercentageRatedouble (v))); }
            public static implicit operator OneOrManyAnnualPercentageRate (List<double> values) { return new OneOrManyAnnualPercentageRate (values.Select(v => (IAnnualPercentageRate) new AnnualPercentageRatedouble (v))); }
            public static implicit operator OneOrManyAnnualPercentageRate (QuantitativeValue value) { return new OneOrManyAnnualPercentageRate (new AnnualPercentageRateQuantitativeValue (value)); }
            public static implicit operator OneOrManyAnnualPercentageRate (QuantitativeValue[] values) { return new OneOrManyAnnualPercentageRate (values.Select(v => (IAnnualPercentageRate) new AnnualPercentageRateQuantitativeValue (v))); }
            public static implicit operator OneOrManyAnnualPercentageRate (List<QuantitativeValue> values) { return new OneOrManyAnnualPercentageRate (values.Select(v => (IAnnualPercentageRate) new AnnualPercentageRateQuantitativeValue (v))); }
        }
        public struct AnnualPercentageRatedouble : IAnnualPercentageRate<double>
        {
            object IValue.Value => this.Value;
            public double Value { get; }
            public AnnualPercentageRatedouble (double value) { Value = value; }
            public static implicit operator AnnualPercentageRatedouble (double value) { return new AnnualPercentageRatedouble (value); }
        }
        public struct AnnualPercentageRateQuantitativeValue : IAnnualPercentageRate<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public AnnualPercentageRateQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator AnnualPercentageRateQuantitativeValue (QuantitativeValue value) { return new AnnualPercentageRateQuantitativeValue (value); }
        }

        public interface IFeesAndCommissionsSpecification : IValue {}
        public interface IFeesAndCommissionsSpecification<T> : IFeesAndCommissionsSpecification { new T Value { get; } }
        public class OneOrManyFeesAndCommissionsSpecification : OneOrMany<IFeesAndCommissionsSpecification>
        {
            public OneOrManyFeesAndCommissionsSpecification(IFeesAndCommissionsSpecification item) : base(item) { }
            public OneOrManyFeesAndCommissionsSpecification(IEnumerable<IFeesAndCommissionsSpecification> items) : base(items) { }
            public static implicit operator OneOrManyFeesAndCommissionsSpecification (string value) { return new OneOrManyFeesAndCommissionsSpecification (new FeesAndCommissionsSpecificationstring (value)); }
            public static implicit operator OneOrManyFeesAndCommissionsSpecification (string[] values) { return new OneOrManyFeesAndCommissionsSpecification (values.Select(v => (IFeesAndCommissionsSpecification) new FeesAndCommissionsSpecificationstring (v))); }
            public static implicit operator OneOrManyFeesAndCommissionsSpecification (List<string> values) { return new OneOrManyFeesAndCommissionsSpecification (values.Select(v => (IFeesAndCommissionsSpecification) new FeesAndCommissionsSpecificationstring (v))); }
            public static implicit operator OneOrManyFeesAndCommissionsSpecification (Uri value) { return new OneOrManyFeesAndCommissionsSpecification (new FeesAndCommissionsSpecificationUri (value)); }
            public static implicit operator OneOrManyFeesAndCommissionsSpecification (Uri[] values) { return new OneOrManyFeesAndCommissionsSpecification (values.Select(v => (IFeesAndCommissionsSpecification) new FeesAndCommissionsSpecificationUri (v))); }
            public static implicit operator OneOrManyFeesAndCommissionsSpecification (List<Uri> values) { return new OneOrManyFeesAndCommissionsSpecification (values.Select(v => (IFeesAndCommissionsSpecification) new FeesAndCommissionsSpecificationUri (v))); }
        }
        public struct FeesAndCommissionsSpecificationstring : IFeesAndCommissionsSpecification<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public FeesAndCommissionsSpecificationstring (string value) { Value = value; }
            public static implicit operator FeesAndCommissionsSpecificationstring (string value) { return new FeesAndCommissionsSpecificationstring (value); }
        }
        public struct FeesAndCommissionsSpecificationUri : IFeesAndCommissionsSpecification<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public FeesAndCommissionsSpecificationUri (Uri value) { Value = value; }
            public static implicit operator FeesAndCommissionsSpecificationUri (Uri value) { return new FeesAndCommissionsSpecificationUri (value); }
        }

        public interface IInterestRate : IValue {}
        public interface IInterestRate<T> : IInterestRate { new T Value { get; } }
        public class OneOrManyInterestRate : OneOrMany<IInterestRate>
        {
            public OneOrManyInterestRate(IInterestRate item) : base(item) { }
            public OneOrManyInterestRate(IEnumerable<IInterestRate> items) : base(items) { }
            public static implicit operator OneOrManyInterestRate (double value) { return new OneOrManyInterestRate (new InterestRatedouble (value)); }
            public static implicit operator OneOrManyInterestRate (double[] values) { return new OneOrManyInterestRate (values.Select(v => (IInterestRate) new InterestRatedouble (v))); }
            public static implicit operator OneOrManyInterestRate (List<double> values) { return new OneOrManyInterestRate (values.Select(v => (IInterestRate) new InterestRatedouble (v))); }
            public static implicit operator OneOrManyInterestRate (QuantitativeValue value) { return new OneOrManyInterestRate (new InterestRateQuantitativeValue (value)); }
            public static implicit operator OneOrManyInterestRate (QuantitativeValue[] values) { return new OneOrManyInterestRate (values.Select(v => (IInterestRate) new InterestRateQuantitativeValue (v))); }
            public static implicit operator OneOrManyInterestRate (List<QuantitativeValue> values) { return new OneOrManyInterestRate (values.Select(v => (IInterestRate) new InterestRateQuantitativeValue (v))); }
        }
        public struct InterestRatedouble : IInterestRate<double>
        {
            object IValue.Value => this.Value;
            public double Value { get; }
            public InterestRatedouble (double value) { Value = value; }
            public static implicit operator InterestRatedouble (double value) { return new InterestRatedouble (value); }
        }
        public struct InterestRateQuantitativeValue : IInterestRate<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public InterestRateQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator InterestRateQuantitativeValue (QuantitativeValue value) { return new InterestRateQuantitativeValue (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "FinancialProduct";

        /// <summary>
        /// The annual rate that is charged for borrowing (or made by investing), expressed as a single percentage number that represents the actual yearly cost of funds over the term of a loan. This includes any fees or additional costs associated with the transaction.
        /// </summary>
        [DataMember(Name = "annualPercentageRate", Order = 306)]
        public OneOrManyAnnualPercentageRate AnnualPercentageRate { get; set; }

        /// <summary>
        /// Description of fees, commissions, and other terms applied either to a class of financial product, or by a financial service organization.
        /// </summary>
        [DataMember(Name = "feesAndCommissionsSpecification", Order = 307)]
        public OneOrManyFeesAndCommissionsSpecification FeesAndCommissionsSpecification { get; set; }

        /// <summary>
        /// The interest rate, charged or paid, applicable to the financial product. Note: This is different from the calculated annualPercentageRate.
        /// </summary>
        [DataMember(Name = "interestRate", Order = 308)]
        public OneOrManyInterestRate InterestRate { get; set; }
    }
}
