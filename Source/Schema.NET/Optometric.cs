namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The science or practice of testing visual acuity and prescribing corrective lenses.
    /// </summary>
    [DataContract]
    public class Optometric : MedicalBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "Optometric";
    }
}
