namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// The causative agent(s) that are responsible for the pathophysiologic process that eventually results in a medical condition, symptom or sign. In this schema, unless otherwise specified this is meant to be the proximate cause of the medical condition, symptom or sign. The proximate cause is defined as the causative agent that most directly results in the medical condition, symptom or sign. For example, the HIV virus could be considered a cause of AIDS. Or in a diagnostic context, if a patient fell and sustained a hip fracture and two days later sustained a pulmonary embolism which eventuated in a cardiac arrest, the cause of the cardiac arrest (the proximate cause) would be the pulmonary embolism and not the fall. Medical causes can include cardiovascular, chemical, dermatologic, endocrine, environmental, gastroenterologic, genetic, hematologic, gynecologic, iatrogenic, infectious, musculoskeletal, neurologic, nutritional, obstetric, oncologic, otolaryngologic, pharmacologic, psychiatric, pulmonary, renal, rheumatologic, toxic, traumatic, or urologic causes; medical conditions can be causes as well.
    /// </summary>
    [DataContract]
    public partial class MedicalCause : MedicalEntity
    {
        public interface ICauseOf : IValue {}
        public interface ICauseOf<T> : ICauseOf { new T Value { get; } }
        public class OneOrManyCauseOf : OneOrMany<ICauseOf>
        {
            public OneOrManyCauseOf(ICauseOf item) : base(item) { }
            public OneOrManyCauseOf(IEnumerable<ICauseOf> items) : base(items) { }
            public static implicit operator OneOrManyCauseOf (MedicalEntity value) { return new OneOrManyCauseOf (new CauseOfMedicalEntity (value)); }
            public static implicit operator OneOrManyCauseOf (MedicalEntity[] values) { return new OneOrManyCauseOf (values.Select(v => (ICauseOf) new CauseOfMedicalEntity (v))); }
            public static implicit operator OneOrManyCauseOf (List<MedicalEntity> values) { return new OneOrManyCauseOf (values.Select(v => (ICauseOf) new CauseOfMedicalEntity (v))); }
        }
        public struct CauseOfMedicalEntity : ICauseOf<MedicalEntity>
        {
            object IValue.Value => this.Value;
            public MedicalEntity Value { get; }
            public CauseOfMedicalEntity (MedicalEntity value) { Value = value; }
            public static implicit operator CauseOfMedicalEntity (MedicalEntity value) { return new CauseOfMedicalEntity (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalCause";

        /// <summary>
        /// The condition, complication, symptom, sign, etc. caused.
        /// </summary>
        [DataMember(Name = "causeOf", Order = 206)]
        public OneOrManyCauseOf CauseOf { get; set; }
    }
}
