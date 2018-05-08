namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A wholesale store.
    /// </summary>
    public partial interface IWholesaleStore : IStore
    {
    }

    /// <summary>
    /// A wholesale store.
    /// </summary>
    [DataContract]
    public partial class WholesaleStore : Store, IWholesaleStore
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "WholesaleStore";
    }
}
