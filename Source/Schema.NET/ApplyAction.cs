namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of registering to an organization/service without the guarantee to receive it...
    /// </summary>
    [DataContract]
    public class ApplyAction : OrganizeAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "ApplyAction";
    }
}
