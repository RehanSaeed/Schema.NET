namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// An application programming interface accessible over Web/Internet technologies.
    /// </summary>
    [DataContract]
    public class WebAPI : Service
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "WebAPI";
    }
}
