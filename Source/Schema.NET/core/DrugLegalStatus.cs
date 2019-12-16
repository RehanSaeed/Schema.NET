namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The legal availability status of a medical drug.
    /// </summary>
    public partial interface IDrugLegalStatus : IMedicalIntangible
    {
        /// <summary>
        /// The location in which the status applies.
        /// </summary>
        OneOrMany<IAdministrativeArea> ApplicableLocation { get; set; }
    }

    /// <summary>
    /// The legal availability status of a medical drug.
    /// </summary>
    [DataContract]
    public partial class DrugLegalStatus : MedicalIntangible, IDrugLegalStatus, IEquatable<DrugLegalStatus>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DrugLegalStatus";

        /// <summary>
        /// The location in which the status applies.
        /// </summary>
        [DataMember(Name = "applicableLocation", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IAdministrativeArea> ApplicableLocation { get; set; }

        /// <inheritdoc/>
        public bool Equals(DrugLegalStatus other)
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
                this.ApplicableLocation == other.ApplicableLocation &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as DrugLegalStatus);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.ApplicableLocation)
            .And(base.GetHashCode());
    }
}
