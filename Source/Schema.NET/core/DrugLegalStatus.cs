namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The legal availability status of a medical drug.
    /// </summary>
    public partial interface IDrugLegalStatus : IMedicalIntangible
    {
        /// <summary>
        /// The location in which the status applies.
        /// </summary>
        OneOrMany<IAdministrativeArea, AdministrativeArea> ApplicableLocation { get; set; }
    }

    /// <summary>
    /// The legal availability status of a medical drug.
    /// </summary>
    [DataContract]
    public partial class DrugLegalStatus : MedicalIntangible, IDrugLegalStatus
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DrugLegalStatus";

        /// <summary>
        /// The location in which the status applies.
        /// </summary>
        [DataMember(Name = "applicableLocation", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IAdministrativeArea, AdministrativeArea> ApplicableLocation { get; set; }
    }
}
