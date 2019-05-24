namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A painting.
    /// </summary>
    public partial interface IPainting : ICreativeWork
    {
    }

    /// <summary>
    /// A painting.
    /// </summary>
    [DataContract]
    public partial class Painting : CreativeWork, IPainting
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Painting";
    }
}
