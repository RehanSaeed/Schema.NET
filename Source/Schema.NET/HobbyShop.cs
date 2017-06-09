namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A store that sells materials useful or necessary for various hobbies.
    /// </summary>
    [DataContract]
    public class HobbyShop : Store
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "HobbyShop";
    }
}
