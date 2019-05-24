namespace Schema.NET
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Level of evidence for a medical guideline. Enumerated type.
    /// </summary>
    public enum MedicalEvidenceLevel
    {
        /// <summary>
        /// Data derived from multiple randomized clinical trials or meta-analyses.
        /// </summary>
        [EnumMember(Value = "http://schema.org/EvidenceLevelA")]
        EvidenceLevelA,

        /// <summary>
        /// Data derived from a single randomized trial, or nonrandomized studies.
        /// </summary>
        [EnumMember(Value = "http://schema.org/EvidenceLevelB")]
        EvidenceLevelB,

        /// <summary>
        /// Only consensus opinion of experts, case studies, or standard-of-care.
        /// </summary>
        [EnumMember(Value = "http://schema.org/EvidenceLevelC")]
        EvidenceLevelC
    }
}
