namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A radio station.
    /// </summary>
    public partial interface IRadioStation : ILocalBusiness
    {
    }

    /// <summary>
    /// A radio station.
    /// </summary>
    [DataContract]
    public partial class RadioStation : LocalBusiness, IRadioStation, IEquatable<RadioStation>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "RadioStation";

        /// <inheritdoc/>
        public bool Equals(RadioStation other)
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
        public override bool Equals(object obj) => this.Equals(obj as RadioStation);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
