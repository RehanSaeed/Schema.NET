using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// &lt;p&gt;The act of physically/electronically taking delivery of an object thathas been transferred from an origin to a destination. Reciprocal of SendAction.&lt;/p&gt;
    /// &lt;p&gt;Related actions:&lt;/p&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/SendAction"&gt;SendAction&lt;/a&gt;: The reciprocal of ReceiveAction.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/TakeAction"&gt;TakeAction&lt;/a&gt;: Unlike TakeAction, ReceiveAction does not imply that the ownership has been transfered (e.g. I can receive a package, but it does not mean the package is now mine).&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class ReceiveAction : TransferAction
    {
        public interface ISender : IWrapper { }
        public interface ISender<T> : ISender { new T Data { get; set; } }
        public class SenderAudience : ISender<Audience>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Audience) value; } }
            public virtual Audience Data { get; set; }
            public SenderAudience () { }
            public SenderAudience (Audience data) { Data = data; }
            public static implicit operator SenderAudience (Audience data) { return new SenderAudience (data); }
        }

        public class SenderOrganization : ISender<Organization>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Organization) value; } }
            public virtual Organization Data { get; set; }
            public SenderOrganization () { }
            public SenderOrganization (Organization data) { Data = data; }
            public static implicit operator SenderOrganization (Organization data) { return new SenderOrganization (data); }
        }

        public class SenderPerson : ISender<Person>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Person) value; } }
            public virtual Person Data { get; set; }
            public SenderPerson () { }
            public SenderPerson (Person data) { Data = data; }
            public static implicit operator SenderPerson (Person data) { return new SenderPerson (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ReceiveAction";

        /// <summary>
        /// A sub property of instrument. The method of delivery.
        /// </summary>
        [DataMember(Name = "deliveryMethod", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DeliveryMethod>? DeliveryMethod { get; set; } 

        /// <summary>
        /// A sub property of participant. The participant who is at the sending end of the action.
        /// </summary>
        [DataMember(Name = "sender", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ISender>? Sender { get; set; } //Audience, Organization, Person
    }
}
