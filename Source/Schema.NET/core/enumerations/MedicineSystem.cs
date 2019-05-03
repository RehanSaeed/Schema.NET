namespace Schema.NET
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Systems of medical practice.
    /// </summary>
    public enum MedicineSystem
    {
        /// <summary>
        /// A system of medicine that originated in India over thousands of years and that focuses on integrating and balancing the body, mind, and spirit.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Ayurvedic")]
        Ayurvedic,

        /// <summary>
        /// A system of medicine focused on the relationship between the body's structure, mainly the spine, and its functioning.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Chiropractic")]
        Chiropractic,

        /// <summary>
        /// A system of medicine based on the principle that a disease can be cured by a substance that produces similar symptoms in healthy people.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Homeopathic")]
        Homeopathic,

        /// <summary>
        /// A system of medicine focused on promoting the body's innate ability to heal itself.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Osteopathic")]
        Osteopathic,

        /// <summary>
        /// A system of medicine based on common theoretical concepts that originated in China and evolved over thousands of years, that uses herbs, acupuncture, exercise, massage, dietary therapy, and other methods to treat a wide range of conditions.
        /// </summary>
        [EnumMember(Value = "http://schema.org/TraditionalChinese")]
        TraditionalChinese,

        /// <summary>
        /// The conventional Western system of medicine, that aims to apply the best available evidence gained from the scientific method to clinical decision making. Also known as conventional or Western medicine.
        /// </summary>
        [EnumMember(Value = "http://schema.org/WesternConventional")]
        WesternConventional
    }
}
