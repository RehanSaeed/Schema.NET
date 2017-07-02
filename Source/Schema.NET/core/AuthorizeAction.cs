namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of granting permission to an object.
    /// </summary>
    [DataContract]
    public partial class AuthorizeAction : AllocateAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AuthorizeAction";

        /// <summary>
        /// A sub property of participant. The participant who is at the receiving end of the action.
        /// </summary>
        [DataMember(Name = "recipient", Order = 406)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Audience, Organization, Person>? Recipient { get; set; }
    }
}
