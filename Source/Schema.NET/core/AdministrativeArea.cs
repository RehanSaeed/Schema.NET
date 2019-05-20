namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A geographical region, typically under the jurisdiction of a particular government.
    /// </summary>
    public partial interface IAdministrativeArea : IPlace
    {
    }

    /// <summary>
    /// A geographical region, typically under the jurisdiction of a particular government.
    /// </summary>
    [DataContract]
    public partial class AdministrativeArea : Place, IAdministrativeArea
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AdministrativeArea";
    }
}
