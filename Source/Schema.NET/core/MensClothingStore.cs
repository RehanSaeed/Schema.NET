namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A men's clothing store.
    /// </summary>
    public partial interface IMensClothingStore : IStore
    {
    }

    /// <summary>
    /// A men's clothing store.
    /// </summary>
    [DataContract]
    public partial class MensClothingStore : Store, IMensClothingStore, IEquatable<MensClothingStore>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MensClothingStore";
    }
}
