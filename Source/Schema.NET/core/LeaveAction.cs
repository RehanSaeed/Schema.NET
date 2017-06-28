namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An agent leaves an event / group with participants/friends at a location...
    /// </summary>
    [DataContract]
    public partial class LeaveAction : InteractAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "LeaveAction";

        /// <summary>
        /// Upcoming or past event associated with this place, organization, or action.
        /// </summary>
        [DataMember(Name = "event", Order = 304)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Event>? Event { get; set; }
    }
}
