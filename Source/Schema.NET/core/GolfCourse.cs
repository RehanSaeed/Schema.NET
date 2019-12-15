namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A golf course.
    /// </summary>
    public partial interface IGolfCourse : ISportsActivityLocation
    {
    }

    /// <summary>
    /// A golf course.
    /// </summary>
    [DataContract]
    public partial class GolfCourse : SportsActivityLocation, IGolfCourse, IEquatable<GolfCourse>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "GolfCourse";
    }
}
