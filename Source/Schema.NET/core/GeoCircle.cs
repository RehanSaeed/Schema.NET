namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A GeoCircle is a GeoShape representing a circular geographic area...
    /// </summary>
    [DataContract]
    public partial class GeoCircle : GeoShape
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "GeoCircle";

        /// <summary>
        /// Indicates the GeoCoordinates at the centre of a GeoShape e.g. GeoCircle.
        /// </summary>
        [DataMember(Name = "geoMidpoint", Order = 405)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<GeoCoordinates>? GeoMidpoint { get; set; }

        /// <summary>
        /// Indicates the approximate radius of a GeoCircle (metres unless indicated otherwise via Distance notation).
        /// </summary>
        [DataMember(Name = "geoRadius", Order = 406)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, double?>? GeoRadius { get; set; }
    }
}
