namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A city hall.
    /// </summary>
    [DataContract]
    public class CityHall : GovernmentBuilding
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "CityHall";
    }
}
