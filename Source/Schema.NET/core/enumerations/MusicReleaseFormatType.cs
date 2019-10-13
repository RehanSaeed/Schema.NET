namespace Schema.NET
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Format of this release (the type of recording media used, ie. compact disc, digital media, LP, etc.).
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MusicReleaseFormatType
    {
        /// <summary>
        /// CassetteFormat.
        /// </summary>
        [EnumMember(Value = "https://schema.org/CassetteFormat")]
        CassetteFormat,

        /// <summary>
        /// CDFormat.
        /// </summary>
        [EnumMember(Value = "https://schema.org/CDFormat")]
        CDFormat,

        /// <summary>
        /// DigitalAudioTapeFormat.
        /// </summary>
        [EnumMember(Value = "https://schema.org/DigitalAudioTapeFormat")]
        DigitalAudioTapeFormat,

        /// <summary>
        /// DigitalFormat.
        /// </summary>
        [EnumMember(Value = "https://schema.org/DigitalFormat")]
        DigitalFormat,

        /// <summary>
        /// DVDFormat.
        /// </summary>
        [EnumMember(Value = "https://schema.org/DVDFormat")]
        DVDFormat,

        /// <summary>
        /// LaserDiscFormat.
        /// </summary>
        [EnumMember(Value = "https://schema.org/LaserDiscFormat")]
        LaserDiscFormat,

        /// <summary>
        /// VinylFormat.
        /// </summary>
        [EnumMember(Value = "https://schema.org/VinylFormat")]
        VinylFormat
    }
}
