namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A risk factor is anything that increases a person's likelihood of developing or contracting a disease, medical condition, or complication.
    /// </summary>
    public partial interface IMedicalRiskFactor : IMedicalEntity
    {
        /// <summary>
        /// The condition, complication, etc. influenced by this factor.
        /// </summary>
        OneOrMany<IMedicalEntity> IncreasesRiskOf { get; set; }
    }

    /// <summary>
    /// A risk factor is anything that increases a person's likelihood of developing or contracting a disease, medical condition, or complication.
    /// </summary>
    [DataContract]
    public partial class MedicalRiskFactor : MedicalEntity, IMedicalRiskFactor
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalRiskFactor";

        /// <summary>
        /// The condition, complication, etc. influenced by this factor.
        /// </summary>
        [DataMember(Name = "increasesRiskOf", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMedicalEntity> IncreasesRiskOf { get; set; }
    }
}
