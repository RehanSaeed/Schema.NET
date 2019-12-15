namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A sports location, such as a playing field.
    /// </summary>
    public partial interface ISportsActivityLocation : ILocalBusiness
    {
    }

    /// <summary>
    /// A sports location, such as a playing field.
    /// </summary>
    [DataContract]
    public partial class SportsActivityLocation : LocalBusiness, ISportsActivityLocation, IEquatable<SportsActivityLocation>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SportsActivityLocation";
    }
}
