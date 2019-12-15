namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A ski resort.
    /// </summary>
    public partial interface ISkiResort : ISportsActivityLocation
    {
    }

    /// <summary>
    /// A ski resort.
    /// </summary>
    [DataContract]
    public partial class SkiResort : SportsActivityLocation, ISkiResort, IEquatable<SkiResort>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SkiResort";
    }
}
