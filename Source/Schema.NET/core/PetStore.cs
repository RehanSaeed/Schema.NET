namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A pet store.
    /// </summary>
    public partial interface IPetStore : IStore
    {
    }

    /// <summary>
    /// A pet store.
    /// </summary>
    [DataContract]
    public partial class PetStore : Store, IPetStore
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PetStore";
    }
}
