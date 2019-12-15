namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A high school.
    /// </summary>
    public partial interface IHighSchool : IEducationalOrganization
    {
    }

    /// <summary>
    /// A high school.
    /// </summary>
    [DataContract]
    public partial class HighSchool : EducationalOrganization, IHighSchool, IEquatable<HighSchool>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "HighSchool";

        /// <inheritdoc/>
        public bool Equals(HighSchool other)
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
        public override bool Equals(object obj) => this.Equals(obj as HighSchool);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
