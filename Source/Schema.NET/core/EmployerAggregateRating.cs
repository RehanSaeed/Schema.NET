namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An aggregate rating of an Organization related to its role as an employer.
    /// </summary>
    public partial interface IEmployerAggregateRating : IAggregateRating
    {
    }

    /// <summary>
    /// An aggregate rating of an Organization related to its role as an employer.
    /// </summary>
    [DataContract]
    public partial class EmployerAggregateRating : AggregateRating, IEmployerAggregateRating, IEquatable<EmployerAggregateRating>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "EmployerAggregateRating";

        /// <inheritdoc/>
        public bool Equals(EmployerAggregateRating other)
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
        public override bool Equals(object obj) => this.Equals(obj as EmployerAggregateRating);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
