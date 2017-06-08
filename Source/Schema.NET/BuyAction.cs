namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of giving money to a seller in exchange for goods or services rendered...
    /// </summary>
    [DataContract]
    public class BuyAction : TradeAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "BuyAction";

        /// <summary>
        /// An entity which offers (sells / leases / lends / loans) the services / goods.  A seller may also be a provider.
        /// </summary>
        [DataMember(Name = "seller")]
        public object Seller { get; protected set; }

        /// <summary>
        /// An entity which offers (sells / leases / lends / loans) the services / goods.  A seller may also be a provider.
        /// </summary>
        [IgnoreDataMember]
        public Organization SellerOrganization
        {
            get => this.Seller as Organization;
            set => this.Seller = value;
        }

        /// <summary>
        /// An entity which offers (sells / leases / lends / loans) the services / goods.  A seller may also be a provider.
        /// </summary>
        [IgnoreDataMember]
        public Person SellerPerson
        {
            get => this.Seller as Person;
            set => this.Seller = value;
        }
    }
}
