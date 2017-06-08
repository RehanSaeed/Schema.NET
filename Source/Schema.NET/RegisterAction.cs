namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of registering to be a user of a service, product or web page...
    /// </summary>
    [DataContract]
    public class RegisterAction : InteractAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "RegisterAction";
    }
}
