namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A Buddhist temple.
    /// </summary>
    public partial interface IBuddhistTemple : IPlaceOfWorship
    {
    }

    /// <summary>
    /// A Buddhist temple.
    /// </summary>
    [DataContract]
    public partial class BuddhistTemple : PlaceOfWorship, IBuddhistTemple, IEquatable<BuddhistTemple>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BuddhistTemple";
    }
}
