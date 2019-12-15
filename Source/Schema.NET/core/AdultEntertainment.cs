﻿namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An adult entertainment establishment.
    /// </summary>
    public partial interface IAdultEntertainment : IEntertainmentBusiness
    {
    }

    /// <summary>
    /// An adult entertainment establishment.
    /// </summary>
    [DataContract]
    public partial class AdultEntertainment : EntertainmentBusiness, IAdultEntertainment, IEquatable<AdultEntertainment>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AdultEntertainment";
    }
}
