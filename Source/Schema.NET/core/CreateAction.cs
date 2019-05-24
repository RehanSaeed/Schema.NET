namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of deliberately creating/producing/generating/building a result out of the agent.
    /// </summary>
    public partial interface ICreateAction : IAction
    {
    }

    /// <summary>
    /// The act of deliberately creating/producing/generating/building a result out of the agent.
    /// </summary>
    [DataContract]
    public partial class CreateAction : Action, ICreateAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "CreateAction";
    }
}
