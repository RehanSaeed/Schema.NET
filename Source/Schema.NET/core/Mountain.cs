namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A mountain, like Mount Whitney or Mount Everest.
    /// </summary>
    public partial interface IMountain : ILandform
    {
    }

    /// <summary>
    /// A mountain, like Mount Whitney or Mount Everest.
    /// </summary>
    [DataContract]
    public partial class Mountain : Landform, IMountain, IEquatable<Mountain>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Mountain";
    }
}
