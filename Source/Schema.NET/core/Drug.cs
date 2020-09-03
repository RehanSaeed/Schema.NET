namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A chemical or biologic substance, used as a medical therapy, that has a physiological effect on an organism. Here the term drug is used interchangeably with the term medicine although clinical knowledge make a clear difference between them.
    /// </summary>
    public partial interface IDrug : ISubstance
    {
        /// <summary>
        /// A route by which this drug may be administered, e.g. 'oral'.
        /// </summary>
        OneOrMany<string> AdministrationRoute { get; set; }

        /// <summary>
        /// Any precaution, guidance, contraindication, etc. related to consumption of alcohol while taking this drug.
        /// </summary>
        OneOrMany<string> AlcoholWarning { get; set; }

        /// <summary>
        /// An available dosage strength for the drug.
        /// </summary>
        OneOrMany<IDrugStrength> AvailableStrength { get; set; }

        /// <summary>
        /// Any precaution, guidance, contraindication, etc. related to this drug's use by breastfeeding mothers.
        /// </summary>
        OneOrMany<string> BreastfeedingWarning { get; set; }

        /// <summary>
        /// Description of the absorption and elimination of drugs, including their concentration (pharmacokinetics, pK) and biological effects (pharmacodynamics, pD).
        /// </summary>
        OneOrMany<string> ClinicalPharmacology { get; set; }

        /// <summary>
        /// A dosage form in which this drug/supplement is available, e.g. 'tablet', 'suspension', 'injection'.
        /// </summary>
        OneOrMany<string> DosageForm { get; set; }

        /// <summary>
        /// A dosing schedule for the drug for a given population, either observed, recommended, or maximum dose based on the type used.
        /// </summary>
        OneOrMany<IDoseSchedule> DoseSchedule { get; set; }

        /// <summary>
        /// The class of drug this belongs to (e.g., statins).
        /// </summary>
        OneOrMany<IDrugClass> DrugClass { get; set; }

        /// <summary>
        /// The unit in which the drug is measured, e.g. '5 mg tablet'.
        /// </summary>
        OneOrMany<string> DrugUnit { get; set; }

        /// <summary>
        /// Any precaution, guidance, contraindication, etc. related to consumption of specific foods while taking this drug.
        /// </summary>
        OneOrMany<string> FoodWarning { get; set; }

        /// <summary>
        /// Another drug that is known to interact with this drug in a way that impacts the effect of this drug or causes a risk to the patient. Note: disease interactions are typically captured as contraindications.
        /// </summary>
        OneOrMany<IDrug> InteractingDrug { get; set; }

        /// <summary>
        /// True if the drug is available in a generic form (regardless of name).
        /// </summary>
        OneOrMany<bool?> IsAvailableGenerically { get; set; }

        /// <summary>
        /// True if this item's name is a proprietary/brand name (vs. generic name).
        /// </summary>
        OneOrMany<bool?> IsProprietary { get; set; }

        /// <summary>
        /// Link to the drug's label details.
        /// </summary>
        OneOrMany<Uri> LabelDetails { get; set; }

        /// <summary>
        /// The manufacturer of the product.
        /// </summary>
        OneOrMany<IOrganization> Manufacturer { get; set; }

        /// <summary>
        /// The specific biochemical interaction through which this drug or supplement produces its pharmacological effect.
        /// </summary>
        OneOrMany<string> MechanismOfAction { get; set; }

        /// <summary>
        /// The generic name of this drug or supplement.
        /// </summary>
        OneOrMany<string> NonProprietaryName { get; set; }

        /// <summary>
        /// Any information related to overdose on a drug, including signs or symptoms, treatments, contact information for emergency response.
        /// </summary>
        OneOrMany<string> Overdosage { get; set; }

        /// <summary>
        /// Pregnancy category of this drug.
        /// </summary>
        OneOrMany<DrugPregnancyCategory?> PregnancyCategory { get; set; }

        /// <summary>
        /// Any precaution, guidance, contraindication, etc. related to this drug's use during pregnancy.
        /// </summary>
        OneOrMany<string> PregnancyWarning { get; set; }

        /// <summary>
        /// Link to prescribing information for the drug.
        /// </summary>
        OneOrMany<Uri> PrescribingInfo { get; set; }

        /// <summary>
        /// Indicates the status of drug prescription eg. local catalogs classifications or whether the drug is available by prescription or over-the-counter, etc.
        /// </summary>
        Values<DrugPrescriptionStatus?, string> PrescriptionStatus { get; set; }

        /// <summary>
        /// Proprietary name given to the diet plan, typically by its originator or creator.
        /// </summary>
        OneOrMany<string> ProprietaryName { get; set; }

        /// <summary>
        /// Any other drug related to this one, for example commonly-prescribed alternatives.
        /// </summary>
        OneOrMany<IDrug> RelatedDrug { get; set; }

        /// <summary>
        /// The RxCUI drug identifier from RXNORM.
        /// </summary>
        OneOrMany<string> Rxcui { get; set; }

        /// <summary>
        /// Any FDA or other warnings about the drug (text or URL).
        /// </summary>
        Values<string, Uri> Warning { get; set; }
    }

    /// <summary>
    /// A chemical or biologic substance, used as a medical therapy, that has a physiological effect on an organism. Here the term drug is used interchangeably with the term medicine although clinical knowledge make a clear difference between them.
    /// </summary>
    [DataContract]
    public partial class Drug : Substance, IDrug, IEquatable<Drug>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Drug";

        /// <summary>
        /// An active ingredient, typically chemical compounds and/or biologic substances.
        /// </summary>
        [DataMember(Name = "activeIngredient", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<string> ActiveIngredient { get; set; }

        /// <summary>
        /// A route by which this drug may be administered, e.g. 'oral'.
        /// </summary>
        [DataMember(Name = "administrationRoute", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> AdministrationRoute { get; set; }

        /// <summary>
        /// Any precaution, guidance, contraindication, etc. related to consumption of alcohol while taking this drug.
        /// </summary>
        [DataMember(Name = "alcoholWarning", Order = 308)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> AlcoholWarning { get; set; }

        /// <summary>
        /// An available dosage strength for the drug.
        /// </summary>
        [DataMember(Name = "availableStrength", Order = 309)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IDrugStrength> AvailableStrength { get; set; }

        /// <summary>
        /// Any precaution, guidance, contraindication, etc. related to this drug's use by breastfeeding mothers.
        /// </summary>
        [DataMember(Name = "breastfeedingWarning", Order = 310)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> BreastfeedingWarning { get; set; }

        /// <summary>
        /// Description of the absorption and elimination of drugs, including their concentration (pharmacokinetics, pK) and biological effects (pharmacodynamics, pD).
        /// </summary>
        [DataMember(Name = "clinicalPharmacology", Order = 311)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ClinicalPharmacology { get; set; }

        /// <summary>
        /// A dosage form in which this drug/supplement is available, e.g. 'tablet', 'suspension', 'injection'.
        /// </summary>
        [DataMember(Name = "dosageForm", Order = 312)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> DosageForm { get; set; }

        /// <summary>
        /// A dosing schedule for the drug for a given population, either observed, recommended, or maximum dose based on the type used.
        /// </summary>
        [DataMember(Name = "doseSchedule", Order = 313)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IDoseSchedule> DoseSchedule { get; set; }

        /// <summary>
        /// The class of drug this belongs to (e.g., statins).
        /// </summary>
        [DataMember(Name = "drugClass", Order = 314)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IDrugClass> DrugClass { get; set; }

        /// <summary>
        /// The unit in which the drug is measured, e.g. '5 mg tablet'.
        /// </summary>
        [DataMember(Name = "drugUnit", Order = 315)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> DrugUnit { get; set; }

        /// <summary>
        /// Any precaution, guidance, contraindication, etc. related to consumption of specific foods while taking this drug.
        /// </summary>
        [DataMember(Name = "foodWarning", Order = 316)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> FoodWarning { get; set; }

        /// <summary>
        /// Another drug that is known to interact with this drug in a way that impacts the effect of this drug or causes a risk to the patient. Note: disease interactions are typically captured as contraindications.
        /// </summary>
        [DataMember(Name = "interactingDrug", Order = 317)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IDrug> InteractingDrug { get; set; }

        /// <summary>
        /// True if the drug is available in a generic form (regardless of name).
        /// </summary>
        [DataMember(Name = "isAvailableGenerically", Order = 318)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<bool?> IsAvailableGenerically { get; set; }

        /// <summary>
        /// True if this item's name is a proprietary/brand name (vs. generic name).
        /// </summary>
        [DataMember(Name = "isProprietary", Order = 319)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<bool?> IsProprietary { get; set; }

        /// <summary>
        /// Link to the drug's label details.
        /// </summary>
        [DataMember(Name = "labelDetails", Order = 320)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<Uri> LabelDetails { get; set; }

        /// <summary>
        /// The drug or supplement's legal status, including any controlled substance schedules that apply.
        /// </summary>
        [DataMember(Name = "legalStatus", Order = 321)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override Values<IDrugLegalStatus, MedicalEnumeration?, string> LegalStatus { get; set; }

        /// <summary>
        /// The manufacturer of the product.
        /// </summary>
        [DataMember(Name = "manufacturer", Order = 322)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOrganization> Manufacturer { get; set; }

        /// <summary>
        /// Recommended intake of this supplement for a given population as defined by a specific recommending authority.
        /// </summary>
        [DataMember(Name = "maximumIntake", Order = 323)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<IMaximumDoseSchedule> MaximumIntake { get; set; }

        /// <summary>
        /// The specific biochemical interaction through which this drug or supplement produces its pharmacological effect.
        /// </summary>
        [DataMember(Name = "mechanismOfAction", Order = 324)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> MechanismOfAction { get; set; }

        /// <summary>
        /// The generic name of this drug or supplement.
        /// </summary>
        [DataMember(Name = "nonProprietaryName", Order = 325)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> NonProprietaryName { get; set; }

        /// <summary>
        /// Any information related to overdose on a drug, including signs or symptoms, treatments, contact information for emergency response.
        /// </summary>
        [DataMember(Name = "overdosage", Order = 326)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Overdosage { get; set; }

        /// <summary>
        /// Pregnancy category of this drug.
        /// </summary>
        [DataMember(Name = "pregnancyCategory", Order = 327)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<DrugPregnancyCategory?> PregnancyCategory { get; set; }

        /// <summary>
        /// Any precaution, guidance, contraindication, etc. related to this drug's use during pregnancy.
        /// </summary>
        [DataMember(Name = "pregnancyWarning", Order = 328)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> PregnancyWarning { get; set; }

        /// <summary>
        /// Link to prescribing information for the drug.
        /// </summary>
        [DataMember(Name = "prescribingInfo", Order = 329)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<Uri> PrescribingInfo { get; set; }

        /// <summary>
        /// Indicates the status of drug prescription eg. local catalogs classifications or whether the drug is available by prescription or over-the-counter, etc.
        /// </summary>
        [DataMember(Name = "prescriptionStatus", Order = 330)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<DrugPrescriptionStatus?, string> PrescriptionStatus { get; set; }

        /// <summary>
        /// Proprietary name given to the diet plan, typically by its originator or creator.
        /// </summary>
        [DataMember(Name = "proprietaryName", Order = 331)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ProprietaryName { get; set; }

        /// <summary>
        /// Any other drug related to this one, for example commonly-prescribed alternatives.
        /// </summary>
        [DataMember(Name = "relatedDrug", Order = 332)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IDrug> RelatedDrug { get; set; }

        /// <summary>
        /// The RxCUI drug identifier from RXNORM.
        /// </summary>
        [DataMember(Name = "rxcui", Order = 333)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Rxcui { get; set; }

        /// <summary>
        /// Any FDA or other warnings about the drug (text or URL).
        /// </summary>
        [DataMember(Name = "warning", Order = 334)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> Warning { get; set; }

        /// <inheritdoc/>
        public bool Equals(Drug other)
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
                this.AdministrationRoute == other.AdministrationRoute &&
                this.AlcoholWarning == other.AlcoholWarning &&
                this.AvailableStrength == other.AvailableStrength &&
                this.BreastfeedingWarning == other.BreastfeedingWarning &&
                this.ClinicalPharmacology == other.ClinicalPharmacology &&
                this.DosageForm == other.DosageForm &&
                this.DoseSchedule == other.DoseSchedule &&
                this.DrugClass == other.DrugClass &&
                this.DrugUnit == other.DrugUnit &&
                this.FoodWarning == other.FoodWarning &&
                this.InteractingDrug == other.InteractingDrug &&
                this.IsAvailableGenerically == other.IsAvailableGenerically &&
                this.IsProprietary == other.IsProprietary &&
                this.LabelDetails == other.LabelDetails &&
                this.LegalStatus == other.LegalStatus &&
                this.Manufacturer == other.Manufacturer &&
                this.MaximumIntake == other.MaximumIntake &&
                this.MechanismOfAction == other.MechanismOfAction &&
                this.NonProprietaryName == other.NonProprietaryName &&
                this.Overdosage == other.Overdosage &&
                this.PregnancyCategory == other.PregnancyCategory &&
                this.PregnancyWarning == other.PregnancyWarning &&
                this.PrescribingInfo == other.PrescribingInfo &&
                this.PrescriptionStatus == other.PrescriptionStatus &&
                this.ProprietaryName == other.ProprietaryName &&
                this.RelatedDrug == other.RelatedDrug &&
                this.Rxcui == other.Rxcui &&
                this.Warning == other.Warning &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as Drug);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.ActiveIngredient)
            .And(this.AdministrationRoute)
            .And(this.AlcoholWarning)
            .And(this.AvailableStrength)
            .And(this.BreastfeedingWarning)
            .And(this.ClinicalPharmacology)
            .And(this.DosageForm)
            .And(this.DoseSchedule)
            .And(this.DrugClass)
            .And(this.DrugUnit)
            .And(this.FoodWarning)
            .And(this.InteractingDrug)
            .And(this.IsAvailableGenerically)
            .And(this.IsProprietary)
            .And(this.LabelDetails)
            .And(this.LegalStatus)
            .And(this.Manufacturer)
            .And(this.MaximumIntake)
            .And(this.MechanismOfAction)
            .And(this.NonProprietaryName)
            .And(this.Overdosage)
            .And(this.PregnancyCategory)
            .And(this.PregnancyWarning)
            .And(this.PrescribingInfo)
            .And(this.PrescriptionStatus)
            .And(this.ProprietaryName)
            .And(this.RelatedDrug)
            .And(this.Rxcui)
            .And(this.Warning)
            .And(base.GetHashCode());
    }
}
