namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of giving money in return for temporary use, but not ownership, of an object such as a vehicle or property...
    /// </summary>
    [DataContract]
    public partial class RentAction : TradeAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "RentAction";

        /// <summary>
        /// A sub property of participant. The owner of the real estate property.
        /// </summary>
        [DataMember(Name = "landlord", Order = 2)]
        public object Landlord { get; protected set; }

        /// <summary>
        /// A sub property of participant. The owner of the real estate property.
        /// </summary>
        [IgnoreDataMember]
        public Person LandlordPerson
        {
            get => this.Landlord as Person;
            set => this.Landlord = value;
        }

        /// <summary>
        /// A sub property of participant. The owner of the real estate property.
        /// </summary>
        [IgnoreDataMember]
        public Organization LandlordOrganization
        {
            get => this.Landlord as Organization;
            set => this.Landlord = value;
        }

        /// <summary>
        /// A sub property of participant. The real estate agent involved in the action.
        /// </summary>
        [DataMember(Name = "realEstateAgent", Order = 3)]
        public RealEstateAgent RealEstateAgent { get; set; }
    }
}
