namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Event type: Business event.
    /// </summary>
    public partial interface IBusinessEvent : IEvent
    {
    }

    /// <summary>
    /// Event type: Business event.
    /// </summary>
    [DataContract]
    public partial class BusinessEvent : Event, IBusinessEvent, IEquatable<BusinessEvent>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BusinessEvent";

        /// <inheritdoc/>
        public bool Equals(BusinessEvent other)
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
        public override bool Equals(object obj) => this.Equals(obj as BusinessEvent);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
