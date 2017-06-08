namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A Role that represents a Web link e.g. as expressed via the 'url' property...
    /// </summary>
    [DataContract]
    public class LinkRole : Role
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "LinkRole";
    }
}
