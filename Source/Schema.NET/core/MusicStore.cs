namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A music store.
    /// </summary>
    public partial interface IMusicStore : IStore
    {
    }

    /// <summary>
    /// A music store.
    /// </summary>
    [DataContract]
    public partial class MusicStore : Store, IMusicStore
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MusicStore";
    }
}
