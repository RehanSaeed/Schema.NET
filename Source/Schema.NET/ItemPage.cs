namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A page devoted to a single item, such as a particular product or hotel.
    /// </summary>
    [DataContract]
    public class ItemPage : WebPage
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "ItemPage";
    }
}
