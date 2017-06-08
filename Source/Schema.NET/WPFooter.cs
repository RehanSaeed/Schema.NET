namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The footer section of the page.
    /// </summary>
    [DataContract]
    public class WPFooter : WebPageElement
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "WPFooter";
    }
}
