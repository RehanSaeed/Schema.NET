namespace Schema.NET
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Any medical imaging modality typically used for diagnostic purposes. Enumerated type.
    /// </summary>
    public enum MedicalImagingTechnique
    {
        /// <summary>
        /// X-ray computed tomography imaging.
        /// </summary>
        [EnumMember(Value = "http://schema.org/CT")]
        CT,

        /// <summary>
        /// Magnetic resonance imaging.
        /// </summary>
        [EnumMember(Value = "http://schema.org/MRI")]
        MRI,

        /// <summary>
        /// Positron emission tomography imaging.
        /// </summary>
        [EnumMember(Value = "http://schema.org/PET")]
        PET,

        /// <summary>
        /// Radiography is an imaging technique that uses electromagnetic radiation other than visible light, especially X-rays, to view the internal structure of a non-uniformly composed and opaque object such as the human body.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Radiography")]
        Radiography,

        /// <summary>
        /// Ultrasound imaging.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Ultrasound")]
        Ultrasound,

        /// <summary>
        /// X-ray imaging.
        /// </summary>
        [EnumMember(Value = "http://schema.org/XRay")]
        XRay
    }
}
