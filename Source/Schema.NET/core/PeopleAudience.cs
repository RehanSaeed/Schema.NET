namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A set of characteristics belonging to people, e.g. who compose an item's target audience.
    /// </summary>
    [DataContract]
    public partial class PeopleAudience : Audience
    {
        public interface IHealthCondition : IValue {}
        public interface IHealthCondition<T> : IHealthCondition { new T Value { get; } }
        public class OneOrManyHealthCondition : OneOrMany<IHealthCondition>
        {
            public OneOrManyHealthCondition(IHealthCondition item) : base(item) { }
            public OneOrManyHealthCondition(IEnumerable<IHealthCondition> items) : base(items) { }
            public static implicit operator OneOrManyHealthCondition (MedicalCondition value) { return new OneOrManyHealthCondition (new HealthConditionMedicalCondition (value)); }
            public static implicit operator OneOrManyHealthCondition (MedicalCondition[] values) { return new OneOrManyHealthCondition (values.Select(v => (IHealthCondition) new HealthConditionMedicalCondition (v))); }
            public static implicit operator OneOrManyHealthCondition (List<MedicalCondition> values) { return new OneOrManyHealthCondition (values.Select(v => (IHealthCondition) new HealthConditionMedicalCondition (v))); }
        }
        public struct HealthConditionMedicalCondition : IHealthCondition<MedicalCondition>
        {
            object IValue.Value => this.Value;
            public MedicalCondition Value { get; }
            public HealthConditionMedicalCondition (MedicalCondition value) { Value = value; }
            public static implicit operator HealthConditionMedicalCondition (MedicalCondition value) { return new HealthConditionMedicalCondition (value); }
        }

        public interface IRequiredGender : IValue {}
        public interface IRequiredGender<T> : IRequiredGender { new T Value { get; } }
        public class OneOrManyRequiredGender : OneOrMany<IRequiredGender>
        {
            public OneOrManyRequiredGender(IRequiredGender item) : base(item) { }
            public OneOrManyRequiredGender(IEnumerable<IRequiredGender> items) : base(items) { }
            public static implicit operator OneOrManyRequiredGender (string value) { return new OneOrManyRequiredGender (new RequiredGenderstring (value)); }
            public static implicit operator OneOrManyRequiredGender (string[] values) { return new OneOrManyRequiredGender (values.Select(v => (IRequiredGender) new RequiredGenderstring (v))); }
            public static implicit operator OneOrManyRequiredGender (List<string> values) { return new OneOrManyRequiredGender (values.Select(v => (IRequiredGender) new RequiredGenderstring (v))); }
        }
        public struct RequiredGenderstring : IRequiredGender<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public RequiredGenderstring (string value) { Value = value; }
            public static implicit operator RequiredGenderstring (string value) { return new RequiredGenderstring (value); }
        }

        public interface IRequiredMaxAge : IValue {}
        public interface IRequiredMaxAge<T> : IRequiredMaxAge { new T Value { get; } }
        public class OneOrManyRequiredMaxAge : OneOrMany<IRequiredMaxAge>
        {
            public OneOrManyRequiredMaxAge(IRequiredMaxAge item) : base(item) { }
            public OneOrManyRequiredMaxAge(IEnumerable<IRequiredMaxAge> items) : base(items) { }
            public static implicit operator OneOrManyRequiredMaxAge (int value) { return new OneOrManyRequiredMaxAge (new RequiredMaxAgeint (value)); }
            public static implicit operator OneOrManyRequiredMaxAge (int[] values) { return new OneOrManyRequiredMaxAge (values.Select(v => (IRequiredMaxAge) new RequiredMaxAgeint (v))); }
            public static implicit operator OneOrManyRequiredMaxAge (List<int> values) { return new OneOrManyRequiredMaxAge (values.Select(v => (IRequiredMaxAge) new RequiredMaxAgeint (v))); }
        }
        public struct RequiredMaxAgeint : IRequiredMaxAge<int>
        {
            object IValue.Value => this.Value;
            public int Value { get; }
            public RequiredMaxAgeint (int value) { Value = value; }
            public static implicit operator RequiredMaxAgeint (int value) { return new RequiredMaxAgeint (value); }
        }

        public interface IRequiredMinAge : IValue {}
        public interface IRequiredMinAge<T> : IRequiredMinAge { new T Value { get; } }
        public class OneOrManyRequiredMinAge : OneOrMany<IRequiredMinAge>
        {
            public OneOrManyRequiredMinAge(IRequiredMinAge item) : base(item) { }
            public OneOrManyRequiredMinAge(IEnumerable<IRequiredMinAge> items) : base(items) { }
            public static implicit operator OneOrManyRequiredMinAge (int value) { return new OneOrManyRequiredMinAge (new RequiredMinAgeint (value)); }
            public static implicit operator OneOrManyRequiredMinAge (int[] values) { return new OneOrManyRequiredMinAge (values.Select(v => (IRequiredMinAge) new RequiredMinAgeint (v))); }
            public static implicit operator OneOrManyRequiredMinAge (List<int> values) { return new OneOrManyRequiredMinAge (values.Select(v => (IRequiredMinAge) new RequiredMinAgeint (v))); }
        }
        public struct RequiredMinAgeint : IRequiredMinAge<int>
        {
            object IValue.Value => this.Value;
            public int Value { get; }
            public RequiredMinAgeint (int value) { Value = value; }
            public static implicit operator RequiredMinAgeint (int value) { return new RequiredMinAgeint (value); }
        }

        public interface ISuggestedGender : IValue {}
        public interface ISuggestedGender<T> : ISuggestedGender { new T Value { get; } }
        public class OneOrManySuggestedGender : OneOrMany<ISuggestedGender>
        {
            public OneOrManySuggestedGender(ISuggestedGender item) : base(item) { }
            public OneOrManySuggestedGender(IEnumerable<ISuggestedGender> items) : base(items) { }
            public static implicit operator OneOrManySuggestedGender (string value) { return new OneOrManySuggestedGender (new SuggestedGenderstring (value)); }
            public static implicit operator OneOrManySuggestedGender (string[] values) { return new OneOrManySuggestedGender (values.Select(v => (ISuggestedGender) new SuggestedGenderstring (v))); }
            public static implicit operator OneOrManySuggestedGender (List<string> values) { return new OneOrManySuggestedGender (values.Select(v => (ISuggestedGender) new SuggestedGenderstring (v))); }
        }
        public struct SuggestedGenderstring : ISuggestedGender<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public SuggestedGenderstring (string value) { Value = value; }
            public static implicit operator SuggestedGenderstring (string value) { return new SuggestedGenderstring (value); }
        }

        public interface ISuggestedMaxAge : IValue {}
        public interface ISuggestedMaxAge<T> : ISuggestedMaxAge { new T Value { get; } }
        public class OneOrManySuggestedMaxAge : OneOrMany<ISuggestedMaxAge>
        {
            public OneOrManySuggestedMaxAge(ISuggestedMaxAge item) : base(item) { }
            public OneOrManySuggestedMaxAge(IEnumerable<ISuggestedMaxAge> items) : base(items) { }
            public static implicit operator OneOrManySuggestedMaxAge (int value) { return new OneOrManySuggestedMaxAge (new SuggestedMaxAgeint (value)); }
            public static implicit operator OneOrManySuggestedMaxAge (int[] values) { return new OneOrManySuggestedMaxAge (values.Select(v => (ISuggestedMaxAge) new SuggestedMaxAgeint (v))); }
            public static implicit operator OneOrManySuggestedMaxAge (List<int> values) { return new OneOrManySuggestedMaxAge (values.Select(v => (ISuggestedMaxAge) new SuggestedMaxAgeint (v))); }
        }
        public struct SuggestedMaxAgeint : ISuggestedMaxAge<int>
        {
            object IValue.Value => this.Value;
            public int Value { get; }
            public SuggestedMaxAgeint (int value) { Value = value; }
            public static implicit operator SuggestedMaxAgeint (int value) { return new SuggestedMaxAgeint (value); }
        }

        public interface ISuggestedMinAge : IValue {}
        public interface ISuggestedMinAge<T> : ISuggestedMinAge { new T Value { get; } }
        public class OneOrManySuggestedMinAge : OneOrMany<ISuggestedMinAge>
        {
            public OneOrManySuggestedMinAge(ISuggestedMinAge item) : base(item) { }
            public OneOrManySuggestedMinAge(IEnumerable<ISuggestedMinAge> items) : base(items) { }
            public static implicit operator OneOrManySuggestedMinAge (int value) { return new OneOrManySuggestedMinAge (new SuggestedMinAgeint (value)); }
            public static implicit operator OneOrManySuggestedMinAge (int[] values) { return new OneOrManySuggestedMinAge (values.Select(v => (ISuggestedMinAge) new SuggestedMinAgeint (v))); }
            public static implicit operator OneOrManySuggestedMinAge (List<int> values) { return new OneOrManySuggestedMinAge (values.Select(v => (ISuggestedMinAge) new SuggestedMinAgeint (v))); }
        }
        public struct SuggestedMinAgeint : ISuggestedMinAge<int>
        {
            object IValue.Value => this.Value;
            public int Value { get; }
            public SuggestedMinAgeint (int value) { Value = value; }
            public static implicit operator SuggestedMinAgeint (int value) { return new SuggestedMinAgeint (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PeopleAudience";

        /// <summary>
        /// Specifying the health condition(s) of a patient, medical study, or other target audience.
        /// </summary>
        [DataMember(Name = "healthCondition", Order = 306)]
        public OneOrManyHealthCondition HealthCondition { get; set; }

        /// <summary>
        /// Audiences defined by a person's gender.
        /// </summary>
        [DataMember(Name = "requiredGender", Order = 307)]
        public OneOrManyRequiredGender RequiredGender { get; set; }

        /// <summary>
        /// Audiences defined by a person's maximum age.
        /// </summary>
        [DataMember(Name = "requiredMaxAge", Order = 308)]
        public OneOrManyRequiredMaxAge RequiredMaxAge { get; set; }

        /// <summary>
        /// Audiences defined by a person's minimum age.
        /// </summary>
        [DataMember(Name = "requiredMinAge", Order = 309)]
        public OneOrManyRequiredMinAge RequiredMinAge { get; set; }

        /// <summary>
        /// The gender of the person or audience.
        /// </summary>
        [DataMember(Name = "suggestedGender", Order = 310)]
        public OneOrManySuggestedGender SuggestedGender { get; set; }

        /// <summary>
        /// Maximal age recommended for viewing content.
        /// </summary>
        [DataMember(Name = "suggestedMaxAge", Order = 311)]
        public OneOrManySuggestedMaxAge SuggestedMaxAge { get; set; }

        /// <summary>
        /// Minimal age recommended for viewing content.
        /// </summary>
        [DataMember(Name = "suggestedMinAge", Order = 312)]
        public OneOrManySuggestedMinAge SuggestedMinAge { get; set; }
    }
}
