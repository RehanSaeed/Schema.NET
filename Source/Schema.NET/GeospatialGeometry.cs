namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// (Eventually to be defined as) a supertype of GeoShape designed to accommodate definitions from Geo-Spatial best practices.
    /// </summary>
    [DataContract]
    public class GeospatialGeometry : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "GeospatialGeometry";
    }
}
