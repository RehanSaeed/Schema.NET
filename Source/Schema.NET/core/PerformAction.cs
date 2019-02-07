namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of participating in performance arts.
    /// </summary>
    [DataContract]
    public partial class PerformAction : PlayAction
    {
        public interface IEntertainmentBusiness : IValue {}
        public interface IEntertainmentBusiness<T> : IEntertainmentBusiness { new T Value { get; } }
        public class OneOrManyEntertainmentBusiness : OneOrMany<IEntertainmentBusiness>
        {
            public OneOrManyEntertainmentBusiness(IEntertainmentBusiness item) : base(item) { }
            public OneOrManyEntertainmentBusiness(IEnumerable<IEntertainmentBusiness> items) : base(items) { }
            public static implicit operator OneOrManyEntertainmentBusiness (EntertainmentBusiness value) { return new OneOrManyEntertainmentBusiness (new EntertainmentBusinessEntertainmentBusiness (value)); }
            public static implicit operator OneOrManyEntertainmentBusiness (EntertainmentBusiness[] values) { return new OneOrManyEntertainmentBusiness (values.Select(v => (IEntertainmentBusiness) new EntertainmentBusinessEntertainmentBusiness (v))); }
            public static implicit operator OneOrManyEntertainmentBusiness (List<EntertainmentBusiness> values) { return new OneOrManyEntertainmentBusiness (values.Select(v => (IEntertainmentBusiness) new EntertainmentBusinessEntertainmentBusiness (v))); }
        }
        public struct EntertainmentBusinessEntertainmentBusiness : IEntertainmentBusiness<EntertainmentBusiness>
        {
            object IValue.Value => this.Value;
            public EntertainmentBusiness Value { get; }
            public EntertainmentBusinessEntertainmentBusiness (EntertainmentBusiness value) { Value = value; }
            public static implicit operator EntertainmentBusinessEntertainmentBusiness (EntertainmentBusiness value) { return new EntertainmentBusinessEntertainmentBusiness (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PerformAction";

        /// <summary>
        /// A sub property of location. The entertainment business where the action occurred.
        /// </summary>
        [DataMember(Name = "entertainmentBusiness", Order = 306)]
        public OneOrManyEntertainmentBusiness EntertainmentBusiness { get; set; }
    }
}
