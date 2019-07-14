namespace Schema.NET
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Target audiences for medical web pages. Enumerated type.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MedicalAudience
    {
        /// <summary>
        /// Medical clinicians, including practicing physicians and other medical professionals involved in clinical practice.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Clinician")]
        Clinician,

        /// <summary>
        /// Medical researchers.
        /// </summary>
        [EnumMember(Value = "http://schema.org/MedicalResearcher")]
        MedicalResearcher
    }
}
