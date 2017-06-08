namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A structured value providing information about when a certain organization or person owned a certain product.
    /// </summary>
    [DataContract]
    public class OwnershipInfo : StructuredValue
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "OwnershipInfo";

        /// <summary>
        /// The product that this structured value is referring to.
        /// </summary>
        [DataMember(Name = "typeOfGood")]
        public object TypeOfGood { get; protected set; }

        /// <summary>
        /// The product that this structured value is referring to.
        /// </summary>
        [IgnoreDataMember]
        public Product TypeOfGoodProduct
        {
            get => this.TypeOfGood as Product;
            set => this.TypeOfGood = value;
        }

        /// <summary>
        /// The product that this structured value is referring to.
        /// </summary>
        [IgnoreDataMember]
        public Service TypeOfGoodService
        {
            get => this.TypeOfGood as Service;
            set => this.TypeOfGood = value;
        }

        /// <summary>
        /// The organization or person from which the product was acquired.
        /// </summary>
        [DataMember(Name = "acquiredFrom")]
        public object AcquiredFrom { get; protected set; }

        /// <summary>
        /// The organization or person from which the product was acquired.
        /// </summary>
        [IgnoreDataMember]
        public Person AcquiredFromPerson
        {
            get => this.AcquiredFrom as Person;
            set => this.AcquiredFrom = value;
        }

        /// <summary>
        /// The organization or person from which the product was acquired.
        /// </summary>
        [IgnoreDataMember]
        public Organization AcquiredFromOrganization
        {
            get => this.AcquiredFrom as Organization;
            set => this.AcquiredFrom = value;
        }

        /// <summary>
        /// The date and time of obtaining the product.
        /// </summary>
        [DataMember(Name = "ownedFrom")]
        public DateTimeOffset OwnedFrom { get; set; }

        /// <summary>
        /// The date and time of giving up ownership on the product.
        /// </summary>
        [DataMember(Name = "ownedThrough")]
        public DateTimeOffset OwnedThrough { get; set; }
    }
}
