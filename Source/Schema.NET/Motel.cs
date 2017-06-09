namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A motel.
    /// See also the dedicated document on the use of schema...
    /// </summary>
    [DataContract]
    public class Motel : LodgingBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Motel";
    }
}
