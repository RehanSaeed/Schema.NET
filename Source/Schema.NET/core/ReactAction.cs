namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of responding instinctively and emotionally to an object, expressing a sentiment.
    /// </summary>
    public partial interface IReactAction : IAssessAction
    {
    }

    /// <summary>
    /// The act of responding instinctively and emotionally to an object, expressing a sentiment.
    /// </summary>
    [DataContract]
    public partial class ReactAction : AssessAction, IReactAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ReactAction";
    }
}
