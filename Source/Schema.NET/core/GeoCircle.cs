namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A GeoCircle is a GeoShape representing a circular geographic area. As it is a GeoShape
    ///           it provides the simple textual property 'circle', but also allows the combination of postalCode alongside geoRadius.
    ///           The center of the circle can be indicated via the 'geoMidpoint' property, or more approximately using 'address', 'postalCode'.
    /// </summary>
    [DataContract]
    public partial class GeoCircle : GeoShape
    {
        public interface IGeoMidpoint : IValue {}
        public interface IGeoMidpoint<T> : IGeoMidpoint { new T Value { get; } }
        public class OneOrManyGeoMidpoint : OneOrMany<IGeoMidpoint>
        {
            public OneOrManyGeoMidpoint(IGeoMidpoint item) : base(item) { }
            public OneOrManyGeoMidpoint(IEnumerable<IGeoMidpoint> items) : base(items) { }
            public static implicit operator OneOrManyGeoMidpoint (GeoCoordinates value) { return new OneOrManyGeoMidpoint (new GeoMidpointGeoCoordinates (value)); }
            public static implicit operator OneOrManyGeoMidpoint (GeoCoordinates[] values) { return new OneOrManyGeoMidpoint (values.Select(v => (IGeoMidpoint) new GeoMidpointGeoCoordinates (v))); }
            public static implicit operator OneOrManyGeoMidpoint (List<GeoCoordinates> values) { return new OneOrManyGeoMidpoint (values.Select(v => (IGeoMidpoint) new GeoMidpointGeoCoordinates (v))); }
        }
        public struct GeoMidpointGeoCoordinates : IGeoMidpoint<GeoCoordinates>
        {
            object IValue.Value => this.Value;
            public GeoCoordinates Value { get; }
            public GeoMidpointGeoCoordinates (GeoCoordinates value) { Value = value; }
            public static implicit operator GeoMidpointGeoCoordinates (GeoCoordinates value) { return new GeoMidpointGeoCoordinates (value); }
        }

        public interface IGeoRadius : IValue {}
        public interface IGeoRadius<T> : IGeoRadius { new T Value { get; } }
        public class OneOrManyGeoRadius : OneOrMany<IGeoRadius>
        {
            public OneOrManyGeoRadius(IGeoRadius item) : base(item) { }
            public OneOrManyGeoRadius(IEnumerable<IGeoRadius> items) : base(items) { }
            public static implicit operator OneOrManyGeoRadius (double value) { return new OneOrManyGeoRadius (new GeoRadiusdouble (value)); }
            public static implicit operator OneOrManyGeoRadius (double[] values) { return new OneOrManyGeoRadius (values.Select(v => (IGeoRadius) new GeoRadiusdouble (v))); }
            public static implicit operator OneOrManyGeoRadius (List<double> values) { return new OneOrManyGeoRadius (values.Select(v => (IGeoRadius) new GeoRadiusdouble (v))); }
            public static implicit operator OneOrManyGeoRadius (string value) { return new OneOrManyGeoRadius (new GeoRadiusstring (value)); }
            public static implicit operator OneOrManyGeoRadius (string[] values) { return new OneOrManyGeoRadius (values.Select(v => (IGeoRadius) new GeoRadiusstring (v))); }
            public static implicit operator OneOrManyGeoRadius (List<string> values) { return new OneOrManyGeoRadius (values.Select(v => (IGeoRadius) new GeoRadiusstring (v))); }
        }
        public struct GeoRadiusdouble : IGeoRadius<double>
        {
            object IValue.Value => this.Value;
            public double Value { get; }
            public GeoRadiusdouble (double value) { Value = value; }
            public static implicit operator GeoRadiusdouble (double value) { return new GeoRadiusdouble (value); }
        }
        public struct GeoRadiusstring : IGeoRadius<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public GeoRadiusstring (string value) { Value = value; }
            public static implicit operator GeoRadiusstring (string value) { return new GeoRadiusstring (value); }
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
        public OneOrManyGeoMidpoint GeoMidpoint { get; set; }

        /// <summary>
        /// Indicates the approximate radius of a GeoCircle (metres unless indicated otherwise via Distance notation).
        /// </summary>
        [DataMember(Name = "geoRadius", Order = 407)]
        public OneOrManyGeoRadius GeoRadius { get; set; }
    }
}
