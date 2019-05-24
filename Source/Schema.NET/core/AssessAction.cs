namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of forming one's opinion, reaction or sentiment.
    /// </summary>
    public partial interface IAssessAction : IAction
    {
    }

    /// <summary>
    /// The act of forming one's opinion, reaction or sentiment.
    /// </summary>
    [DataContract]
    public partial class AssessAction : Action, IAssessAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AssessAction";
    }
}
