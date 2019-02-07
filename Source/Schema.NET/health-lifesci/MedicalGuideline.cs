namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// Any recommendation made by a standard society (e.g. ACC/AHA) or consensus statement that denotes how to diagnose and treat a particular condition. Note: this type should be used to tag the actual guideline recommendation; if the guideline recommendation occurs in a larger scholarly article, use MedicalScholarlyArticle to tag the overall article, not this type. Note also: the organization making the recommendation should be captured in the recognizingAuthority base property of MedicalEntity.
    /// </summary>
    [DataContract]
    public partial class MedicalGuideline : MedicalEntity
    {
        public interface IEvidenceLevel : IValue {}
        public interface IEvidenceLevel<T> : IEvidenceLevel { new T Value { get; } }
        public class OneOrManyEvidenceLevel : OneOrMany<IEvidenceLevel>
        {
            public OneOrManyEvidenceLevel(IEvidenceLevel item) : base(item) { }
            public OneOrManyEvidenceLevel(IEnumerable<IEvidenceLevel> items) : base(items) { }
            public static implicit operator OneOrManyEvidenceLevel (MedicalEvidenceLevel value) { return new OneOrManyEvidenceLevel (new EvidenceLevelMedicalEvidenceLevel (value)); }
            public static implicit operator OneOrManyEvidenceLevel (MedicalEvidenceLevel[] values) { return new OneOrManyEvidenceLevel (values.Select(v => (IEvidenceLevel) new EvidenceLevelMedicalEvidenceLevel (v))); }
            public static implicit operator OneOrManyEvidenceLevel (List<MedicalEvidenceLevel> values) { return new OneOrManyEvidenceLevel (values.Select(v => (IEvidenceLevel) new EvidenceLevelMedicalEvidenceLevel (v))); }
        }
        public struct EvidenceLevelMedicalEvidenceLevel : IEvidenceLevel<MedicalEvidenceLevel>
        {
            object IValue.Value => this.Value;
            public MedicalEvidenceLevel Value { get; }
            public EvidenceLevelMedicalEvidenceLevel (MedicalEvidenceLevel value) { Value = value; }
            public static implicit operator EvidenceLevelMedicalEvidenceLevel (MedicalEvidenceLevel value) { return new EvidenceLevelMedicalEvidenceLevel (value); }
        }

        public interface IEvidenceOrigin : IValue {}
        public interface IEvidenceOrigin<T> : IEvidenceOrigin { new T Value { get; } }
        public class OneOrManyEvidenceOrigin : OneOrMany<IEvidenceOrigin>
        {
            public OneOrManyEvidenceOrigin(IEvidenceOrigin item) : base(item) { }
            public OneOrManyEvidenceOrigin(IEnumerable<IEvidenceOrigin> items) : base(items) { }
            public static implicit operator OneOrManyEvidenceOrigin (string value) { return new OneOrManyEvidenceOrigin (new EvidenceOriginstring (value)); }
            public static implicit operator OneOrManyEvidenceOrigin (string[] values) { return new OneOrManyEvidenceOrigin (values.Select(v => (IEvidenceOrigin) new EvidenceOriginstring (v))); }
            public static implicit operator OneOrManyEvidenceOrigin (List<string> values) { return new OneOrManyEvidenceOrigin (values.Select(v => (IEvidenceOrigin) new EvidenceOriginstring (v))); }
        }
        public struct EvidenceOriginstring : IEvidenceOrigin<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public EvidenceOriginstring (string value) { Value = value; }
            public static implicit operator EvidenceOriginstring (string value) { return new EvidenceOriginstring (value); }
        }

        public interface IGuidelineDate : IValue {}
        public interface IGuidelineDate<T> : IGuidelineDate { new T Value { get; } }
        public class OneOrManyGuidelineDate : OneOrMany<IGuidelineDate>
        {
            public OneOrManyGuidelineDate(IGuidelineDate item) : base(item) { }
            public OneOrManyGuidelineDate(IEnumerable<IGuidelineDate> items) : base(items) { }
            public static implicit operator OneOrManyGuidelineDate (DateTimeOffset value) { return new OneOrManyGuidelineDate (new GuidelineDateDateTimeOffset (value)); }
            public static implicit operator OneOrManyGuidelineDate (DateTimeOffset[] values) { return new OneOrManyGuidelineDate (values.Select(v => (IGuidelineDate) new GuidelineDateDateTimeOffset (v))); }
            public static implicit operator OneOrManyGuidelineDate (List<DateTimeOffset> values) { return new OneOrManyGuidelineDate (values.Select(v => (IGuidelineDate) new GuidelineDateDateTimeOffset (v))); }
        }
        public struct GuidelineDateDateTimeOffset : IGuidelineDate<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public GuidelineDateDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator GuidelineDateDateTimeOffset (DateTimeOffset value) { return new GuidelineDateDateTimeOffset (value); }
        }

        public interface IGuidelineSubject : IValue {}
        public interface IGuidelineSubject<T> : IGuidelineSubject { new T Value { get; } }
        public class OneOrManyGuidelineSubject : OneOrMany<IGuidelineSubject>
        {
            public OneOrManyGuidelineSubject(IGuidelineSubject item) : base(item) { }
            public OneOrManyGuidelineSubject(IEnumerable<IGuidelineSubject> items) : base(items) { }
            public static implicit operator OneOrManyGuidelineSubject (MedicalEntity value) { return new OneOrManyGuidelineSubject (new GuidelineSubjectMedicalEntity (value)); }
            public static implicit operator OneOrManyGuidelineSubject (MedicalEntity[] values) { return new OneOrManyGuidelineSubject (values.Select(v => (IGuidelineSubject) new GuidelineSubjectMedicalEntity (v))); }
            public static implicit operator OneOrManyGuidelineSubject (List<MedicalEntity> values) { return new OneOrManyGuidelineSubject (values.Select(v => (IGuidelineSubject) new GuidelineSubjectMedicalEntity (v))); }
        }
        public struct GuidelineSubjectMedicalEntity : IGuidelineSubject<MedicalEntity>
        {
            object IValue.Value => this.Value;
            public MedicalEntity Value { get; }
            public GuidelineSubjectMedicalEntity (MedicalEntity value) { Value = value; }
            public static implicit operator GuidelineSubjectMedicalEntity (MedicalEntity value) { return new GuidelineSubjectMedicalEntity (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalGuideline";

        /// <summary>
        /// Strength of evidence of the data used to formulate the guideline (enumerated).
        /// </summary>
        [DataMember(Name = "evidenceLevel", Order = 206)]
        public OneOrManyEvidenceLevel EvidenceLevel { get; set; }

        /// <summary>
        /// Source of the data used to formulate the guidance, e.g. RCT, consensus opinion, etc.
        /// </summary>
        [DataMember(Name = "evidenceOrigin", Order = 207)]
        public OneOrManyEvidenceOrigin EvidenceOrigin { get; set; }

        /// <summary>
        /// Date on which this guideline's recommendation was made.
        /// </summary>
        [DataMember(Name = "guidelineDate", Order = 208)]
        public OneOrManyGuidelineDate GuidelineDate { get; set; }

        /// <summary>
        /// The medical conditions, treatments, etc. that are the subject of the guideline.
        /// </summary>
        [DataMember(Name = "guidelineSubject", Order = 209)]
        public OneOrManyGuidelineSubject GuidelineSubject { get; set; }
    }
}
