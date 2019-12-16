namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A theater or other performing art center.
    /// </summary>
    public partial interface IPerformingArtsTheater : ICivicStructure
    {
    }

    /// <summary>
    /// A theater or other performing art center.
    /// </summary>
    [DataContract]
    public partial class PerformingArtsTheater : CivicStructure, IPerformingArtsTheater, IEquatable<PerformingArtsTheater>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PerformingArtsTheater";

        /// <inheritdoc/>
        public bool Equals(PerformingArtsTheater other)
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
        public override bool Equals(object obj) => this.Equals(obj as PerformingArtsTheater);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
