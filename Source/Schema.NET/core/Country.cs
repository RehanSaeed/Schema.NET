namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A country.
    /// </summary>
    public partial interface ICountry : IAdministrativeArea
    {
    }

    /// <summary>
    /// A country.
    /// </summary>
    [DataContract]
    public partial class Country : AdministrativeArea, ICountry
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Country";
    }
}
