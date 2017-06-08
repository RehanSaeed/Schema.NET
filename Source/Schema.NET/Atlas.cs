namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A collection or bound volume of maps, charts, plates or tables, physical or in media form illustrating any subject.
    /// </summary>
    [DataContract]
    public class Atlas : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "Atlas";
    }
}
