namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of expressing a desire about the object. An agent wants an object.
    /// </summary>
    [DataContract]
    public class WantAction : ReactAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "WantAction";
    }
}
