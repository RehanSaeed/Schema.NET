using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// The act of intentionally disregarding the object. An agent ignores an object.
    /// </summary>
    [DataContract]
    public partial class IgnoreAction : AssessAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "IgnoreAction";
    }
}
