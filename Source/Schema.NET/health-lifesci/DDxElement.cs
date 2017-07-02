namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An alternative, closely-related condition typically considered later in the differential diagnosis process along with the signs that are used to distinguish it.
    /// </summary>
    [DataContract]
    public partial class DDxElement : MedicalIntangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DDxElement";

        /// <summary>
        /// One or more alternative conditions considered in the differential diagnosis process as output of a diagnosis process.
        /// </summary>
        [DataMember(Name = "diagnosis", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MedicalCondition>? Diagnosis { get; set; }

        /// <summary>
        /// One of a set of signs and symptoms that can be used to distinguish this diagnosis from others in the differential diagnosis.
        /// </summary>
        [DataMember(Name = "distinguishingSign", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MedicalSignOrSymptom>? DistinguishingSign { get; set; }
    }
}
