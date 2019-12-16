namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Event type: Education event.
    /// </summary>
    public partial interface IEducationEvent : IEvent
    {
    }

    /// <summary>
    /// Event type: Education event.
    /// </summary>
    [DataContract]
    public partial class EducationEvent : Event, IEducationEvent, IEquatable<EducationEvent>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "EducationEvent";

        /// <inheritdoc/>
        public bool Equals(EducationEvent other)
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
        public override bool Equals(object obj) => this.Equals(obj as EducationEvent);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
