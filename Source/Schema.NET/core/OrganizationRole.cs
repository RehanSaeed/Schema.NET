namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A subclass of Role used to describe roles within organizations.
    /// </summary>
    [DataContract]
    public partial class OrganizationRole : Role
    {
        public interface INumberedPosition : IValue {}
        public interface INumberedPosition<T> : INumberedPosition { new T Value { get; } }
        public class OneOrManyNumberedPosition : OneOrMany<INumberedPosition>
        {
            public OneOrManyNumberedPosition(INumberedPosition item) : base(item) { }
            public OneOrManyNumberedPosition(IEnumerable<INumberedPosition> items) : base(items) { }
            public static implicit operator OneOrManyNumberedPosition (double value) { return new OneOrManyNumberedPosition (new NumberedPositiondouble (value)); }
            public static implicit operator OneOrManyNumberedPosition (double[] values) { return new OneOrManyNumberedPosition (values.Select(v => (INumberedPosition) new NumberedPositiondouble (v))); }
            public static implicit operator OneOrManyNumberedPosition (List<double> values) { return new OneOrManyNumberedPosition (values.Select(v => (INumberedPosition) new NumberedPositiondouble (v))); }
        }
        public struct NumberedPositiondouble : INumberedPosition<double>
        {
            object IValue.Value => this.Value;
            public double Value { get; }
            public NumberedPositiondouble (double value) { Value = value; }
            public static implicit operator NumberedPositiondouble (double value) { return new NumberedPositiondouble (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "OrganizationRole";

        /// <summary>
        /// A number associated with a role in an organization, for example, the number on an athlete's jersey.
        /// </summary>
        [DataMember(Name = "numberedPosition", Order = 306)]
        public OneOrManyNumberedPosition NumberedPosition { get; set; }
    }
}
