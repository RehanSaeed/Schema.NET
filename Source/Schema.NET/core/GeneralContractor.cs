namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A general contractor.
    /// </summary>
    public partial interface IGeneralContractor : IHomeAndConstructionBusiness
    {
    }

    /// <summary>
    /// A general contractor.
    /// </summary>
    [DataContract]
    public partial class GeneralContractor : HomeAndConstructionBusiness, IGeneralContractor, IEquatable<GeneralContractor>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "GeneralContractor";

        /// <inheritdoc/>
        public bool Equals(GeneralContractor other)
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
        public override bool Equals(object obj) => this.Equals(obj as GeneralContractor);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
