namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of achieving victory in a competitive activity.
    /// </summary>
    public partial interface IWinAction : IAchieveAction
    {
        /// <summary>
        /// A sub property of participant. The loser of the action.
        /// </summary>
        OneOrMany<IPerson>? Loser { get; set; }
    }

    /// <summary>
    /// The act of achieving victory in a competitive activity.
    /// </summary>
    [DataContract]
    public partial class WinAction : AchieveAction, IWinAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "WinAction";

        /// <summary>
        /// A sub property of participant. The loser of the action.
        /// </summary>
        [DataMember(Name = "loser", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IPerson>? Loser { get; set; }
    }
}
