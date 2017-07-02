namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// &lt;p&gt;The act of an agent communicating (service provider, social media, etc) their departure of a previously reserved service (e.g. flight check in) or place (e.g. hotel).&lt;/p&gt;
    /// &lt;p&gt;Related actions:&lt;/p&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/CheckInAction"&gt;CheckInAction&lt;/a&gt;: The antonym of CheckOutAction.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/DepartAction"&gt;DepartAction&lt;/a&gt;: Unlike DepartAction, CheckOutAction implies that the agent is informing/confirming the end of a previously reserved service.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/CancelAction"&gt;CancelAction&lt;/a&gt;: Unlike CancelAction, CheckOutAction implies that the agent is informing/confirming the end of a previously reserved service.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class CheckOutAction : CommunicateAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "CheckOutAction";
    }
}
