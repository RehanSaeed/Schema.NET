namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A utility class that serves as the umbrella for a number of 'intangible' things in the medical space.
    /// </summary>
    [DataContract]
    public class MedicalIntangible : MedicalEntity
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "MedicalIntangible";
    }
}
