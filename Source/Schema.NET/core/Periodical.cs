namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A publication in any medium issued in successive parts bearing numerical or chronological designations and intended, such as a magazine, scholarly journal, or newspaper to continue indefinitely.&lt;br/&gt;&lt;br/&gt;
    /// See also &lt;a href="http://blog.schema.org/2014/09/schemaorg-support-for-bibliographic_2.html"&gt;blog post&lt;/a&gt;.
    /// </summary>
    [DataContract]
    public partial class Periodical : CreativeWorkSeries
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Periodical";
    }
}
