namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of committing to/adopting an object.
    /// Related actions:
    ///
    /// RejectAction: The antonym of AcceptAction.
    /// </summary>
    [DataContract]
    public partial class AcceptAction : AllocateAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AcceptAction";
    }
}
