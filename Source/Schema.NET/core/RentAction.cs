using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// The act of giving money in return for temporary use, but not ownership, of an object such as a vehicle or property. For example, an agent rents a property from a landlord in exchange for a periodic payment.
    /// </summary>
    [DataContract]
    public partial class RentAction : TradeAction
    {
        public interface ILandlord : IWrapper { }
        public interface ILandlord<T> : ILandlord { new T Data { get; set; } }
        public class LandlordOrganization : ILandlord<Organization>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Organization) value; } }
            public virtual Organization Data { get; set; }
            public LandlordOrganization () { }
            public LandlordOrganization (Organization data) { Data = data; }
            public static implicit operator LandlordOrganization (Organization data) { return new LandlordOrganization (data); }
        }

        public class LandlordPerson : ILandlord<Person>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Person) value; } }
            public virtual Person Data { get; set; }
            public LandlordPerson () { }
            public LandlordPerson (Person data) { Data = data; }
            public static implicit operator LandlordPerson (Person data) { return new LandlordPerson (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "RentAction";

        /// <summary>
        /// A sub property of participant. The owner of the real estate property.
        /// </summary>
        [DataMember(Name = "landlord", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ILandlord>? Landlord { get; set; } //Organization, Person

        /// <summary>
        /// A sub property of participant. The real estate agent involved in the action.
        /// </summary>
        [DataMember(Name = "realEstateAgent", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<RealEstateAgent>? RealEstateAgent { get; set; } 
    }
}
