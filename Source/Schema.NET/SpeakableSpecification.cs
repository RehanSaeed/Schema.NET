namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A SpeakableSpecification indicates (typically via xpath or cssSelector) sections of a document that are highlighted as particularly speakable...
    /// </summary>
    [DataContract]
    public class SpeakableSpecification : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "SpeakableSpecification";
    }
}
