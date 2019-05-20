namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A recycling center.
    /// </summary>
    public partial interface IRecyclingCenter : ILocalBusiness
    {
    }

    /// <summary>
    /// A recycling center.
    /// </summary>
    [DataContract]
    public partial class RecyclingCenter : LocalBusiness, IRecyclingCenter
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "RecyclingCenter";
    }
}
