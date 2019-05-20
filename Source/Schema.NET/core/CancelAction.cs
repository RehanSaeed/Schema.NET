namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of asserting that a future event/action is no longer going to happen.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/ConfirmAction"&gt;ConfirmAction&lt;/a&gt;: The antonym of CancelAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    public partial interface ICancelAction : IPlanAction
    {
    }

    /// <summary>
    /// The act of asserting that a future event/action is no longer going to happen.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/ConfirmAction"&gt;ConfirmAction&lt;/a&gt;: The antonym of CancelAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class CancelAction : PlanAction, ICancelAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "CancelAction";
    }
}
