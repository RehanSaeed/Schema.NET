namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A radio channel that uses AM.
    /// </summary>
    public partial interface IAMRadioChannel : IRadioChannel
    {
    }

    /// <summary>
    /// A radio channel that uses AM.
    /// </summary>
    [DataContract]
    public partial class AMRadioChannel : RadioChannel, IAMRadioChannel, IEquatable<AMRadioChannel>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AMRadioChannel";

        /// <inheritdoc/>
        public bool Equals(AMRadioChannel other)
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
        public override bool Equals(object obj) => this.Equals(obj as AMRadioChannel);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
