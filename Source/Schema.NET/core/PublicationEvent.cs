namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A PublicationEvent corresponds indifferently to the event of publication for a CreativeWork of any type e.g. a broadcast event, an on-demand event, a book/journal publication via a variety of delivery media.
    /// </summary>
    public partial interface IPublicationEvent : IEvent
    {
        /// <summary>
        /// An agent associated with the publication event.
        /// </summary>
        Values<IOrganization, IPerson> PublishedBy { get; set; }

        /// <summary>
        /// A broadcast service associated with the publication event.
        /// </summary>
        OneOrMany<IBroadcastService> PublishedOn { get; set; }
    }

    /// <summary>
    /// A PublicationEvent corresponds indifferently to the event of publication for a CreativeWork of any type e.g. a broadcast event, an on-demand event, a book/journal publication via a variety of delivery media.
    /// </summary>
    [DataContract]
    public partial class PublicationEvent : Event, IPublicationEvent, IEquatable<PublicationEvent>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PublicationEvent";

        /// <summary>
        /// An agent associated with the publication event.
        /// </summary>
        [DataMember(Name = "publishedBy", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> PublishedBy { get; set; }

        /// <summary>
        /// A broadcast service associated with the publication event.
        /// </summary>
        [DataMember(Name = "publishedOn", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IBroadcastService> PublishedOn { get; set; }

        /// <inheritdoc/>
        public bool Equals(PublicationEvent other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Type == other.Type &&
                this.PublishedBy == other.PublishedBy &&
                this.PublishedOn == other.PublishedOn &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as PublicationEvent);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.PublishedBy)
            .And(this.PublishedOn)
            .And(base.GetHashCode());
    }
}
