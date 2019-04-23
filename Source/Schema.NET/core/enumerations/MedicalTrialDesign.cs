namespace Schema.NET
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Design models for medical trials. Enumerated type.
    /// </summary>
    public enum MedicalTrialDesign
    {
        /// <summary>
        /// A trial design in which neither the researcher nor the patient knows the details of the treatment the patient was randomly assigned to.
        /// </summary>
        [EnumMember(Value = "http://schema.org/DoubleBlindedTrial")]
        DoubleBlindedTrial,

        /// <summary>
        /// An international trial.
        /// </summary>
        [EnumMember(Value = "http://schema.org/InternationalTrial")]
        InternationalTrial,

        /// <summary>
        /// A trial that takes place at multiple centers.
        /// </summary>
        [EnumMember(Value = "http://schema.org/MultiCenterTrial")]
        MultiCenterTrial,

        /// <summary>
        /// A trial design in which the researcher knows the full details of the treatment, and so does the patient.
        /// </summary>
        [EnumMember(Value = "http://schema.org/OpenTrial")]
        OpenTrial,

        /// <summary>
        /// A placebo-controlled trial design.
        /// </summary>
        [EnumMember(Value = "http://schema.org/PlaceboControlledTrial")]
        PlaceboControlledTrial,

        /// <summary>
        /// A randomized trial design.
        /// </summary>
        [EnumMember(Value = "http://schema.org/RandomizedTrial")]
        RandomizedTrial,

        /// <summary>
        /// A trial design in which the researcher knows which treatment the patient was randomly assigned to but the patient does not.
        /// </summary>
        [EnumMember(Value = "http://schema.org/SingleBlindedTrial")]
        SingleBlindedTrial,

        /// <summary>
        /// A trial that takes place at a single center.
        /// </summary>
        [EnumMember(Value = "http://schema.org/SingleCenterTrial")]
        SingleCenterTrial,

        /// <summary>
        /// A trial design in which neither the researcher, the person administering the therapy nor the patient knows the details of the treatment the patient was randomly assigned to.
        /// </summary>
        [EnumMember(Value = "http://schema.org/TripleBlindedTrial")]
        TripleBlindedTrial
    }
}
