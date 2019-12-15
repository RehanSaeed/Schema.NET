﻿namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A crematorium.
    /// </summary>
    public partial interface ICrematorium : ICivicStructure
    {
    }

    /// <summary>
    /// A crematorium.
    /// </summary>
    [DataContract]
    public partial class Crematorium : CivicStructure, ICrematorium, IEquatable<Crematorium>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Crematorium";
    }
}
