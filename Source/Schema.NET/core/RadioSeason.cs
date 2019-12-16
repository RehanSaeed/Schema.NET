namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Season dedicated to radio broadcast and associated online delivery.
    /// </summary>
    public partial interface IRadioSeason : ICreativeWorkSeason
    {
    }

    /// <summary>
    /// Season dedicated to radio broadcast and associated online delivery.
    /// </summary>
    [DataContract]
    public partial class RadioSeason : CreativeWorkSeason, IRadioSeason, IEquatable<RadioSeason>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "RadioSeason";

        /// <inheritdoc/>
        public bool Equals(RadioSeason other)
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
        public override bool Equals(object obj) => this.Equals(obj as RadioSeason);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
