namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of forming a personal connection with someone/something (object) unidirectionally/asymmetrically to get updates pushed to.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/FollowAction"&gt;FollowAction&lt;/a&gt;: Unlike FollowAction, SubscribeAction implies that the subscriber acts as a passive agent being constantly/actively pushed for updates.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/RegisterAction"&gt;RegisterAction&lt;/a&gt;: Unlike RegisterAction, SubscribeAction implies that the agent is interested in continuing receiving updates from the object.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/JoinAction"&gt;JoinAction&lt;/a&gt;: Unlike JoinAction, SubscribeAction implies that the agent is interested in continuing receiving updates from the object.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class SubscribeAction : InteractAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SubscribeAction";
    }
}
