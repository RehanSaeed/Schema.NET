namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A grocery store.
    /// </summary>
    public partial interface IGroceryStore : IStore
    {
    }

    /// <summary>
    /// A grocery store.
    /// </summary>
    [DataContract]
    public partial class GroceryStore : Store, IGroceryStore
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "GroceryStore";
    }
}
