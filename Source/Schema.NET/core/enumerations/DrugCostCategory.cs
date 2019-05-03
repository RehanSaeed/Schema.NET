namespace Schema.NET
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Enumerated categories of medical drug costs.
    /// </summary>
    public enum DrugCostCategory
    {
        /// <summary>
        /// The drug's cost represents the maximum reimbursement paid by an insurer for the drug.
        /// </summary>
        [EnumMember(Value = "http://schema.org/ReimbursementCap")]
        ReimbursementCap,

        /// <summary>
        /// The drug's cost represents the retail cost of the drug.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Retail")]
        Retail,

        /// <summary>
        /// The drug's cost represents the wholesale acquisition cost of the drug.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Wholesale")]
        Wholesale
    }
}
