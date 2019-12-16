namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A component of the human body circulatory system comprised of an intricate network of hollow tubes that transport blood throughout the entire body.
    /// </summary>
    public partial interface IVessel : IAnatomicalStructure
    {
    }

    /// <summary>
    /// A component of the human body circulatory system comprised of an intricate network of hollow tubes that transport blood throughout the entire body.
    /// </summary>
    [DataContract]
    public partial class Vessel : AnatomicalStructure, IVessel, IEquatable<Vessel>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Vessel";

        /// <inheritdoc/>
        public bool Equals(Vessel other)
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
        public override bool Equals(object obj) => this.Equals(obj as Vessel);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
