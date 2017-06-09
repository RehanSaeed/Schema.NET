namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A range of of services that will be provided to a customer free of charge in case of a defect or malfunction of a product...
    /// </summary>
    [DataContract]
    public class WarrantyScope : Enumeration
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "WarrantyScope";
    }
}
