namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of transferring ownership of an object to a destination...
    /// </summary>
    [DataContract]
    public partial class GiveAction : TransferAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "GiveAction";

        /// <summary>
        /// A sub property of participant. The participant who is at the receiving end of the action.
        /// </summary>
        [DataMember(Name = "recipient", Order = 305)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person, Audience, Organization>? Recipient { get; set; }
    }
}
