namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Car repair, sales, or parts.
    /// </summary>
    public partial interface IAutomotiveBusiness : ILocalBusiness
    {
    }

    /// <summary>
    /// Car repair, sales, or parts.
    /// </summary>
    [DataContract]
    public partial class AutomotiveBusiness : LocalBusiness, IAutomotiveBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AutomotiveBusiness";
    }
}
