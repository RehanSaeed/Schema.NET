namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A set of characteristics describing parents, who can be interested in viewing some content.
    /// </summary>
    [DataContract]
    public partial class ParentAudience : PeopleAudience
    {
        public interface IChildMaxAge : IValue {}
        public interface IChildMaxAge<T> : IChildMaxAge { new T Value { get; } }
        public class OneOrManyChildMaxAge : OneOrMany<IChildMaxAge>
        {
            public OneOrManyChildMaxAge(IChildMaxAge item) : base(item) { }
            public OneOrManyChildMaxAge(IEnumerable<IChildMaxAge> items) : base(items) { }
            public static implicit operator OneOrManyChildMaxAge (int value) { return new OneOrManyChildMaxAge (new ChildMaxAgeint (value)); }
            public static implicit operator OneOrManyChildMaxAge (int[] values) { return new OneOrManyChildMaxAge (values.Select(v => (IChildMaxAge) new ChildMaxAgeint (v))); }
            public static implicit operator OneOrManyChildMaxAge (List<int> values) { return new OneOrManyChildMaxAge (values.Select(v => (IChildMaxAge) new ChildMaxAgeint (v))); }
        }
        public struct ChildMaxAgeint : IChildMaxAge<int>
        {
            object IValue.Value => this.Value;
            public int Value { get; }
            public ChildMaxAgeint (int value) { Value = value; }
            public static implicit operator ChildMaxAgeint (int value) { return new ChildMaxAgeint (value); }
        }

        public interface IChildMinAge : IValue {}
        public interface IChildMinAge<T> : IChildMinAge { new T Value { get; } }
        public class OneOrManyChildMinAge : OneOrMany<IChildMinAge>
        {
            public OneOrManyChildMinAge(IChildMinAge item) : base(item) { }
            public OneOrManyChildMinAge(IEnumerable<IChildMinAge> items) : base(items) { }
            public static implicit operator OneOrManyChildMinAge (int value) { return new OneOrManyChildMinAge (new ChildMinAgeint (value)); }
            public static implicit operator OneOrManyChildMinAge (int[] values) { return new OneOrManyChildMinAge (values.Select(v => (IChildMinAge) new ChildMinAgeint (v))); }
            public static implicit operator OneOrManyChildMinAge (List<int> values) { return new OneOrManyChildMinAge (values.Select(v => (IChildMinAge) new ChildMinAgeint (v))); }
        }
        public struct ChildMinAgeint : IChildMinAge<int>
        {
            object IValue.Value => this.Value;
            public int Value { get; }
            public ChildMinAgeint (int value) { Value = value; }
            public static implicit operator ChildMinAgeint (int value) { return new ChildMinAgeint (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ParentAudience";

        /// <summary>
        /// Maximal age of the child.
        /// </summary>
        [DataMember(Name = "childMaxAge", Order = 406)]
        public OneOrManyChildMaxAge ChildMaxAge { get; set; }

        /// <summary>
        /// Minimal age of the child.
        /// </summary>
        [DataMember(Name = "childMinAge", Order = 407)]
        public OneOrManyChildMinAge ChildMinAge { get; set; }
    }
}
