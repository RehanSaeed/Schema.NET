namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of manipulating/administering/supervising/controlling one or more objects.
    /// </summary>
    public partial interface IOrganizeAction : IAction
    {
    }

    /// <summary>
    /// The act of manipulating/administering/supervising/controlling one or more objects.
    /// </summary>
    [DataContract]
    public partial class OrganizeAction : Action, IOrganizeAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "OrganizeAction";
    }
}
