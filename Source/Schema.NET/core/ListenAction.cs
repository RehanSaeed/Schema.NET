namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of consuming audio content.
    /// </summary>
    public partial interface IListenAction : IConsumeAction
    {
    }

    /// <summary>
    /// The act of consuming audio content.
    /// </summary>
    [DataContract]
    public partial class ListenAction : ConsumeAction, IListenAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ListenAction";
    }
}
