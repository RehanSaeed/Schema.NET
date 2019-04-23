namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Any physical manifestation of a person's medical condition discoverable by objective diagnostic tests or physical examination.
    /// </summary>
    [DataContract]
    public partial class MedicalSign : MedicalSignOrSymptom
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalSign";

        /// <summary>
        /// A physical examination that can identify this sign.
        /// </summary>
        [DataMember(Name = "identifyingExam", Order = 406)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<PhysicalExam?>? IdentifyingExam { get; set; }

        /// <summary>
        /// A diagnostic test that can identify this sign.
        /// </summary>
        [DataMember(Name = "identifyingTest", Order = 407)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<MedicalTest>? IdentifyingTest { get; set; }
    }
}
