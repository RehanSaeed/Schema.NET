namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A radio station.
    /// </summary>
    public partial interface IRadioStation : ILocalBusiness
    {
    }

    /// <summary>
    /// A radio station.
    /// </summary>
    [DataContract]
    public partial class RadioStation : LocalBusiness, IRadioStation
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "RadioStation";
    }
}
