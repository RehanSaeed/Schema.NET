namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A store that sells materials useful or necessary for various hobbies.
    /// </summary>
    public partial interface IHobbyShop : IStore
    {
    }

    /// <summary>
    /// A store that sells materials useful or necessary for various hobbies.
    /// </summary>
    [DataContract]
    public partial class HobbyShop : Store, IHobbyShop
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "HobbyShop";
    }
}
