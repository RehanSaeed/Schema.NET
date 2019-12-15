namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An car dealership.
    /// </summary>
    public partial interface IAutoDealer : IAutomotiveBusiness
    {
    }

    /// <summary>
    /// An car dealership.
    /// </summary>
    [DataContract]
    public partial class AutoDealer : AutomotiveBusiness, IAutoDealer, IEquatable<AutoDealer>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AutoDealer";
    }
}
