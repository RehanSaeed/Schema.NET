namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Event type: Children's event.
    /// </summary>
    public partial interface IChildrensEvent : IEvent
    {
    }

    /// <summary>
    /// Event type: Children's event.
    /// </summary>
    [DataContract]
    public partial class ChildrensEvent : Event, IChildrensEvent, IEquatable<ChildrensEvent>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ChildrensEvent";

        /// <inheritdoc/>
        public bool Equals(ChildrensEvent other)
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
        public override bool Equals(object obj) => this.Equals(obj as ChildrensEvent);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
