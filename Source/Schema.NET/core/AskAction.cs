namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of posing a question / favor to someone.
    /// Related actions:
    ///
    /// ReplyAction: Appears generally as a response to AskAction.
    /// </summary>
    [DataContract]
    public partial class AskAction : CommunicateAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AskAction";

        /// <summary>
        /// A sub property of object. A question.
        /// </summary>
        [DataMember(Name = "question", Order = 2)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Question>? Question { get; set; }
    }
}
