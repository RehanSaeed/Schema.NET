namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of expressing a consistency of opinion with the object...
    /// </summary>
    [DataContract]
    public class AgreeAction : ReactAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "AgreeAction";
    }
}
