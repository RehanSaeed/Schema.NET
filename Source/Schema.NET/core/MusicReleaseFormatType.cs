namespace Schema.NET
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Format of this release (the type of recording media used, ie. compact disc, digital media, LP, etc...
    /// </summary>
    public enum MusicReleaseFormatType
    {
        /// <summary>
        /// CassetteFormat.
        /// </summary>
        [EnumMember(Value = "http://schema.org/CassetteFormat")]
        CassetteFormat,

        /// <summary>
        /// CDFormat.
        /// </summary>
        [EnumMember(Value = "http://schema.org/CDFormat")]
        CDFormat,

        /// <summary>
        /// DigitalAudioTapeFormat.
        /// </summary>
        [EnumMember(Value = "http://schema.org/DigitalAudioTapeFormat")]
        DigitalAudioTapeFormat,

        /// <summary>
        /// DigitalFormat.
        /// </summary>
        [EnumMember(Value = "http://schema.org/DigitalFormat")]
        DigitalFormat,

        /// <summary>
        /// DVDFormat.
        /// </summary>
        [EnumMember(Value = "http://schema.org/DVDFormat")]
        DVDFormat,

        /// <summary>
        /// LaserDiscFormat.
        /// </summary>
        [EnumMember(Value = "http://schema.org/LaserDiscFormat")]
        LaserDiscFormat,

        /// <summary>
        /// VinylFormat.
        /// </summary>
        [EnumMember(Value = "http://schema.org/VinylFormat")]
        VinylFormat
    }
}
