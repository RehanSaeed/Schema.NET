namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Lists or enumerations—for example, a list of cuisines or music genres, etc.
    /// </summary>
    [DataContract]
    public class Enumeration : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "Enumeration";
    }
}
