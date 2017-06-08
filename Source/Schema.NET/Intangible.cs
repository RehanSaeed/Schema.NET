namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A utility class that serves as the umbrella for a number of 'intangible' things such as quantities, structured values, etc.
    /// </summary>
    [DataContract]
    public class Intangible : Thing
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "Intangible";
    }
}
