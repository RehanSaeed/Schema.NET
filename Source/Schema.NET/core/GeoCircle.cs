using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A GeoCircle is a GeoShape representing a circular geographic area. As it is a GeoShape
    ///           it provides the simple textual property 'circle', but also allows the combination of postalCode alongside geoRadius.
    ///           The center of the circle can be indicated via the 'geoMidpoint' property, or more approximately using 'address', 'postalCode'.
    /// </summary>
    [DataContract]
    public partial class GeoCircle : GeoShape
    {
        public interface IGeoRadius : IWrapper { }
        public interface IGeoRadius<T> : IGeoRadius { new T Data { get; set; } }
        public class GeoRadiusdouble : IGeoRadius<double>
        {
            object IWrapper.Data { get { return Data; } set { Data = (double) value; } }
            public virtual double Data { get; set; }
            public GeoRadiusdouble () { }
            public GeoRadiusdouble (double data) { Data = data; }
            public static implicit operator GeoRadiusdouble (double data) { return new GeoRadiusdouble (data); }
        }

        public class GeoRadiusstring : IGeoRadius<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public GeoRadiusstring () { }
            public GeoRadiusstring (string data) { Data = data; }
            public static implicit operator GeoRadiusstring (string data) { return new GeoRadiusstring (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "GeoCircle";

        /// <summary>
        /// Indicates the GeoCoordinates at the centre of a GeoShape e.g. GeoCircle.
        /// </summary>
        [DataMember(Name = "geoMidpoint", Order = 406)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<GeoCoordinates>? GeoMidpoint { get; set; } 

        /// <summary>
        /// Indicates the approximate radius of a GeoCircle (metres unless indicated otherwise via Distance notation).
        /// </summary>
        [DataMember(Name = "geoRadius", Order = 407)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IGeoRadius>? GeoRadius { get; set; } //double?, string
    }
}
