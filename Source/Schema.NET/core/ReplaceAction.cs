namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of editing a recipient by replacing an old object with a new object.
    /// </summary>
    [DataContract]
    public partial class ReplaceAction : UpdateAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ReplaceAction";

        /// <summary>
        /// A sub property of object. The object that is being replaced.
        /// </summary>
        [DataMember(Name = "replacee", Order = 305)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Thing>? Replacee { get; set; }

        /// <summary>
        /// A sub property of object. The object that replaces.
        /// </summary>
        [DataMember(Name = "replacer", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Thing>? Replacer { get; set; }
    }
}
