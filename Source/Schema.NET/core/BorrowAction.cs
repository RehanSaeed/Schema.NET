namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of obtaining an object under an agreement to return it at a later date...
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
        [DataMember(Name = "lender", Order = 304)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person, Organization>? Lender { get; set; }
    }
}
