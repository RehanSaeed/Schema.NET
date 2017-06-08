namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A home goods store.
    /// </summary>
    [DataContract]
    public class HomeGoodsStore : Store
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "HomeGoodsStore";
    }
}
