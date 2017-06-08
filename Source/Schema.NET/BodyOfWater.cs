namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A body of water, such as a sea, ocean, or lake.
    /// </summary>
    [DataContract]
    public class BodyOfWater : Landform
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "BodyOfWater";
    }
}
