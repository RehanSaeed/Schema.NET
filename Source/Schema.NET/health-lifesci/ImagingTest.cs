namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Any medical imaging modality typically used for diagnostic purposes.
    /// </summary>
    [DataContract]
    public partial class ImagingTest : MedicalTest
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ImagingTest";

        /// <summary>
        /// Imaging technique used.
        /// </summary>
        [DataMember(Name = "imagingTechnique", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MedicalImagingTechnique?>? ImagingTechnique { get; set; }
    }
}
