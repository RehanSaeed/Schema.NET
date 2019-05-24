namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A car wash business.
    /// </summary>
    public partial interface IAutoWash : IAutomotiveBusiness
    {
    }

    /// <summary>
    /// A car wash business.
    /// </summary>
    [DataContract]
    public partial class AutoWash : AutomotiveBusiness, IAutoWash
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AutoWash";
    }
}
