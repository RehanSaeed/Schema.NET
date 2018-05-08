namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A volcano, like Fuji san.
    /// </summary>
    public partial interface IVolcano : ILandform
    {
    }

    /// <summary>
    /// A volcano, like Fuji san.
    /// </summary>
    [DataContract]
    public partial class Volcano : Landform, IVolcano
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Volcano";
    }
}
