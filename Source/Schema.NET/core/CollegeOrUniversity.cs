namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A college, university, or other third-level educational institution.
    /// </summary>
    public partial interface ICollegeOrUniversity : IEducationalOrganization
    {
    }

    /// <summary>
    /// A college, university, or other third-level educational institution.
    /// </summary>
    [DataContract]
    public partial class CollegeOrUniversity : EducationalOrganization, ICollegeOrUniversity, IEquatable<CollegeOrUniversity>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "CollegeOrUniversity";

        /// <inheritdoc/>
        public bool Equals(CollegeOrUniversity other)
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
        public override bool Equals(object obj) => this.Equals(obj as CollegeOrUniversity);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
