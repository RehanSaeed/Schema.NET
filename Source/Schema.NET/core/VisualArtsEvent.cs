namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Event type: Visual arts event.
    /// </summary>
    public partial interface IVisualArtsEvent : IEvent
    {
    }

    /// <summary>
    /// Event type: Visual arts event.
    /// </summary>
    [DataContract]
    public partial class VisualArtsEvent : Event, IVisualArtsEvent, IEquatable<VisualArtsEvent>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "VisualArtsEvent";

        /// <inheritdoc/>
        public bool Equals(VisualArtsEvent other)
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
        public override bool Equals(object obj) => this.Equals(obj as VisualArtsEvent);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
