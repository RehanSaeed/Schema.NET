namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A toy store.
    /// </summary>
    public partial interface IToyStore : IStore
    {
    }

    /// <summary>
    /// A toy store.
    /// </summary>
    [DataContract]
    public partial class ToyStore : Store, IToyStore
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ToyStore";
    }
}
