namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A sporting goods store.
    /// </summary>
    public partial interface ISportingGoodsStore : IStore
    {
    }

    /// <summary>
    /// A sporting goods store.
    /// </summary>
    [DataContract]
    public partial class SportingGoodsStore : Store, ISportingGoodsStore
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SportingGoodsStore";
    }
}
