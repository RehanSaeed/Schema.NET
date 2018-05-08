namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A state or province of a country.
    /// </summary>
    public partial interface IState : IAdministrativeArea
    {
    }

    /// <summary>
    /// A state or province of a country.
    /// </summary>
    [DataContract]
    public partial class State : AdministrativeArea, IState
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "State";
    }
}
