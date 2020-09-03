namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of an agent relocating to a place.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/TransferAction"&gt;TransferAction&lt;/a&gt;: Unlike TransferAction, the subject of the move is a living Person or Organization rather than an inanimate object.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    public partial interface IMoveAction : IAction
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
    /// The act of an agent relocating to a place.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/TransferAction"&gt;TransferAction&lt;/a&gt;: Unlike TransferAction, the subject of the move is a living Person or Organization rather than an inanimate object.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class MoveAction : Action, IMoveAction, IEquatable<MoveAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MoveAction";

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
        public bool Equals(MoveAction other)
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
        public override bool Equals(object obj) => this.Equals(obj as MoveAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.FromLocation)
            .And(this.ToLocation)
            .And(base.GetHashCode());
    }
}
