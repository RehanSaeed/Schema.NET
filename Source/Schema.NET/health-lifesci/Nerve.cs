namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A common pathway for the electrochemical nerve impulses that are transmitted along each of the axons.
    /// </summary>
    [DataContract]
    public class Nerve : AnatomicalStructure
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Nerve";
    }
}
