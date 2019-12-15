namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A radio channel that uses FM.
    /// </summary>
    public partial interface IFMRadioChannel : IRadioChannel
    {
    }

    /// <summary>
    /// A radio channel that uses FM.
    /// </summary>
    [DataContract]
    public partial class FMRadioChannel : RadioChannel, IFMRadioChannel, IEquatable<FMRadioChannel>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "FMRadioChannel";

        /// <inheritdoc/>
        public bool Equals(FMRadioChannel other)
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
        public override bool Equals(object obj) => this.Equals(obj as FMRadioChannel);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
