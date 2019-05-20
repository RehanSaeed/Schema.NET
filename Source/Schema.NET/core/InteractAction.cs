namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of interacting with another person or organization.
    /// </summary>
    public partial interface IInteractAction : IAction
    {
    }

    /// <summary>
    /// The act of interacting with another person or organization.
    /// </summary>
    [DataContract]
    public partial class InteractAction : Action, IInteractAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "InteractAction";
    }
}
