namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// &lt;p&gt;The act of obtaining an object under an agreement to return it at a later date. Reciprocal of LendAction.&lt;/p&gt;
    /// &lt;p&gt;Related actions:&lt;/p&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/LendAction"&gt;LendAction&lt;/a&gt;: Reciprocal of BorrowAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class BorrowAction : TransferAction
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
        public Values<Organization, Person>? Lender { get; set; }
    }
}
