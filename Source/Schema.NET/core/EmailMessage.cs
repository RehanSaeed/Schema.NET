namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An email message.
    /// </summary>
    public partial interface IEmailMessage : IMessage
    {
    }

    /// <summary>
    /// An email message.
    /// </summary>
    [DataContract]
    public partial class EmailMessage : Message, IEmailMessage
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "EmailMessage";
    }
}
