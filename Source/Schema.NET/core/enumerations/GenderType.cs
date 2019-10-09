namespace Schema.NET
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// An enumeration of genders.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GenderType
    {
        /// <summary>
        /// The female gender.
        /// </summary>
        [EnumMember(Value = "https://schema.org/Female")]
        Female,

        /// <summary>
        /// The male gender.
        /// </summary>
        [EnumMember(Value = "https://schema.org/Male")]
        Male
    }
}
