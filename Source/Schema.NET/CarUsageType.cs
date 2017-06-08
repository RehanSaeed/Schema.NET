namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A value indicating a special usage of a car, e.g. commercial rental, driving school, or as a taxi.
    /// </summary>
    [DataContract]
    public class CarUsageType : QualitativeValue
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "CarUsageType";
    }
}
