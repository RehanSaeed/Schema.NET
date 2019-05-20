namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of obtaining an object under an agreement to return it at a later date. Reciprocal of LendAction.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/LendAction"&gt;LendAction&lt;/a&gt;: Reciprocal of BorrowAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    public partial interface IBorrowAction : ITransferAction
    {
        /// <summary>
        /// A sub property of participant. The person that lends the object being borrowed.
        /// </summary>
        Values<IOrganization, IPerson>? Lender { get; set; }
    }

    /// <summary>
    /// The act of obtaining an object under an agreement to return it at a later date. Reciprocal of LendAction.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/LendAction"&gt;LendAction&lt;/a&gt;: Reciprocal of BorrowAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class BorrowAction : TransferAction, IBorrowAction
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
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IOrganization, IPerson>? Lender { get; set; }
    }
}
