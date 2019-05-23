namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of being defeated in a competitive activity.
    /// </summary>
    public partial interface ILoseAction : IAchieveAction
    {
        /// <summary>
        /// A sub property of participant. The winner of the action.
        /// </summary>
        OneOrMany<IPerson> Winner { get; set; }
    }

    /// <summary>
    /// The act of being defeated in a competitive activity.
    /// </summary>
    [DataContract]
    public partial class LoseAction : AchieveAction, ILoseAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "LoseAction";

        /// <summary>
        /// A sub property of participant. The winner of the action.
        /// </summary>
        [DataMember(Name = "winner", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Winner { get; set; }
    }
}
