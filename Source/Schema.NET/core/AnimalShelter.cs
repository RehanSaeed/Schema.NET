namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Animal shelter.
    /// </summary>
    public partial interface IAnimalShelter : ILocalBusiness
    {
    }

    /// <summary>
    /// Animal shelter.
    /// </summary>
    [DataContract]
    public partial class AnimalShelter : LocalBusiness, IAnimalShelter, IEquatable<AnimalShelter>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AnimalShelter";

        /// <inheritdoc/>
        public bool Equals(AnimalShelter other)
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
        public override bool Equals(object obj) => this.Equals(obj as AnimalShelter);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
