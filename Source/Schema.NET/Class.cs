namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A class, also often called a 'Type'; equivalent to rdfs:Class.
    /// </summary>
    [DataContract]
    public class Class : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Class";
    }
}
