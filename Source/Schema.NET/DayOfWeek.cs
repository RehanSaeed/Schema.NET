namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The day of the week, e.g. used to specify to which day the opening hours of an OpeningHoursSpecification refer...
    /// </summary>
    [DataContract]
    public class DayOfWeek : Enumeration
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "DayOfWeek";
    }
}
