namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A golf course.
    /// </summary>
    public partial interface IGolfCourse : ISportsActivityLocation
    {
    }

    /// <summary>
    /// A golf course.
    /// </summary>
    [DataContract]
    public partial class GolfCourse : SportsActivityLocation, IGolfCourse, IEquatable<GolfCourse>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "GolfCourse";

        /// <inheritdoc/>
        public bool Equals(GolfCourse other)
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
        public override bool Equals(object obj) => this.Equals(obj as GolfCourse);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
