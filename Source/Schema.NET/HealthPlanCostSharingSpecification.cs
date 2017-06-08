namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A description of costs to the patient under a given network or formulary.
    /// </summary>
    [DataContract]
    public class HealthPlanCostSharingSpecification : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "HealthPlanCostSharingSpecification";
    }
}
