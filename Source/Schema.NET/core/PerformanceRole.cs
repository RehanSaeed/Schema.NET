namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A PerformanceRole is a Role that some entity places with regard to a theatrical performance, e.g. in a Movie, TVSeries etc.
    /// </summary>
    [DataContract]
    public partial class PerformanceRole : Role
    {
        public interface ICharacterName : IValue {}
        public interface ICharacterName<T> : ICharacterName { new T Value { get; } }
        public class OneOrManyCharacterName : OneOrMany<ICharacterName>
        {
            public OneOrManyCharacterName(ICharacterName item) : base(item) { }
            public OneOrManyCharacterName(IEnumerable<ICharacterName> items) : base(items) { }
            public static implicit operator OneOrManyCharacterName (string value) { return new OneOrManyCharacterName (new CharacterNamestring (value)); }
            public static implicit operator OneOrManyCharacterName (string[] values) { return new OneOrManyCharacterName (values.Select(v => (ICharacterName) new CharacterNamestring (v))); }
            public static implicit operator OneOrManyCharacterName (List<string> values) { return new OneOrManyCharacterName (values.Select(v => (ICharacterName) new CharacterNamestring (v))); }
        }
        public struct CharacterNamestring : ICharacterName<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public CharacterNamestring (string value) { Value = value; }
            public static implicit operator CharacterNamestring (string value) { return new CharacterNamestring (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PerformanceRole";

        /// <summary>
        /// The name of a character played in some acting or performing role, i.e. in a PerformanceRole.
        /// </summary>
        [DataMember(Name = "characterName", Order = 306)]
        public OneOrManyCharacterName CharacterName { get; set; }
    }
}
