namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A publication containing information about varied topics that are pertinent to general information, a geographic area, or a specific subject matter (i...
    /// </summary>
    [DataContract]
    public class Newspaper : Periodical
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "Newspaper";
    }
}
