namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A travel agency.
    /// </summary>
    public partial interface ITravelAgency : ILocalBusiness
    {
    }

    /// <summary>
    /// A travel agency.
    /// </summary>
    [DataContract]
    public partial class TravelAgency : LocalBusiness, ITravelAgency, IEquatable<TravelAgency>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TravelAgency";
    }
}
