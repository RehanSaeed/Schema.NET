namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// &lt;p&gt;A part of a successively published publication such as a periodical or multi-volume work, often numbered. It may represent a time span, such as a year.&lt;/p&gt;
    /// &lt;pre&gt;&lt;code&gt;  &amp;lt;br/&amp;gt;&amp;lt;br/&amp;gt;See also &amp;lt;a href="http://blog.schema.org/2014/09/schemaorg-support-for-bibliographic_2.html"&amp;gt;blog post&amp;lt;/a&amp;gt;.
    /// &lt;/code&gt;&lt;/pre&gt;
    /// </summary>
    [DataContract]
    public partial class PublicationVolume : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PublicationVolume";

        /// <summary>
        /// The page on which the work ends; for example "138" or "xvi".
        /// </summary>
        [DataMember(Name = "pageEnd", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<int?, string>? PageEnd { get; set; }

        /// <summary>
        /// The page on which the work starts; for example "135" or "xiii".
        /// </summary>
        [DataMember(Name = "pageStart", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<int?, string>? PageStart { get; set; }

        /// <summary>
        /// Any description of pages that is not separated into pageStart and pageEnd; for example, "1-6, 9, 55" or "10-12, 46-49".
        /// </summary>
        [DataMember(Name = "pagination", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Pagination { get; set; }

        /// <summary>
        /// Identifies the volume of publication or multi-part work; for example, "iii" or "2".
        /// </summary>
        [DataMember(Name = "volumeNumber", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<int?, string>? VolumeNumber { get; set; }
    }
}
