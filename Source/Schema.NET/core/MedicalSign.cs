namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Any physical manifestation of a person's medical condition discoverable by objective diagnostic tests or physical examination.
    /// </summary>
    public partial interface IMedicalSign : IMedicalSignOrSymptom
    {
        /// <summary>
        /// A physical examination that can identify this sign.
        /// </summary>
        OneOrMany<PhysicalExam?> IdentifyingExam { get; set; }

        /// <summary>
        /// A diagnostic test that can identify this sign.
        /// </summary>
        OneOrMany<IMedicalTest> IdentifyingTest { get; set; }
    }

    /// <summary>
    /// Any physical manifestation of a person's medical condition discoverable by objective diagnostic tests or physical examination.
    /// </summary>
    [DataContract]
    public partial class MedicalSign : MedicalSignOrSymptom, IMedicalSign, IEquatable<MedicalSign>
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
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<PhysicalExam?> IdentifyingExam { get; set; }

        /// <summary>
        /// A diagnostic test that can identify this sign.
        /// </summary>
        [DataMember(Name = "identifyingTest", Order = 407)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMedicalTest> IdentifyingTest { get; set; }

        /// <inheritdoc/>
        public bool Equals(MedicalSign other)
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
                this.IdentifyingExam == other.IdentifyingExam &&
                this.IdentifyingTest == other.IdentifyingTest &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as MedicalSign);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.IdentifyingExam)
            .And(this.IdentifyingTest)
            .And(base.GetHashCode());
    }
}
