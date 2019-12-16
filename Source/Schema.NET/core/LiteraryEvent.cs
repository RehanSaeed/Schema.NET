namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Event type: Literary event.
    /// </summary>
    public partial interface ILiteraryEvent : IEvent
    {
    }

    /// <summary>
    /// Event type: Literary event.
    /// </summary>
    [DataContract]
    public partial class LiteraryEvent : Event, ILiteraryEvent, IEquatable<LiteraryEvent>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "LiteraryEvent";

        /// <inheritdoc/>
        public bool Equals(LiteraryEvent other)
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
        public override bool Equals(object obj) => this.Equals(obj as LiteraryEvent);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
