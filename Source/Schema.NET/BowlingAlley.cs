namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A bowling alley.
    /// </summary>
    [DataContract]
    public class BowlingAlley : SportsActivityLocation
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "BowlingAlley";
    }
}
