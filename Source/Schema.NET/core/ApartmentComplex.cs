namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Residence type: Apartment complex.
    /// </summary>
    public partial interface IApartmentComplex : IResidence
    {
    }

    /// <summary>
    /// Residence type: Apartment complex.
    /// </summary>
    [DataContract]
    public partial class ApartmentComplex : Residence, IApartmentComplex
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ApartmentComplex";
    }
}
