namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A camping site, campsite, or campground is a place used for overnight stay in the outdoors...
    /// </summary>
    [DataContract]
    public partial class Campground : LodgingBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Campground";
    }
}
