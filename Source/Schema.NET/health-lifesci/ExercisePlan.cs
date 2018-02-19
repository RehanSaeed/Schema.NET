using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// Fitness-related activity designed for a specific health-related purpose, including defined exercise routines as well as activity prescribed by a clinician.
    /// </summary>
    [DataContract]
    public partial class ExercisePlan : CreativeWorkAndPhysicalActivity
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ExercisePlan";

        /// <summary>
        /// Length of time to engage in the activity.
        /// </summary>
        [DataMember(Name = "activityDuration", Order = 406)]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesConverter))]
        public Values<TimeSpan>? ActivityDuration { get; set; } 

        /// <summary>
        /// How often one should engage in the activity.
        /// </summary>
        [DataMember(Name = "activityFrequency", Order = 407)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? ActivityFrequency { get; set; } 

        /// <summary>
        /// Any additional component of the exercise prescription that may need to be articulated to the patient. This may include the order of exercises, the number of repetitions of movement, quantitative distance, progressions over time, etc.
        /// </summary>
        [DataMember(Name = "additionalVariable", Order = 408)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? AdditionalVariable { get; set; } 

        /// <summary>
        /// Type(s) of exercise or activity, such as strength training, flexibility training, aerobics, cardiac rehabilitation, etc.
        /// </summary>
        [DataMember(Name = "exerciseType", Order = 409)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? ExerciseType { get; set; } 

        /// <summary>
        /// Quantitative measure gauging the degree of force involved in the exercise, for example, heartbeats per minute. May include the velocity of the movement.
        /// </summary>
        [DataMember(Name = "intensity", Order = 410)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Intensity { get; set; } 

        /// <summary>
        /// Number of times one should repeat the activity.
        /// </summary>
        [DataMember(Name = "repetitions", Order = 411)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<double>? Repetitions { get; set; } 

        /// <summary>
        /// How often one should break from the activity.
        /// </summary>
        [DataMember(Name = "restPeriods", Order = 412)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? RestPeriods { get; set; } 

        /// <summary>
        /// Quantitative measure of the physiologic output of the exercise; also referred to as energy expenditure.
        /// </summary>
        [DataMember(Name = "workload", Order = 413)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Workload { get; set; } 
    }
}
