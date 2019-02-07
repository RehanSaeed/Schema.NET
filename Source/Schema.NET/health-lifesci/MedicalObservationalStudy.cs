namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// An observational study is a type of medical study that attempts to infer the possible effect of a treatment through observation of a cohort of subjects over a period of time. In an observational study, the assignment of subjects into treatment groups versus control groups is outside the control of the investigator. This is in contrast with controlled studies, such as the randomized controlled trials represented by MedicalTrial, where each subject is randomly assigned to a treatment group or a control group before the start of the treatment.
    /// </summary>
    [DataContract]
    public partial class MedicalObservationalStudy : MedicalStudy
    {
        public interface IStudyDesign : IValue {}
        public interface IStudyDesign<T> : IStudyDesign { new T Value { get; } }
        public class OneOrManyStudyDesign : OneOrMany<IStudyDesign>
        {
            public OneOrManyStudyDesign(IStudyDesign item) : base(item) { }
            public OneOrManyStudyDesign(IEnumerable<IStudyDesign> items) : base(items) { }
            public static implicit operator OneOrManyStudyDesign (MedicalObservationalStudyDesign value) { return new OneOrManyStudyDesign (new StudyDesignMedicalObservationalStudyDesign (value)); }
            public static implicit operator OneOrManyStudyDesign (MedicalObservationalStudyDesign[] values) { return new OneOrManyStudyDesign (values.Select(v => (IStudyDesign) new StudyDesignMedicalObservationalStudyDesign (v))); }
            public static implicit operator OneOrManyStudyDesign (List<MedicalObservationalStudyDesign> values) { return new OneOrManyStudyDesign (values.Select(v => (IStudyDesign) new StudyDesignMedicalObservationalStudyDesign (v))); }
        }
        public struct StudyDesignMedicalObservationalStudyDesign : IStudyDesign<MedicalObservationalStudyDesign>
        {
            object IValue.Value => this.Value;
            public MedicalObservationalStudyDesign Value { get; }
            public StudyDesignMedicalObservationalStudyDesign (MedicalObservationalStudyDesign value) { Value = value; }
            public static implicit operator StudyDesignMedicalObservationalStudyDesign (MedicalObservationalStudyDesign value) { return new StudyDesignMedicalObservationalStudyDesign (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalObservationalStudy";

        /// <summary>
        /// Specifics about the observational study design (enumerated).
        /// </summary>
        [DataMember(Name = "studyDesign", Order = 306)]
        public OneOrManyStudyDesign StudyDesign { get; set; }
    }
}
