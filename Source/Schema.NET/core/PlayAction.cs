namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of playing/exercising/training/performing for enjoyment, leisure, recreation, Competition or exercise...
    /// </summary>
    [DataContract]
    public partial class PlayAction : Action
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PlayAction";

        /// <summary>
        /// An intended audience, i.e. a group for whom something was created.
        /// </summary>
        [DataMember(Name = "audience", Order = 205)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Audience>? Audience { get; set; }

        /// <summary>
        /// Upcoming or past event associated with this place, organization, or action.
        /// </summary>
        [DataMember(Name = "event", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Event>? Event { get; set; }
    }
}
