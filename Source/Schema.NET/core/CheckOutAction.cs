namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of an agent communicating (service provider, social media, etc) their departure of a previously reserved service (e.g. flight check in) or place (e.g. hotel).&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/CheckInAction"&gt;CheckInAction&lt;/a&gt;: The antonym of CheckOutAction.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/DepartAction"&gt;DepartAction&lt;/a&gt;: Unlike DepartAction, CheckOutAction implies that the agent is informing/confirming the end of a previously reserved service.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/CancelAction"&gt;CancelAction&lt;/a&gt;: Unlike CancelAction, CheckOutAction implies that the agent is informing/confirming the end of a previously reserved service.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    public partial interface ICheckOutAction : ICommunicateAction
    {
    }

    /// <summary>
    /// The act of an agent communicating (service provider, social media, etc) their departure of a previously reserved service (e.g. flight check in) or place (e.g. hotel).&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/CheckInAction"&gt;CheckInAction&lt;/a&gt;: The antonym of CheckOutAction.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/DepartAction"&gt;DepartAction&lt;/a&gt;: Unlike DepartAction, CheckOutAction implies that the agent is informing/confirming the end of a previously reserved service.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/CancelAction"&gt;CancelAction&lt;/a&gt;: Unlike CancelAction, CheckOutAction implies that the agent is informing/confirming the end of a previously reserved service.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class CheckOutAction : CommunicateAction, ICheckOutAction, IEquatable<CheckOutAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "CheckOutAction";

        /// <inheritdoc/>
        public bool Equals(CheckOutAction other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Type == other.Type &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as CheckOutAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
