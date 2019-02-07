namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// Financial services business.
    /// </summary>
    [DataContract]
    public partial class FinancialService : LocalBusiness
    {
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

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "FinancialService";

        /// <summary>
        /// Description of fees, commissions, and other terms applied either to a class of financial product, or by a financial service organization.
        /// </summary>
        [DataMember(Name = "feesAndCommissionsSpecification", Order = 306)]
        public OneOrManyFeesAndCommissionsSpecification FeesAndCommissionsSpecification { get; set; }
    }
}
