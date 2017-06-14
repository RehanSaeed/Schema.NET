namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A QAPage is a WebPage focussed on a specific Question and its Answer(s), e...
    /// </summary>
    [DataContract]
    public partial class QAPage : WebPage
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "QAPage";
    }
}
