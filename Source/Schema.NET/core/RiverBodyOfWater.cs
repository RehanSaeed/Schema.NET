namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A river (for example, the broad majestic Shannon).
    /// </summary>
    [DataContract]
    public partial class RiverBodyOfWater : BodyOfWater
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "RiverBodyOfWater";
    }
}
