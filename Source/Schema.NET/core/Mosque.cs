namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A mosque.
    /// </summary>
    public partial interface IMosque : IPlaceOfWorship
    {
    }

    /// <summary>
    /// A mosque.
    /// </summary>
    [DataContract]
    public partial class Mosque : PlaceOfWorship, IMosque
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Mosque";
    }
}
