namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Bed and breakfast.
    /// See also the dedicated document on the use of schema...
    /// </summary>
    [DataContract]
    public class BedAndBreakfast : LodgingBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "BedAndBreakfast";
    }
}
