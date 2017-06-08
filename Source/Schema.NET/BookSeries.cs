namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A series of books. Included books can be indicated with the hasPart property.
    /// </summary>
    [DataContract]
    public class BookSeries : CreativeWorkSeries
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "BookSeries";
    }
}
