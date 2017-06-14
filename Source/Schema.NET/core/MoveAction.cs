namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of an agent relocating to a place.
    /// Related actions:
    ///
    /// TransferAction: Unlike TransferAction, the subject of the move is a living Person or Organization rather than an inanimate object.
    /// </summary>
    [DataContract]
    public partial class MoveAction : Action
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MoveAction";

        /// <summary>
        /// A sub property of location. The original location of the object or the agent before the action.
        /// </summary>
        [DataMember(Name = "fromLocation", Order = 2)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Place>? FromLocation { get; set; }

        /// <summary>
        /// A sub property of location. The final location of the object or the agent after the action.
        /// </summary>
        [DataMember(Name = "toLocation", Order = 3)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Place>? ToLocation { get; set; }
    }
}
