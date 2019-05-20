namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A created collection of Creative Works or other artefacts.
    /// </summary>
    public partial interface ICollection : ICreativeWork
    {
        /// <summary>
        /// The number of items in the &lt;a class="localLink" href="http://schema.org/Collection"&gt;Collection&lt;/a&gt;.
        /// </summary>
        OneOrMany<int?>? CollectionSize { get; set; }
    }

    /// <summary>
    /// A created collection of Creative Works or other artefacts.
    /// </summary>
    [DataContract]
    public partial class Collection : CreativeWork, ICollection
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Collection";

        /// <summary>
        /// The number of items in the &lt;a class="localLink" href="http://schema.org/Collection"&gt;Collection&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "collectionSize", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<int?>? CollectionSize { get; set; }
    }
}
