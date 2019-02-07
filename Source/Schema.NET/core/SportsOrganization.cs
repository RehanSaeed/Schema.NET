namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents the collection of all sports organizations, including sports teams, governing bodies, and sports associations.
    /// </summary>
    [DataContract]
    public partial class SportsOrganization : Organization
    {
        public interface ISport : IValue {}
        public interface ISport<T> : ISport { new T Value { get; } }
        public class OneOrManySport : OneOrMany<ISport>
        {
            public OneOrManySport(ISport item) : base(item) { }
            public OneOrManySport(IEnumerable<ISport> items) : base(items) { }
            public static implicit operator OneOrManySport (string value) { return new OneOrManySport (new Sportstring (value)); }
            public static implicit operator OneOrManySport (string[] values) { return new OneOrManySport (values.Select(v => (ISport) new Sportstring (v))); }
            public static implicit operator OneOrManySport (List<string> values) { return new OneOrManySport (values.Select(v => (ISport) new Sportstring (v))); }
            public static implicit operator OneOrManySport (Uri value) { return new OneOrManySport (new SportUri (value)); }
            public static implicit operator OneOrManySport (Uri[] values) { return new OneOrManySport (values.Select(v => (ISport) new SportUri (v))); }
            public static implicit operator OneOrManySport (List<Uri> values) { return new OneOrManySport (values.Select(v => (ISport) new SportUri (v))); }
        }
        public struct Sportstring : ISport<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Sportstring (string value) { Value = value; }
            public static implicit operator Sportstring (string value) { return new Sportstring (value); }
        }
        public struct SportUri : ISport<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public SportUri (Uri value) { Value = value; }
            public static implicit operator SportUri (Uri value) { return new SportUri (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SportsOrganization";

        /// <summary>
        /// A type of sport (e.g. Baseball).
        /// </summary>
        [DataMember(Name = "sport", Order = 206)]
        public OneOrManySport Sport { get; set; }
    }
}
