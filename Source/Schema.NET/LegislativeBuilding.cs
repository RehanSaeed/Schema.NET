namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A legislative building&amp;#x2014;for example, the state capitol.
    /// </summary>
    [DataContract]
    public class LegislativeBuilding : GovernmentBuilding
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "LegislativeBuilding";
    }
}
