﻿namespace Schema.NET
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Any medical imaging modality typically used for diagnostic purposes. Enumerated type.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MedicalImagingTechnique
    {
        /// <summary>
        /// X-ray computed tomography imaging.
        /// </summary>
        [EnumMember(Value = "https://schema.org/CT")]
        CT,

        /// <summary>
        /// Magnetic resonance imaging.
        /// </summary>
        [EnumMember(Value = "https://schema.org/MRI")]
        MRI,

        /// <summary>
        /// Positron emission tomography imaging.
        /// </summary>
        [EnumMember(Value = "https://schema.org/PET")]
        PET,

        /// <summary>
        /// Radiography is an imaging technique that uses electromagnetic radiation other than visible light, especially X-rays, to view the internal structure of a non-uniformly composed and opaque object such as the human body.
        /// </summary>
        [EnumMember(Value = "https://schema.org/Radiography")]
        Radiography,

        /// <summary>
        /// Ultrasound imaging.
        /// </summary>
        [EnumMember(Value = "https://schema.org/Ultrasound")]
        Ultrasound,

        /// <summary>
        /// X-ray imaging.
        /// </summary>
        [EnumMember(Value = "https://schema.org/XRay")]
        XRay
    }
}
