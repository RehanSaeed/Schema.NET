namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of notifying someone of information pertinent to them, with no expectation of a response.
    /// </summary>
    public partial interface IInformAction : ICommunicateAction
    {
        /// <summary>
        /// Upcoming or past event associated with this place, organization, or action.
        /// </summary>
        OneOrMany<IEvent>? Event { get; set; }
    }

    /// <summary>
    /// The act of notifying someone of information pertinent to them, with no expectation of a response.
    /// </summary>
    [DataContract]
    public partial class InformAction : CommunicateAction, IInformAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "InformAction";

        /// <summary>
        /// Upcoming or past event associated with this place, organization, or action.
        /// </summary>
        [DataMember(Name = "event", Order = 406)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IEvent>? Event { get; set; }
    }
}
