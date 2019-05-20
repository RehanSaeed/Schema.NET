namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Represents the collection of all sports organizations, including sports teams, governing bodies, and sports associations.
    /// </summary>
    public partial interface ISportsOrganization : IOrganization
    {
        /// <summary>
        /// A type of sport (e.g. Baseball).
        /// </summary>
        Values<string, Uri>? Sport { get; set; }
    }

    /// <summary>
    /// Represents the collection of all sports organizations, including sports teams, governing bodies, and sports associations.
    /// </summary>
    [DataContract]
    public partial class SportsOrganization : Organization, ISportsOrganization
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SportsOrganization";

        /// <summary>
        /// A type of sport (e.g. Baseball).
        /// </summary>
        [DataMember(Name = "sport", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, Uri>? Sport { get; set; }
    }
}
