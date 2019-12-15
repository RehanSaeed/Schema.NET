namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A dry-cleaning business.
    /// </summary>
    public partial interface IDryCleaningOrLaundry : ILocalBusiness
    {
    }

    /// <summary>
    /// A dry-cleaning business.
    /// </summary>
    [DataContract]
    public partial class DryCleaningOrLaundry : LocalBusiness, IDryCleaningOrLaundry, IEquatable<DryCleaningOrLaundry>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DryCleaningOrLaundry";

        /// <inheritdoc/>
        public bool Equals(DryCleaningOrLaundry other)
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
        public override bool Equals(object obj) => this.Equals(obj as DryCleaningOrLaundry);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
