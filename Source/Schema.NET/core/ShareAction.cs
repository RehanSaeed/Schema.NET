namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of distributing content to people for their amusement or edification.
    /// </summary>
    public partial interface IShareAction : ICommunicateAction
    {
    }

    /// <summary>
    /// The act of distributing content to people for their amusement or edification.
    /// </summary>
    [DataContract]
    public partial class ShareAction : CommunicateAction, IShareAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ShareAction";
    }
}
