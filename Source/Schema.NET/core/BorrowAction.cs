namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of obtaining an object under an agreement to return it at a later date. Reciprocal of LendAction.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/LendAction"&gt;LendAction&lt;/a&gt;: Reciprocal of BorrowAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    public partial interface IBorrowAction : ITransferAction
    {
        /// <summary>
        /// A sub property of participant. The person that lends the object being borrowed.
        /// </summary>
        Values<IOrganization, IPerson> Lender { get; set; }
    }

    /// <summary>
    /// The act of obtaining an object under an agreement to return it at a later date. Reciprocal of LendAction.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/LendAction"&gt;LendAction&lt;/a&gt;: Reciprocal of BorrowAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class BorrowAction : TransferAction, IBorrowAction, IEquatable<BorrowAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BorrowAction";

        /// <summary>
        /// A sub property of participant. The person that lends the object being borrowed.
        /// </summary>
        [DataMember(Name = "lender", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Lender { get; set; }

        /// <inheritdoc/>
        public bool Equals(BorrowAction other)
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
                this.Lender == other.Lender &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as BorrowAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.Lender)
            .And(base.GetHashCode());
    }
}
