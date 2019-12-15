namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An alternative, closely-related condition typically considered later in the differential diagnosis process along with the signs that are used to distinguish it.
    /// </summary>
    public partial interface IDDxElement : IMedicalIntangible
    {
        /// <summary>
        /// One or more alternative conditions considered in the differential diagnosis process as output of a diagnosis process.
        /// </summary>
        OneOrMany<IMedicalCondition> Diagnosis { get; set; }

        /// <summary>
        /// One of a set of signs and symptoms that can be used to distinguish this diagnosis from others in the differential diagnosis.
        /// </summary>
        OneOrMany<IMedicalSignOrSymptom> DistinguishingSign { get; set; }
    }

    /// <summary>
    /// An alternative, closely-related condition typically considered later in the differential diagnosis process along with the signs that are used to distinguish it.
    /// </summary>
    [DataContract]
    public partial class DDxElement : MedicalIntangible, IDDxElement, IEquatable<DDxElement>
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
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMedicalCondition> Diagnosis { get; set; }

        /// <summary>
        /// One of a set of signs and symptoms that can be used to distinguish this diagnosis from others in the differential diagnosis.
        /// </summary>
        [DataMember(Name = "distinguishingSign", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMedicalSignOrSymptom> DistinguishingSign { get; set; }

        /// <inheritdoc/>
        public bool Equals(DDxElement other)
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
                this.DistinguishingSign == other.DistinguishingSign &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as DDxElement);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.Diagnosis)
            .And(this.DistinguishingSign)
            .And(base.GetHashCode());
    }
}
