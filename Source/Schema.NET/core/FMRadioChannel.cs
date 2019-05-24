namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A radio channel that uses FM.
    /// </summary>
    public partial interface IFMRadioChannel : IRadioChannel
    {
    }

    /// <summary>
    /// A radio channel that uses FM.
    /// </summary>
    [DataContract]
    public partial class FMRadioChannel : RadioChannel, IFMRadioChannel
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "FMRadioChannel";
    }
}
