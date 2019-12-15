namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// See AutomotiveBusiness, Store for more information.
    /// </summary>
    public partial interface IAutomotiveBusinessAndStore : IStore, IAutomotiveBusiness
    {
    }

    /// <summary>
    /// See AutomotiveBusiness, Store for more information.
    /// </summary>
    [DataContract]
    public abstract partial class AutomotiveBusinessAndStore : LocalBusiness, IAutomotiveBusinessAndStore, IEquatable<AutomotiveBusinessAndStore>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AutomotiveBusinessAndStore";
    }
}
