namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Event type: Sales event.
    /// </summary>
    public partial interface ISaleEvent : IEvent
    {
    }

    /// <summary>
    /// Event type: Sales event.
    /// </summary>
    [DataContract]
    public partial class SaleEvent : Event, ISaleEvent, IEquatable<SaleEvent>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SaleEvent";

        /// <inheritdoc/>
        public bool Equals(SaleEvent other)
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
        public override bool Equals(object obj) => this.Equals(obj as SaleEvent);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
