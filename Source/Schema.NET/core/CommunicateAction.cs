using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// The act of conveying information to another person via a communication medium (instrument) such as speech, email, or telephone conversation.
    /// </summary>
    [DataContract]
    public partial class CommunicateAction : InteractAction
    {
        public interface IInLanguage : IWrapper { }
        public interface IInLanguage<T> : IInLanguage { new T Data { get; set; } }
        public class InLanguageLanguage : IInLanguage<Language>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Language) value; } }
            public virtual Language Data { get; set; }
            public InLanguageLanguage () { }
            public InLanguageLanguage (Language data) { Data = data; }
            public static implicit operator InLanguageLanguage (Language data) { return new InLanguageLanguage (data); }
        }

        public class InLanguagestring : IInLanguage<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public InLanguagestring () { }
            public InLanguagestring (string data) { Data = data; }
            public static implicit operator InLanguagestring (string data) { return new InLanguagestring (data); }
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
        public override string Type => "CommunicateAction";

        /// <summary>
        /// The subject matter of the content.
        /// </summary>
        [DataMember(Name = "about", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Thing>? About { get; set; } 

        /// <summary>
        /// The language of the content or performance or used in an action. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="http://schema.org/availableLanguage"&gt;availableLanguage&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "inLanguage", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IInLanguage>? InLanguage { get; set; } //Language, string

        /// <summary>
        /// A sub property of participant. The participant who is at the receiving end of the action.
        /// </summary>
        [DataMember(Name = "recipient", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IRecipient>? Recipient { get; set; } //Audience, ContactPoint, Organization, Person
    }
}
