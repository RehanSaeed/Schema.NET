namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A specific strength in which a medical drug is available in a specific country.
    /// </summary>
    public partial interface IDrugStrength : IMedicalIntangible
    {
        /// <summary>
        /// An active ingredient, typically chemical compounds and/or biologic substances.
        /// </summary>
        OneOrMany<string> ActiveIngredient { get; set; }

        /// <summary>
        /// The location in which the strength is available.
        /// </summary>
        OneOrMany<IAdministrativeArea> AvailableIn { get; set; }

        /// <summary>
        /// Recommended intake of this supplement for a given population as defined by a specific recommending authority.
        /// </summary>
        OneOrMany<IMaximumDoseSchedule> MaximumIntake { get; set; }

        /// <summary>
        /// The units of an active ingredient's strength, e.g. mg.
        /// </summary>
        OneOrMany<string> StrengthUnit { get; set; }

        /// <summary>
        /// The value of an active ingredient's strength, e.g. 325.
        /// </summary>
        OneOrMany<double?> StrengthValue { get; set; }
    }

    /// <summary>
    /// A specific strength in which a medical drug is available in a specific country.
    /// </summary>
    [DataContract]
    public partial class DrugStrength : MedicalIntangible, IDrugStrength, IEquatable<DrugStrength>
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
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ActiveIngredient { get; set; }

        /// <summary>
        /// The location in which the strength is available.
        /// </summary>
        [DataMember(Name = "availableIn", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IAdministrativeArea> AvailableIn { get; set; }

        /// <summary>
        /// Recommended intake of this supplement for a given population as defined by a specific recommending authority.
        /// </summary>
        [DataMember(Name = "maximumIntake", Order = 308)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMaximumDoseSchedule> MaximumIntake { get; set; }

        /// <summary>
        /// The units of an active ingredient's strength, e.g. mg.
        /// </summary>
        [DataMember(Name = "strengthUnit", Order = 309)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> StrengthUnit { get; set; }

        /// <summary>
        /// The value of an active ingredient's strength, e.g. 325.
        /// </summary>
        [DataMember(Name = "strengthValue", Order = 310)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<double?> StrengthValue { get; set; }

        /// <inheritdoc/>
        public bool Equals(DrugStrength other)
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
                this.ActiveIngredient == other.ActiveIngredient &&
                this.AvailableIn == other.AvailableIn &&
                this.MaximumIntake == other.MaximumIntake &&
                this.StrengthUnit == other.StrengthUnit &&
                this.StrengthValue == other.StrengthValue &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as DrugStrength);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.ActiveIngredient)
            .And(this.AvailableIn)
            .And(this.MaximumIntake)
            .And(this.StrengthUnit)
            .And(this.StrengthValue)
            .And(base.GetHashCode());
    }
}
