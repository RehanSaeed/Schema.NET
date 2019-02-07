namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A risk factor is anything that increases a person's likelihood of developing or contracting a disease, medical condition, or complication.
    /// </summary>
    [DataContract]
    public partial class MedicalRiskFactor : MedicalEntity
    {
        public interface IIncreasesRiskOf : IValue {}
        public interface IIncreasesRiskOf<T> : IIncreasesRiskOf { new T Value { get; } }
        public class OneOrManyIncreasesRiskOf : OneOrMany<IIncreasesRiskOf>
        {
            public OneOrManyIncreasesRiskOf(IIncreasesRiskOf item) : base(item) { }
            public OneOrManyIncreasesRiskOf(IEnumerable<IIncreasesRiskOf> items) : base(items) { }
            public static implicit operator OneOrManyIncreasesRiskOf (MedicalEntity value) { return new OneOrManyIncreasesRiskOf (new IncreasesRiskOfMedicalEntity (value)); }
            public static implicit operator OneOrManyIncreasesRiskOf (MedicalEntity[] values) { return new OneOrManyIncreasesRiskOf (values.Select(v => (IIncreasesRiskOf) new IncreasesRiskOfMedicalEntity (v))); }
            public static implicit operator OneOrManyIncreasesRiskOf (List<MedicalEntity> values) { return new OneOrManyIncreasesRiskOf (values.Select(v => (IIncreasesRiskOf) new IncreasesRiskOfMedicalEntity (v))); }
        }
        public struct IncreasesRiskOfMedicalEntity : IIncreasesRiskOf<MedicalEntity>
        {
            object IValue.Value => this.Value;
            public MedicalEntity Value { get; }
            public IncreasesRiskOfMedicalEntity (MedicalEntity value) { Value = value; }
            public static implicit operator IncreasesRiskOfMedicalEntity (MedicalEntity value) { return new IncreasesRiskOfMedicalEntity (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalRiskFactor";

        /// <summary>
        /// The condition, complication, etc. influenced by this factor.
        /// </summary>
        [DataMember(Name = "increasesRiskOf", Order = 206)]
        public OneOrManyIncreasesRiskOf IncreasesRiskOf { get; set; }
    }
}
