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
        OneOrMany<IDrug> AffectedBy { get; set; }

        /// <summary>
        /// Range of acceptable values for a typical patient, when applicable.
        /// </summary>
        Values<MedicalEnumeration?, string> NormalRange { get; set; }

        /// <summary>
        /// A sign detected by the test.
        /// </summary>
        OneOrMany<IMedicalSign> SignDetected { get; set; }

        /// <summary>
        /// A condition the test is used to diagnose.
        /// </summary>
        OneOrMany<IMedicalCondition> UsedToDiagnose { get; set; }

        /// <summary>
        /// Device used to perform the test.
        /// </summary>
        OneOrMany<IMedicalDevice> UsesDevice { get; set; }
    }

    /// <summary>
    /// Any medical test, typically performed for diagnostic purposes.
    /// </summary>
    [DataContract]
    public partial class MedicalTest : MedicalEntity, IMedicalTest, IEquatable<MedicalTest>
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
        public OneOrMany<IDrug> AffectedBy { get; set; }

        /// <summary>
        /// Range of acceptable values for a typical patient, when applicable.
        /// </summary>
        [DataMember(Name = "normalRange", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<MedicalEnumeration?, string> NormalRange { get; set; }

        /// <summary>
        /// A sign detected by the test.
        /// </summary>
        [DataMember(Name = "signDetected", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMedicalSign> SignDetected { get; set; }

        /// <summary>
        /// A condition the test is used to diagnose.
        /// </summary>
        [DataMember(Name = "usedToDiagnose", Order = 209)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMedicalCondition> UsedToDiagnose { get; set; }

        /// <summary>
        /// Device used to perform the test.
        /// </summary>
        [DataMember(Name = "usesDevice", Order = 210)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMedicalDevice> UsesDevice { get; set; }

        /// <inheritdoc/>
        public bool Equals(MedicalTest other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Type == other.Type &&
                this.AffectedBy == other.AffectedBy &&
                this.NormalRange == other.NormalRange &&
                this.SignDetected == other.SignDetected &&
                this.UsedToDiagnose == other.UsedToDiagnose &&
                this.UsesDevice == other.UsesDevice &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as MedicalTest);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.AffectedBy)
            .And(this.NormalRange)
            .And(this.SignDetected)
            .And(this.UsedToDiagnose)
            .And(this.UsesDevice)
            .And(base.GetHashCode());
    }
}
