namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A theater group or company, for example, the Royal Shakespeare Company or Druid Theatre.
    /// </summary>
    [DataContract]
    public class TheaterGroup : PerformingGroup
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "TheaterGroup";
    }
}
