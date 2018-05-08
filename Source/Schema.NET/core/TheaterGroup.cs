namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A theater group or company, for example, the Royal Shakespeare Company or Druid Theatre.
    /// </summary>
    public partial interface ITheaterGroup : IPerformingGroup
    {
    }

    /// <summary>
    /// A theater group or company, for example, the Royal Shakespeare Company or Druid Theatre.
    /// </summary>
    [DataContract]
    public partial class TheaterGroup : PerformingGroup, ITheaterGroup
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TheaterGroup";
    }
}
