namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of intentionally disregarding the object. An agent ignores an object.
    /// </summary>
    public partial interface IIgnoreAction : IAssessAction
    {
    }

    /// <summary>
    /// The act of intentionally disregarding the object. An agent ignores an object.
    /// </summary>
    [DataContract]
    public partial class IgnoreAction : AssessAction, IIgnoreAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "IgnoreAction";
    }
}
