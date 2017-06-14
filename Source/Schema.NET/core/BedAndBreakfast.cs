namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Bed and breakfast.
    /// See also the dedicated document on the use of schema...
    /// </summary>
    [DataContract]
    public partial class BedAndBreakfast : LodgingBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BedAndBreakfast";
    }
}
