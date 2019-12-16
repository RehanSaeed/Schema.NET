namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of traveling from an fromLocation to a destination by a specified mode of transport, optionally with participants.
    /// </summary>
    public partial interface ITravelAction : IMoveAction
    {
        /// <summary>
        /// The distance travelled, e.g. exercising or travelling.
        /// </summary>
        OneOrMany<string> Distance { get; set; }
    }

    /// <summary>
    /// The act of traveling from an fromLocation to a destination by a specified mode of transport, optionally with participants.
    /// </summary>
    [DataContract]
    public partial class TravelAction : MoveAction, ITravelAction, IEquatable<TravelAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TravelAction";

        /// <summary>
        /// The distance travelled, e.g. exercising or travelling.
        /// </summary>
        [DataMember(Name = "distance", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Distance { get; set; }

        /// <inheritdoc/>
        public bool Equals(TravelAction other)
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
                this.Distance == other.Distance &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as TravelAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.Distance)
            .And(base.GetHashCode());
    }
}
