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
        OneOrMany<string>? Distance { get; set; }
    }

    /// <summary>
    /// The act of traveling from an fromLocation to a destination by a specified mode of transport, optionally with participants.
    /// </summary>
    [DataContract]
    public partial class TravelAction : MoveAction, ITravelAction
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
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? Distance { get; set; }
    }
}
