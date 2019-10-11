namespace Schema.NET
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// A diet restricted to certain foods or preparations for cultural, religious, health or lifestyle reasons.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RestrictedDiet
    {
        /// <summary>
        /// A diet appropriate for people with diabetes.
        /// </summary>
        [EnumMember(Value = "https://schema.org/DiabeticDiet")]
        DiabeticDiet,

        /// <summary>
        /// A diet exclusive of gluten.
        /// </summary>
        [EnumMember(Value = "https://schema.org/GlutenFreeDiet")]
        GlutenFreeDiet,

        /// <summary>
        /// A diet conforming to Islamic dietary practices.
        /// </summary>
        [EnumMember(Value = "https://schema.org/HalalDiet")]
        HalalDiet,

        /// <summary>
        /// A diet conforming to Hindu dietary practices, in particular, beef-free.
        /// </summary>
        [EnumMember(Value = "https://schema.org/HinduDiet")]
        HinduDiet,

        /// <summary>
        /// A diet conforming to Jewish dietary practices.
        /// </summary>
        [EnumMember(Value = "https://schema.org/KosherDiet")]
        KosherDiet,

        /// <summary>
        /// A diet focused on reduced calorie intake.
        /// </summary>
        [EnumMember(Value = "https://schema.org/LowCalorieDiet")]
        LowCalorieDiet,

        /// <summary>
        /// A diet focused on reduced fat and cholesterol intake.
        /// </summary>
        [EnumMember(Value = "https://schema.org/LowFatDiet")]
        LowFatDiet,

        /// <summary>
        /// A diet appropriate for people with lactose intolerance.
        /// </summary>
        [EnumMember(Value = "https://schema.org/LowLactoseDiet")]
        LowLactoseDiet,

        /// <summary>
        /// A diet focused on reduced sodium intake.
        /// </summary>
        [EnumMember(Value = "https://schema.org/LowSaltDiet")]
        LowSaltDiet,

        /// <summary>
        /// A diet exclusive of all animal products.
        /// </summary>
        [EnumMember(Value = "https://schema.org/VeganDiet")]
        VeganDiet,

        /// <summary>
        /// A diet exclusive of animal meat.
        /// </summary>
        [EnumMember(Value = "https://schema.org/VegetarianDiet")]
        VegetarianDiet
    }
}
