namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An audiobook.
    /// </summary>
    public partial interface IAudiobook : IAudioObjectAndBook
    {
        /// <summary>
        /// A person who reads (performs) the audiobook.
        /// </summary>
        OneOrMany<IPerson>? ReadBy { get; set; }
    }

    /// <summary>
    /// An audiobook.
    /// </summary>
    [DataContract]
    public partial class Audiobook : AudioObjectAndBook, IAudiobook
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Audiobook";

        /// <summary>
        /// A person who reads (performs) the audiobook.
        /// </summary>
        [DataMember(Name = "readBy", Order = 406)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IPerson>? ReadBy { get; set; }
    }
}
