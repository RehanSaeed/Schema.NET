namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A dance group&amp;#x2014;for example, the Alvin Ailey Dance Theater or Riverdance.
    /// </summary>
    public partial interface IDanceGroup : IPerformingGroup
    {
    }

    /// <summary>
    /// A dance group&amp;#x2014;for example, the Alvin Ailey Dance Theater or Riverdance.
    /// </summary>
    [DataContract]
    public partial class DanceGroup : PerformingGroup, IDanceGroup, IEquatable<DanceGroup>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DanceGroup";

        /// <inheritdoc/>
        public bool Equals(DanceGroup other)
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
        public override bool Equals(object obj) => this.Equals(obj as DanceGroup);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
