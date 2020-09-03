namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of an agent communicating (service provider, social media, etc) their arrival by registering/confirming for a previously reserved service (e.g. flight check in) or at a place (e.g. hotel), possibly resulting in a result (boarding pass, etc).&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/CheckOutAction"&gt;CheckOutAction&lt;/a&gt;: The antonym of CheckInAction.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/ArriveAction"&gt;ArriveAction&lt;/a&gt;: Unlike ArriveAction, CheckInAction implies that the agent is informing/confirming the start of a previously reserved service.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/ConfirmAction"&gt;ConfirmAction&lt;/a&gt;: Unlike ConfirmAction, CheckInAction implies that the agent is informing/confirming the &lt;em&gt;start&lt;/em&gt; of a previously reserved service rather than its validity/existence.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    public partial interface ICheckInAction : ICommunicateAction
    {
    }

    /// <summary>
    /// The act of an agent communicating (service provider, social media, etc) their arrival by registering/confirming for a previously reserved service (e.g. flight check in) or at a place (e.g. hotel), possibly resulting in a result (boarding pass, etc).&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/CheckOutAction"&gt;CheckOutAction&lt;/a&gt;: The antonym of CheckInAction.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/ArriveAction"&gt;ArriveAction&lt;/a&gt;: Unlike ArriveAction, CheckInAction implies that the agent is informing/confirming the start of a previously reserved service.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/ConfirmAction"&gt;ConfirmAction&lt;/a&gt;: Unlike ConfirmAction, CheckInAction implies that the agent is informing/confirming the &lt;em&gt;start&lt;/em&gt; of a previously reserved service rather than its validity/existence.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class CheckInAction : CommunicateAction, ICheckInAction, IEquatable<CheckInAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "CheckInAction";

        /// <inheritdoc/>
        public bool Equals(CheckInAction other)
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
        public override bool Equals(object obj) => this.Equals(obj as CheckInAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
