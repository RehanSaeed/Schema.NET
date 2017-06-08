namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Classes of agents or pathogens that transmit infectious diseases...
    /// </summary>
    [DataContract]
    public class InfectiousAgentClass : MedicalEnumeration
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "InfectiousAgentClass";
    }
}
