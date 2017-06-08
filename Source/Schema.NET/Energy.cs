namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Properties that take Energy as values are of the form '&amp;lt;Number&amp;gt; &amp;lt;Energy unit of measure&amp;gt;'.
    /// </summary>
    [DataContract]
    public class Energy : Quantity
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "Energy";
    }
}
