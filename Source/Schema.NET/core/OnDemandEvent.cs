namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A publication event e.g. catch-up TV or radio podcast, during which a program is available on-demand.
    /// </summary>
    public partial interface IOnDemandEvent : IPublicationEvent
    {
    }

    /// <summary>
    /// A publication event e.g. catch-up TV or radio podcast, during which a program is available on-demand.
    /// </summary>
    [DataContract]
    public partial class OnDemandEvent : PublicationEvent, IOnDemandEvent, IEquatable<OnDemandEvent>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "OnDemandEvent";

        /// <inheritdoc/>
        public bool Equals(OnDemandEvent other)
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
        public override bool Equals(object obj) => this.Equals(obj as OnDemandEvent);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
