namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A florist.
    /// </summary>
    public partial interface IFlorist : IStore
    {
    }

    /// <summary>
    /// A florist.
    /// </summary>
    [DataContract]
    public partial class Florist : Store, IFlorist
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Florist";
    }
}
