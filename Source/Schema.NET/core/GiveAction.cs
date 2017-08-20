namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// &lt;p&gt;The act of transferring ownership of an object to a destination. Reciprocal of TakeAction.&lt;/p&gt;
    /// &lt;p&gt;Related actions:&lt;/p&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/TakeAction"&gt;TakeAction&lt;/a&gt;: Reciprocal of GiveAction.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/SendAction"&gt;SendAction&lt;/a&gt;: Unlike SendAction, GiveAction implies that ownership is being transferred (e.g. I may send my laptop to you, but that doesn't mean I'm giving it to you).&lt;/li&gt;
    /// &lt;/ul&gt;
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
        [DataMember(Name = "recipient", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Audience, ContactPoint, Organization, Person>? Recipient { get; set; }
    }
}
