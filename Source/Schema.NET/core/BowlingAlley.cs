namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A bowling alley.
    /// </summary>
    public partial interface IBowlingAlley : ISportsActivityLocation
    {
    }

    /// <summary>
    /// A bowling alley.
    /// </summary>
    [DataContract]
    public partial class BowlingAlley : SportsActivityLocation, IBowlingAlley
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BowlingAlley";
    }
}
