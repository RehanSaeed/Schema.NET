namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of gaining ownership of an object from an origin. Reciprocal of GiveAction.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/GiveAction"&gt;GiveAction&lt;/a&gt;: The reciprocal of TakeAction.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/ReceiveAction"&gt;ReceiveAction&lt;/a&gt;: Unlike ReceiveAction, TakeAction implies that ownership has been transfered.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    public partial interface ITakeAction : ITransferAction
    {
    }

    /// <summary>
    /// The act of gaining ownership of an object from an origin. Reciprocal of GiveAction.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/GiveAction"&gt;GiveAction&lt;/a&gt;: The reciprocal of TakeAction.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/ReceiveAction"&gt;ReceiveAction&lt;/a&gt;: Unlike ReceiveAction, TakeAction implies that ownership has been transfered.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class TakeAction : TransferAction, ITakeAction, IEquatable<TakeAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TakeAction";

        /// <inheritdoc/>
        public bool Equals(TakeAction other)
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
        public override bool Equals(object obj) => this.Equals(obj as TakeAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
