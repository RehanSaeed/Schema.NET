namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A Childcare center.
    /// </summary>
    public partial interface IChildCare : ILocalBusiness
    {
    }

    /// <summary>
    /// A Childcare center.
    /// </summary>
    [DataContract]
    public partial class ChildCare : LocalBusiness, IChildCare, IEquatable<ChildCare>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ChildCare";

        /// <inheritdoc/>
        public bool Equals(ChildCare other)
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
        public override bool Equals(object obj) => this.Equals(obj as ChildCare);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
