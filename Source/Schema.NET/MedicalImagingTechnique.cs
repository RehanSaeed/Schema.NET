namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Any medical imaging modality typically used for diagnostic purposes...
    /// </summary>
    [DataContract]
    public class MedicalImagingTechnique : MedicalEnumeration
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalImagingTechnique";
    }
}
