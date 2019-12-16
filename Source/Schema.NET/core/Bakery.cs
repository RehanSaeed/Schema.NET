namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A bakery.
    /// </summary>
    public partial interface IBakery : IFoodEstablishment
    {
    }

    /// <summary>
    /// A bakery.
    /// </summary>
    [DataContract]
    public partial class Bakery : FoodEstablishment, IBakery, IEquatable<Bakery>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Bakery";

        /// <inheritdoc/>
        public bool Equals(Bakery other)
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
        public override bool Equals(object obj) => this.Equals(obj as Bakery);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
