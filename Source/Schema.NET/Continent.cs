namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// One of the continents (for example, Europe or Africa).
    /// </summary>
    [DataContract]
    public class Continent : Landform
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "Continent";
    }
}
