namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A television station.
    /// </summary>
    public partial interface ITelevisionStation : ILocalBusiness
    {
    }

    /// <summary>
    /// A television station.
    /// </summary>
    [DataContract]
    public partial class TelevisionStation : LocalBusiness, ITelevisionStation
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TelevisionStation";
    }
}
