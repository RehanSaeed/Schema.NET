namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of obtaining an object under an agreement to return it at a later date...
    /// </summary>
    [DataContract]
    public class BorrowAction : TransferAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BorrowAction";

        /// <summary>
        /// A sub property of participant. The person that lends the object being borrowed.
        /// </summary>
        [DataMember(Name = "lender", Order = 2)]
        public object Lender { get; protected set; }

        /// <summary>
        /// A sub property of participant. The person that lends the object being borrowed.
        /// </summary>
        [IgnoreDataMember]
        public Person LenderPerson
        {
            get => this.Lender as Person;
            set => this.Lender = value;
        }

        /// <summary>
        /// A sub property of participant. The person that lends the object being borrowed.
        /// </summary>
        [IgnoreDataMember]
        public Organization LenderOrganization
        {
            get => this.Lender as Organization;
            set => this.Lender = value;
        }
    }
}
