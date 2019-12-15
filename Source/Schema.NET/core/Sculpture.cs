namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A piece of sculpture.
    /// </summary>
    public partial interface ISculpture : ICreativeWork
    {
    }

    /// <summary>
    /// A piece of sculpture.
    /// </summary>
    [DataContract]
    public partial class Sculpture : CreativeWork, ISculpture, IEquatable<Sculpture>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Sculpture";
    }
}
