namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Auto body shop.
    /// </summary>
    public partial interface IAutoBodyShop : IAutomotiveBusiness
    {
    }

    /// <summary>
    /// Auto body shop.
    /// </summary>
    [DataContract]
    public partial class AutoBodyShop : AutomotiveBusiness, IAutoBodyShop
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AutoBodyShop";
    }
}
