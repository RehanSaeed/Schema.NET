namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Place of worship, such as a church, synagogue, or mosque.
    /// </summary>
    [DataContract]
    public class PlaceOfWorship : CivicStructure
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PlaceOfWorship";
    }
}
