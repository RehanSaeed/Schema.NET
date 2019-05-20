namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A city or town.
    /// </summary>
    public partial interface ICity : IAdministrativeArea
    {
    }

    /// <summary>
    /// A city or town.
    /// </summary>
    [DataContract]
    public partial class City : AdministrativeArea, ICity
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "City";
    }
}
