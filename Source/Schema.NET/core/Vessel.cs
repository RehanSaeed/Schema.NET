namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A component of the human body circulatory system comprised of an intricate network of hollow tubes that transport blood throughout the entire body.
    /// </summary>
    public partial interface IVessel : IAnatomicalStructure
    {
    }

    /// <summary>
    /// A component of the human body circulatory system comprised of an intricate network of hollow tubes that transport blood throughout the entire body.
    /// </summary>
    [DataContract]
    public partial class Vessel : AnatomicalStructure, IVessel, IEquatable<Vessel>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Vessel";
    }
}
