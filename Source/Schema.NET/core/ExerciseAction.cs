namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of participating in exertive activity for the purposes of improving health and fitness.
    /// </summary>
    [DataContract]
    public partial class ExerciseAction : PlayAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ExerciseAction";

        /// <summary>
        /// The distance travelled, e.g. exercising or travelling.
        /// </summary>
        [DataMember(Name = "distance", Order = 305)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Distance { get; set; }

        /// <summary>
        /// A sub property of location. The course where this action was taken.
        /// </summary>
        [DataMember(Name = "exerciseCourse", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Place>? ExerciseCourse { get; set; }

        /// <summary>
        /// A sub property of location. The original location of the object or the agent before the action.
        /// </summary>
        [DataMember(Name = "fromLocation", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Place>? FromLocation { get; set; }

        /// <summary>
        /// A sub property of participant. The opponent on this action.
        /// </summary>
        [DataMember(Name = "opponent", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person>? Opponent { get; set; }

        /// <summary>
        /// A sub property of location. The sports activity location where this action occurred.
        /// </summary>
        [DataMember(Name = "sportsActivityLocation", Order = 309)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<SportsActivityLocation>? SportsActivityLocation { get; set; }

        /// <summary>
        /// A sub property of location. The sports event where this action occurred.
        /// </summary>
        [DataMember(Name = "sportsEvent", Order = 310)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<SportsEvent>? SportsEvent { get; set; }

        /// <summary>
        /// A sub property of participant. The sports team that participated on this action.
        /// </summary>
        [DataMember(Name = "sportsTeam", Order = 311)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<SportsTeam>? SportsTeam { get; set; }

        /// <summary>
        /// A sub property of location. The final location of the object or the agent after the action.
        /// </summary>
        [DataMember(Name = "toLocation", Order = 312)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Place>? ToLocation { get; set; }
    }
}
