using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A PublicationEvent corresponds indifferently to the event of publication for a CreativeWork of any type e.g. a broadcast event, an on-demand event, a book/journal publication via a variety of delivery media.
    /// </summary>
    [DataContract]
    public partial class PublicationEvent : Event
    {
        public interface IPublishedBy : IWrapper { }
        public interface IPublishedBy<T> : IPublishedBy { new T Data { get; set; } }
        public class PublishedByOrganization : IPublishedBy<Organization>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Organization) value; } }
            public virtual Organization Data { get; set; }
            public PublishedByOrganization () { }
            public PublishedByOrganization (Organization data) { Data = data; }
            public static implicit operator PublishedByOrganization (Organization data) { return new PublishedByOrganization (data); }
        }

        public class PublishedByPerson : IPublishedBy<Person>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Person) value; } }
            public virtual Person Data { get; set; }
            public PublishedByPerson () { }
            public PublishedByPerson (Person data) { Data = data; }
            public static implicit operator PublishedByPerson (Person data) { return new PublishedByPerson (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PublicationEvent";

        /// <summary>
        /// A flag to signal that the item, event, or place is accessible for free.
        /// </summary>
        [DataMember(Name = "isAccessibleForFree", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<bool>? IsAccessibleForFree { get; set; } 

        /// <summary>
        /// An agent associated with the publication event.
        /// </summary>
        [DataMember(Name = "publishedBy", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IPublishedBy>? PublishedBy { get; set; } //Organization, Person

        /// <summary>
        /// A broadcast service associated with the publication event.
        /// </summary>
        [DataMember(Name = "publishedOn", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<BroadcastService>? PublishedOn { get; set; } 
    }
}
