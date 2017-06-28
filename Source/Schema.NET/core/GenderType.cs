namespace Schema.NET
{
    using System.Runtime.Serialization;

    /// <summary>
    /// An enumeration of genders.
    /// </summary>
    public enum GenderType
    {
        /// <summary>
        /// The female gender.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Female")]
        Female,

        /// <summary>
        /// The male gender.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Male")]
        Male
    }
}
