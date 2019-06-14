namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Any medical test, typically performed for diagnostic purposes.
    /// </summary>
    public partial interface IMedicalTest : IMedicalEntity
    {
        /// <summary>
        /// Drugs that affect the test's results.
        /// </summary>
        OneOrMany<IDrug, Drug> AffectedBy { get; set; }

        /// <summary>
        /// Range of acceptable values for a typical patient, when applicable.
        /// </summary>
        Values<MedicalEnumeration?, string>? NormalRange { get; set; }

        /// <summary>
        /// A sign detected by the test.
        /// </summary>
        OneOrMany<IMedicalSign, MedicalSign> SignDetected { get; set; }

        /// <summary>
        /// A condition the test is used to diagnose.
        /// </summary>
        OneOrMany<IMedicalCondition, MedicalCondition> UsedToDiagnose { get; set; }

        /// <summary>
        /// Device used to perform the test.
        /// </summary>
        OneOrMany<IMedicalDevice, MedicalDevice> UsesDevice { get; set; }
    }

    /// <summary>
    /// Any medical test, typically performed for diagnostic purposes.
    /// </summary>
    [DataContract]
    public partial class MedicalTest : MedicalEntity, IMedicalTest
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalTest";

        /// <summary>
        /// Drugs that affect the test's results.
        /// </summary>
        [DataMember(Name = "affectedBy", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IDrug, Drug> AffectedBy { get; set; }

        /// <summary>
        /// Range of acceptable values for a typical patient, when applicable.
        /// </summary>
        [DataMember(Name = "normalRange", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<MedicalEnumeration?, string>? NormalRange { get; set; }

        /// <summary>
        /// A sign detected by the test.
        /// </summary>
        [DataMember(Name = "signDetected", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMedicalSign, MedicalSign> SignDetected { get; set; }

        /// <summary>
        /// A condition the test is used to diagnose.
        /// </summary>
        [DataMember(Name = "usedToDiagnose", Order = 209)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMedicalCondition, MedicalCondition> UsedToDiagnose { get; set; }

        /// <summary>
        /// Device used to perform the test.
        /// </summary>
        [DataMember(Name = "usesDevice", Order = 210)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMedicalDevice, MedicalDevice> UsesDevice { get; set; }
    }
}
