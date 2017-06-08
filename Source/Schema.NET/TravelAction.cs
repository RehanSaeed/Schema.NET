namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of traveling from an fromLocation to a destination by a specified mode of transport, optionally with participants.
    /// </summary>
    [DataContract]
    public class TravelAction : MoveAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "TravelAction";

        /// <summary>
        /// The distance travelled, e.g. exercising or travelling.
        /// </summary>
        [DataMember(Name = "distance")]
        public Distance Distance { get; set; }
    }
}
