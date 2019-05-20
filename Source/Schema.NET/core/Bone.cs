namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Rigid connective tissue that comprises up the skeletal structure of the human body.
    /// </summary>
    public partial interface IBone : IAnatomicalStructure
    {
    }

    /// <summary>
    /// Rigid connective tissue that comprises up the skeletal structure of the human body.
    /// </summary>
    [DataContract]
    public partial class Bone : AnatomicalStructure, IBone
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Bone";
    }
}
