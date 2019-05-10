namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of participating in exertive activity for the purposes of improving health and fitness.
    /// </summary>
    public partial interface IExerciseAction : IPlayAction
    {
        /// <summary>
        /// A sub property of instrument. The diet used in this action.
        /// </summary>
        OneOrMany<IDiet>? Diet { get; set; }

        /// <summary>
        /// The distance travelled, e.g. exercising or travelling.
        /// </summary>
        OneOrMany<string>? Distance { get; set; }

        /// <summary>
        /// A sub property of location. The course where this action was taken.
        /// </summary>
        OneOrMany<IPlace>? ExerciseCourse { get; set; }

        /// <summary>
        /// A sub property of instrument. The exercise plan used on this action.
        /// </summary>
        OneOrMany<IExercisePlan>? ExercisePlan { get; set; }

        /// <summary>
        /// A sub property of instrument. The diet used in this action.
        /// </summary>
        OneOrMany<IDiet>? ExerciseRelatedDiet { get; set; }

        /// <summary>
        /// Type(s) of exercise or activity, such as strength training, flexibility training, aerobics, cardiac rehabilitation, etc.
        /// </summary>
        OneOrMany<string>? ExerciseType { get; set; }

        /// <summary>
        /// A sub property of location. The original location of the object or the agent before the action.
        /// </summary>
        OneOrMany<IPlace>? FromLocation { get; set; }

        /// <summary>
        /// A sub property of participant. The opponent on this action.
        /// </summary>
        OneOrMany<IPerson>? Opponent { get; set; }

        /// <summary>
        /// A sub property of location. The sports activity location where this action occurred.
        /// </summary>
        OneOrMany<ISportsActivityLocation>? SportsActivityLocation { get; set; }

        /// <summary>
        /// A sub property of location. The sports event where this action occurred.
        /// </summary>
        OneOrMany<ISportsEvent>? SportsEvent { get; set; }

        /// <summary>
        /// A sub property of participant. The sports team that participated on this action.
        /// </summary>
        OneOrMany<ISportsTeam>? SportsTeam { get; set; }

        /// <summary>
        /// A sub property of location. The final location of the object or the agent after the action.
        /// </summary>
        OneOrMany<IPlace>? ToLocation { get; set; }
    }

    /// <summary>
    /// The act of participating in exertive activity for the purposes of improving health and fitness.
    /// </summary>
    [DataContract]
    public partial class ExerciseAction : PlayAction, IExerciseAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ExerciseAction";

        /// <summary>
        /// A sub property of instrument. The diet used in this action.
        /// </summary>
        [DataMember(Name = "diet", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IDiet>? Diet { get; set; }

        /// <summary>
        /// The distance travelled, e.g. exercising or travelling.
        /// </summary>
        [DataMember(Name = "distance", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? Distance { get; set; }

        /// <summary>
        /// A sub property of location. The course where this action was taken.
        /// </summary>
        [DataMember(Name = "exerciseCourse", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IPlace>? ExerciseCourse { get; set; }

        /// <summary>
        /// A sub property of instrument. The exercise plan used on this action.
        /// </summary>
        [DataMember(Name = "exercisePlan", Order = 309)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IExercisePlan>? ExercisePlan { get; set; }

        /// <summary>
        /// A sub property of instrument. The diet used in this action.
        /// </summary>
        [DataMember(Name = "exerciseRelatedDiet", Order = 310)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IDiet>? ExerciseRelatedDiet { get; set; }

        /// <summary>
        /// Type(s) of exercise or activity, such as strength training, flexibility training, aerobics, cardiac rehabilitation, etc.
        /// </summary>
        [DataMember(Name = "exerciseType", Order = 311)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? ExerciseType { get; set; }

        /// <summary>
        /// A sub property of location. The original location of the object or the agent before the action.
        /// </summary>
        [DataMember(Name = "fromLocation", Order = 312)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IPlace>? FromLocation { get; set; }

        /// <summary>
        /// A sub property of participant. The opponent on this action.
        /// </summary>
        [DataMember(Name = "opponent", Order = 313)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IPerson>? Opponent { get; set; }

        /// <summary>
        /// A sub property of location. The sports activity location where this action occurred.
        /// </summary>
        [DataMember(Name = "sportsActivityLocation", Order = 314)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<ISportsActivityLocation>? SportsActivityLocation { get; set; }

        /// <summary>
        /// A sub property of location. The sports event where this action occurred.
        /// </summary>
        [DataMember(Name = "sportsEvent", Order = 315)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<ISportsEvent>? SportsEvent { get; set; }

        /// <summary>
        /// A sub property of participant. The sports team that participated on this action.
        /// </summary>
        [DataMember(Name = "sportsTeam", Order = 316)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<ISportsTeam>? SportsTeam { get; set; }

        /// <summary>
        /// A sub property of location. The final location of the object or the agent after the action.
        /// </summary>
        [DataMember(Name = "toLocation", Order = 317)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IPlace>? ToLocation { get; set; }
    }
}
