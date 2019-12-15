﻿namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A nightclub or discotheque.
    /// </summary>
    public partial interface INightClub : IEntertainmentBusiness
    {
    }

    /// <summary>
    /// A nightclub or discotheque.
    /// </summary>
    [DataContract]
    public partial class NightClub : EntertainmentBusiness, INightClub, IEquatable<NightClub>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "NightClub";
    }
}
