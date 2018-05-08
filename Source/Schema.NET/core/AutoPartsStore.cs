namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An auto parts store.
    /// </summary>
    public partial interface IAutoPartsStore : IAutomotiveBusinessAndStore
    {
    }

    /// <summary>
    /// An auto parts store.
    /// </summary>
    [DataContract]
    public partial class AutoPartsStore : AutomotiveBusinessAndStore, IAutoPartsStore
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AutoPartsStore";
    }
}
