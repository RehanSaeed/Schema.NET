namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The anatomical location at which two or more bones make contact.
    /// </summary>
    [DataContract]
    public partial class Joint : AnatomicalStructure
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Joint";

        /// <summary>
        /// The biomechanical properties of the bone.
        /// </summary>
        [DataMember(Name = "biomechnicalClass", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? BiomechnicalClass { get; set; }

        /// <summary>
        /// The degree of mobility the joint allows.
        /// </summary>
        [DataMember(Name = "functionalClass", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MedicalEntity, string>? FunctionalClass { get; set; }

        /// <summary>
        /// The name given to how bone physically connects to each other.
        /// </summary>
        [DataMember(Name = "structuralClass", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? StructuralClass { get; set; }
    }
}
