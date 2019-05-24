namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A tennis complex.
    /// </summary>
    public partial interface ITennisComplex : ISportsActivityLocation
    {
    }

    /// <summary>
    /// A tennis complex.
    /// </summary>
    [DataContract]
    public partial class TennisComplex : SportsActivityLocation, ITennisComplex
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TennisComplex";
    }
}
