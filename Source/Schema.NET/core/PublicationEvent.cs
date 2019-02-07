namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A PublicationEvent corresponds indifferently to the event of publication for a CreativeWork of any type e.g. a broadcast event, an on-demand event, a book/journal publication via a variety of delivery media.
    /// </summary>
    [DataContract]
    public partial class PublicationEvent : Event
    {

        public interface IPublishedBy : IValue {}
        public interface IPublishedBy<T> : IPublishedBy { new T Value { get; } }
        public class OneOrManyPublishedBy : OneOrMany<IPublishedBy>
        {
            public OneOrManyPublishedBy(IPublishedBy item) : base(item) { }
            public OneOrManyPublishedBy(IEnumerable<IPublishedBy> items) : base(items) { }
            public static implicit operator OneOrManyPublishedBy (Organization value) { return new OneOrManyPublishedBy (new PublishedByOrganization (value)); }
            public static implicit operator OneOrManyPublishedBy (Organization[] values) { return new OneOrManyPublishedBy (values.Select(v => (IPublishedBy) new PublishedByOrganization (v))); }
            public static implicit operator OneOrManyPublishedBy (List<Organization> values) { return new OneOrManyPublishedBy (values.Select(v => (IPublishedBy) new PublishedByOrganization (v))); }
            public static implicit operator OneOrManyPublishedBy (Person value) { return new OneOrManyPublishedBy (new PublishedByPerson (value)); }
            public static implicit operator OneOrManyPublishedBy (Person[] values) { return new OneOrManyPublishedBy (values.Select(v => (IPublishedBy) new PublishedByPerson (v))); }
            public static implicit operator OneOrManyPublishedBy (List<Person> values) { return new OneOrManyPublishedBy (values.Select(v => (IPublishedBy) new PublishedByPerson (v))); }
        }
        public struct PublishedByOrganization : IPublishedBy<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public PublishedByOrganization (Organization value) { Value = value; }
            public static implicit operator PublishedByOrganization (Organization value) { return new PublishedByOrganization (value); }
        }
        public struct PublishedByPerson : IPublishedBy<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public PublishedByPerson (Person value) { Value = value; }
            public static implicit operator PublishedByPerson (Person value) { return new PublishedByPerson (value); }
        }

        public interface IPublishedOn : IValue {}
        public interface IPublishedOn<T> : IPublishedOn { new T Value { get; } }
        public class OneOrManyPublishedOn : OneOrMany<IPublishedOn>
        {
            public OneOrManyPublishedOn(IPublishedOn item) : base(item) { }
            public OneOrManyPublishedOn(IEnumerable<IPublishedOn> items) : base(items) { }
            public static implicit operator OneOrManyPublishedOn (BroadcastService value) { return new OneOrManyPublishedOn (new PublishedOnBroadcastService (value)); }
            public static implicit operator OneOrManyPublishedOn (BroadcastService[] values) { return new OneOrManyPublishedOn (values.Select(v => (IPublishedOn) new PublishedOnBroadcastService (v))); }
            public static implicit operator OneOrManyPublishedOn (List<BroadcastService> values) { return new OneOrManyPublishedOn (values.Select(v => (IPublishedOn) new PublishedOnBroadcastService (v))); }
        }
        public struct PublishedOnBroadcastService : IPublishedOn<BroadcastService>
        {
            object IValue.Value => this.Value;
            public BroadcastService Value { get; }
            public PublishedOnBroadcastService (BroadcastService value) { Value = value; }
            public static implicit operator PublishedOnBroadcastService (BroadcastService value) { return new PublishedOnBroadcastService (value); }
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
        public override OneOrManyIsAccessibleForFree IsAccessibleForFree { get; set; }

        /// <summary>
        /// An agent associated with the publication event.
        /// </summary>
        [DataMember(Name = "publishedBy", Order = 207)]
        public OneOrManyPublishedBy PublishedBy { get; set; }

        /// <summary>
        /// A broadcast service associated with the publication event.
        /// </summary>
        [DataMember(Name = "publishedOn", Order = 208)]
        public OneOrManyPublishedOn PublishedOn { get; set; }
    }
}
