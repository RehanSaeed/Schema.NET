namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of participating in exertive activity for the purposes of improving health and fitness.
    /// </summary>
    [DataContract]
    public partial class ExerciseAction : PlayAction
    {
        public interface IDiet : IValue {}
        public interface IDiet<T> : IDiet { new T Value { get; } }
        public class OneOrManyDiet : OneOrMany<IDiet>
        {
            public OneOrManyDiet(IDiet item) : base(item) { }
            public OneOrManyDiet(IEnumerable<IDiet> items) : base(items) { }
            public static implicit operator OneOrManyDiet (Diet value) { return new OneOrManyDiet (new DietDiet (value)); }
            public static implicit operator OneOrManyDiet (Diet[] values) { return new OneOrManyDiet (values.Select(v => (IDiet) new DietDiet (v))); }
            public static implicit operator OneOrManyDiet (List<Diet> values) { return new OneOrManyDiet (values.Select(v => (IDiet) new DietDiet (v))); }
        }
        public struct DietDiet : IDiet<Diet>
        {
            object IValue.Value => this.Value;
            public Diet Value { get; }
            public DietDiet (Diet value) { Value = value; }
            public static implicit operator DietDiet (Diet value) { return new DietDiet (value); }
        }

        public interface IDistance : IValue {}
        public interface IDistance<T> : IDistance { new T Value { get; } }
        public class OneOrManyDistance : OneOrMany<IDistance>
        {
            public OneOrManyDistance(IDistance item) : base(item) { }
            public OneOrManyDistance(IEnumerable<IDistance> items) : base(items) { }
            public static implicit operator OneOrManyDistance (string value) { return new OneOrManyDistance (new Distancestring (value)); }
            public static implicit operator OneOrManyDistance (string[] values) { return new OneOrManyDistance (values.Select(v => (IDistance) new Distancestring (v))); }
            public static implicit operator OneOrManyDistance (List<string> values) { return new OneOrManyDistance (values.Select(v => (IDistance) new Distancestring (v))); }
        }
        public struct Distancestring : IDistance<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Distancestring (string value) { Value = value; }
            public static implicit operator Distancestring (string value) { return new Distancestring (value); }
        }

        public interface IExerciseCourse : IValue {}
        public interface IExerciseCourse<T> : IExerciseCourse { new T Value { get; } }
        public class OneOrManyExerciseCourse : OneOrMany<IExerciseCourse>
        {
            public OneOrManyExerciseCourse(IExerciseCourse item) : base(item) { }
            public OneOrManyExerciseCourse(IEnumerable<IExerciseCourse> items) : base(items) { }
            public static implicit operator OneOrManyExerciseCourse (Place value) { return new OneOrManyExerciseCourse (new ExerciseCoursePlace (value)); }
            public static implicit operator OneOrManyExerciseCourse (Place[] values) { return new OneOrManyExerciseCourse (values.Select(v => (IExerciseCourse) new ExerciseCoursePlace (v))); }
            public static implicit operator OneOrManyExerciseCourse (List<Place> values) { return new OneOrManyExerciseCourse (values.Select(v => (IExerciseCourse) new ExerciseCoursePlace (v))); }
        }
        public struct ExerciseCoursePlace : IExerciseCourse<Place>
        {
            object IValue.Value => this.Value;
            public Place Value { get; }
            public ExerciseCoursePlace (Place value) { Value = value; }
            public static implicit operator ExerciseCoursePlace (Place value) { return new ExerciseCoursePlace (value); }
        }

        public interface IExercisePlan : IValue {}
        public interface IExercisePlan<T> : IExercisePlan { new T Value { get; } }
        public class OneOrManyExercisePlan : OneOrMany<IExercisePlan>
        {
            public OneOrManyExercisePlan(IExercisePlan item) : base(item) { }
            public OneOrManyExercisePlan(IEnumerable<IExercisePlan> items) : base(items) { }
            public static implicit operator OneOrManyExercisePlan (ExercisePlan value) { return new OneOrManyExercisePlan (new ExercisePlanExercisePlan (value)); }
            public static implicit operator OneOrManyExercisePlan (ExercisePlan[] values) { return new OneOrManyExercisePlan (values.Select(v => (IExercisePlan) new ExercisePlanExercisePlan (v))); }
            public static implicit operator OneOrManyExercisePlan (List<ExercisePlan> values) { return new OneOrManyExercisePlan (values.Select(v => (IExercisePlan) new ExercisePlanExercisePlan (v))); }
        }
        public struct ExercisePlanExercisePlan : IExercisePlan<ExercisePlan>
        {
            object IValue.Value => this.Value;
            public ExercisePlan Value { get; }
            public ExercisePlanExercisePlan (ExercisePlan value) { Value = value; }
            public static implicit operator ExercisePlanExercisePlan (ExercisePlan value) { return new ExercisePlanExercisePlan (value); }
        }

        public interface IExerciseRelatedDiet : IValue {}
        public interface IExerciseRelatedDiet<T> : IExerciseRelatedDiet { new T Value { get; } }
        public class OneOrManyExerciseRelatedDiet : OneOrMany<IExerciseRelatedDiet>
        {
            public OneOrManyExerciseRelatedDiet(IExerciseRelatedDiet item) : base(item) { }
            public OneOrManyExerciseRelatedDiet(IEnumerable<IExerciseRelatedDiet> items) : base(items) { }
            public static implicit operator OneOrManyExerciseRelatedDiet (Diet value) { return new OneOrManyExerciseRelatedDiet (new ExerciseRelatedDietDiet (value)); }
            public static implicit operator OneOrManyExerciseRelatedDiet (Diet[] values) { return new OneOrManyExerciseRelatedDiet (values.Select(v => (IExerciseRelatedDiet) new ExerciseRelatedDietDiet (v))); }
            public static implicit operator OneOrManyExerciseRelatedDiet (List<Diet> values) { return new OneOrManyExerciseRelatedDiet (values.Select(v => (IExerciseRelatedDiet) new ExerciseRelatedDietDiet (v))); }
        }
        public struct ExerciseRelatedDietDiet : IExerciseRelatedDiet<Diet>
        {
            object IValue.Value => this.Value;
            public Diet Value { get; }
            public ExerciseRelatedDietDiet (Diet value) { Value = value; }
            public static implicit operator ExerciseRelatedDietDiet (Diet value) { return new ExerciseRelatedDietDiet (value); }
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

        public interface IFromLocation : IValue {}
        public interface IFromLocation<T> : IFromLocation { new T Value { get; } }
        public class OneOrManyFromLocation : OneOrMany<IFromLocation>
        {
            public OneOrManyFromLocation(IFromLocation item) : base(item) { }
            public OneOrManyFromLocation(IEnumerable<IFromLocation> items) : base(items) { }
            public static implicit operator OneOrManyFromLocation (Place value) { return new OneOrManyFromLocation (new FromLocationPlace (value)); }
            public static implicit operator OneOrManyFromLocation (Place[] values) { return new OneOrManyFromLocation (values.Select(v => (IFromLocation) new FromLocationPlace (v))); }
            public static implicit operator OneOrManyFromLocation (List<Place> values) { return new OneOrManyFromLocation (values.Select(v => (IFromLocation) new FromLocationPlace (v))); }
        }
        public struct FromLocationPlace : IFromLocation<Place>
        {
            object IValue.Value => this.Value;
            public Place Value { get; }
            public FromLocationPlace (Place value) { Value = value; }
            public static implicit operator FromLocationPlace (Place value) { return new FromLocationPlace (value); }
        }

        public interface IOpponent : IValue {}
        public interface IOpponent<T> : IOpponent { new T Value { get; } }
        public class OneOrManyOpponent : OneOrMany<IOpponent>
        {
            public OneOrManyOpponent(IOpponent item) : base(item) { }
            public OneOrManyOpponent(IEnumerable<IOpponent> items) : base(items) { }
            public static implicit operator OneOrManyOpponent (Person value) { return new OneOrManyOpponent (new OpponentPerson (value)); }
            public static implicit operator OneOrManyOpponent (Person[] values) { return new OneOrManyOpponent (values.Select(v => (IOpponent) new OpponentPerson (v))); }
            public static implicit operator OneOrManyOpponent (List<Person> values) { return new OneOrManyOpponent (values.Select(v => (IOpponent) new OpponentPerson (v))); }
        }
        public struct OpponentPerson : IOpponent<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public OpponentPerson (Person value) { Value = value; }
            public static implicit operator OpponentPerson (Person value) { return new OpponentPerson (value); }
        }

        public interface ISportsActivityLocation : IValue {}
        public interface ISportsActivityLocation<T> : ISportsActivityLocation { new T Value { get; } }
        public class OneOrManySportsActivityLocation : OneOrMany<ISportsActivityLocation>
        {
            public OneOrManySportsActivityLocation(ISportsActivityLocation item) : base(item) { }
            public OneOrManySportsActivityLocation(IEnumerable<ISportsActivityLocation> items) : base(items) { }
            public static implicit operator OneOrManySportsActivityLocation (SportsActivityLocation value) { return new OneOrManySportsActivityLocation (new SportsActivityLocationSportsActivityLocation (value)); }
            public static implicit operator OneOrManySportsActivityLocation (SportsActivityLocation[] values) { return new OneOrManySportsActivityLocation (values.Select(v => (ISportsActivityLocation) new SportsActivityLocationSportsActivityLocation (v))); }
            public static implicit operator OneOrManySportsActivityLocation (List<SportsActivityLocation> values) { return new OneOrManySportsActivityLocation (values.Select(v => (ISportsActivityLocation) new SportsActivityLocationSportsActivityLocation (v))); }
        }
        public struct SportsActivityLocationSportsActivityLocation : ISportsActivityLocation<SportsActivityLocation>
        {
            object IValue.Value => this.Value;
            public SportsActivityLocation Value { get; }
            public SportsActivityLocationSportsActivityLocation (SportsActivityLocation value) { Value = value; }
            public static implicit operator SportsActivityLocationSportsActivityLocation (SportsActivityLocation value) { return new SportsActivityLocationSportsActivityLocation (value); }
        }

        public interface ISportsEvent : IValue {}
        public interface ISportsEvent<T> : ISportsEvent { new T Value { get; } }
        public class OneOrManySportsEvent : OneOrMany<ISportsEvent>
        {
            public OneOrManySportsEvent(ISportsEvent item) : base(item) { }
            public OneOrManySportsEvent(IEnumerable<ISportsEvent> items) : base(items) { }
            public static implicit operator OneOrManySportsEvent (SportsEvent value) { return new OneOrManySportsEvent (new SportsEventSportsEvent (value)); }
            public static implicit operator OneOrManySportsEvent (SportsEvent[] values) { return new OneOrManySportsEvent (values.Select(v => (ISportsEvent) new SportsEventSportsEvent (v))); }
            public static implicit operator OneOrManySportsEvent (List<SportsEvent> values) { return new OneOrManySportsEvent (values.Select(v => (ISportsEvent) new SportsEventSportsEvent (v))); }
        }
        public struct SportsEventSportsEvent : ISportsEvent<SportsEvent>
        {
            object IValue.Value => this.Value;
            public SportsEvent Value { get; }
            public SportsEventSportsEvent (SportsEvent value) { Value = value; }
            public static implicit operator SportsEventSportsEvent (SportsEvent value) { return new SportsEventSportsEvent (value); }
        }

        public interface ISportsTeam : IValue {}
        public interface ISportsTeam<T> : ISportsTeam { new T Value { get; } }
        public class OneOrManySportsTeam : OneOrMany<ISportsTeam>
        {
            public OneOrManySportsTeam(ISportsTeam item) : base(item) { }
            public OneOrManySportsTeam(IEnumerable<ISportsTeam> items) : base(items) { }
            public static implicit operator OneOrManySportsTeam (SportsTeam value) { return new OneOrManySportsTeam (new SportsTeamSportsTeam (value)); }
            public static implicit operator OneOrManySportsTeam (SportsTeam[] values) { return new OneOrManySportsTeam (values.Select(v => (ISportsTeam) new SportsTeamSportsTeam (v))); }
            public static implicit operator OneOrManySportsTeam (List<SportsTeam> values) { return new OneOrManySportsTeam (values.Select(v => (ISportsTeam) new SportsTeamSportsTeam (v))); }
        }
        public struct SportsTeamSportsTeam : ISportsTeam<SportsTeam>
        {
            object IValue.Value => this.Value;
            public SportsTeam Value { get; }
            public SportsTeamSportsTeam (SportsTeam value) { Value = value; }
            public static implicit operator SportsTeamSportsTeam (SportsTeam value) { return new SportsTeamSportsTeam (value); }
        }

        public interface IToLocation : IValue {}
        public interface IToLocation<T> : IToLocation { new T Value { get; } }
        public class OneOrManyToLocation : OneOrMany<IToLocation>
        {
            public OneOrManyToLocation(IToLocation item) : base(item) { }
            public OneOrManyToLocation(IEnumerable<IToLocation> items) : base(items) { }
            public static implicit operator OneOrManyToLocation (Place value) { return new OneOrManyToLocation (new ToLocationPlace (value)); }
            public static implicit operator OneOrManyToLocation (Place[] values) { return new OneOrManyToLocation (values.Select(v => (IToLocation) new ToLocationPlace (v))); }
            public static implicit operator OneOrManyToLocation (List<Place> values) { return new OneOrManyToLocation (values.Select(v => (IToLocation) new ToLocationPlace (v))); }
        }
        public struct ToLocationPlace : IToLocation<Place>
        {
            object IValue.Value => this.Value;
            public Place Value { get; }
            public ToLocationPlace (Place value) { Value = value; }
            public static implicit operator ToLocationPlace (Place value) { return new ToLocationPlace (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ExerciseAction";

        /// <summary>
        /// A sub property of instrument. The diet used in this action.
        /// </summary>
        [DataMember(Name = "diet", Order = 306)]
        public OneOrManyDiet Diet { get; set; }

        /// <summary>
        /// The distance travelled, e.g. exercising or travelling.
        /// </summary>
        [DataMember(Name = "distance", Order = 307)]
        public OneOrManyDistance Distance { get; set; }

        /// <summary>
        /// A sub property of location. The course where this action was taken.
        /// </summary>
        [DataMember(Name = "exerciseCourse", Order = 308)]
        public OneOrManyExerciseCourse ExerciseCourse { get; set; }

        /// <summary>
        /// A sub property of instrument. The exercise plan used on this action.
        /// </summary>
        [DataMember(Name = "exercisePlan", Order = 309)]
        public OneOrManyExercisePlan ExercisePlan { get; set; }

        /// <summary>
        /// A sub property of instrument. The diet used in this action.
        /// </summary>
        [DataMember(Name = "exerciseRelatedDiet", Order = 310)]
        public OneOrManyExerciseRelatedDiet ExerciseRelatedDiet { get; set; }

        /// <summary>
        /// Type(s) of exercise or activity, such as strength training, flexibility training, aerobics, cardiac rehabilitation, etc.
        /// </summary>
        [DataMember(Name = "exerciseType", Order = 311)]
        public OneOrManyExerciseType ExerciseType { get; set; }

        /// <summary>
        /// A sub property of location. The original location of the object or the agent before the action.
        /// </summary>
        [DataMember(Name = "fromLocation", Order = 312)]
        public OneOrManyFromLocation FromLocation { get; set; }

        /// <summary>
        /// A sub property of participant. The opponent on this action.
        /// </summary>
        [DataMember(Name = "opponent", Order = 313)]
        public OneOrManyOpponent Opponent { get; set; }

        /// <summary>
        /// A sub property of location. The sports activity location where this action occurred.
        /// </summary>
        [DataMember(Name = "sportsActivityLocation", Order = 314)]
        public OneOrManySportsActivityLocation SportsActivityLocation { get; set; }

        /// <summary>
        /// A sub property of location. The sports event where this action occurred.
        /// </summary>
        [DataMember(Name = "sportsEvent", Order = 315)]
        public OneOrManySportsEvent SportsEvent { get; set; }

        /// <summary>
        /// A sub property of participant. The sports team that participated on this action.
        /// </summary>
        [DataMember(Name = "sportsTeam", Order = 316)]
        public OneOrManySportsTeam SportsTeam { get; set; }

        /// <summary>
        /// A sub property of location. The final location of the object or the agent after the action.
        /// </summary>
        [DataMember(Name = "toLocation", Order = 317)]
        public OneOrManyToLocation ToLocation { get; set; }
    }
}
