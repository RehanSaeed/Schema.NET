namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A specific dosing schedule for a drug or supplement.
    /// </summary>
    public partial interface IDoseSchedule : IMedicalIntangible
    {
        /// <summary>
        /// The unit of the dose, e.g. 'mg'.
        /// </summary>
        OneOrMany<string> DoseUnit { get; set; }

        /// <summary>
        /// The value of the dose, e.g. 500.
        /// </summary>
        OneOrMany<double?> DoseValue { get; set; }

        /// <summary>
        /// How often the dose is taken, e.g. 'daily'.
        /// </summary>
        OneOrMany<string> Frequency { get; set; }

        /// <summary>
        /// Characteristics of the population for which this is intended, or which typically uses it, e.g. 'adults'.
        /// </summary>
        OneOrMany<string> TargetPopulation { get; set; }
    }

    /// <summary>
    /// A specific dosing schedule for a drug or supplement.
    /// </summary>
    [DataContract]
    public partial class DoseSchedule : MedicalIntangible, IDoseSchedule
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DoseSchedule";

        /// <summary>
        /// The unit of the dose, e.g. 'mg'.
        /// </summary>
        [DataMember(Name = "doseUnit", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> DoseUnit { get; set; }

        /// <summary>
        /// The value of the dose, e.g. 500.
        /// </summary>
        [DataMember(Name = "doseValue", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<double?> DoseValue { get; set; }

        /// <summary>
        /// How often the dose is taken, e.g. 'daily'.
        /// </summary>
        [DataMember(Name = "frequency", Order = 308)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Frequency { get; set; }

        /// <summary>
        /// Characteristics of the population for which this is intended, or which typically uses it, e.g. 'adults'.
        /// </summary>
        [DataMember(Name = "targetPopulation", Order = 309)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> TargetPopulation { get; set; }
    }
}
