namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A Series in schema.org is a group of related items, typically but not necessarily of the same kind.
    /// </summary>
    public partial interface ISeries : ICreativeWork
    {
    }

    /// <summary>
    /// A Series in schema.org is a group of related items, typically but not necessarily of the same kind.
    /// </summary>
    [DataContract]
    public partial class Series : CreativeWork, ISeries
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Series";
    }
}
