namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of expressing a preference from a set of options or a large or unbounded set of choices/options.
    /// </summary>
    [DataContract]
    public partial class ChooseAction : AssessAction
    {
        public interface IActionOption : IValue {}
        public interface IActionOption<T> : IActionOption { new T Value { get; } }
        public class OneOrManyActionOption : OneOrMany<IActionOption>
        {
            public OneOrManyActionOption(IActionOption item) : base(item) { }
            public OneOrManyActionOption(IEnumerable<IActionOption> items) : base(items) { }
            public static implicit operator OneOrManyActionOption (string value) { return new OneOrManyActionOption (new ActionOptionstring (value)); }
            public static implicit operator OneOrManyActionOption (string[] values) { return new OneOrManyActionOption (values.Select(v => (IActionOption) new ActionOptionstring (v))); }
            public static implicit operator OneOrManyActionOption (List<string> values) { return new OneOrManyActionOption (values.Select(v => (IActionOption) new ActionOptionstring (v))); }
            public static implicit operator OneOrManyActionOption (Thing value) { return new OneOrManyActionOption (new ActionOptionThing (value)); }
            public static implicit operator OneOrManyActionOption (Thing[] values) { return new OneOrManyActionOption (values.Select(v => (IActionOption) new ActionOptionThing (v))); }
            public static implicit operator OneOrManyActionOption (List<Thing> values) { return new OneOrManyActionOption (values.Select(v => (IActionOption) new ActionOptionThing (v))); }
        }
        public struct ActionOptionstring : IActionOption<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public ActionOptionstring (string value) { Value = value; }
            public static implicit operator ActionOptionstring (string value) { return new ActionOptionstring (value); }
        }
        public struct ActionOptionThing : IActionOption<Thing>
        {
            object IValue.Value => this.Value;
            public Thing Value { get; }
            public ActionOptionThing (Thing value) { Value = value; }
            public static implicit operator ActionOptionThing (Thing value) { return new ActionOptionThing (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ChooseAction";

        /// <summary>
        /// A sub property of object. The options subject to this action.
        /// </summary>
        [DataMember(Name = "actionOption", Order = 306)]
        public OneOrManyActionOption ActionOption { get; set; }
    }
}
