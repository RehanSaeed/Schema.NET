namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A bike store.
    /// </summary>
    public partial interface IBikeStore : IStore
    {
    }

    /// <summary>
    /// A bike store.
    /// </summary>
    [DataContract]
    public partial class BikeStore : Store, IBikeStore
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BikeStore";
    }
}
