namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A furniture store.
    /// </summary>
    public partial interface IFurnitureStore : IStore
    {
    }

    /// <summary>
    /// A furniture store.
    /// </summary>
    [DataContract]
    public partial class FurnitureStore : Store, IFurnitureStore
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "FurnitureStore";
    }
}
