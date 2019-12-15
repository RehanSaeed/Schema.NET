namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of transferring/moving (abstract or concrete) animate or inanimate objects from one place to another.
    /// </summary>
    public partial interface ITransferAction : IAction
    {
        /// <summary>
        /// A sub property of location. The original location of the object or the agent before the action.
        /// </summary>
        OneOrMany<IPlace> FromLocation { get; set; }

        /// <summary>
        /// A sub property of location. The final location of the object or the agent after the action.
        /// </summary>
        OneOrMany<IPlace> ToLocation { get; set; }
    }

    /// <summary>
    /// The act of transferring/moving (abstract or concrete) animate or inanimate objects from one place to another.
    /// </summary>
    [DataContract]
    public partial class TransferAction : Action, ITransferAction, IEquatable<TransferAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TransferAction";

        /// <summary>
        /// A sub property of location. The original location of the object or the agent before the action.
        /// </summary>
        [DataMember(Name = "fromLocation", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPlace> FromLocation { get; set; }

        /// <summary>
        /// A sub property of location. The final location of the object or the agent after the action.
        /// </summary>
        [DataMember(Name = "toLocation", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPlace> ToLocation { get; set; }

        /// <inheritdoc/>
        public bool Equals(TransferAction other)
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
                this.FromLocation == other.FromLocation &&
                this.ToLocation == other.ToLocation &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as TransferAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.FromLocation)
            .And(this.ToLocation)
            .And(base.GetHashCode());
    }
}
