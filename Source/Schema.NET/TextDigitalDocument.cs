namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A file composed primarily of text.
    /// </summary>
    [DataContract]
    public class TextDigitalDocument : DigitalDocument
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "TextDigitalDocument";
    }
}
