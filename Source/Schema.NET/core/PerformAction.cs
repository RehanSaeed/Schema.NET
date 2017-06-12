namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of participating in performance arts.
    /// </summary>
    [DataContract]
    public class PerformAction : PlayAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PerformAction";

        /// <summary>
        /// A sub property of location. The entertainment business where the action occurred.
        /// </summary>
        [DataMember(Name = "entertainmentBusiness", Order = 2)]
        public EntertainmentBusiness EntertainmentBusiness { get; set; }
    }
}
