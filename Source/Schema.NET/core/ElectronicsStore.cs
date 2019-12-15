namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An electronics store.
    /// </summary>
    public partial interface IElectronicsStore : IStore
    {
    }

    /// <summary>
    /// An electronics store.
    /// </summary>
    [DataContract]
    public partial class ElectronicsStore : Store, IElectronicsStore, IEquatable<ElectronicsStore>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ElectronicsStore";
    }
}
