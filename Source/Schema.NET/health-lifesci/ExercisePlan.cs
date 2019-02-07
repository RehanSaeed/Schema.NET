namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// Fitness-related activity designed for a specific health-related purpose, including defined exercise routines as well as activity prescribed by a clinician.
    /// </summary>
    [DataContract]
    public partial class ExercisePlan : CreativeWorkAndPhysicalActivity
    {
        public interface IActivityDuration : IValue {}
        public interface IActivityDuration<T> : IActivityDuration { new T Value { get; } }
        public class OneOrManyActivityDuration : OneOrMany<IActivityDuration>
        {
            public OneOrManyActivityDuration(IActivityDuration item) : base(item) { }
            public OneOrManyActivityDuration(IEnumerable<IActivityDuration> items) : base(items) { }
            public static implicit operator OneOrManyActivityDuration (TimeSpan value) { return new OneOrManyActivityDuration (new ActivityDurationTimeSpan (value)); }
            public static implicit operator OneOrManyActivityDuration (TimeSpan[] values) { return new OneOrManyActivityDuration (values.Select(v => (IActivityDuration) new ActivityDurationTimeSpan (v))); }
            public static implicit operator OneOrManyActivityDuration (List<TimeSpan> values) { return new OneOrManyActivityDuration (values.Select(v => (IActivityDuration) new ActivityDurationTimeSpan (v))); }
        }
        public struct ActivityDurationTimeSpan : IActivityDuration<TimeSpan>
        {
            object IValue.Value => this.Value;
            public TimeSpan Value { get; }
            public ActivityDurationTimeSpan (TimeSpan value) { Value = value; }
            public static implicit operator ActivityDurationTimeSpan (TimeSpan value) { return new ActivityDurationTimeSpan (value); }
        }

        public interface IActivityFrequency : IValue {}
        public interface IActivityFrequency<T> : IActivityFrequency { new T Value { get; } }
        public class OneOrManyActivityFrequency : OneOrMany<IActivityFrequency>
        {
            public OneOrManyActivityFrequency(IActivityFrequency item) : base(item) { }
            public OneOrManyActivityFrequency(IEnumerable<IActivityFrequency> items) : base(items) { }
            public static implicit operator OneOrManyActivityFrequency (string value) { return new OneOrManyActivityFrequency (new ActivityFrequencystring (value)); }
            public static implicit operator OneOrManyActivityFrequency (string[] values) { return new OneOrManyActivityFrequency (values.Select(v => (IActivityFrequency) new ActivityFrequencystring (v))); }
            public static implicit operator OneOrManyActivityFrequency (List<string> values) { return new OneOrManyActivityFrequency (values.Select(v => (IActivityFrequency) new ActivityFrequencystring (v))); }
        }
        public struct ActivityFrequencystring : IActivityFrequency<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public ActivityFrequencystring (string value) { Value = value; }
            public static implicit operator ActivityFrequencystring (string value) { return new ActivityFrequencystring (value); }
        }

        public interface IAdditionalVariable : IValue {}
        public interface IAdditionalVariable<T> : IAdditionalVariable { new T Value { get; } }
        public class OneOrManyAdditionalVariable : OneOrMany<IAdditionalVariable>
        {
            public OneOrManyAdditionalVariable(IAdditionalVariable item) : base(item) { }
            public OneOrManyAdditionalVariable(IEnumerable<IAdditionalVariable> items) : base(items) { }
            public static implicit operator OneOrManyAdditionalVariable (string value) { return new OneOrManyAdditionalVariable (new AdditionalVariablestring (value)); }
            public static implicit operator OneOrManyAdditionalVariable (string[] values) { return new OneOrManyAdditionalVariable (values.Select(v => (IAdditionalVariable) new AdditionalVariablestring (v))); }
            public static implicit operator OneOrManyAdditionalVariable (List<string> values) { return new OneOrManyAdditionalVariable (values.Select(v => (IAdditionalVariable) new AdditionalVariablestring (v))); }
        }
        public struct AdditionalVariablestring : IAdditionalVariable<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public AdditionalVariablestring (string value) { Value = value; }
            public static implicit operator AdditionalVariablestring (string value) { return new AdditionalVariablestring (value); }
        }

        public interface IExerciseType : IValue {}
        public interface IExerciseType<T> : IExerciseType { new T Value { get; } }
        public class OneOrManyExerciseType : OneOrMany<IExerciseType>
        {
            public OneOrManyExerciseType(IExerciseType item) : base(item) { }
            public OneOrManyExerciseType(IEnumerable<IExerciseType> items) : base(items) { }
            public static implicit operator OneOrManyExerciseType (string value) { return new OneOrManyExerciseType (new ExerciseTypestring (value)); }
            public static implicit operator OneOrManyExerciseType (string[] values) { return new OneOrManyExerciseType (values.Select(v => (IExerciseType) new ExerciseTypestring (v))); }
            public static implicit operator OneOrManyExerciseType (List<string> values) { return new OneOrManyExerciseType (values.Select(v => (IExerciseType) new ExerciseTypestring (v))); }
        }
        public struct ExerciseTypestring : IExerciseType<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public ExerciseTypestring (string value) { Value = value; }
            public static implicit operator ExerciseTypestring (string value) { return new ExerciseTypestring (value); }
        }

        public interface IIntensity : IValue {}
        public interface IIntensity<T> : IIntensity { new T Value { get; } }
        public class OneOrManyIntensity : OneOrMany<IIntensity>
        {
            public OneOrManyIntensity(IIntensity item) : base(item) { }
            public OneOrManyIntensity(IEnumerable<IIntensity> items) : base(items) { }
            public static implicit operator OneOrManyIntensity (string value) { return new OneOrManyIntensity (new Intensitystring (value)); }
            public static implicit operator OneOrManyIntensity (string[] values) { return new OneOrManyIntensity (values.Select(v => (IIntensity) new Intensitystring (v))); }
            public static implicit operator OneOrManyIntensity (List<string> values) { return new OneOrManyIntensity (values.Select(v => (IIntensity) new Intensitystring (v))); }
        }
        public struct Intensitystring : IIntensity<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Intensitystring (string value) { Value = value; }
            public static implicit operator Intensitystring (string value) { return new Intensitystring (value); }
        }

        public interface IRepetitions : IValue {}
        public interface IRepetitions<T> : IRepetitions { new T Value { get; } }
        public class OneOrManyRepetitions : OneOrMany<IRepetitions>
        {
            public OneOrManyRepetitions(IRepetitions item) : base(item) { }
            public OneOrManyRepetitions(IEnumerable<IRepetitions> items) : base(items) { }
            public static implicit operator OneOrManyRepetitions (double value) { return new OneOrManyRepetitions (new Repetitionsdouble (value)); }
            public static implicit operator OneOrManyRepetitions (double[] values) { return new OneOrManyRepetitions (values.Select(v => (IRepetitions) new Repetitionsdouble (v))); }
            public static implicit operator OneOrManyRepetitions (List<double> values) { return new OneOrManyRepetitions (values.Select(v => (IRepetitions) new Repetitionsdouble (v))); }
        }
        public struct Repetitionsdouble : IRepetitions<double>
        {
            object IValue.Value => this.Value;
            public double Value { get; }
            public Repetitionsdouble (double value) { Value = value; }
            public static implicit operator Repetitionsdouble (double value) { return new Repetitionsdouble (value); }
        }

        public interface IRestPeriods : IValue {}
        public interface IRestPeriods<T> : IRestPeriods { new T Value { get; } }
        public class OneOrManyRestPeriods : OneOrMany<IRestPeriods>
        {
            public OneOrManyRestPeriods(IRestPeriods item) : base(item) { }
            public OneOrManyRestPeriods(IEnumerable<IRestPeriods> items) : base(items) { }
            public static implicit operator OneOrManyRestPeriods (string value) { return new OneOrManyRestPeriods (new RestPeriodsstring (value)); }
            public static implicit operator OneOrManyRestPeriods (string[] values) { return new OneOrManyRestPeriods (values.Select(v => (IRestPeriods) new RestPeriodsstring (v))); }
            public static implicit operator OneOrManyRestPeriods (List<string> values) { return new OneOrManyRestPeriods (values.Select(v => (IRestPeriods) new RestPeriodsstring (v))); }
        }
        public struct RestPeriodsstring : IRestPeriods<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public RestPeriodsstring (string value) { Value = value; }
            public static implicit operator RestPeriodsstring (string value) { return new RestPeriodsstring (value); }
        }

        public interface IWorkload : IValue {}
        public interface IWorkload<T> : IWorkload { new T Value { get; } }
        public class OneOrManyWorkload : OneOrMany<IWorkload>
        {
            public OneOrManyWorkload(IWorkload item) : base(item) { }
            public OneOrManyWorkload(IEnumerable<IWorkload> items) : base(items) { }
            public static implicit operator OneOrManyWorkload (string value) { return new OneOrManyWorkload (new Workloadstring (value)); }
            public static implicit operator OneOrManyWorkload (string[] values) { return new OneOrManyWorkload (values.Select(v => (IWorkload) new Workloadstring (v))); }
            public static implicit operator OneOrManyWorkload (List<string> values) { return new OneOrManyWorkload (values.Select(v => (IWorkload) new Workloadstring (v))); }
        }
        public struct Workloadstring : IWorkload<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Workloadstring (string value) { Value = value; }
            public static implicit operator Workloadstring (string value) { return new Workloadstring (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ExercisePlan";

        /// <summary>
        /// Length of time to engage in the activity.
        /// </summary>
        [DataMember(Name = "activityDuration", Order = 406)]
        public OneOrManyActivityDuration ActivityDuration { get; set; }

        /// <summary>
        /// How often one should engage in the activity.
        /// </summary>
        [DataMember(Name = "activityFrequency", Order = 407)]
        public OneOrManyActivityFrequency ActivityFrequency { get; set; }

        /// <summary>
        /// Any additional component of the exercise prescription that may need to be articulated to the patient. This may include the order of exercises, the number of repetitions of movement, quantitative distance, progressions over time, etc.
        /// </summary>
        [DataMember(Name = "additionalVariable", Order = 408)]
        public OneOrManyAdditionalVariable AdditionalVariable { get; set; }

        /// <summary>
        /// Type(s) of exercise or activity, such as strength training, flexibility training, aerobics, cardiac rehabilitation, etc.
        /// </summary>
        [DataMember(Name = "exerciseType", Order = 409)]
        public OneOrManyExerciseType ExerciseType { get; set; }

        /// <summary>
        /// Quantitative measure gauging the degree of force involved in the exercise, for example, heartbeats per minute. May include the velocity of the movement.
        /// </summary>
        [DataMember(Name = "intensity", Order = 410)]
        public OneOrManyIntensity Intensity { get; set; }

        /// <summary>
        /// Number of times one should repeat the activity.
        /// </summary>
        [DataMember(Name = "repetitions", Order = 411)]
        public OneOrManyRepetitions Repetitions { get; set; }

        /// <summary>
        /// How often one should break from the activity.
        /// </summary>
        [DataMember(Name = "restPeriods", Order = 412)]
        public OneOrManyRestPeriods RestPeriods { get; set; }

        /// <summary>
        /// Quantitative measure of the physiologic output of the exercise; also referred to as energy expenditure.
        /// </summary>
        [DataMember(Name = "workload", Order = 413)]
        public OneOrManyWorkload Workload { get; set; }
    }
}
