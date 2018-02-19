using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// See AutomotiveBusiness, Store for more information.
    /// </summary>
    [DataContract]
    public abstract partial class AutomotiveBusinessAndStore : LocalBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AutomotiveBusinessAndStore";
    }
}
