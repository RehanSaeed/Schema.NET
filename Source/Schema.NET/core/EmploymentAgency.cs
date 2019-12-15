namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An employment agency.
    /// </summary>
    public partial interface IEmploymentAgency : ILocalBusiness
    {
    }

    /// <summary>
    /// An employment agency.
    /// </summary>
    [DataContract]
    public partial class EmploymentAgency : LocalBusiness, IEmploymentAgency, IEquatable<EmploymentAgency>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "EmploymentAgency";

        /// <inheritdoc/>
        public bool Equals(EmploymentAgency other)
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
        public override bool Equals(object obj) => this.Equals(obj as EmploymentAgency);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
