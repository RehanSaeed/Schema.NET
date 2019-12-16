namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A winery.
    /// </summary>
    public partial interface IWinery : IFoodEstablishment
    {
    }

    /// <summary>
    /// A winery.
    /// </summary>
    [DataContract]
    public partial class Winery : FoodEstablishment, IWinery, IEquatable<Winery>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Winery";

        /// <inheritdoc/>
        public bool Equals(Winery other)
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
        public override bool Equals(object obj) => this.Equals(obj as Winery);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
