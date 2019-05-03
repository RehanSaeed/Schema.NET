namespace Schema.NET
{
    using System.Runtime.Serialization;

    /// <summary>
    /// A type of physical examination of a patient performed by a physician.
    /// </summary>
    public enum PhysicalExam
    {
        /// <summary>
        /// Abdomen clinical examination.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Abdomen")]
        Abdomen,

        /// <summary>
        /// Appearance assessment with clinical examination.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Appearance")]
        Appearance,

        /// <summary>
        /// Cardiovascular system assessment withclinical examination.
        /// </summary>
        [EnumMember(Value = "http://schema.org/CardiovascularExam")]
        CardiovascularExam,

        /// <summary>
        /// Ear function assessment with clinical examination.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Ear")]
        Ear,

        /// <summary>
        /// Eye or ophtalmological function assessment with clinical examination.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Eye")]
        Eye,

        /// <summary>
        /// Genitourinary system function assessment with clinical examination.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Genitourinary")]
        Genitourinary,

        /// <summary>
        /// Head assessment with clinical examination.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Head")]
        Head,

        /// <summary>
        /// Lung and respiratory system clinical examination.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Lung")]
        Lung,

        /// <summary>
        /// Musculoskeletal system clinical examination.
        /// </summary>
        [EnumMember(Value = "http://schema.org/MusculoskeletalExam")]
        MusculoskeletalExam,

        /// <summary>
        /// Neck assessment with clinical examination.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Neck")]
        Neck,

        /// <summary>
        /// Neurological system clinical examination.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Neuro")]
        Neuro,

        /// <summary>
        /// Nose function assessment with clinical examination.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Nose")]
        Nose,

        /// <summary>
        /// Skin assessment with clinical examination.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Skin")]
        Skin,

        /// <summary>
        /// Throat assessment with  clinical examination.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Throat")]
        Throat
    }
}
