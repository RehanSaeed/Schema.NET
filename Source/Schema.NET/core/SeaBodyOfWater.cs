namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A sea (for example, the Caspian sea).
    /// </summary>
    public partial interface ISeaBodyOfWater : IBodyOfWater
    {
    }

    /// <summary>
    /// A sea (for example, the Caspian sea).
    /// </summary>
    [DataContract]
    public partial class SeaBodyOfWater : BodyOfWater, ISeaBodyOfWater
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SeaBodyOfWater";
    }
}
