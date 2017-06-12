namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The causative agent(s) that are responsible for the pathophysiologic process that eventually results in a medical condition, symptom or sign...
    /// </summary>
    [DataContract]
    public partial class MedicalCause : MedicalEntity
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalCause";
    }
}
