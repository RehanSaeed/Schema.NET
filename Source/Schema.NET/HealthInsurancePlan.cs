namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A US-style health insurance plan, including PPOs, EPOs, and HMOs.
    /// </summary>
    [DataContract]
    public class HealthInsurancePlan : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "HealthInsurancePlan";
    }
}
