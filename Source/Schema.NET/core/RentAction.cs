namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of giving money in return for temporary use, but not ownership, of an object such as a vehicle or property. For example, an agent rents a property from a landlord in exchange for a periodic payment.
    /// </summary>
    [DataContract]
    public partial class RentAction : TradeAction
    {
        public interface ILandlord : IValue {}
        public interface ILandlord<T> : ILandlord { new T Value { get; } }
        public class OneOrManyLandlord : OneOrMany<ILandlord>
        {
            public OneOrManyLandlord(ILandlord item) : base(item) { }
            public OneOrManyLandlord(IEnumerable<ILandlord> items) : base(items) { }
            public static implicit operator OneOrManyLandlord (Organization value) { return new OneOrManyLandlord (new LandlordOrganization (value)); }
            public static implicit operator OneOrManyLandlord (Organization[] values) { return new OneOrManyLandlord (values.Select(v => (ILandlord) new LandlordOrganization (v))); }
            public static implicit operator OneOrManyLandlord (List<Organization> values) { return new OneOrManyLandlord (values.Select(v => (ILandlord) new LandlordOrganization (v))); }
            public static implicit operator OneOrManyLandlord (Person value) { return new OneOrManyLandlord (new LandlordPerson (value)); }
            public static implicit operator OneOrManyLandlord (Person[] values) { return new OneOrManyLandlord (values.Select(v => (ILandlord) new LandlordPerson (v))); }
            public static implicit operator OneOrManyLandlord (List<Person> values) { return new OneOrManyLandlord (values.Select(v => (ILandlord) new LandlordPerson (v))); }
        }
        public struct LandlordOrganization : ILandlord<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public LandlordOrganization (Organization value) { Value = value; }
            public static implicit operator LandlordOrganization (Organization value) { return new LandlordOrganization (value); }
        }
        public struct LandlordPerson : ILandlord<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public LandlordPerson (Person value) { Value = value; }
            public static implicit operator LandlordPerson (Person value) { return new LandlordPerson (value); }
        }

        public interface IRealEstateAgent : IValue {}
        public interface IRealEstateAgent<T> : IRealEstateAgent { new T Value { get; } }
        public class OneOrManyRealEstateAgent : OneOrMany<IRealEstateAgent>
        {
            public OneOrManyRealEstateAgent(IRealEstateAgent item) : base(item) { }
            public OneOrManyRealEstateAgent(IEnumerable<IRealEstateAgent> items) : base(items) { }
            public static implicit operator OneOrManyRealEstateAgent (RealEstateAgent value) { return new OneOrManyRealEstateAgent (new RealEstateAgentRealEstateAgent (value)); }
            public static implicit operator OneOrManyRealEstateAgent (RealEstateAgent[] values) { return new OneOrManyRealEstateAgent (values.Select(v => (IRealEstateAgent) new RealEstateAgentRealEstateAgent (v))); }
            public static implicit operator OneOrManyRealEstateAgent (List<RealEstateAgent> values) { return new OneOrManyRealEstateAgent (values.Select(v => (IRealEstateAgent) new RealEstateAgentRealEstateAgent (v))); }
        }
        public struct RealEstateAgentRealEstateAgent : IRealEstateAgent<RealEstateAgent>
        {
            object IValue.Value => this.Value;
            public RealEstateAgent Value { get; }
            public RealEstateAgentRealEstateAgent (RealEstateAgent value) { Value = value; }
            public static implicit operator RealEstateAgentRealEstateAgent (RealEstateAgent value) { return new RealEstateAgentRealEstateAgent (value); }
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
        public OneOrManyLandlord Landlord { get; set; }

        /// <summary>
        /// A sub property of participant. The real estate agent involved in the action.
        /// </summary>
        [DataMember(Name = "realEstateAgent", Order = 307)]
        public OneOrManyRealEstateAgent RealEstateAgent { get; set; }
    }
}
