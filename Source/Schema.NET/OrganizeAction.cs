namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of manipulating/administering/supervising/controlling one or more objects.
    /// </summary>
    [DataContract]
    public class OrganizeAction : Action
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "OrganizeAction";
    }
}
