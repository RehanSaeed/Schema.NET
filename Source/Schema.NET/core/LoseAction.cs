namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of being defeated in a competitive activity.
    /// </summary>
    [DataContract]
    public partial class LoseAction : AchieveAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "LoseAction";

        /// <summary>
        /// A sub property of participant. The winner of the action.
        /// </summary>
        [DataMember(Name = "winner", Order = 305)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person>? Winner { get; set; }
    }
}
