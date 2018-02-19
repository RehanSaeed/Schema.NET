using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A product provided to consumers and businesses by financial institutions such as banks, insurance companies, brokerage firms, consumer finance companies, and investment companies which comprise the financial services industry.
    /// </summary>
    [DataContract]
    public partial class FinancialProduct : Service
    {
        public interface IAnnualPercentageRate : IWrapper { }
        public interface IAnnualPercentageRate<T> : IAnnualPercentageRate { new T Data { get; set; } }
        public class AnnualPercentageRatedouble : IAnnualPercentageRate<double>
        {
            object IWrapper.Data { get { return Data; } set { Data = (double) value; } }
            public virtual double Data { get; set; }
            public AnnualPercentageRatedouble () { }
            public AnnualPercentageRatedouble (double data) { Data = data; }
            public static implicit operator AnnualPercentageRatedouble (double data) { return new AnnualPercentageRatedouble (data); }
        }

        public class AnnualPercentageRateQuantitativeValue : IAnnualPercentageRate<QuantitativeValue>
        {
            object IWrapper.Data { get { return Data; } set { Data = (QuantitativeValue) value; } }
            public virtual QuantitativeValue Data { get; set; }
            public AnnualPercentageRateQuantitativeValue () { }
            public AnnualPercentageRateQuantitativeValue (QuantitativeValue data) { Data = data; }
            public static implicit operator AnnualPercentageRateQuantitativeValue (QuantitativeValue data) { return new AnnualPercentageRateQuantitativeValue (data); }
        }


        public interface IFeesAndCommissionsSpecification : IWrapper { }
        public interface IFeesAndCommissionsSpecification<T> : IFeesAndCommissionsSpecification { new T Data { get; set; } }
        public class FeesAndCommissionsSpecificationstring : IFeesAndCommissionsSpecification<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public FeesAndCommissionsSpecificationstring () { }
            public FeesAndCommissionsSpecificationstring (string data) { Data = data; }
            public static implicit operator FeesAndCommissionsSpecificationstring (string data) { return new FeesAndCommissionsSpecificationstring (data); }
        }

        public class FeesAndCommissionsSpecificationUri : IFeesAndCommissionsSpecification<Uri>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Uri) value; } }
            public virtual Uri Data { get; set; }
            public FeesAndCommissionsSpecificationUri () { }
            public FeesAndCommissionsSpecificationUri (Uri data) { Data = data; }
            public static implicit operator FeesAndCommissionsSpecificationUri (Uri data) { return new FeesAndCommissionsSpecificationUri (data); }
        }


        public interface IInterestRate : IWrapper { }
        public interface IInterestRate<T> : IInterestRate { new T Data { get; set; } }
        public class InterestRatedouble : IInterestRate<double>
        {
            object IWrapper.Data { get { return Data; } set { Data = (double) value; } }
            public virtual double Data { get; set; }
            public InterestRatedouble () { }
            public InterestRatedouble (double data) { Data = data; }
            public static implicit operator InterestRatedouble (double data) { return new InterestRatedouble (data); }
        }

        public class InterestRateQuantitativeValue : IInterestRate<QuantitativeValue>
        {
            object IWrapper.Data { get { return Data; } set { Data = (QuantitativeValue) value; } }
            public virtual QuantitativeValue Data { get; set; }
            public InterestRateQuantitativeValue () { }
            public InterestRateQuantitativeValue (QuantitativeValue data) { Data = data; }
            public static implicit operator InterestRateQuantitativeValue (QuantitativeValue data) { return new InterestRateQuantitativeValue (data); }
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
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IAnnualPercentageRate>? AnnualPercentageRate { get; set; } //double?, QuantitativeValue

        /// <summary>
        /// Description of fees, commissions, and other terms applied either to a class of financial product, or by a financial service organization.
        /// </summary>
        [DataMember(Name = "feesAndCommissionsSpecification", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IFeesAndCommissionsSpecification>? FeesAndCommissionsSpecification { get; set; } //string, Uri

        /// <summary>
        /// The interest rate, charged or paid, applicable to the financial product. Note: This is different from the calculated annualPercentageRate.
        /// </summary>
        [DataMember(Name = "interestRate", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IInterestRate>? InterestRate { get; set; } //double?, QuantitativeValue
    }
}
