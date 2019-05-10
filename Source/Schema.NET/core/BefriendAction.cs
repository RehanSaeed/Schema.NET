namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of forming a personal connection with someone (object) mutually/bidirectionally/symmetrically.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/FollowAction"&gt;FollowAction&lt;/a&gt;: Unlike FollowAction, BefriendAction implies that the connection is reciprocal.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    public partial interface IBefriendAction : IInteractAction
    {
    }

    /// <summary>
    /// The act of forming a personal connection with someone (object) mutually/bidirectionally/symmetrically.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/FollowAction"&gt;FollowAction&lt;/a&gt;: Unlike FollowAction, BefriendAction implies that the connection is reciprocal.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class BefriendAction : InteractAction, IBefriendAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BefriendAction";
    }
}
