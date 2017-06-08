namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A movie theater.
    /// </summary>
    [DataContract]
    public class MovieTheater : EntertainmentBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "MovieTheater";

        /// <summary>
        /// The number of screens in the movie theater.
        /// </summary>
        [DataMember(Name = "screenCount")]
        public decimal ScreenCount { get; set; }
    }
}
