namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Any recommendation made by a standard society (e.g. ACC/AHA) or consensus statement that denotes how to diagnose and treat a particular condition. Note: this type should be used to tag the actual guideline recommendation; if the guideline recommendation occurs in a larger scholarly article, use MedicalScholarlyArticle to tag the overall article, not this type. Note also: the organization making the recommendation should be captured in the recognizingAuthority base property of MedicalEntity.
    /// </summary>
    public partial interface IMedicalGuideline : IMedicalEntity
    {
        /// <summary>
        /// Strength of evidence of the data used to formulate the guideline (enumerated).
        /// </summary>
        OneOrMany<MedicalEvidenceLevel?>? EvidenceLevel { get; set; }

        /// <summary>
        /// Source of the data used to formulate the guidance, e.g. RCT, consensus opinion, etc.
        /// </summary>
        OneOrMany<string>? EvidenceOrigin { get; set; }

        /// <summary>
        /// Date on which this guideline's recommendation was made.
        /// </summary>
        OneOrMany<DateTimeOffset?>? GuidelineDate { get; set; }

        /// <summary>
        /// The medical conditions, treatments, etc. that are the subject of the guideline.
        /// </summary>
        OneOrMany<IMedicalEntity>? GuidelineSubject { get; set; }
    }

    /// <summary>
    /// Any recommendation made by a standard society (e.g. ACC/AHA) or consensus statement that denotes how to diagnose and treat a particular condition. Note: this type should be used to tag the actual guideline recommendation; if the guideline recommendation occurs in a larger scholarly article, use MedicalScholarlyArticle to tag the overall article, not this type. Note also: the organization making the recommendation should be captured in the recognizingAuthority base property of MedicalEntity.
    /// </summary>
    [DataContract]
    public partial class MedicalGuideline : MedicalEntity, IMedicalGuideline
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalGuideline";

        /// <summary>
        /// Strength of evidence of the data used to formulate the guideline (enumerated).
        /// </summary>
        [DataMember(Name = "evidenceLevel", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<MedicalEvidenceLevel?>? EvidenceLevel { get; set; }

        /// <summary>
        /// Source of the data used to formulate the guidance, e.g. RCT, consensus opinion, etc.
        /// </summary>
        [DataMember(Name = "evidenceOrigin", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? EvidenceOrigin { get; set; }

        /// <summary>
        /// Date on which this guideline's recommendation was made.
        /// </summary>
        [DataMember(Name = "guidelineDate", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<DateTimeOffset?>? GuidelineDate { get; set; }

        /// <summary>
        /// The medical conditions, treatments, etc. that are the subject of the guideline.
        /// </summary>
        [DataMember(Name = "guidelineSubject", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IMedicalEntity>? GuidelineSubject { get; set; }
    }
}
