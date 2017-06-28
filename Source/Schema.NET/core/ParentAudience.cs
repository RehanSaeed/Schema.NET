namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A set of characteristics describing parents, who can be interested in viewing some content.
    /// </summary>
    [DataContract]
    public partial class ParentAudience : PeopleAudience
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ParentAudience";

        /// <summary>
        /// Maximal age of the child.
        /// </summary>
        [DataMember(Name = "childMaxAge", Order = 405)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<int?>? ChildMaxAge { get; set; }

        /// <summary>
        /// Minimal age of the child.
        /// </summary>
        [DataMember(Name = "childMinAge", Order = 406)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<int?>? ChildMinAge { get; set; }
    }
}
