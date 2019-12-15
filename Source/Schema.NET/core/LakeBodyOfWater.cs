namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A lake (for example, Lake Pontrachain).
    /// </summary>
    public partial interface ILakeBodyOfWater : IBodyOfWater
    {
    }

    /// <summary>
    /// A lake (for example, Lake Pontrachain).
    /// </summary>
    [DataContract]
    public partial class LakeBodyOfWater : BodyOfWater, ILakeBodyOfWater, IEquatable<LakeBodyOfWater>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "LakeBodyOfWater";
    }
}
