using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// &lt;p&gt;The act of obtaining an object under an agreement to return it at a later date. Reciprocal of LendAction.&lt;/p&gt;
    /// &lt;p&gt;Related actions:&lt;/p&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/LendAction"&gt;LendAction&lt;/a&gt;: Reciprocal of BorrowAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class BorrowAction : TransferAction
    {
        public interface ILender : IWrapper { }
        public interface ILender<T> : ILender { new T Data { get; set; } }
        public class LenderOrganization : ILender<Organization>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Organization) value; } }
            public virtual Organization Data { get; set; }
            public LenderOrganization () { }
            public LenderOrganization (Organization data) { Data = data; }
            public static implicit operator LenderOrganization (Organization data) { return new LenderOrganization (data); }
        }

        public class LenderPerson : ILender<Person>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Person) value; } }
            public virtual Person Data { get; set; }
            public LenderPerson () { }
            public LenderPerson (Person data) { Data = data; }
            public static implicit operator LenderPerson (Person data) { return new LenderPerson (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BorrowAction";

        /// <summary>
        /// A sub property of participant. The person that lends the object being borrowed.
        /// </summary>
        [DataMember(Name = "lender", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ILender>? Lender { get; set; } //Organization, Person
    }
}
