namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Place of worship, such as a church, synagogue, or mosque.
    /// </summary>
    public partial interface IPlaceOfWorship : ICivicStructure
    {
    }

    /// <summary>
    /// Place of worship, such as a church, synagogue, or mosque.
    /// </summary>
    [DataContract]
    public partial class PlaceOfWorship : CivicStructure, IPlaceOfWorship
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PlaceOfWorship";
    }
}
