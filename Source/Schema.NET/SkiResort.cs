namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A ski resort.
    /// </summary>
    [DataContract]
    public class SkiResort : SportsActivityLocation
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "SkiResort";
    }
}
