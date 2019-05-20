namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of consuming dynamic/moving visual content.
    /// </summary>
    public partial interface IWatchAction : IConsumeAction
    {
    }

    /// <summary>
    /// The act of consuming dynamic/moving visual content.
    /// </summary>
    [DataContract]
    public partial class WatchAction : ConsumeAction, IWatchAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "WatchAction";
    }
}
