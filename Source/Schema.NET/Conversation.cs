namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// One or more messages between organizations or people on a particular topic...
    /// </summary>
    [DataContract]
    public class Conversation : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Conversation";
    }
}
