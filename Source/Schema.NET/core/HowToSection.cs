namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A sub-grouping of steps in the instructions for how to achieve a result (e.g. steps for making a pie crust within a pie recipe).
    /// </summary>
    [DataContract]
    public partial class HowToSection : ItemList
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "HowToSection";

        /// <summary>
        /// The steps in the form of a single item (text, document, video, etc.) or an ordered list with HowToStep and/or HowToSection items.
        /// </summary>
        [DataMember(Name = "steps", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<CreativeWork, ItemList, string>? Steps { get; set; }
    }
}
