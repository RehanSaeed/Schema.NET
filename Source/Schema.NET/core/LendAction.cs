namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of providing an object under an agreement that it will be returned at a later date...
    /// </summary>
    [DataContract]
    public partial class LendAction : TransferAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "LendAction";

        /// <summary>
        /// A sub property of participant. The person that borrows the object being lent.
        /// </summary>
        [DataMember(Name = "borrower", Order = 2)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person>? Borrower { get; set; }
    }
}
