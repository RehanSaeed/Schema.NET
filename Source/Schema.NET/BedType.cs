namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A type of bed. This is used for indicating the bed or beds available in an accommodation.
    /// </summary>
    [DataContract]
    public class BedType : QualitativeValue
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "BedType";
    }
}
