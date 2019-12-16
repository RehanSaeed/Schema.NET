namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Event type: Food event.
    /// </summary>
    public partial interface IFoodEvent : IEvent
    {
    }

    /// <summary>
    /// Event type: Food event.
    /// </summary>
    [DataContract]
    public partial class FoodEvent : Event, IFoodEvent, IEquatable<FoodEvent>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "FoodEvent";

        /// <inheritdoc/>
        public bool Equals(FoodEvent other)
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
        public override bool Equals(object obj) => this.Equals(obj as FoodEvent);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
