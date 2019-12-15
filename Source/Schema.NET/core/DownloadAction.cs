namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of downloading an object.
    /// </summary>
    public partial interface IDownloadAction : ITransferAction
    {
    }

    /// <summary>
    /// The act of downloading an object.
    /// </summary>
    [DataContract]
    public partial class DownloadAction : TransferAction, IDownloadAction, IEquatable<DownloadAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DownloadAction";
    }
}
