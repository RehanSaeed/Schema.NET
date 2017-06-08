namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Vital signs are measures of various physiological functions in order to assess the most basic body functions.
    /// </summary>
    [DataContract]
    public class VitalSign : MedicalSign
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "VitalSign";
    }
}
