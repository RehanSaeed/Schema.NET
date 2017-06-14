namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A body of water, such as a sea, ocean, or lake.
    /// </summary>
    [DataContract]
    public partial class BodyOfWater : Landform
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BodyOfWater";
    }
}
