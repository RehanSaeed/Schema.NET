namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A business providing entertainment.
    /// </summary>
    public partial interface IEntertainmentBusiness : ILocalBusiness
    {
    }

    /// <summary>
    /// A business providing entertainment.
    /// </summary>
    [DataContract]
    public partial class EntertainmentBusiness : LocalBusiness, IEntertainmentBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "EntertainmentBusiness";
    }
}
