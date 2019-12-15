namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A shop that sells alcoholic drinks such as wine, beer, whisky and other spirits.
    /// </summary>
    public partial interface ILiquorStore : IStore
    {
    }

    /// <summary>
    /// A shop that sells alcoholic drinks such as wine, beer, whisky and other spirits.
    /// </summary>
    [DataContract]
    public partial class LiquorStore : Store, ILiquorStore, IEquatable<LiquorStore>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "LiquorStore";
    }
}
