namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An electrician.
    /// </summary>
    public partial interface IElectrician : IHomeAndConstructionBusiness
    {
    }

    /// <summary>
    /// An electrician.
    /// </summary>
    [DataContract]
    public partial class Electrician : HomeAndConstructionBusiness, IElectrician
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Electrician";
    }
}
