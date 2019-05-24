namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A shopping center or mall.
    /// </summary>
    public partial interface IShoppingCenter : ILocalBusiness
    {
    }

    /// <summary>
    /// A shopping center or mall.
    /// </summary>
    [DataContract]
    public partial class ShoppingCenter : LocalBusiness, IShoppingCenter
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ShoppingCenter";
    }
}
