namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A permit issued by a government agency.
    /// </summary>
    public partial interface IGovernmentPermit : IPermit
    {
    }

    /// <summary>
    /// A permit issued by a government agency.
    /// </summary>
    [DataContract]
    public partial class GovernmentPermit : Permit, IGovernmentPermit, IEquatable<GovernmentPermit>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "GovernmentPermit";
    }
}
