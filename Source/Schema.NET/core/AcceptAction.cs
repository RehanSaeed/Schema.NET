namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of committing to/adopting an object.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/RejectAction"&gt;RejectAction&lt;/a&gt;: The antonym of AcceptAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    public partial interface IAcceptAction : IAllocateAction
    {
    }

    /// <summary>
    /// The act of committing to/adopting an object.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/RejectAction"&gt;RejectAction&lt;/a&gt;: The antonym of AcceptAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class AcceptAction : AllocateAction, IAcceptAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AcceptAction";
    }
}
