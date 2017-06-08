namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// For a given health insurance plan, the specification for costs and coverage of prescription drugs.
    /// </summary>
    [DataContract]
    public class HealthPlanFormulary : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "HealthPlanFormulary";
    }
}
