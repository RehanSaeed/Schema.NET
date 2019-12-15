namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An event venue.
    /// </summary>
    public partial interface IEventVenue : ICivicStructure
    {
    }

    /// <summary>
    /// An event venue.
    /// </summary>
    [DataContract]
    public partial class EventVenue : CivicStructure, IEventVenue, IEquatable<EventVenue>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "EventVenue";

        /// <inheritdoc/>
        public bool Equals(EventVenue other)
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
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as EventVenue);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
