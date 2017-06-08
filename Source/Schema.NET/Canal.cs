namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A canal, like the Panama Canal.
    /// </summary>
    [DataContract]
    public class Canal : BodyOfWater
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "Canal";
    }
}
