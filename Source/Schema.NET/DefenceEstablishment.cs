namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A defence establishment, such as an army or navy base.
    /// </summary>
    [DataContract]
    public class DefenceEstablishment : GovernmentBuilding
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DefenceEstablishment";
    }
}
