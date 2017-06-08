namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A file containing a note, primarily for the author.
    /// </summary>
    [DataContract]
    public class NoteDigitalDocument : DigitalDocument
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "NoteDigitalDocument";
    }
}
