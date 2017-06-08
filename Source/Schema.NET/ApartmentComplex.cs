namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Residence type: Apartment complex.
    /// </summary>
    [DataContract]
    public class ApartmentComplex : Residence
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "ApartmentComplex";
    }
}
