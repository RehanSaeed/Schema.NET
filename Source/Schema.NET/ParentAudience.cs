namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A set of characteristics describing parents, who can be interested in viewing some content.
    /// </summary>
    [DataContract]
    public class ParentAudience : PeopleAudience
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "ParentAudience";

        /// <summary>
        /// Maximal age of the child.
        /// </summary>
        [DataMember(Name = "childMaxAge")]
        public decimal ChildMaxAge { get; set; }

        /// <summary>
        /// Minimal age of the child.
        /// </summary>
        [DataMember(Name = "childMinAge")]
        public decimal ChildMinAge { get; set; }
    }
}
