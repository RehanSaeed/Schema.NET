namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Car repair business.
    /// </summary>
    public partial interface IAutoRepair : IAutomotiveBusiness
    {
    }

    /// <summary>
    /// Car repair business.
    /// </summary>
    [DataContract]
    public partial class AutoRepair : AutomotiveBusiness, IAutoRepair
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AutoRepair";
    }
}
