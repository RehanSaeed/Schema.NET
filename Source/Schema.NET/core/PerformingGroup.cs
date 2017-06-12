namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A performance group, such as a band, an orchestra, or a circus.
    /// </summary>
    [DataContract]
    public class PerformingGroup : Organization
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PerformingGroup";
    }
}
