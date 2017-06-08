namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of providing an object under an agreement that it will be returned at a later date...
    /// </summary>
    [DataContract]
    public class LendAction : TransferAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "LendAction";

        /// <summary>
        /// A sub property of participant. The person that borrows the object being lent.
        /// </summary>
        [DataMember(Name = "borrower")]
        public Person Borrower { get; set; }
    }
}
