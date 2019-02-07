namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A movie theater.
    /// </summary>
    [DataContract]
    public partial class MovieTheater : CivicStructureAndEntertainmentBusiness
    {
        public interface IScreenCount : IValue {}
        public interface IScreenCount<T> : IScreenCount { new T Value { get; } }
        public class OneOrManyScreenCount : OneOrMany<IScreenCount>
        {
            public OneOrManyScreenCount(IScreenCount item) : base(item) { }
            public OneOrManyScreenCount(IEnumerable<IScreenCount> items) : base(items) { }
            public static implicit operator OneOrManyScreenCount (int value) { return new OneOrManyScreenCount (new ScreenCountint (value)); }
            public static implicit operator OneOrManyScreenCount (int[] values) { return new OneOrManyScreenCount (values.Select(v => (IScreenCount) new ScreenCountint (v))); }
            public static implicit operator OneOrManyScreenCount (List<int> values) { return new OneOrManyScreenCount (values.Select(v => (IScreenCount) new ScreenCountint (v))); }
        }
        public struct ScreenCountint : IScreenCount<int>
        {
            object IValue.Value => this.Value;
            public int Value { get; }
            public ScreenCountint (int value) { Value = value; }
            public static implicit operator ScreenCountint (int value) { return new ScreenCountint (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MovieTheater";

        /// <summary>
        /// The number of screens in the movie theater.
        /// </summary>
        [DataMember(Name = "screenCount", Order = 406)]
        public OneOrManyScreenCount ScreenCount { get; set; }
    }
}
