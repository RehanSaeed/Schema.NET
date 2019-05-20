namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of consuming written content.
    /// </summary>
    public partial interface IReadAction : IConsumeAction
    {
    }

    /// <summary>
    /// The act of consuming written content.
    /// </summary>
    [DataContract]
    public partial class ReadAction : ConsumeAction, IReadAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ReadAction";
    }
}
