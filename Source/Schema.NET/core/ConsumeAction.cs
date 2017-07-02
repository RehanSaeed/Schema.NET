namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of ingesting information/resources/food.
    /// </summary>
    [DataContract]
    public partial class ConsumeAction : Action
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ConsumeAction";

        /// <summary>
        /// An Offer which must be accepted before the user can perform the Action. For example, the user may need to buy a movie before being able to watch it.
        /// </summary>
        [DataMember(Name = "expectsAcceptanceOf", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Offer>? ExpectsAcceptanceOf { get; set; }
    }
}
