using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// The act of expressing a preference from a set of options or a large or unbounded set of choices/options.
    /// </summary>
    [DataContract]
    public partial class ChooseAction : AssessAction
    {
        public interface IActionOption : IWrapper { }
        public interface IActionOption<T> : IActionOption { new T Data { get; set; } }
        public class ActionOptionstring : IActionOption<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public ActionOptionstring () { }
            public ActionOptionstring (string data) { Data = data; }
            public static implicit operator ActionOptionstring (string data) { return new ActionOptionstring (data); }
        }

        public class ActionOptionThing : IActionOption<Thing>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Thing) value; } }
            public virtual Thing Data { get; set; }
            public ActionOptionThing () { }
            public ActionOptionThing (Thing data) { Data = data; }
            public static implicit operator ActionOptionThing (Thing data) { return new ActionOptionThing (data); }
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
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IActionOption>? ActionOption { get; set; } //string, Thing
    }
}
