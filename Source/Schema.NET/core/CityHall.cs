namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A city hall.
    /// </summary>
    public partial interface ICityHall : IGovernmentBuilding
    {
    }

    /// <summary>
    /// A city hall.
    /// </summary>
    [DataContract]
    public partial class CityHall : GovernmentBuilding, ICityHall
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "CityHall";
    }
}
