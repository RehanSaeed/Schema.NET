namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A pond.
    /// </summary>
    public partial interface IPond : IBodyOfWater
    {
    }

    /// <summary>
    /// A pond.
    /// </summary>
    [DataContract]
    public partial class Pond : BodyOfWater, IPond, IEquatable<Pond>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Pond";
    }
}
