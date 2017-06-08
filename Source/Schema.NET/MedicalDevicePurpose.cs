namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Categories of medical devices, organized by the purpose or intended use of the device.
    /// </summary>
    [DataContract]
    public class MedicalDevicePurpose : MedicalEnumeration
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "MedicalDevicePurpose";
    }
}
