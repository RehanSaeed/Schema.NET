namespace Schema.NET
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Level of evidence for a medical guideline. Enumerated type.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MedicalEvidenceLevel
    {
        /// <summary>
        /// Data derived from multiple randomized clinical trials or meta-analyses.
        /// </summary>
        [EnumMember(Value = "https://schema.org/EvidenceLevelA")]
        EvidenceLevelA,

        /// <summary>
        /// Data derived from a single randomized trial, or nonrandomized studies.
        /// </summary>
        [EnumMember(Value = "https://schema.org/EvidenceLevelB")]
        EvidenceLevelB,

        /// <summary>
        /// Only consensus opinion of experts, case studies, or standard-of-care.
        /// </summary>
        [EnumMember(Value = "https://schema.org/EvidenceLevelC")]
        EvidenceLevelC,
    }
}
