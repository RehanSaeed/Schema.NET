namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// An alternative, closely-related condition typically considered later in the differential diagnosis process along with the signs that are used to distinguish it.
    /// </summary>
    [DataContract]
    public partial class DDxElement : MedicalIntangible
    {
        public interface IDiagnosis : IValue {}
        public interface IDiagnosis<T> : IDiagnosis { new T Value { get; } }
        public class OneOrManyDiagnosis : OneOrMany<IDiagnosis>
        {
            public OneOrManyDiagnosis(IDiagnosis item) : base(item) { }
            public OneOrManyDiagnosis(IEnumerable<IDiagnosis> items) : base(items) { }
            public static implicit operator OneOrManyDiagnosis (MedicalCondition value) { return new OneOrManyDiagnosis (new DiagnosisMedicalCondition (value)); }
            public static implicit operator OneOrManyDiagnosis (MedicalCondition[] values) { return new OneOrManyDiagnosis (values.Select(v => (IDiagnosis) new DiagnosisMedicalCondition (v))); }
            public static implicit operator OneOrManyDiagnosis (List<MedicalCondition> values) { return new OneOrManyDiagnosis (values.Select(v => (IDiagnosis) new DiagnosisMedicalCondition (v))); }
        }
        public struct DiagnosisMedicalCondition : IDiagnosis<MedicalCondition>
        {
            object IValue.Value => this.Value;
            public MedicalCondition Value { get; }
            public DiagnosisMedicalCondition (MedicalCondition value) { Value = value; }
            public static implicit operator DiagnosisMedicalCondition (MedicalCondition value) { return new DiagnosisMedicalCondition (value); }
        }

        public interface IDistinguishingSign : IValue {}
        public interface IDistinguishingSign<T> : IDistinguishingSign { new T Value { get; } }
        public class OneOrManyDistinguishingSign : OneOrMany<IDistinguishingSign>
        {
            public OneOrManyDistinguishingSign(IDistinguishingSign item) : base(item) { }
            public OneOrManyDistinguishingSign(IEnumerable<IDistinguishingSign> items) : base(items) { }
            public static implicit operator OneOrManyDistinguishingSign (MedicalSignOrSymptom value) { return new OneOrManyDistinguishingSign (new DistinguishingSignMedicalSignOrSymptom (value)); }
            public static implicit operator OneOrManyDistinguishingSign (MedicalSignOrSymptom[] values) { return new OneOrManyDistinguishingSign (values.Select(v => (IDistinguishingSign) new DistinguishingSignMedicalSignOrSymptom (v))); }
            public static implicit operator OneOrManyDistinguishingSign (List<MedicalSignOrSymptom> values) { return new OneOrManyDistinguishingSign (values.Select(v => (IDistinguishingSign) new DistinguishingSignMedicalSignOrSymptom (v))); }
        }
        public struct DistinguishingSignMedicalSignOrSymptom : IDistinguishingSign<MedicalSignOrSymptom>
        {
            object IValue.Value => this.Value;
            public MedicalSignOrSymptom Value { get; }
            public DistinguishingSignMedicalSignOrSymptom (MedicalSignOrSymptom value) { Value = value; }
            public static implicit operator DistinguishingSignMedicalSignOrSymptom (MedicalSignOrSymptom value) { return new DistinguishingSignMedicalSignOrSymptom (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DDxElement";

        /// <summary>
        /// One or more alternative conditions considered in the differential diagnosis process as output of a diagnosis process.
        /// </summary>
        [DataMember(Name = "diagnosis", Order = 306)]
        public OneOrManyDiagnosis Diagnosis { get; set; }

        /// <summary>
        /// One of a set of signs and symptoms that can be used to distinguish this diagnosis from others in the differential diagnosis.
        /// </summary>
        [DataMember(Name = "distinguishingSign", Order = 307)]
        public OneOrManyDistinguishingSign DistinguishingSign { get; set; }
    }
}
