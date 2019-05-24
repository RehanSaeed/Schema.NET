namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A hardware store.
    /// </summary>
    public partial interface IHardwareStore : IStore
    {
    }

    /// <summary>
    /// A hardware store.
    /// </summary>
    [DataContract]
    public partial class HardwareStore : Store, IHardwareStore
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "HardwareStore";
    }
}
