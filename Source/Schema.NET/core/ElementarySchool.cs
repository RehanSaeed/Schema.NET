namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An elementary school.
    /// </summary>
    public partial interface IElementarySchool : IEducationalOrganization
    {
    }

    /// <summary>
    /// An elementary school.
    /// </summary>
    [DataContract]
    public partial class ElementarySchool : EducationalOrganization, IElementarySchool, IEquatable<ElementarySchool>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ElementarySchool";

        /// <inheritdoc/>
        public bool Equals(ElementarySchool other)
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
        public override bool Equals(object obj) => this.Equals(obj as ElementarySchool);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
