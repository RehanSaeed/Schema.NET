namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of notifying someone of information pertinent to them, with no expectation of a response.
    /// </summary>
    [DataContract]
    public class InformAction : CommunicateAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "InformAction";

        /// <summary>
        /// Upcoming or past event associated with this place, organization, or action.
        /// </summary>
        [DataMember(Name = "event")]
        public Event Event { get; set; }
    }
}
