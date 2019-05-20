namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A gym.
    /// </summary>
    public partial interface IExerciseGym : ISportsActivityLocation
    {
    }

    /// <summary>
    /// A gym.
    /// </summary>
    [DataContract]
    public partial class ExerciseGym : SportsActivityLocation, IExerciseGym
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ExerciseGym";
    }
}
