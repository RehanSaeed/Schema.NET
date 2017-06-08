namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of stopping or deactivating a device or application (e...
    /// </summary>
    [DataContract]
    public class DeactivateAction : ControlAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "DeactivateAction";
    }
}
