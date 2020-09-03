namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of asserting that a future event/action is no longer going to happen.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/ConfirmAction"&gt;ConfirmAction&lt;/a&gt;: The antonym of CancelAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    public partial interface ICancelAction : IPlanAction
    {
    }

    /// <summary>
    /// The act of asserting that a future event/action is no longer going to happen.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/ConfirmAction"&gt;ConfirmAction&lt;/a&gt;: The antonym of CancelAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class CancelAction : PlanAction, ICancelAction, IEquatable<CancelAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "CancelAction";

        /// <inheritdoc/>
        public bool Equals(CancelAction other)
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
        public override bool Equals(object obj) => this.Equals(obj as CancelAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
