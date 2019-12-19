namespace Schema.NET
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// A type of physical examination of a patient performed by a physician.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PhysicalExam
    {
        /// <summary>
        /// Abdomen clinical examination.
        /// </summary>
        [EnumMember(Value = "https://schema.org/Abdomen")]
        Abdomen,

        /// <summary>
        /// Appearance assessment with clinical examination.
        /// </summary>
        [EnumMember(Value = "https://schema.org/Appearance")]
        Appearance,

        /// <summary>
        /// Cardiovascular system assessment withclinical examination.
        /// </summary>
        [EnumMember(Value = "https://schema.org/CardiovascularExam")]
        CardiovascularExam,

        /// <summary>
        /// Ear function assessment with clinical examination.
        /// </summary>
        [EnumMember(Value = "https://schema.org/Ear")]
        Ear,

        /// <summary>
        /// Eye or ophtalmological function assessment with clinical examination.
        /// </summary>
        [EnumMember(Value = "https://schema.org/Eye")]
        Eye,

        /// <summary>
        /// Genitourinary system function assessment with clinical examination.
        /// </summary>
        [EnumMember(Value = "https://schema.org/Genitourinary")]
        Genitourinary,

        /// <summary>
        /// Head assessment with clinical examination.
        /// </summary>
        [EnumMember(Value = "https://schema.org/Head")]
        Head,

        /// <summary>
        /// Lung and respiratory system clinical examination.
        /// </summary>
        [EnumMember(Value = "https://schema.org/Lung")]
        Lung,

        /// <summary>
        /// Musculoskeletal system clinical examination.
        /// </summary>
        [EnumMember(Value = "https://schema.org/MusculoskeletalExam")]
        MusculoskeletalExam,

        /// <summary>
        /// Neck assessment with clinical examination.
        /// </summary>
        [EnumMember(Value = "https://schema.org/Neck")]
        Neck,

        /// <summary>
        /// Neurological system clinical examination.
        /// </summary>
        [EnumMember(Value = "https://schema.org/Neuro")]
        Neuro,

        /// <summary>
        /// Nose function assessment with clinical examination.
        /// </summary>
        [EnumMember(Value = "https://schema.org/Nose")]
        Nose,

        /// <summary>
        /// Skin assessment with clinical examination.
        /// </summary>
        [EnumMember(Value = "https://schema.org/Skin")]
        Skin,

        /// <summary>
        /// Throat assessment with  clinical examination.
        /// </summary>
        [EnumMember(Value = "https://schema.org/Throat")]
        Throat,
    }
}
