namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Any medical test, typically performed for diagnostic purposes.
    /// </summary>
    [DataContract]
    public class MedicalTest : MedicalEntity
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "MedicalTest";
    }
}
