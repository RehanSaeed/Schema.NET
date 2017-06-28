namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of transferring/moving (abstract or concrete) animate or inanimate objects from one place to another.
    /// </summary>
    [DataContract]
    public partial class TransferAction : Action
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TransferAction";

        /// <summary>
        /// A sub property of location. The original location of the object or the agent before the action.
        /// </summary>
        [DataMember(Name = "fromLocation", Order = 205)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Place>? FromLocation { get; set; }

        /// <summary>
        /// A sub property of location. The final location of the object or the agent after the action.
        /// </summary>
        [DataMember(Name = "toLocation", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Place>? ToLocation { get; set; }
    }
}
