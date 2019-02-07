namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A thesis or dissertation document submitted in support of candidature for an academic degree or professional qualification.
    /// </summary>
    [DataContract]
    public partial class Thesis : CreativeWork
    {
        public interface IInSupportOf : IValue {}
        public interface IInSupportOf<T> : IInSupportOf { new T Value { get; } }
        public class OneOrManyInSupportOf : OneOrMany<IInSupportOf>
        {
            public OneOrManyInSupportOf(IInSupportOf item) : base(item) { }
            public OneOrManyInSupportOf(IEnumerable<IInSupportOf> items) : base(items) { }
            public static implicit operator OneOrManyInSupportOf (string value) { return new OneOrManyInSupportOf (new InSupportOfstring (value)); }
            public static implicit operator OneOrManyInSupportOf (string[] values) { return new OneOrManyInSupportOf (values.Select(v => (IInSupportOf) new InSupportOfstring (v))); }
            public static implicit operator OneOrManyInSupportOf (List<string> values) { return new OneOrManyInSupportOf (values.Select(v => (IInSupportOf) new InSupportOfstring (v))); }
        }
        public struct InSupportOfstring : IInSupportOf<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public InSupportOfstring (string value) { Value = value; }
            public static implicit operator InSupportOfstring (string value) { return new InSupportOfstring (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Thesis";

        /// <summary>
        /// Qualification, candidature, degree, application that Thesis supports.
        /// </summary>
        [DataMember(Name = "inSupportOf", Order = 206)]
        public OneOrManyInSupportOf InSupportOf { get; set; }
    }
}
