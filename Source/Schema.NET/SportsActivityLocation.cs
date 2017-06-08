namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A sports location, such as a playing field.
    /// </summary>
    [DataContract]
    public class SportsActivityLocation : LocalBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "SportsActivityLocation";
    }
}
