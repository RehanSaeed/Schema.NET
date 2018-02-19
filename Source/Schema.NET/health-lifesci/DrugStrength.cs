using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A specific strength in which a medical drug is available in a specific country.
    /// </summary>
    [DataContract]
    public partial class DrugStrength : MedicalIntangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DrugStrength";

        /// <summary>
        /// An active ingredient, typically chemical compounds and/or biologic substances.
        /// </summary>
        [DataMember(Name = "activeIngredient", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? ActiveIngredient { get; set; } 

        /// <summary>
        /// The location in which the strength is available.
        /// </summary>
        [DataMember(Name = "availableIn", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<AdministrativeArea>? AvailableIn { get; set; } 

        /// <summary>
        /// Recommended intake of this supplement for a given population as defined by a specific recommending authority.
        /// </summary>
        [DataMember(Name = "maximumIntake", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MaximumDoseSchedule>? MaximumIntake { get; set; } 

        /// <summary>
        /// The units of an active ingredient's strength, e.g. mg.
        /// </summary>
        [DataMember(Name = "strengthUnit", Order = 309)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? StrengthUnit { get; set; } 

        /// <summary>
        /// The value of an active ingredient's strength, e.g. 325.
        /// </summary>
        [DataMember(Name = "strengthValue", Order = 310)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<double>? StrengthValue { get; set; } 
    }
}
