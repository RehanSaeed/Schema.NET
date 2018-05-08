namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A defence establishment, such as an army or navy base.
    /// </summary>
    public partial interface IDefenceEstablishment : IGovernmentBuilding
    {
    }

    /// <summary>
    /// A defence establishment, such as an army or navy base.
    /// </summary>
    [DataContract]
    public partial class DefenceEstablishment : GovernmentBuilding, IDefenceEstablishment
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DefenceEstablishment";
    }
}
