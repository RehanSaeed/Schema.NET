namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of allocating an action/event/task to some destination (someone or something).
    /// </summary>
    public partial interface IAssignAction : IAllocateAction
    {
    }

    /// <summary>
    /// The act of allocating an action/event/task to some destination (someone or something).
    /// </summary>
    [DataContract]
    public partial class AssignAction : AllocateAction, IAssignAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AssignAction";
    }
}
