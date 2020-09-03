namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The cost per unit of a medical drug. Note that this type is not meant to represent the price in an offer of a drug for sale; see the Offer type for that. This type will typically be used to tag wholesale or average retail cost of a drug, or maximum reimbursable cost. Costs of medical drugs vary widely depending on how and where they are paid for, so while this type captures some of the variables, costs should be used with caution by consumers of this schema's markup.
    /// </summary>
    public partial interface IDrugCost : IMedicalEntity
    {
        /// <summary>
        /// The location in which the status applies.
        /// </summary>
        OneOrMany<IAdministrativeArea> ApplicableLocation { get; set; }

        /// <summary>
        /// The category of cost, such as wholesale, retail, reimbursement cap, etc.
        /// </summary>
        OneOrMany<DrugCostCategory?> CostCategory { get; set; }

        /// <summary>
        /// The currency (in 3-letter of the drug cost. See: http://en.wikipedia.org/wiki/ISO_4217
        /// </summary>
        OneOrMany<string> CostCurrency { get; set; }

        /// <summary>
        /// Additional details to capture the origin of the cost data. For example, 'Medicare Part B'.
        /// </summary>
        OneOrMany<string> CostOrigin { get; set; }

        /// <summary>
        /// The cost per unit of the drug.
        /// </summary>
        Values<double?, string> CostPerUnit { get; set; }

        /// <summary>
        /// The unit in which the drug is measured, e.g. '5 mg tablet'.
        /// </summary>
        OneOrMany<string> DrugUnit { get; set; }
    }

    /// <summary>
    /// The cost per unit of a medical drug. Note that this type is not meant to represent the price in an offer of a drug for sale; see the Offer type for that. This type will typically be used to tag wholesale or average retail cost of a drug, or maximum reimbursable cost. Costs of medical drugs vary widely depending on how and where they are paid for, so while this type captures some of the variables, costs should be used with caution by consumers of this schema's markup.
    /// </summary>
    [DataContract]
    public partial class DrugCost : MedicalEntity, IDrugCost, IEquatable<DrugCost>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DrugCost";

        /// <summary>
        /// The location in which the status applies.
        /// </summary>
        [DataMember(Name = "applicableLocation", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IAdministrativeArea> ApplicableLocation { get; set; }

        /// <summary>
        /// The category of cost, such as wholesale, retail, reimbursement cap, etc.
        /// </summary>
        [DataMember(Name = "costCategory", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<DrugCostCategory?> CostCategory { get; set; }

        /// <summary>
        /// The currency (in 3-letter of the drug cost. See: http://en.wikipedia.org/wiki/ISO_4217
        /// </summary>
        [DataMember(Name = "costCurrency", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> CostCurrency { get; set; }

        /// <summary>
        /// Additional details to capture the origin of the cost data. For example, 'Medicare Part B'.
        /// </summary>
        [DataMember(Name = "costOrigin", Order = 209)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> CostOrigin { get; set; }

        /// <summary>
        /// The cost per unit of the drug.
        /// </summary>
        [DataMember(Name = "costPerUnit", Order = 210)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<double?, string> CostPerUnit { get; set; }

        /// <summary>
        /// The unit in which the drug is measured, e.g. '5 mg tablet'.
        /// </summary>
        [DataMember(Name = "drugUnit", Order = 211)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> DrugUnit { get; set; }

        /// <inheritdoc/>
        public bool Equals(DrugCost other)
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
                this.CostCategory == other.CostCategory &&
                this.CostCurrency == other.CostCurrency &&
                this.CostOrigin == other.CostOrigin &&
                this.CostPerUnit == other.CostPerUnit &&
                this.DrugUnit == other.DrugUnit &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as DrugCost);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.ApplicableLocation)
            .And(this.CostCategory)
            .And(this.CostCurrency)
            .And(this.CostOrigin)
            .And(this.CostPerUnit)
            .And(this.DrugUnit)
            .And(base.GetHashCode());
    }
}
