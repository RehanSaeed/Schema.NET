namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A food service, like breakfast, lunch, or dinner.
    /// </summary>
    public partial interface IFoodService : IService
    {
    }

    /// <summary>
    /// A food service, like breakfast, lunch, or dinner.
    /// </summary>
    [DataContract]
    public partial class FoodService : Service, IFoodService, IEquatable<FoodService>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "FoodService";

        /// <inheritdoc/>
        public bool Equals(FoodService other)
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
        public override bool Equals(object obj) => this.Equals(obj as FoodService);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
