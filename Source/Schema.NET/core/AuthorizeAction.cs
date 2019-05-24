namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of granting permission to an object.
    /// </summary>
    public partial interface IAuthorizeAction : IAllocateAction
    {
        /// <summary>
        /// A sub property of participant. The participant who is at the receiving end of the action.
        /// </summary>
        Values<IAudience, IContactPoint, IOrganization, IPerson>? Recipient { get; set; }
    }

    /// <summary>
    /// The act of granting permission to an object.
    /// </summary>
    [DataContract]
    public partial class AuthorizeAction : AllocateAction, IAuthorizeAction
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
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IAudience, IContactPoint, IOrganization, IPerson>? Recipient { get; set; }
    }
}
