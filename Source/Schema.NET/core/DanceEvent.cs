namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Event type: A social dance.
    /// </summary>
    public partial interface IDanceEvent : IEvent
    {
    }

    /// <summary>
    /// Event type: A social dance.
    /// </summary>
    [DataContract]
    public partial class DanceEvent : Event, IDanceEvent, IEquatable<DanceEvent>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DanceEvent";

        /// <inheritdoc/>
        public bool Equals(DanceEvent other)
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
        public override bool Equals(object obj) => this.Equals(obj as DanceEvent);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
