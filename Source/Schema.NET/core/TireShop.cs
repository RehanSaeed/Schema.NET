namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A tire shop.
    /// </summary>
    public partial interface ITireShop : IStore
    {
    }

    /// <summary>
    /// A tire shop.
    /// </summary>
    [DataContract]
    public partial class TireShop : Store, ITireShop
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TireShop";
    }
}
