namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Event type: Theater performance.
    /// </summary>
    public partial interface ITheaterEvent : IEvent
    {
    }

    /// <summary>
    /// Event type: Theater performance.
    /// </summary>
    [DataContract]
    public partial class TheaterEvent : Event, ITheaterEvent, IEquatable<TheaterEvent>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TheaterEvent";

        /// <inheritdoc/>
        public bool Equals(TheaterEvent other)
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
        public override bool Equals(object obj) => this.Equals(obj as TheaterEvent);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
