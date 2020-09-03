namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A patient is any person recipient of health care services.
    /// </summary>
    public partial interface IPatient : IMedicalAudienceAndPerson
    {
        /// <summary>
        /// One or more alternative conditions considered in the differential diagnosis process as output of a diagnosis process.
        /// </summary>
        OneOrMany<IMedicalCondition> Diagnosis { get; set; }

        /// <summary>
        /// Specifying a drug or medicine used in a medication procedure
        /// </summary>
        OneOrMany<IDrug> Drug { get; set; }
    }

    /// <summary>
    /// A patient is any person recipient of health care services.
    /// </summary>
    [DataContract]
    public partial class Patient : MedicalAudienceAndPerson, IPatient, IEquatable<Patient>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Patient";

        /// <summary>
        /// One or more alternative conditions considered in the differential diagnosis process as output of a diagnosis process.
        /// </summary>
        [DataMember(Name = "diagnosis", Order = 506)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMedicalCondition> Diagnosis { get; set; }

        /// <summary>
        /// Specifying a drug or medicine used in a medication procedure
        /// </summary>
        [DataMember(Name = "drug", Order = 507)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IDrug> Drug { get; set; }

        /// <summary>
        /// Specifying the health condition(s) of a patient, medical study, or other target audience.
        /// </summary>
        [DataMember(Name = "healthCondition", Order = 508)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<IMedicalCondition> HealthCondition { get; set; }

        /// <inheritdoc/>
        public bool Equals(Patient other)
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
                this.Diagnosis == other.Diagnosis &&
                this.Drug == other.Drug &&
                this.HealthCondition == other.HealthCondition &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as Patient);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.Diagnosis)
            .And(this.Drug)
            .And(this.HealthCondition)
            .And(base.GetHashCode());
    }
}
