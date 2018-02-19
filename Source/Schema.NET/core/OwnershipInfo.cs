using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A structured value providing information about when a certain organization or person owned a certain product.
    /// </summary>
    [DataContract]
    public partial class OwnershipInfo : StructuredValue
    {
        public interface IAcquiredFrom : IWrapper { }
        public interface IAcquiredFrom<T> : IAcquiredFrom { new T Data { get; set; } }
        public class AcquiredFromOrganization : IAcquiredFrom<Organization>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Organization) value; } }
            public virtual Organization Data { get; set; }
            public AcquiredFromOrganization () { }
            public AcquiredFromOrganization (Organization data) { Data = data; }
            public static implicit operator AcquiredFromOrganization (Organization data) { return new AcquiredFromOrganization (data); }
        }

        public class AcquiredFromPerson : IAcquiredFrom<Person>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Person) value; } }
            public virtual Person Data { get; set; }
            public AcquiredFromPerson () { }
            public AcquiredFromPerson (Person data) { Data = data; }
            public static implicit operator AcquiredFromPerson (Person data) { return new AcquiredFromPerson (data); }
        }


        public interface ITypeOfGood : IWrapper { }
        public interface ITypeOfGood<T> : ITypeOfGood { new T Data { get; set; } }
        public class TypeOfGoodProduct : ITypeOfGood<Product>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Product) value; } }
            public virtual Product Data { get; set; }
            public TypeOfGoodProduct () { }
            public TypeOfGoodProduct (Product data) { Data = data; }
            public static implicit operator TypeOfGoodProduct (Product data) { return new TypeOfGoodProduct (data); }
        }

        public class TypeOfGoodService : ITypeOfGood<Service>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Service) value; } }
            public virtual Service Data { get; set; }
            public TypeOfGoodService () { }
            public TypeOfGoodService (Service data) { Data = data; }
            public static implicit operator TypeOfGoodService (Service data) { return new TypeOfGoodService (data); }
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
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IAcquiredFrom>? AcquiredFrom { get; set; } //Organization, Person

        /// <summary>
        /// The date and time of obtaining the product.
        /// </summary>
        [DataMember(Name = "ownedFrom", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset>? OwnedFrom { get; set; } 

        /// <summary>
        /// The date and time of giving up ownership on the product.
        /// </summary>
        [DataMember(Name = "ownedThrough", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset>? OwnedThrough { get; set; } 

        /// <summary>
        /// The product that this structured value is referring to.
        /// </summary>
        [DataMember(Name = "typeOfGood", Order = 309)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ITypeOfGood>? TypeOfGood { get; set; } //Product, Service
    }
}
