namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A Consortium is a membership Organization whose members are typically Organizations.
    /// </summary>
    [DataContract]
    public class Consortium : Organization
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "Consortium";
    }
}
