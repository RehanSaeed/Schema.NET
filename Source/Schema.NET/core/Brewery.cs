namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Brewery.
    /// </summary>
    public partial interface IBrewery : IFoodEstablishment
    {
    }

    /// <summary>
    /// Brewery.
    /// </summary>
    [DataContract]
    public partial class Brewery : FoodEstablishment, IBrewery, IEquatable<Brewery>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Brewery";

        /// <inheritdoc/>
        public bool Equals(Brewery other)
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
        public override bool Equals(object obj) => this.Equals(obj as Brewery);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
