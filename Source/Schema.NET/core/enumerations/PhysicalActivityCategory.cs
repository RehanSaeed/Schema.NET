namespace Schema.NET
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Categories of physical activity, organized by physiologic classification.
    /// </summary>
    public enum PhysicalActivityCategory
    {
        /// <summary>
        /// Physical activity of relatively low intensity that depends primarily on the aerobic energy-generating process; during activity, the aerobic metabolism uses oxygen to adequately meet energy demands during exercise.
        /// </summary>
        [EnumMember(Value = "http://schema.org/AerobicActivity")]
        AerobicActivity,

        /// <summary>
        /// Physical activity that is of high-intensity which utilizes the anaerobic metabolism of the body.
        /// </summary>
        [EnumMember(Value = "http://schema.org/AnaerobicActivity")]
        AnaerobicActivity,

        /// <summary>
        /// Physical activity that is engaged to help maintain posture and balance.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Balance")]
        Balance,

        /// <summary>
        /// Physical activity that is engaged in to improve joint and muscle flexibility.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Flexibility")]
        Flexibility,

        /// <summary>
        /// Any physical activity engaged in for recreational purposes. Examples may include ballroom dancing, roller skating, canoeing, fishing, etc.
        /// </summary>
        [EnumMember(Value = "http://schema.org/LeisureTimeActivity")]
        LeisureTimeActivity,

        /// <summary>
        /// Any physical activity engaged in for job-related purposes. Examples may include waiting tables, maid service, carrying a mailbag, picking fruits or vegetables, construction work, etc.
        /// </summary>
        [EnumMember(Value = "http://schema.org/OccupationalActivity")]
        OccupationalActivity,

        /// <summary>
        /// Physical activity that is engaged in to improve muscle and bone strength. Also referred to as resistance training.
        /// </summary>
        [EnumMember(Value = "http://schema.org/StrengthTraining")]
        StrengthTraining
    }
}
