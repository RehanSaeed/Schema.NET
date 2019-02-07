namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// Any rule set or interactive tool for estimating the risk of developing a complication or condition.
    /// </summary>
    [DataContract]
    public partial class MedicalRiskEstimator : MedicalEntity
    {
        public interface IEstimatesRiskOf : IValue {}
        public interface IEstimatesRiskOf<T> : IEstimatesRiskOf { new T Value { get; } }
        public class OneOrManyEstimatesRiskOf : OneOrMany<IEstimatesRiskOf>
        {
            public OneOrManyEstimatesRiskOf(IEstimatesRiskOf item) : base(item) { }
            public OneOrManyEstimatesRiskOf(IEnumerable<IEstimatesRiskOf> items) : base(items) { }
            public static implicit operator OneOrManyEstimatesRiskOf (MedicalEntity value) { return new OneOrManyEstimatesRiskOf (new EstimatesRiskOfMedicalEntity (value)); }
            public static implicit operator OneOrManyEstimatesRiskOf (MedicalEntity[] values) { return new OneOrManyEstimatesRiskOf (values.Select(v => (IEstimatesRiskOf) new EstimatesRiskOfMedicalEntity (v))); }
            public static implicit operator OneOrManyEstimatesRiskOf (List<MedicalEntity> values) { return new OneOrManyEstimatesRiskOf (values.Select(v => (IEstimatesRiskOf) new EstimatesRiskOfMedicalEntity (v))); }
        }
        public struct EstimatesRiskOfMedicalEntity : IEstimatesRiskOf<MedicalEntity>
        {
            object IValue.Value => this.Value;
            public MedicalEntity Value { get; }
            public EstimatesRiskOfMedicalEntity (MedicalEntity value) { Value = value; }
            public static implicit operator EstimatesRiskOfMedicalEntity (MedicalEntity value) { return new EstimatesRiskOfMedicalEntity (value); }
        }

        public interface IIncludedRiskFactor : IValue {}
        public interface IIncludedRiskFactor<T> : IIncludedRiskFactor { new T Value { get; } }
        public class OneOrManyIncludedRiskFactor : OneOrMany<IIncludedRiskFactor>
        {
            public OneOrManyIncludedRiskFactor(IIncludedRiskFactor item) : base(item) { }
            public OneOrManyIncludedRiskFactor(IEnumerable<IIncludedRiskFactor> items) : base(items) { }
            public static implicit operator OneOrManyIncludedRiskFactor (MedicalRiskFactor value) { return new OneOrManyIncludedRiskFactor (new IncludedRiskFactorMedicalRiskFactor (value)); }
            public static implicit operator OneOrManyIncludedRiskFactor (MedicalRiskFactor[] values) { return new OneOrManyIncludedRiskFactor (values.Select(v => (IIncludedRiskFactor) new IncludedRiskFactorMedicalRiskFactor (v))); }
            public static implicit operator OneOrManyIncludedRiskFactor (List<MedicalRiskFactor> values) { return new OneOrManyIncludedRiskFactor (values.Select(v => (IIncludedRiskFactor) new IncludedRiskFactorMedicalRiskFactor (v))); }
        }
        public struct IncludedRiskFactorMedicalRiskFactor : IIncludedRiskFactor<MedicalRiskFactor>
        {
            object IValue.Value => this.Value;
            public MedicalRiskFactor Value { get; }
            public IncludedRiskFactorMedicalRiskFactor (MedicalRiskFactor value) { Value = value; }
            public static implicit operator IncludedRiskFactorMedicalRiskFactor (MedicalRiskFactor value) { return new IncludedRiskFactorMedicalRiskFactor (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalRiskEstimator";

        /// <summary>
        /// The condition, complication, or symptom whose risk is being estimated.
        /// </summary>
        [DataMember(Name = "estimatesRiskOf", Order = 206)]
        public OneOrManyEstimatesRiskOf EstimatesRiskOf { get; set; }

        /// <summary>
        /// A modifiable or non-modifiable risk factor included in the calculation, e.g. age, coexisting condition.
        /// </summary>
        [DataMember(Name = "includedRiskFactor", Order = 207)]
        public OneOrManyIncludedRiskFactor IncludedRiskFactor { get; set; }
    }
}
