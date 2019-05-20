namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of rejecting to/adopting an object.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/AcceptAction"&gt;AcceptAction&lt;/a&gt;: The antonym of RejectAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    public partial interface IRejectAction : IAllocateAction
    {
    }

    /// <summary>
    /// The act of rejecting to/adopting an object.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/AcceptAction"&gt;AcceptAction&lt;/a&gt;: The antonym of RejectAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class RejectAction : AllocateAction, IRejectAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "RejectAction";
    }
}
