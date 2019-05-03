namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A subscription which allows a user to access media including audio, video, books, etc.
    /// </summary>
    [DataContract]
    public partial class MediaSubscription : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MediaSubscription";

        /// <summary>
        /// The Organization responsible for authenticating the user's subscription. For example, many media apps require a cable/satellite provider to authenticate your subscription before playing media.
        /// </summary>
        [DataMember(Name = "authenticator", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<Organization>? Authenticator { get; set; }

        /// <summary>
        /// An Offer which must be accepted before the user can perform the Action. For example, the user may need to buy a movie before being able to watch it.
        /// </summary>
        [DataMember(Name = "expectsAcceptanceOf", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<Offer>? ExpectsAcceptanceOf { get; set; }
    }
}
