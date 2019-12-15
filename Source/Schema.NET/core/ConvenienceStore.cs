namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A convenience store.
    /// </summary>
    public partial interface IConvenienceStore : IStore
    {
    }

    /// <summary>
    /// A convenience store.
    /// </summary>
    [DataContract]
    public partial class ConvenienceStore : Store, IConvenienceStore, IEquatable<ConvenienceStore>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ConvenienceStore";
    }
}
