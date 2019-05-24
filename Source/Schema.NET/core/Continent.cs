namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// One of the continents (for example, Europe or Africa).
    /// </summary>
    public partial interface IContinent : ILandform
    {
    }

    /// <summary>
    /// One of the continents (for example, Europe or Africa).
    /// </summary>
    [DataContract]
    public partial class Continent : Landform, IContinent
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Continent";
    }
}
