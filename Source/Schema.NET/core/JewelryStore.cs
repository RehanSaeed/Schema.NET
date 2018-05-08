namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A jewelry store.
    /// </summary>
    public partial interface IJewelryStore : IStore
    {
    }

    /// <summary>
    /// A jewelry store.
    /// </summary>
    [DataContract]
    public partial class JewelryStore : Store, IJewelryStore
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "JewelryStore";
    }
}
