using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A sub-grouping of steps in the instructions for how to achieve a result (e.g. steps for making a pie crust within a pie recipe).
    /// </summary>
    [DataContract]
    public partial class HowToSection : ItemList
    {
        public interface ISteps : IWrapper { }
        public interface ISteps<T> : ISteps { new T Data { get; set; } }
        public class StepsCreativeWork : ISteps<CreativeWork>
        {
            object IWrapper.Data { get { return Data; } set { Data = (CreativeWork) value; } }
            public virtual CreativeWork Data { get; set; }
            public StepsCreativeWork () { }
            public StepsCreativeWork (CreativeWork data) { Data = data; }
            public static implicit operator StepsCreativeWork (CreativeWork data) { return new StepsCreativeWork (data); }
        }

        public class StepsItemList : ISteps<ItemList>
        {
            object IWrapper.Data { get { return Data; } set { Data = (ItemList) value; } }
            public virtual ItemList Data { get; set; }
            public StepsItemList () { }
            public StepsItemList (ItemList data) { Data = data; }
            public static implicit operator StepsItemList (ItemList data) { return new StepsItemList (data); }
        }

        public class Stepsstring : ISteps<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public Stepsstring () { }
            public Stepsstring (string data) { Data = data; }
            public static implicit operator Stepsstring (string data) { return new Stepsstring (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "HowToSection";

        /// <summary>
        /// The steps in the form of a single item (text, document, video, etc.) or an ordered list with HowToStep and/or HowToSection items.
        /// </summary>
        [DataMember(Name = "steps", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ISteps>? Steps { get; set; } //CreativeWork, ItemList, string
    }
}
