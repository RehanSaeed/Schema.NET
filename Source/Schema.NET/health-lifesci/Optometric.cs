namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The science or practice of testing visual acuity and prescribing corrective lenses.
    /// </summary>
    [DataContract]
    public partial class Optometric : MedicalBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Optometric";
    }
}
