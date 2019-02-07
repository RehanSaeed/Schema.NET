namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// An EducationalAudience.
    /// </summary>
    [DataContract]
    public partial class EducationalAudience : Audience
    {
        public interface IEducationalRole : IValue {}
        public interface IEducationalRole<T> : IEducationalRole { new T Value { get; } }
        public class OneOrManyEducationalRole : OneOrMany<IEducationalRole>
        {
            public OneOrManyEducationalRole(IEducationalRole item) : base(item) { }
            public OneOrManyEducationalRole(IEnumerable<IEducationalRole> items) : base(items) { }
            public static implicit operator OneOrManyEducationalRole (string value) { return new OneOrManyEducationalRole (new EducationalRolestring (value)); }
            public static implicit operator OneOrManyEducationalRole (string[] values) { return new OneOrManyEducationalRole (values.Select(v => (IEducationalRole) new EducationalRolestring (v))); }
            public static implicit operator OneOrManyEducationalRole (List<string> values) { return new OneOrManyEducationalRole (values.Select(v => (IEducationalRole) new EducationalRolestring (v))); }
        }
        public struct EducationalRolestring : IEducationalRole<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public EducationalRolestring (string value) { Value = value; }
            public static implicit operator EducationalRolestring (string value) { return new EducationalRolestring (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "EducationalAudience";

        /// <summary>
        /// An educationalRole of an EducationalAudience.
        /// </summary>
        [DataMember(Name = "educationalRole", Order = 306)]
        public OneOrManyEducationalRole EducationalRole { get; set; }
    }
}
