namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A house painting service.
    /// </summary>
    public partial interface IHousePainter : IHomeAndConstructionBusiness
    {
    }

    /// <summary>
    /// A house painting service.
    /// </summary>
    [DataContract]
    public partial class HousePainter : HomeAndConstructionBusiness, IHousePainter, IEquatable<HousePainter>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "HousePainter";
    }
}
