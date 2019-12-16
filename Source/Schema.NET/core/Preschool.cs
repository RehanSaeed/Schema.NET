namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A preschool.
    /// </summary>
    public partial interface IPreschool : IEducationalOrganization
    {
    }

    /// <summary>
    /// A preschool.
    /// </summary>
    [DataContract]
    public partial class Preschool : EducationalOrganization, IPreschool, IEquatable<Preschool>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Preschool";

        /// <inheritdoc/>
        public bool Equals(Preschool other)
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
        public override bool Equals(object obj) => this.Equals(obj as Preschool);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
