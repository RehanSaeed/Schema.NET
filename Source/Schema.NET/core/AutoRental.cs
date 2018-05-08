namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A car rental business.
    /// </summary>
    public partial interface IAutoRental : IAutomotiveBusiness
    {
    }

    /// <summary>
    /// A car rental business.
    /// </summary>
    [DataContract]
    public partial class AutoRental : AutomotiveBusiness, IAutoRental
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AutoRental";
    }
}
