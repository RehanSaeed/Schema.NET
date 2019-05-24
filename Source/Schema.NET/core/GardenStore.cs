namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A garden store.
    /// </summary>
    public partial interface IGardenStore : IStore
    {
    }

    /// <summary>
    /// A garden store.
    /// </summary>
    [DataContract]
    public partial class GardenStore : Store, IGardenStore
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "GardenStore";
    }
}
