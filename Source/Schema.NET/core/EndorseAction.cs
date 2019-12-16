namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An agent approves/certifies/likes/supports/sanction an object.
    /// </summary>
    public partial interface IEndorseAction : IReactAction
    {
        /// <summary>
        /// A sub property of participant. The person/organization being supported.
        /// </summary>
        Values<IOrganization, IPerson> Endorsee { get; set; }
    }

    /// <summary>
    /// An agent approves/certifies/likes/supports/sanction an object.
    /// </summary>
    [DataContract]
    public partial class EndorseAction : ReactAction, IEndorseAction, IEquatable<EndorseAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "EndorseAction";

        /// <summary>
        /// A sub property of participant. The person/organization being supported.
        /// </summary>
        [DataMember(Name = "endorsee", Order = 406)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Endorsee { get; set; }

        /// <inheritdoc/>
        public bool Equals(EndorseAction other)
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
                this.Endorsee == other.Endorsee &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as EndorseAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.Endorsee)
            .And(base.GetHashCode());
    }
}
