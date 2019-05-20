namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A retail good store.
    /// </summary>
    public partial interface IStore : ILocalBusiness
    {
    }

    /// <summary>
    /// A retail good store.
    /// </summary>
    [DataContract]
    public partial class Store : LocalBusiness, IStore
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Store";
    }
}
