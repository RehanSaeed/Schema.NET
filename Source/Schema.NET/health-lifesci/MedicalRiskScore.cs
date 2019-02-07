namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A simple system that adds up the number of risk factors to yield a score that is associated with prognosis, e.g. CHAD score, TIMI risk score.
    /// </summary>
    [DataContract]
    public partial class MedicalRiskScore : MedicalRiskEstimator
    {
        public interface IAlgorithm : IValue {}
        public interface IAlgorithm<T> : IAlgorithm { new T Value { get; } }
        public class OneOrManyAlgorithm : OneOrMany<IAlgorithm>
        {
            public OneOrManyAlgorithm(IAlgorithm item) : base(item) { }
            public OneOrManyAlgorithm(IEnumerable<IAlgorithm> items) : base(items) { }
            public static implicit operator OneOrManyAlgorithm (string value) { return new OneOrManyAlgorithm (new Algorithmstring (value)); }
            public static implicit operator OneOrManyAlgorithm (string[] values) { return new OneOrManyAlgorithm (values.Select(v => (IAlgorithm) new Algorithmstring (v))); }
            public static implicit operator OneOrManyAlgorithm (List<string> values) { return new OneOrManyAlgorithm (values.Select(v => (IAlgorithm) new Algorithmstring (v))); }
        }
        public struct Algorithmstring : IAlgorithm<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Algorithmstring (string value) { Value = value; }
            public static implicit operator Algorithmstring (string value) { return new Algorithmstring (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalRiskScore";

        /// <summary>
        /// The algorithm or rules to follow to compute the score.
        /// </summary>
        [DataMember(Name = "algorithm", Order = 306)]
        public OneOrManyAlgorithm Algorithm { get; set; }
    }
}
