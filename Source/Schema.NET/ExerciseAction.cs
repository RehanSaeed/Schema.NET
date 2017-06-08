namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of participating in exertive activity for the purposes of improving health and fitness.
    /// </summary>
    [DataContract]
    public class ExerciseAction : PlayAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "ExerciseAction";

        /// <summary>
        /// A sub property of participant. The sports team that participated on this action.
        /// </summary>
        [DataMember(Name = "sportsTeam")]
        public SportsTeam SportsTeam { get; set; }

        /// <summary>
        /// A sub property of location. The sports event where this action occurred.
        /// </summary>
        [DataMember(Name = "sportsEvent")]
        public SportsEvent SportsEvent { get; set; }

        /// <summary>
        /// The distance travelled, e.g. exercising or travelling.
        /// </summary>
        [DataMember(Name = "distance")]
        public Distance Distance { get; set; }

        /// <summary>
        /// A sub property of participant. The opponent on this action.
        /// </summary>
        [DataMember(Name = "opponent")]
        public Person Opponent { get; set; }

        /// <summary>
        /// A sub property of location. The sports activity location where this action occurred.
        /// </summary>
        [DataMember(Name = "sportsActivityLocation")]
        public SportsActivityLocation SportsActivityLocation { get; set; }

        /// <summary>
        /// A sub property of location. The final location of the object or the agent after the action.
        /// </summary>
        [DataMember(Name = "toLocation")]
        public Place ToLocation { get; set; }

        /// <summary>
        /// A sub property of location. The original location of the object or the agent before the action.
        /// </summary>
        [DataMember(Name = "fromLocation")]
        public Place FromLocation { get; set; }

        /// <summary>
        /// A sub property of location. The course where this action was taken.
        /// </summary>
        [DataMember(Name = "exerciseCourse")]
        public Place ExerciseCourse { get; set; }
    }
}
