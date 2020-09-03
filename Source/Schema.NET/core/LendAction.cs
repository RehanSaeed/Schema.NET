namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of providing an object under an agreement that it will be returned at a later date. Reciprocal of BorrowAction.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/BorrowAction"&gt;BorrowAction&lt;/a&gt;: Reciprocal of LendAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    public partial interface ILendAction : ITransferAction
    {
        /// <summary>
        /// A sub property of participant. The person that borrows the object being lent.
        /// </summary>
        OneOrMany<IPerson> Borrower { get; set; }
    }

    /// <summary>
    /// The act of providing an object under an agreement that it will be returned at a later date. Reciprocal of BorrowAction.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/BorrowAction"&gt;BorrowAction&lt;/a&gt;: Reciprocal of LendAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class LendAction : TransferAction, ILendAction, IEquatable<LendAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "LendAction";

        /// <summary>
        /// A sub property of participant. The person that borrows the object being lent.
        /// </summary>
        [DataMember(Name = "borrower", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Borrower { get; set; }

        /// <inheritdoc/>
        public bool Equals(LendAction other)
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
                this.Borrower == other.Borrower &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as LendAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.Borrower)
            .And(base.GetHashCode());
    }
}
