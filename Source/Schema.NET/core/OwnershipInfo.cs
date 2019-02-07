namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A structured value providing information about when a certain organization or person owned a certain product.
    /// </summary>
    [DataContract]
    public partial class OwnershipInfo : StructuredValue
    {
        public interface IAcquiredFrom : IValue {}
        public interface IAcquiredFrom<T> : IAcquiredFrom { new T Value { get; } }
        public class OneOrManyAcquiredFrom : OneOrMany<IAcquiredFrom>
        {
            public OneOrManyAcquiredFrom(IAcquiredFrom item) : base(item) { }
            public OneOrManyAcquiredFrom(IEnumerable<IAcquiredFrom> items) : base(items) { }
            public static implicit operator OneOrManyAcquiredFrom (Organization value) { return new OneOrManyAcquiredFrom (new AcquiredFromOrganization (value)); }
            public static implicit operator OneOrManyAcquiredFrom (Organization[] values) { return new OneOrManyAcquiredFrom (values.Select(v => (IAcquiredFrom) new AcquiredFromOrganization (v))); }
            public static implicit operator OneOrManyAcquiredFrom (List<Organization> values) { return new OneOrManyAcquiredFrom (values.Select(v => (IAcquiredFrom) new AcquiredFromOrganization (v))); }
            public static implicit operator OneOrManyAcquiredFrom (Person value) { return new OneOrManyAcquiredFrom (new AcquiredFromPerson (value)); }
            public static implicit operator OneOrManyAcquiredFrom (Person[] values) { return new OneOrManyAcquiredFrom (values.Select(v => (IAcquiredFrom) new AcquiredFromPerson (v))); }
            public static implicit operator OneOrManyAcquiredFrom (List<Person> values) { return new OneOrManyAcquiredFrom (values.Select(v => (IAcquiredFrom) new AcquiredFromPerson (v))); }
        }
        public struct AcquiredFromOrganization : IAcquiredFrom<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public AcquiredFromOrganization (Organization value) { Value = value; }
            public static implicit operator AcquiredFromOrganization (Organization value) { return new AcquiredFromOrganization (value); }
        }
        public struct AcquiredFromPerson : IAcquiredFrom<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public AcquiredFromPerson (Person value) { Value = value; }
            public static implicit operator AcquiredFromPerson (Person value) { return new AcquiredFromPerson (value); }
        }

        public interface IOwnedFrom : IValue {}
        public interface IOwnedFrom<T> : IOwnedFrom { new T Value { get; } }
        public class OneOrManyOwnedFrom : OneOrMany<IOwnedFrom>
        {
            public OneOrManyOwnedFrom(IOwnedFrom item) : base(item) { }
            public OneOrManyOwnedFrom(IEnumerable<IOwnedFrom> items) : base(items) { }
            public static implicit operator OneOrManyOwnedFrom (DateTimeOffset value) { return new OneOrManyOwnedFrom (new OwnedFromDateTimeOffset (value)); }
            public static implicit operator OneOrManyOwnedFrom (DateTimeOffset[] values) { return new OneOrManyOwnedFrom (values.Select(v => (IOwnedFrom) new OwnedFromDateTimeOffset (v))); }
            public static implicit operator OneOrManyOwnedFrom (List<DateTimeOffset> values) { return new OneOrManyOwnedFrom (values.Select(v => (IOwnedFrom) new OwnedFromDateTimeOffset (v))); }
        }
        public struct OwnedFromDateTimeOffset : IOwnedFrom<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public OwnedFromDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator OwnedFromDateTimeOffset (DateTimeOffset value) { return new OwnedFromDateTimeOffset (value); }
        }

        public interface IOwnedThrough : IValue {}
        public interface IOwnedThrough<T> : IOwnedThrough { new T Value { get; } }
        public class OneOrManyOwnedThrough : OneOrMany<IOwnedThrough>
        {
            public OneOrManyOwnedThrough(IOwnedThrough item) : base(item) { }
            public OneOrManyOwnedThrough(IEnumerable<IOwnedThrough> items) : base(items) { }
            public static implicit operator OneOrManyOwnedThrough (DateTimeOffset value) { return new OneOrManyOwnedThrough (new OwnedThroughDateTimeOffset (value)); }
            public static implicit operator OneOrManyOwnedThrough (DateTimeOffset[] values) { return new OneOrManyOwnedThrough (values.Select(v => (IOwnedThrough) new OwnedThroughDateTimeOffset (v))); }
            public static implicit operator OneOrManyOwnedThrough (List<DateTimeOffset> values) { return new OneOrManyOwnedThrough (values.Select(v => (IOwnedThrough) new OwnedThroughDateTimeOffset (v))); }
        }
        public struct OwnedThroughDateTimeOffset : IOwnedThrough<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public OwnedThroughDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator OwnedThroughDateTimeOffset (DateTimeOffset value) { return new OwnedThroughDateTimeOffset (value); }
        }

        public interface ITypeOfGood : IValue {}
        public interface ITypeOfGood<T> : ITypeOfGood { new T Value { get; } }
        public class OneOrManyTypeOfGood : OneOrMany<ITypeOfGood>
        {
            public OneOrManyTypeOfGood(ITypeOfGood item) : base(item) { }
            public OneOrManyTypeOfGood(IEnumerable<ITypeOfGood> items) : base(items) { }
            public static implicit operator OneOrManyTypeOfGood (Product value) { return new OneOrManyTypeOfGood (new TypeOfGoodProduct (value)); }
            public static implicit operator OneOrManyTypeOfGood (Product[] values) { return new OneOrManyTypeOfGood (values.Select(v => (ITypeOfGood) new TypeOfGoodProduct (v))); }
            public static implicit operator OneOrManyTypeOfGood (List<Product> values) { return new OneOrManyTypeOfGood (values.Select(v => (ITypeOfGood) new TypeOfGoodProduct (v))); }
            public static implicit operator OneOrManyTypeOfGood (Service value) { return new OneOrManyTypeOfGood (new TypeOfGoodService (value)); }
            public static implicit operator OneOrManyTypeOfGood (Service[] values) { return new OneOrManyTypeOfGood (values.Select(v => (ITypeOfGood) new TypeOfGoodService (v))); }
            public static implicit operator OneOrManyTypeOfGood (List<Service> values) { return new OneOrManyTypeOfGood (values.Select(v => (ITypeOfGood) new TypeOfGoodService (v))); }
        }
        public struct TypeOfGoodProduct : ITypeOfGood<Product>
        {
            object IValue.Value => this.Value;
            public Product Value { get; }
            public TypeOfGoodProduct (Product value) { Value = value; }
            public static implicit operator TypeOfGoodProduct (Product value) { return new TypeOfGoodProduct (value); }
        }
        public struct TypeOfGoodService : ITypeOfGood<Service>
        {
            object IValue.Value => this.Value;
            public Service Value { get; }
            public TypeOfGoodService (Service value) { Value = value; }
            public static implicit operator TypeOfGoodService (Service value) { return new TypeOfGoodService (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "OwnershipInfo";

        /// <summary>
        /// The organization or person from which the product was acquired.
        /// </summary>
        [DataMember(Name = "acquiredFrom", Order = 306)]
        public OneOrManyAcquiredFrom AcquiredFrom { get; set; }

        /// <summary>
        /// The date and time of obtaining the product.
        /// </summary>
        [DataMember(Name = "ownedFrom", Order = 307)]
        public OneOrManyOwnedFrom OwnedFrom { get; set; }

        /// <summary>
        /// The date and time of giving up ownership on the product.
        /// </summary>
        [DataMember(Name = "ownedThrough", Order = 308)]
        public OneOrManyOwnedThrough OwnedThrough { get; set; }

        /// <summary>
        /// The product that this structured value is referring to.
        /// </summary>
        [DataMember(Name = "typeOfGood", Order = 309)]
        public OneOrManyTypeOfGood TypeOfGood { get; set; }
    }
}
