using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// The act of adding at a specific location in an ordered collection.
    /// </summary>
    [DataContract]
    public partial class InsertAction : AddAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "InsertAction";

        /// <summary>
        /// A sub property of location. The final location of the object or the agent after the action.
        /// </summary>
        [DataMember(Name = "toLocation", Order = 406)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Place>? ToLocation { get; set; } 
    }
}
