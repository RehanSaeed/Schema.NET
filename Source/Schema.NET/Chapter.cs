namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// One of the sections into which a book is divided. A chapter usually has a section number or a name.
    /// </summary>
    [DataContract]
    public class Chapter : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "Chapter";
    }
}
