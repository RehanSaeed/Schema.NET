namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A jewelry store.
    /// </summary>
    [DataContract]
    public class JewelryStore : Store
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "JewelryStore";
    }
}
