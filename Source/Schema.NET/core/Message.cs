namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A single message from a sender to one or more organizations or people.
    /// </summary>
    [DataContract]
    public partial class Message : CreativeWork
    {
        public interface IBccRecipient : IValue {}
        public interface IBccRecipient<T> : IBccRecipient { new T Value { get; } }
        public class OneOrManyBccRecipient : OneOrMany<IBccRecipient>
        {
            public OneOrManyBccRecipient(IBccRecipient item) : base(item) { }
            public OneOrManyBccRecipient(IEnumerable<IBccRecipient> items) : base(items) { }
            public static implicit operator OneOrManyBccRecipient (ContactPoint value) { return new OneOrManyBccRecipient (new BccRecipientContactPoint (value)); }
            public static implicit operator OneOrManyBccRecipient (ContactPoint[] values) { return new OneOrManyBccRecipient (values.Select(v => (IBccRecipient) new BccRecipientContactPoint (v))); }
            public static implicit operator OneOrManyBccRecipient (List<ContactPoint> values) { return new OneOrManyBccRecipient (values.Select(v => (IBccRecipient) new BccRecipientContactPoint (v))); }
            public static implicit operator OneOrManyBccRecipient (Organization value) { return new OneOrManyBccRecipient (new BccRecipientOrganization (value)); }
            public static implicit operator OneOrManyBccRecipient (Organization[] values) { return new OneOrManyBccRecipient (values.Select(v => (IBccRecipient) new BccRecipientOrganization (v))); }
            public static implicit operator OneOrManyBccRecipient (List<Organization> values) { return new OneOrManyBccRecipient (values.Select(v => (IBccRecipient) new BccRecipientOrganization (v))); }
            public static implicit operator OneOrManyBccRecipient (Person value) { return new OneOrManyBccRecipient (new BccRecipientPerson (value)); }
            public static implicit operator OneOrManyBccRecipient (Person[] values) { return new OneOrManyBccRecipient (values.Select(v => (IBccRecipient) new BccRecipientPerson (v))); }
            public static implicit operator OneOrManyBccRecipient (List<Person> values) { return new OneOrManyBccRecipient (values.Select(v => (IBccRecipient) new BccRecipientPerson (v))); }
        }
        public struct BccRecipientContactPoint : IBccRecipient<ContactPoint>
        {
            object IValue.Value => this.Value;
            public ContactPoint Value { get; }
            public BccRecipientContactPoint (ContactPoint value) { Value = value; }
            public static implicit operator BccRecipientContactPoint (ContactPoint value) { return new BccRecipientContactPoint (value); }
        }
        public struct BccRecipientOrganization : IBccRecipient<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public BccRecipientOrganization (Organization value) { Value = value; }
            public static implicit operator BccRecipientOrganization (Organization value) { return new BccRecipientOrganization (value); }
        }
        public struct BccRecipientPerson : IBccRecipient<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public BccRecipientPerson (Person value) { Value = value; }
            public static implicit operator BccRecipientPerson (Person value) { return new BccRecipientPerson (value); }
        }

        public interface ICcRecipient : IValue {}
        public interface ICcRecipient<T> : ICcRecipient { new T Value { get; } }
        public class OneOrManyCcRecipient : OneOrMany<ICcRecipient>
        {
            public OneOrManyCcRecipient(ICcRecipient item) : base(item) { }
            public OneOrManyCcRecipient(IEnumerable<ICcRecipient> items) : base(items) { }
            public static implicit operator OneOrManyCcRecipient (ContactPoint value) { return new OneOrManyCcRecipient (new CcRecipientContactPoint (value)); }
            public static implicit operator OneOrManyCcRecipient (ContactPoint[] values) { return new OneOrManyCcRecipient (values.Select(v => (ICcRecipient) new CcRecipientContactPoint (v))); }
            public static implicit operator OneOrManyCcRecipient (List<ContactPoint> values) { return new OneOrManyCcRecipient (values.Select(v => (ICcRecipient) new CcRecipientContactPoint (v))); }
            public static implicit operator OneOrManyCcRecipient (Organization value) { return new OneOrManyCcRecipient (new CcRecipientOrganization (value)); }
            public static implicit operator OneOrManyCcRecipient (Organization[] values) { return new OneOrManyCcRecipient (values.Select(v => (ICcRecipient) new CcRecipientOrganization (v))); }
            public static implicit operator OneOrManyCcRecipient (List<Organization> values) { return new OneOrManyCcRecipient (values.Select(v => (ICcRecipient) new CcRecipientOrganization (v))); }
            public static implicit operator OneOrManyCcRecipient (Person value) { return new OneOrManyCcRecipient (new CcRecipientPerson (value)); }
            public static implicit operator OneOrManyCcRecipient (Person[] values) { return new OneOrManyCcRecipient (values.Select(v => (ICcRecipient) new CcRecipientPerson (v))); }
            public static implicit operator OneOrManyCcRecipient (List<Person> values) { return new OneOrManyCcRecipient (values.Select(v => (ICcRecipient) new CcRecipientPerson (v))); }
        }
        public struct CcRecipientContactPoint : ICcRecipient<ContactPoint>
        {
            object IValue.Value => this.Value;
            public ContactPoint Value { get; }
            public CcRecipientContactPoint (ContactPoint value) { Value = value; }
            public static implicit operator CcRecipientContactPoint (ContactPoint value) { return new CcRecipientContactPoint (value); }
        }
        public struct CcRecipientOrganization : ICcRecipient<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public CcRecipientOrganization (Organization value) { Value = value; }
            public static implicit operator CcRecipientOrganization (Organization value) { return new CcRecipientOrganization (value); }
        }
        public struct CcRecipientPerson : ICcRecipient<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public CcRecipientPerson (Person value) { Value = value; }
            public static implicit operator CcRecipientPerson (Person value) { return new CcRecipientPerson (value); }
        }

        public interface IDateRead : IValue {}
        public interface IDateRead<T> : IDateRead { new T Value { get; } }
        public class OneOrManyDateRead : OneOrMany<IDateRead>
        {
            public OneOrManyDateRead(IDateRead item) : base(item) { }
            public OneOrManyDateRead(IEnumerable<IDateRead> items) : base(items) { }
            public static implicit operator OneOrManyDateRead (DateTimeOffset value) { return new OneOrManyDateRead (new DateReadDateTimeOffset (value)); }
            public static implicit operator OneOrManyDateRead (DateTimeOffset[] values) { return new OneOrManyDateRead (values.Select(v => (IDateRead) new DateReadDateTimeOffset (v))); }
            public static implicit operator OneOrManyDateRead (List<DateTimeOffset> values) { return new OneOrManyDateRead (values.Select(v => (IDateRead) new DateReadDateTimeOffset (v))); }
        }
        public struct DateReadDateTimeOffset : IDateRead<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public DateReadDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator DateReadDateTimeOffset (DateTimeOffset value) { return new DateReadDateTimeOffset (value); }
        }

        public interface IDateReceived : IValue {}
        public interface IDateReceived<T> : IDateReceived { new T Value { get; } }
        public class OneOrManyDateReceived : OneOrMany<IDateReceived>
        {
            public OneOrManyDateReceived(IDateReceived item) : base(item) { }
            public OneOrManyDateReceived(IEnumerable<IDateReceived> items) : base(items) { }
            public static implicit operator OneOrManyDateReceived (DateTimeOffset value) { return new OneOrManyDateReceived (new DateReceivedDateTimeOffset (value)); }
            public static implicit operator OneOrManyDateReceived (DateTimeOffset[] values) { return new OneOrManyDateReceived (values.Select(v => (IDateReceived) new DateReceivedDateTimeOffset (v))); }
            public static implicit operator OneOrManyDateReceived (List<DateTimeOffset> values) { return new OneOrManyDateReceived (values.Select(v => (IDateReceived) new DateReceivedDateTimeOffset (v))); }
        }
        public struct DateReceivedDateTimeOffset : IDateReceived<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public DateReceivedDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator DateReceivedDateTimeOffset (DateTimeOffset value) { return new DateReceivedDateTimeOffset (value); }
        }

        public interface IDateSent : IValue {}
        public interface IDateSent<T> : IDateSent { new T Value { get; } }
        public class OneOrManyDateSent : OneOrMany<IDateSent>
        {
            public OneOrManyDateSent(IDateSent item) : base(item) { }
            public OneOrManyDateSent(IEnumerable<IDateSent> items) : base(items) { }
            public static implicit operator OneOrManyDateSent (DateTimeOffset value) { return new OneOrManyDateSent (new DateSentDateTimeOffset (value)); }
            public static implicit operator OneOrManyDateSent (DateTimeOffset[] values) { return new OneOrManyDateSent (values.Select(v => (IDateSent) new DateSentDateTimeOffset (v))); }
            public static implicit operator OneOrManyDateSent (List<DateTimeOffset> values) { return new OneOrManyDateSent (values.Select(v => (IDateSent) new DateSentDateTimeOffset (v))); }
        }
        public struct DateSentDateTimeOffset : IDateSent<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public DateSentDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator DateSentDateTimeOffset (DateTimeOffset value) { return new DateSentDateTimeOffset (value); }
        }

        public interface IMessageAttachment : IValue {}
        public interface IMessageAttachment<T> : IMessageAttachment { new T Value { get; } }
        public class OneOrManyMessageAttachment : OneOrMany<IMessageAttachment>
        {
            public OneOrManyMessageAttachment(IMessageAttachment item) : base(item) { }
            public OneOrManyMessageAttachment(IEnumerable<IMessageAttachment> items) : base(items) { }
            public static implicit operator OneOrManyMessageAttachment (CreativeWork value) { return new OneOrManyMessageAttachment (new MessageAttachmentCreativeWork (value)); }
            public static implicit operator OneOrManyMessageAttachment (CreativeWork[] values) { return new OneOrManyMessageAttachment (values.Select(v => (IMessageAttachment) new MessageAttachmentCreativeWork (v))); }
            public static implicit operator OneOrManyMessageAttachment (List<CreativeWork> values) { return new OneOrManyMessageAttachment (values.Select(v => (IMessageAttachment) new MessageAttachmentCreativeWork (v))); }
        }
        public struct MessageAttachmentCreativeWork : IMessageAttachment<CreativeWork>
        {
            object IValue.Value => this.Value;
            public CreativeWork Value { get; }
            public MessageAttachmentCreativeWork (CreativeWork value) { Value = value; }
            public static implicit operator MessageAttachmentCreativeWork (CreativeWork value) { return new MessageAttachmentCreativeWork (value); }
        }

        public interface IRecipient : IValue {}
        public interface IRecipient<T> : IRecipient { new T Value { get; } }
        public class OneOrManyRecipient : OneOrMany<IRecipient>
        {
            public OneOrManyRecipient(IRecipient item) : base(item) { }
            public OneOrManyRecipient(IEnumerable<IRecipient> items) : base(items) { }
            public static implicit operator OneOrManyRecipient (Audience value) { return new OneOrManyRecipient (new RecipientAudience (value)); }
            public static implicit operator OneOrManyRecipient (Audience[] values) { return new OneOrManyRecipient (values.Select(v => (IRecipient) new RecipientAudience (v))); }
            public static implicit operator OneOrManyRecipient (List<Audience> values) { return new OneOrManyRecipient (values.Select(v => (IRecipient) new RecipientAudience (v))); }
            public static implicit operator OneOrManyRecipient (ContactPoint value) { return new OneOrManyRecipient (new RecipientContactPoint (value)); }
            public static implicit operator OneOrManyRecipient (ContactPoint[] values) { return new OneOrManyRecipient (values.Select(v => (IRecipient) new RecipientContactPoint (v))); }
            public static implicit operator OneOrManyRecipient (List<ContactPoint> values) { return new OneOrManyRecipient (values.Select(v => (IRecipient) new RecipientContactPoint (v))); }
            public static implicit operator OneOrManyRecipient (Organization value) { return new OneOrManyRecipient (new RecipientOrganization (value)); }
            public static implicit operator OneOrManyRecipient (Organization[] values) { return new OneOrManyRecipient (values.Select(v => (IRecipient) new RecipientOrganization (v))); }
            public static implicit operator OneOrManyRecipient (List<Organization> values) { return new OneOrManyRecipient (values.Select(v => (IRecipient) new RecipientOrganization (v))); }
            public static implicit operator OneOrManyRecipient (Person value) { return new OneOrManyRecipient (new RecipientPerson (value)); }
            public static implicit operator OneOrManyRecipient (Person[] values) { return new OneOrManyRecipient (values.Select(v => (IRecipient) new RecipientPerson (v))); }
            public static implicit operator OneOrManyRecipient (List<Person> values) { return new OneOrManyRecipient (values.Select(v => (IRecipient) new RecipientPerson (v))); }
        }
        public struct RecipientAudience : IRecipient<Audience>
        {
            object IValue.Value => this.Value;
            public Audience Value { get; }
            public RecipientAudience (Audience value) { Value = value; }
            public static implicit operator RecipientAudience (Audience value) { return new RecipientAudience (value); }
        }
        public struct RecipientContactPoint : IRecipient<ContactPoint>
        {
            object IValue.Value => this.Value;
            public ContactPoint Value { get; }
            public RecipientContactPoint (ContactPoint value) { Value = value; }
            public static implicit operator RecipientContactPoint (ContactPoint value) { return new RecipientContactPoint (value); }
        }
        public struct RecipientOrganization : IRecipient<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public RecipientOrganization (Organization value) { Value = value; }
            public static implicit operator RecipientOrganization (Organization value) { return new RecipientOrganization (value); }
        }
        public struct RecipientPerson : IRecipient<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public RecipientPerson (Person value) { Value = value; }
            public static implicit operator RecipientPerson (Person value) { return new RecipientPerson (value); }
        }

        public interface ISender : IValue {}
        public interface ISender<T> : ISender { new T Value { get; } }
        public class OneOrManySender : OneOrMany<ISender>
        {
            public OneOrManySender(ISender item) : base(item) { }
            public OneOrManySender(IEnumerable<ISender> items) : base(items) { }
            public static implicit operator OneOrManySender (Audience value) { return new OneOrManySender (new SenderAudience (value)); }
            public static implicit operator OneOrManySender (Audience[] values) { return new OneOrManySender (values.Select(v => (ISender) new SenderAudience (v))); }
            public static implicit operator OneOrManySender (List<Audience> values) { return new OneOrManySender (values.Select(v => (ISender) new SenderAudience (v))); }
            public static implicit operator OneOrManySender (Organization value) { return new OneOrManySender (new SenderOrganization (value)); }
            public static implicit operator OneOrManySender (Organization[] values) { return new OneOrManySender (values.Select(v => (ISender) new SenderOrganization (v))); }
            public static implicit operator OneOrManySender (List<Organization> values) { return new OneOrManySender (values.Select(v => (ISender) new SenderOrganization (v))); }
            public static implicit operator OneOrManySender (Person value) { return new OneOrManySender (new SenderPerson (value)); }
            public static implicit operator OneOrManySender (Person[] values) { return new OneOrManySender (values.Select(v => (ISender) new SenderPerson (v))); }
            public static implicit operator OneOrManySender (List<Person> values) { return new OneOrManySender (values.Select(v => (ISender) new SenderPerson (v))); }
        }
        public struct SenderAudience : ISender<Audience>
        {
            object IValue.Value => this.Value;
            public Audience Value { get; }
            public SenderAudience (Audience value) { Value = value; }
            public static implicit operator SenderAudience (Audience value) { return new SenderAudience (value); }
        }
        public struct SenderOrganization : ISender<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public SenderOrganization (Organization value) { Value = value; }
            public static implicit operator SenderOrganization (Organization value) { return new SenderOrganization (value); }
        }
        public struct SenderPerson : ISender<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public SenderPerson (Person value) { Value = value; }
            public static implicit operator SenderPerson (Person value) { return new SenderPerson (value); }
        }

        public interface IToRecipient : IValue {}
        public interface IToRecipient<T> : IToRecipient { new T Value { get; } }
        public class OneOrManyToRecipient : OneOrMany<IToRecipient>
        {
            public OneOrManyToRecipient(IToRecipient item) : base(item) { }
            public OneOrManyToRecipient(IEnumerable<IToRecipient> items) : base(items) { }
            public static implicit operator OneOrManyToRecipient (Audience value) { return new OneOrManyToRecipient (new ToRecipientAudience (value)); }
            public static implicit operator OneOrManyToRecipient (Audience[] values) { return new OneOrManyToRecipient (values.Select(v => (IToRecipient) new ToRecipientAudience (v))); }
            public static implicit operator OneOrManyToRecipient (List<Audience> values) { return new OneOrManyToRecipient (values.Select(v => (IToRecipient) new ToRecipientAudience (v))); }
            public static implicit operator OneOrManyToRecipient (ContactPoint value) { return new OneOrManyToRecipient (new ToRecipientContactPoint (value)); }
            public static implicit operator OneOrManyToRecipient (ContactPoint[] values) { return new OneOrManyToRecipient (values.Select(v => (IToRecipient) new ToRecipientContactPoint (v))); }
            public static implicit operator OneOrManyToRecipient (List<ContactPoint> values) { return new OneOrManyToRecipient (values.Select(v => (IToRecipient) new ToRecipientContactPoint (v))); }
            public static implicit operator OneOrManyToRecipient (Organization value) { return new OneOrManyToRecipient (new ToRecipientOrganization (value)); }
            public static implicit operator OneOrManyToRecipient (Organization[] values) { return new OneOrManyToRecipient (values.Select(v => (IToRecipient) new ToRecipientOrganization (v))); }
            public static implicit operator OneOrManyToRecipient (List<Organization> values) { return new OneOrManyToRecipient (values.Select(v => (IToRecipient) new ToRecipientOrganization (v))); }
            public static implicit operator OneOrManyToRecipient (Person value) { return new OneOrManyToRecipient (new ToRecipientPerson (value)); }
            public static implicit operator OneOrManyToRecipient (Person[] values) { return new OneOrManyToRecipient (values.Select(v => (IToRecipient) new ToRecipientPerson (v))); }
            public static implicit operator OneOrManyToRecipient (List<Person> values) { return new OneOrManyToRecipient (values.Select(v => (IToRecipient) new ToRecipientPerson (v))); }
        }
        public struct ToRecipientAudience : IToRecipient<Audience>
        {
            object IValue.Value => this.Value;
            public Audience Value { get; }
            public ToRecipientAudience (Audience value) { Value = value; }
            public static implicit operator ToRecipientAudience (Audience value) { return new ToRecipientAudience (value); }
        }
        public struct ToRecipientContactPoint : IToRecipient<ContactPoint>
        {
            object IValue.Value => this.Value;
            public ContactPoint Value { get; }
            public ToRecipientContactPoint (ContactPoint value) { Value = value; }
            public static implicit operator ToRecipientContactPoint (ContactPoint value) { return new ToRecipientContactPoint (value); }
        }
        public struct ToRecipientOrganization : IToRecipient<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public ToRecipientOrganization (Organization value) { Value = value; }
            public static implicit operator ToRecipientOrganization (Organization value) { return new ToRecipientOrganization (value); }
        }
        public struct ToRecipientPerson : IToRecipient<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public ToRecipientPerson (Person value) { Value = value; }
            public static implicit operator ToRecipientPerson (Person value) { return new ToRecipientPerson (value); }
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
        public OneOrManyBccRecipient BccRecipient { get; set; }

        /// <summary>
        /// A sub property of recipient. The recipient copied on a message.
        /// </summary>
        [DataMember(Name = "ccRecipient", Order = 207)]
        public OneOrManyCcRecipient CcRecipient { get; set; }

        /// <summary>
        /// The date/time at which the message has been read by the recipient if a single recipient exists.
        /// </summary>
        [DataMember(Name = "dateRead", Order = 208)]
        public OneOrManyDateRead DateRead { get; set; }

        /// <summary>
        /// The date/time the message was received if a single recipient exists.
        /// </summary>
        [DataMember(Name = "dateReceived", Order = 209)]
        public OneOrManyDateReceived DateReceived { get; set; }

        /// <summary>
        /// The date/time at which the message was sent.
        /// </summary>
        [DataMember(Name = "dateSent", Order = 210)]
        public OneOrManyDateSent DateSent { get; set; }

        /// <summary>
        /// A CreativeWork attached to the message.
        /// </summary>
        [DataMember(Name = "messageAttachment", Order = 211)]
        public OneOrManyMessageAttachment MessageAttachment { get; set; }

        /// <summary>
        /// A sub property of participant. The participant who is at the receiving end of the action.
        /// </summary>
        [DataMember(Name = "recipient", Order = 212)]
        public OneOrManyRecipient Recipient { get; set; }

        /// <summary>
        /// A sub property of participant. The participant who is at the sending end of the action.
        /// </summary>
        [DataMember(Name = "sender", Order = 213)]
        public OneOrManySender Sender { get; set; }

        /// <summary>
        /// A sub property of recipient. The recipient who was directly sent the message.
        /// </summary>
        [DataMember(Name = "toRecipient", Order = 214)]
        public OneOrManyToRecipient ToRecipient { get; set; }
    }
}
