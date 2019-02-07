namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A technical article - Example: How-to (task) topics, step-by-step, procedural troubleshooting, specifications, etc.
    /// </summary>
    [DataContract]
    public partial class TechArticle : Article
    {
        public interface IDependencies : IValue {}
        public interface IDependencies<T> : IDependencies { new T Value { get; } }
        public class OneOrManyDependencies : OneOrMany<IDependencies>
        {
            public OneOrManyDependencies(IDependencies item) : base(item) { }
            public OneOrManyDependencies(IEnumerable<IDependencies> items) : base(items) { }
            public static implicit operator OneOrManyDependencies (string value) { return new OneOrManyDependencies (new Dependenciesstring (value)); }
            public static implicit operator OneOrManyDependencies (string[] values) { return new OneOrManyDependencies (values.Select(v => (IDependencies) new Dependenciesstring (v))); }
            public static implicit operator OneOrManyDependencies (List<string> values) { return new OneOrManyDependencies (values.Select(v => (IDependencies) new Dependenciesstring (v))); }
        }
        public struct Dependenciesstring : IDependencies<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Dependenciesstring (string value) { Value = value; }
            public static implicit operator Dependenciesstring (string value) { return new Dependenciesstring (value); }
        }

        public interface IProficiencyLevel : IValue {}
        public interface IProficiencyLevel<T> : IProficiencyLevel { new T Value { get; } }
        public class OneOrManyProficiencyLevel : OneOrMany<IProficiencyLevel>
        {
            public OneOrManyProficiencyLevel(IProficiencyLevel item) : base(item) { }
            public OneOrManyProficiencyLevel(IEnumerable<IProficiencyLevel> items) : base(items) { }
            public static implicit operator OneOrManyProficiencyLevel (string value) { return new OneOrManyProficiencyLevel (new ProficiencyLevelstring (value)); }
            public static implicit operator OneOrManyProficiencyLevel (string[] values) { return new OneOrManyProficiencyLevel (values.Select(v => (IProficiencyLevel) new ProficiencyLevelstring (v))); }
            public static implicit operator OneOrManyProficiencyLevel (List<string> values) { return new OneOrManyProficiencyLevel (values.Select(v => (IProficiencyLevel) new ProficiencyLevelstring (v))); }
        }
        public struct ProficiencyLevelstring : IProficiencyLevel<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public ProficiencyLevelstring (string value) { Value = value; }
            public static implicit operator ProficiencyLevelstring (string value) { return new ProficiencyLevelstring (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TechArticle";

        /// <summary>
        /// Prerequisites needed to fulfill steps in article.
        /// </summary>
        [DataMember(Name = "dependencies", Order = 306)]
        public OneOrManyDependencies Dependencies { get; set; }

        /// <summary>
        /// Proficiency needed for this content; expected values: 'Beginner', 'Expert'.
        /// </summary>
        [DataMember(Name = "proficiencyLevel", Order = 307)]
        public OneOrManyProficiencyLevel ProficiencyLevel { get; set; }
    }
}
