using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// The act of returning to the origin that which was previously received (concrete objects) or taken (ownership).
    /// </summary>
    [DataContract]
    public partial class ReturnAction : TransferAction
    {
        public interface IRecipient : IWrapper { }
        public interface IRecipient<T> : IRecipient { new T Data { get; set; } }
        public class RecipientAudience : IRecipient<Audience>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Audience) value; } }
            public virtual Audience Data { get; set; }
            public RecipientAudience () { }
            public RecipientAudience (Audience data) { Data = data; }
            public static implicit operator RecipientAudience (Audience data) { return new RecipientAudience (data); }
        }

        public class RecipientContactPoint : IRecipient<ContactPoint>
        {
            object IWrapper.Data { get { return Data; } set { Data = (ContactPoint) value; } }
            public virtual ContactPoint Data { get; set; }
            public RecipientContactPoint () { }
            public RecipientContactPoint (ContactPoint data) { Data = data; }
            public static implicit operator RecipientContactPoint (ContactPoint data) { return new RecipientContactPoint (data); }
        }

        public class RecipientOrganization : IRecipient<Organization>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Organization) value; } }
            public virtual Organization Data { get; set; }
            public RecipientOrganization () { }
            public RecipientOrganization (Organization data) { Data = data; }
            public static implicit operator RecipientOrganization (Organization data) { return new RecipientOrganization (data); }
        }

        public class RecipientPerson : IRecipient<Person>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Person) value; } }
            public virtual Person Data { get; set; }
            public RecipientPerson () { }
            public RecipientPerson (Person data) { Data = data; }
            public static implicit operator RecipientPerson (Person data) { return new RecipientPerson (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ReturnAction";

        /// <summary>
        /// A sub property of participant. The participant who is at the receiving end of the action.
        /// </summary>
        [DataMember(Name = "recipient", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IRecipient>? Recipient { get; set; } //Audience, ContactPoint, Organization, Person
    }
}
