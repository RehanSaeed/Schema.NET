namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A waterfall, like Niagara.
    /// </summary>
    [DataContract]
    public class Waterfall : BodyOfWater
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "Waterfall";
    }
}
