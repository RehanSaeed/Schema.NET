namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A theater or other performing art center.
    /// </summary>
    public partial interface IPerformingArtsTheater : ICivicStructure
    {
    }

    /// <summary>
    /// A theater or other performing art center.
    /// </summary>
    [DataContract]
    public partial class PerformingArtsTheater : CivicStructure, IPerformingArtsTheater, IEquatable<PerformingArtsTheater>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PerformingArtsTheater";
    }
}
