namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A set of characteristics describing parents, who can be interested in viewing some content.
    /// </summary>
    public partial interface IParentAudience : IPeopleAudience
    {
        /// <summary>
        /// Maximal age of the child.
        /// </summary>
        OneOrMany<int?> ChildMaxAge { get; set; }

        /// <summary>
        /// Minimal age of the child.
        /// </summary>
        OneOrMany<int?> ChildMinAge { get; set; }
    }

    /// <summary>
    /// A set of characteristics describing parents, who can be interested in viewing some content.
    /// </summary>
    [DataContract]
    public partial class ParentAudience : PeopleAudience, IParentAudience
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ParentAudience";

        /// <summary>
        /// Maximal age of the child.
        /// </summary>
        [DataMember(Name = "childMaxAge", Order = 406)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<int?> ChildMaxAge { get; set; }

        /// <summary>
        /// Minimal age of the child.
        /// </summary>
        [DataMember(Name = "childMinAge", Order = 407)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<int?> ChildMinAge { get; set; }
    }
}
