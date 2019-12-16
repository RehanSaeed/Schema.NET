namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A permit issued by a government agency.
    /// </summary>
    public partial interface IGovernmentPermit : IPermit
    {
    }

    /// <summary>
    /// A permit issued by a government agency.
    /// </summary>
    [DataContract]
    public partial class GovernmentPermit : Permit, IGovernmentPermit, IEquatable<GovernmentPermit>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "GovernmentPermit";

        /// <inheritdoc/>
        public bool Equals(GovernmentPermit other)
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
        public override bool Equals(object obj) => this.Equals(obj as GovernmentPermit);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
