namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A shoe store.
    /// </summary>
    public partial interface IShoeStore : IStore
    {
    }

    /// <summary>
    /// A shoe store.
    /// </summary>
    [DataContract]
    public partial class ShoeStore : Store, IShoeStore
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ShoeStore";
    }
}
