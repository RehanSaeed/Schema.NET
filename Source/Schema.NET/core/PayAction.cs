namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// An agent pays a price to a participant.
    /// </summary>
    [DataContract]
    public partial class PayAction : TradeAction
    {
        public interface IPurpose : IValue {}
        public interface IPurpose<T> : IPurpose { new T Value { get; } }
        public class OneOrManyPurpose : OneOrMany<IPurpose>
        {
            public OneOrManyPurpose(IPurpose item) : base(item) { }
            public OneOrManyPurpose(IEnumerable<IPurpose> items) : base(items) { }
            public static implicit operator OneOrManyPurpose (MedicalDevicePurpose value) { return new OneOrManyPurpose (new PurposeMedicalDevicePurpose (value)); }
            public static implicit operator OneOrManyPurpose (MedicalDevicePurpose[] values) { return new OneOrManyPurpose (values.Select(v => (IPurpose) new PurposeMedicalDevicePurpose (v))); }
            public static implicit operator OneOrManyPurpose (List<MedicalDevicePurpose> values) { return new OneOrManyPurpose (values.Select(v => (IPurpose) new PurposeMedicalDevicePurpose (v))); }
            public static implicit operator OneOrManyPurpose (Thing value) { return new OneOrManyPurpose (new PurposeThing (value)); }
            public static implicit operator OneOrManyPurpose (Thing[] values) { return new OneOrManyPurpose (values.Select(v => (IPurpose) new PurposeThing (v))); }
            public static implicit operator OneOrManyPurpose (List<Thing> values) { return new OneOrManyPurpose (values.Select(v => (IPurpose) new PurposeThing (v))); }
        }
        public struct PurposeMedicalDevicePurpose : IPurpose<MedicalDevicePurpose>
        {
            object IValue.Value => this.Value;
            public MedicalDevicePurpose Value { get; }
            public PurposeMedicalDevicePurpose (MedicalDevicePurpose value) { Value = value; }
            public static implicit operator PurposeMedicalDevicePurpose (MedicalDevicePurpose value) { return new PurposeMedicalDevicePurpose (value); }
        }
        public struct PurposeThing : IPurpose<Thing>
        {
            object IValue.Value => this.Value;
            public Thing Value { get; }
            public PurposeThing (Thing value) { Value = value; }
            public static implicit operator PurposeThing (Thing value) { return new PurposeThing (value); }
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

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PayAction";

        /// <summary>
        /// A goal towards an action is taken. Can be concrete or abstract.
        /// </summary>
        [DataMember(Name = "purpose", Order = 306)]
        public OneOrManyPurpose Purpose { get; set; }

        /// <summary>
        /// A sub property of participant. The participant who is at the receiving end of the action.
        /// </summary>
        [DataMember(Name = "recipient", Order = 307)]
        public OneOrManyRecipient Recipient { get; set; }
    }
}
