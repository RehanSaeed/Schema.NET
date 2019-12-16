namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of installing an application.
    /// </summary>
    public partial interface IInstallAction : IConsumeAction
    {
    }

    /// <summary>
    /// The act of installing an application.
    /// </summary>
    [DataContract]
    public partial class InstallAction : ConsumeAction, IInstallAction, IEquatable<InstallAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "InstallAction";

        /// <inheritdoc/>
        public bool Equals(InstallAction other)
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
        public override bool Equals(object obj) => this.Equals(obj as InstallAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
