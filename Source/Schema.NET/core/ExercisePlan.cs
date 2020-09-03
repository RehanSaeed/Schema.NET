namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Fitness-related activity designed for a specific health-related purpose, including defined exercise routines as well as activity prescribed by a clinician.
    /// </summary>
    public partial interface IExercisePlan : ICreativeWorkAndPhysicalActivity
    {
        /// <summary>
        /// Length of time to engage in the activity.
        /// </summary>
        Values<TimeSpan?, IQuantitativeValue> ActivityDuration { get; set; }

        /// <summary>
        /// How often one should engage in the activity.
        /// </summary>
        Values<IQuantitativeValue, string> ActivityFrequency { get; set; }

        /// <summary>
        /// Any additional component of the exercise prescription that may need to be articulated to the patient. This may include the order of exercises, the number of repetitions of movement, quantitative distance, progressions over time, etc.
        /// </summary>
        OneOrMany<string> AdditionalVariable { get; set; }

        /// <summary>
        /// Type(s) of exercise or activity, such as strength training, flexibility training, aerobics, cardiac rehabilitation, etc.
        /// </summary>
        OneOrMany<string> ExerciseType { get; set; }

        /// <summary>
        /// Quantitative measure gauging the degree of force involved in the exercise, for example, heartbeats per minute. May include the velocity of the movement.
        /// </summary>
        Values<IQuantitativeValue, string> Intensity { get; set; }

        /// <summary>
        /// Number of times one should repeat the activity.
        /// </summary>
        Values<double?, IQuantitativeValue> Repetitions { get; set; }

        /// <summary>
        /// How often one should break from the activity.
        /// </summary>
        Values<IQuantitativeValue, string> RestPeriods { get; set; }

        /// <summary>
        /// Quantitative measure of the physiologic output of the exercise; also referred to as energy expenditure.
        /// </summary>
        Values<string, IQuantitativeValue> Workload { get; set; }
    }

    /// <summary>
    /// Fitness-related activity designed for a specific health-related purpose, including defined exercise routines as well as activity prescribed by a clinician.
    /// </summary>
    [DataContract]
    public partial class ExercisePlan : CreativeWorkAndPhysicalActivity, IExercisePlan, IEquatable<ExercisePlan>
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
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesJsonConverter))]
        public Values<TimeSpan?, IQuantitativeValue> ActivityDuration { get; set; }

        /// <summary>
        /// How often one should engage in the activity.
        /// </summary>
        [DataMember(Name = "activityFrequency", Order = 407)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IQuantitativeValue, string> ActivityFrequency { get; set; }

        /// <summary>
        /// Any additional component of the exercise prescription that may need to be articulated to the patient. This may include the order of exercises, the number of repetitions of movement, quantitative distance, progressions over time, etc.
        /// </summary>
        [DataMember(Name = "additionalVariable", Order = 408)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> AdditionalVariable { get; set; }

        /// <summary>
        /// Type(s) of exercise or activity, such as strength training, flexibility training, aerobics, cardiac rehabilitation, etc.
        /// </summary>
        [DataMember(Name = "exerciseType", Order = 409)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ExerciseType { get; set; }

        /// <summary>
        /// Quantitative measure gauging the degree of force involved in the exercise, for example, heartbeats per minute. May include the velocity of the movement.
        /// </summary>
        [DataMember(Name = "intensity", Order = 410)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IQuantitativeValue, string> Intensity { get; set; }

        /// <summary>
        /// Number of times one should repeat the activity.
        /// </summary>
        [DataMember(Name = "repetitions", Order = 411)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<double?, IQuantitativeValue> Repetitions { get; set; }

        /// <summary>
        /// How often one should break from the activity.
        /// </summary>
        [DataMember(Name = "restPeriods", Order = 412)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IQuantitativeValue, string> RestPeriods { get; set; }

        /// <summary>
        /// Quantitative measure of the physiologic output of the exercise; also referred to as energy expenditure.
        /// </summary>
        [DataMember(Name = "workload", Order = 413)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, IQuantitativeValue> Workload { get; set; }

        /// <inheritdoc/>
        public bool Equals(ExercisePlan other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Type == other.Type &&
                this.ActivityDuration == other.ActivityDuration &&
                this.ActivityFrequency == other.ActivityFrequency &&
                this.AdditionalVariable == other.AdditionalVariable &&
                this.ExerciseType == other.ExerciseType &&
                this.Intensity == other.Intensity &&
                this.Repetitions == other.Repetitions &&
                this.RestPeriods == other.RestPeriods &&
                this.Workload == other.Workload &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as ExercisePlan);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.ActivityDuration)
            .And(this.ActivityFrequency)
            .And(this.AdditionalVariable)
            .And(this.ExerciseType)
            .And(this.Intensity)
            .And(this.Repetitions)
            .And(this.RestPeriods)
            .And(this.Workload)
            .And(base.GetHashCode());
    }
}
