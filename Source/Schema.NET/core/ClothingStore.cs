namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A clothing store.
    /// </summary>
    public partial interface IClothingStore : IStore
    {
    }

    /// <summary>
    /// A clothing store.
    /// </summary>
    [DataContract]
    public partial class ClothingStore : Store, IClothingStore, IEquatable<ClothingStore>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ClothingStore";
    }
}
