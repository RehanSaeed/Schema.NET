namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A collection or bound volume of maps, charts, plates or tables, physical or in media form illustrating any subject.
    /// </summary>
    public partial interface IAtlas : ICreativeWork
    {
    }

    /// <summary>
    /// A collection or bound volume of maps, charts, plates or tables, physical or in media form illustrating any subject.
    /// </summary>
    [DataContract]
    public partial class Atlas : CreativeWork, IAtlas
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Atlas";
    }
}
