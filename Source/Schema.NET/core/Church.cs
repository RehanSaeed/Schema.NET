namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A church.
    /// </summary>
    public partial interface IChurch : IPlaceOfWorship
    {
    }

    /// <summary>
    /// A church.
    /// </summary>
    [DataContract]
    public partial class Church : PlaceOfWorship, IChurch, IEquatable<Church>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Church";
    }
}
