namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A QAPage is a WebPage focussed on a specific Question and its Answer(s), e...
    /// </summary>
    [DataContract]
    public class QAPage : WebPage
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "QAPage";
    }
}
