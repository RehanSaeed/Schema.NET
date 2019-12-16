namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Event type: Exhibition event, e.g. at a museum, library, archive, tradeshow, ...
    /// </summary>
    public partial interface IExhibitionEvent : IEvent
    {
    }

    /// <summary>
    /// Event type: Exhibition event, e.g. at a museum, library, archive, tradeshow, ...
    /// </summary>
    [DataContract]
    public partial class ExhibitionEvent : Event, IExhibitionEvent, IEquatable<ExhibitionEvent>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ExhibitionEvent";

        /// <inheritdoc/>
        public bool Equals(ExhibitionEvent other)
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
        public override bool Equals(object obj) => this.Equals(obj as ExhibitionEvent);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
