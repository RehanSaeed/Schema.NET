namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A photograph.
    /// </summary>
    public partial interface IPhotograph : ICreativeWork
    {
    }

    /// <summary>
    /// A photograph.
    /// </summary>
    [DataContract]
    public partial class Photograph : CreativeWork, IPhotograph
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Photograph";
    }
}
