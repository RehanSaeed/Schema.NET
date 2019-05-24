namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of managing by changing/editing the state of the object.
    /// </summary>
    public partial interface IUpdateAction : IAction
    {
        /// <summary>
        /// A sub property of object. The collection target of the action.
        /// </summary>
        OneOrMany<IThing> TargetCollection { get; set; }
    }

    /// <summary>
    /// The act of managing by changing/editing the state of the object.
    /// </summary>
    [DataContract]
    public partial class UpdateAction : Action, IUpdateAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "UpdateAction";

        /// <summary>
        /// A sub property of object. The collection target of the action.
        /// </summary>
        [DataMember(Name = "targetCollection", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IThing> TargetCollection { get; set; }
    }
}
