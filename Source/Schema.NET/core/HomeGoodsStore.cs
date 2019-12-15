namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A home goods store.
    /// </summary>
    public partial interface IHomeGoodsStore : IStore
    {
    }

    /// <summary>
    /// A home goods store.
    /// </summary>
    [DataContract]
    public partial class HomeGoodsStore : Store, IHomeGoodsStore, IEquatable<HomeGoodsStore>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "HomeGoodsStore";
    }
}
