namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A distillery.
    /// </summary>
    public partial interface IDistillery : IFoodEstablishment
    {
    }

    /// <summary>
    /// A distillery.
    /// </summary>
    [DataContract]
    public partial class Distillery : FoodEstablishment, IDistillery, IEquatable<Distillery>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Distillery";

        /// <inheritdoc/>
        public bool Equals(Distillery other)
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
        public override bool Equals(object obj) => this.Equals(obj as Distillery);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
