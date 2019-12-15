namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An outlet store.
    /// </summary>
    public partial interface IOutletStore : IStore
    {
    }

    /// <summary>
    /// An outlet store.
    /// </summary>
    [DataContract]
    public partial class OutletStore : Store, IOutletStore, IEquatable<OutletStore>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "OutletStore";
    }
}
