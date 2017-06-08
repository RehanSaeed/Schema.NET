namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of responding to a question/message asked/sent by the object...
    /// </summary>
    [DataContract]
    public class ReplyAction : CommunicateAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "ReplyAction";

        /// <summary>
        /// A sub property of result. The Comment created or sent as a result of this action.
        /// </summary>
        [DataMember(Name = "resultComment")]
        public Comment ResultComment { get; set; }
    }
}
