using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// The act of giving money to a seller in exchange for goods or services rendered. An agent buys an object, product, or service from a seller for a price. Reciprocal of SellAction.
    /// </summary>
    [DataContract]
    public partial class BuyAction : TradeAction
    {
        public interface ISeller : IWrapper { }
        public interface ISeller<T> : ISeller { new T Data { get; set; } }
        public class SellerOrganization : ISeller<Organization>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Organization) value; } }
            public virtual Organization Data { get; set; }
            public SellerOrganization () { }
            public SellerOrganization (Organization data) { Data = data; }
            public static implicit operator SellerOrganization (Organization data) { return new SellerOrganization (data); }
        }

        public class SellerPerson : ISeller<Person>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Person) value; } }
            public virtual Person Data { get; set; }
            public SellerPerson () { }
            public SellerPerson (Person data) { Data = data; }
            public static implicit operator SellerPerson (Person data) { return new SellerPerson (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BuyAction";

        /// <summary>
        /// An entity which offers (sells / leases / lends / loans) the services / goods.  A seller may also be a provider.
        /// </summary>
        [DataMember(Name = "seller", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ISeller>? Seller { get; set; } //Organization, Person
    }
}
