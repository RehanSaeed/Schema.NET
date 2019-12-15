﻿namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A canal, like the Panama Canal.
    /// </summary>
    public partial interface ICanal : IBodyOfWater
    {
    }

    /// <summary>
    /// A canal, like the Panama Canal.
    /// </summary>
    [DataContract]
    public partial class Canal : BodyOfWater, ICanal, IEquatable<Canal>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Canal";
    }
}
