namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Intended audience for an item, i.e. the group for whom the item was created.
    /// </summary>
    public partial interface IAudience : IIntangible
    {
        /// <summary>
        /// The target group associated with a given audience (e.g. veterans, car owners, musicians, etc.).
        /// </summary>
        OneOrMany<string>? AudienceType { get; set; }

        /// <summary>
        /// The geographic area associated with the audience.
        /// </summary>
        OneOrMany<IAdministrativeArea>? GeographicArea { get; set; }
    }

    /// <summary>
    /// Intended audience for an item, i.e. the group for whom the item was created.
    /// </summary>
    [DataContract]
    public partial class Audience : Intangible, IAudience
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Audience";

        /// <summary>
        /// The target group associated with a given audience (e.g. veterans, car owners, musicians, etc.).
        /// </summary>
        [DataMember(Name = "audienceType", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? AudienceType { get; set; }

        /// <summary>
        /// The geographic area associated with the audience.
        /// </summary>
        [DataMember(Name = "geographicArea", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IAdministrativeArea>? GeographicArea { get; set; }
    }
}
