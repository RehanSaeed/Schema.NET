namespace Schema.NET
{
    /// <summary>
    /// A diet restricted to certain foods or preparations for cultural, religious, health or lifestyle reasons.
    /// </summary>
    public enum RestrictedDiet
    {
        /// <summary>
        /// A diet appropriate for people with diabetes.
        /// </summary>
        DiabeticDiet,

        /// <summary>
        /// A diet exclusive of gluten.
        /// </summary>
        GlutenFreeDiet,

        /// <summary>
        /// A diet conforming to Islamic dietary practices.
        /// </summary>
        HalalDiet,

        /// <summary>
        /// A diet conforming to Hindu dietary practices, in particular, beef-free.
        /// </summary>
        HinduDiet,

        /// <summary>
        /// A diet conforming to Jewish dietary practices.
        /// </summary>
        KosherDiet,

        /// <summary>
        /// A diet focused on reduced calorie intake.
        /// </summary>
        LowCalorieDiet,

        /// <summary>
        /// A diet focused on reduced fat and cholesterol intake.
        /// </summary>
        LowFatDiet,

        /// <summary>
        /// A diet appropriate for people with lactose intolerance.
        /// </summary>
        LowLactoseDiet,

        /// <summary>
        /// A diet focused on reduced sodium intake.
        /// </summary>
        LowSaltDiet,

        /// <summary>
        /// A diet exclusive of all animal products.
        /// </summary>
        VeganDiet,

        /// <summary>
        /// A diet exclusive of animal meat.
        /// </summary>
        VegetarianDiet
    }
}
