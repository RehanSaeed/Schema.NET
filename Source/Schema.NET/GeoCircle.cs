namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A GeoCircle is a GeoShape representing a circular geographic area...
    /// </summary>
    [DataContract]
    public class GeoCircle : GeoShape
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "GeoCircle";

        /// <summary>
        /// Indicates the approximate radius of a GeoCircle (metres unless indicated otherwise via Distance notation).
        /// </summary>
        [DataMember(Name = "geoRadius")]
        public object GeoRadius { get; protected set; }

        /// <summary>
        /// Indicates the approximate radius of a GeoCircle (metres unless indicated otherwise via Distance notation).
        /// </summary>
        [IgnoreDataMember]
        public Distance GeoRadiusDistance
        {
            get => this.GeoRadius as Distance;
            set => this.GeoRadius = value;
        }

        /// <summary>
        /// Indicates the approximate radius of a GeoCircle (metres unless indicated otherwise via Distance notation).
        /// </summary>
        [IgnoreDataMember]
        public decimal? GeoRadiusNumber
        {
            get => this.GeoRadius as decimal?;
            set => this.GeoRadius = value;
        }

        /// <summary>
        /// Indicates the approximate radius of a GeoCircle (metres unless indicated otherwise via Distance notation).
        /// </summary>
        [IgnoreDataMember]
        public string GeoRadiusText
        {
            get => this.GeoRadius as string;
            set => this.GeoRadius = value;
        }

        /// <summary>
        /// Indicates the GeoCoordinates at the centre of a GeoShape e.g. GeoCircle.
        /// </summary>
        [DataMember(Name = "geoMidpoint")]
        public GeoCoordinates GeoMidpoint { get; set; }
    }
}
