namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An OfferCatalog is an ItemList that contains related Offers and/or further OfferCatalogs that are offeredBy the same provider.
    /// </summary>
    public partial interface IOfferCatalog : IItemList
    {
    }

    /// <summary>
    /// An OfferCatalog is an ItemList that contains related Offers and/or further OfferCatalogs that are offeredBy the same provider.
    /// </summary>
    [DataContract]
    public partial class OfferCatalog : ItemList, IOfferCatalog, IEquatable<OfferCatalog>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "OfferCatalog";
    }
}
