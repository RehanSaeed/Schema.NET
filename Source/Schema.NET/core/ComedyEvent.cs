﻿namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Event type: Comedy event.
    /// </summary>
    public partial interface IComedyEvent : IEvent
    {
    }

    /// <summary>
    /// Event type: Comedy event.
    /// </summary>
    [DataContract]
    public partial class ComedyEvent : Event, IComedyEvent, IEquatable<ComedyEvent>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ComedyEvent";

        /// <inheritdoc/>
        public bool Equals(ComedyEvent other)
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
        public override bool Equals(object obj) => this.Equals(obj as ComedyEvent);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
