using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// An agent pays a price to a participant.
    /// </summary>
    [DataContract]
    public partial class PayAction : TradeAction
    {
        public interface IPurpose : IWrapper { }
        public interface IPurpose<T> : IPurpose { new T Data { get; set; } }
        public class PurposeMedicalDevicePurpose : IPurpose<MedicalDevicePurpose>
        {
            object IWrapper.Data { get { return Data; } set { Data = (MedicalDevicePurpose) value; } }
            public virtual MedicalDevicePurpose Data { get; set; }
            public PurposeMedicalDevicePurpose () { }
            public PurposeMedicalDevicePurpose (MedicalDevicePurpose data) { Data = data; }
            public static implicit operator PurposeMedicalDevicePurpose (MedicalDevicePurpose data) { return new PurposeMedicalDevicePurpose (data); }
        }

        public class PurposeThing : IPurpose<Thing>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Thing) value; } }
            public virtual Thing Data { get; set; }
            public PurposeThing () { }
            public PurposeThing (Thing data) { Data = data; }
            public static implicit operator PurposeThing (Thing data) { return new PurposeThing (data); }
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


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PayAction";

        /// <summary>
        /// A goal towards an action is taken. Can be concrete or abstract.
        /// </summary>
        [DataMember(Name = "purpose", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IPurpose>? Purpose { get; set; } //MedicalDevicePurpose?, Thing

        /// <summary>
        /// A sub property of participant. The participant who is at the receiving end of the action.
        /// </summary>
        [DataMember(Name = "recipient", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IRecipient>? Recipient { get; set; } //Audience, ContactPoint, Organization, Person
    }
}
