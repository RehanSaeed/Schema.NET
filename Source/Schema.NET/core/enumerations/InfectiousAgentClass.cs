namespace Schema.NET
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Classes of agents or pathogens that transmit infectious diseases. Enumerated type.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InfectiousAgentClass
    {
        /// <summary>
        /// Pathogenic bacteria that cause bacterial infection.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Bacteria")]
        Bacteria,

        /// <summary>
        /// Pathogenic fungus.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Fungus")]
        Fungus,

        /// <summary>
        /// Multicellular parasite that causes an infection.
        /// </summary>
        [EnumMember(Value = "http://schema.org/MulticellularParasite")]
        MulticellularParasite,

        /// <summary>
        /// A prion is an infectious agent composed of protein in a misfolded form.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Prion")]
        Prion,

        /// <summary>
        /// Single-celled organism that causes an infection.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Protozoa")]
        Protozoa,

        /// <summary>
        /// Pathogenic virus that causes viral infection.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Virus")]
        Virus
    }
}
