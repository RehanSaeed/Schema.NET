using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A single message from a sender to one or more organizations or people.
    /// </summary>
    [DataContract]
    public partial class Message : CreativeWork
    {
        public interface IBccRecipient : IWrapper { }
        public interface IBccRecipient<T> : IBccRecipient { new T Data { get; set; } }
        public class BccRecipientContactPoint : IBccRecipient<ContactPoint>
        {
            object IWrapper.Data { get { return Data; } set { Data = (ContactPoint) value; } }
            public virtual ContactPoint Data { get; set; }
            public BccRecipientContactPoint () { }
            public BccRecipientContactPoint (ContactPoint data) { Data = data; }
            public static implicit operator BccRecipientContactPoint (ContactPoint data) { return new BccRecipientContactPoint (data); }
        }

        public class BccRecipientOrganization : IBccRecipient<Organization>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Organization) value; } }
            public virtual Organization Data { get; set; }
            public BccRecipientOrganization () { }
            public BccRecipientOrganization (Organization data) { Data = data; }
            public static implicit operator BccRecipientOrganization (Organization data) { return new BccRecipientOrganization (data); }
        }

        public class BccRecipientPerson : IBccRecipient<Person>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Person) value; } }
            public virtual Person Data { get; set; }
            public BccRecipientPerson () { }
            public BccRecipientPerson (Person data) { Data = data; }
            public static implicit operator BccRecipientPerson (Person data) { return new BccRecipientPerson (data); }
        }


        public interface ICcRecipient : IWrapper { }
        public interface ICcRecipient<T> : ICcRecipient { new T Data { get; set; } }
        public class CcRecipientContactPoint : ICcRecipient<ContactPoint>
        {
            object IWrapper.Data { get { return Data; } set { Data = (ContactPoint) value; } }
            public virtual ContactPoint Data { get; set; }
            public CcRecipientContactPoint () { }
            public CcRecipientContactPoint (ContactPoint data) { Data = data; }
            public static implicit operator CcRecipientContactPoint (ContactPoint data) { return new CcRecipientContactPoint (data); }
        }

        public class CcRecipientOrganization : ICcRecipient<Organization>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Organization) value; } }
            public virtual Organization Data { get; set; }
            public CcRecipientOrganization () { }
            public CcRecipientOrganization (Organization data) { Data = data; }
            public static implicit operator CcRecipientOrganization (Organization data) { return new CcRecipientOrganization (data); }
        }

        public class CcRecipientPerson : ICcRecipient<Person>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Person) value; } }
            public virtual Person Data { get; set; }
            public CcRecipientPerson () { }
            public CcRecipientPerson (Person data) { Data = data; }
            public static implicit operator CcRecipientPerson (Person data) { return new CcRecipientPerson (data); }
        }


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


        public interface IToRecipient : IWrapper { }
        public interface IToRecipient<T> : IToRecipient { new T Data { get; set; } }
        public class ToRecipientAudience : IToRecipient<Audience>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Audience) value; } }
            public virtual Audience Data { get; set; }
            public ToRecipientAudience () { }
            public ToRecipientAudience (Audience data) { Data = data; }
            public static implicit operator ToRecipientAudience (Audience data) { return new ToRecipientAudience (data); }
        }

        public class ToRecipientContactPoint : IToRecipient<ContactPoint>
        {
            object IWrapper.Data { get { return Data; } set { Data = (ContactPoint) value; } }
            public virtual ContactPoint Data { get; set; }
            public ToRecipientContactPoint () { }
            public ToRecipientContactPoint (ContactPoint data) { Data = data; }
            public static implicit operator ToRecipientContactPoint (ContactPoint data) { return new ToRecipientContactPoint (data); }
        }

        public class ToRecipientOrganization : IToRecipient<Organization>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Organization) value; } }
            public virtual Organization Data { get; set; }
            public ToRecipientOrganization () { }
            public ToRecipientOrganization (Organization data) { Data = data; }
            public static implicit operator ToRecipientOrganization (Organization data) { return new ToRecipientOrganization (data); }
        }

        public class ToRecipientPerson : IToRecipient<Person>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Person) value; } }
            public virtual Person Data { get; set; }
            public ToRecipientPerson () { }
            public ToRecipientPerson (Person data) { Data = data; }
            public static implicit operator ToRecipientPerson (Person data) { return new ToRecipientPerson (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Message";

        /// <summary>
        /// A sub property of recipient. The recipient blind copied on a message.
        /// </summary>
        [DataMember(Name = "bccRecipient", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IBccRecipient>? BccRecipient { get; set; } //ContactPoint, Organization, Person

        /// <summary>
        /// A sub property of recipient. The recipient copied on a message.
        /// </summary>
        [DataMember(Name = "ccRecipient", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ICcRecipient>? CcRecipient { get; set; } //ContactPoint, Organization, Person

        /// <summary>
        /// The date/time at which the message has been read by the recipient if a single recipient exists.
        /// </summary>
        [DataMember(Name = "dateRead", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset>? DateRead { get; set; } 

        /// <summary>
        /// The date/time the message was received if a single recipient exists.
        /// </summary>
        [DataMember(Name = "dateReceived", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset>? DateReceived { get; set; } 

        /// <summary>
        /// The date/time at which the message was sent.
        /// </summary>
        [DataMember(Name = "dateSent", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset>? DateSent { get; set; } 

        /// <summary>
        /// A CreativeWork attached to the message.
        /// </summary>
        [DataMember(Name = "messageAttachment", Order = 211)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<CreativeWork>? MessageAttachment { get; set; } 

        /// <summary>
        /// A sub property of participant. The participant who is at the receiving end of the action.
        /// </summary>
        [DataMember(Name = "recipient", Order = 212)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IRecipient>? Recipient { get; set; } //Audience, ContactPoint, Organization, Person

        /// <summary>
        /// A sub property of participant. The participant who is at the sending end of the action.
        /// </summary>
        [DataMember(Name = "sender", Order = 213)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ISender>? Sender { get; set; } //Audience, Organization, Person

        /// <summary>
        /// A sub property of recipient. The recipient who was directly sent the message.
        /// </summary>
        [DataMember(Name = "toRecipient", Order = 214)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IToRecipient>? ToRecipient { get; set; } //Audience, ContactPoint, Organization, Person
    }
}
