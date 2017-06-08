namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A Hindu temple.
    /// </summary>
    [DataContract]
    public class HinduTemple : PlaceOfWorship
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "HinduTemple";
    }
}
