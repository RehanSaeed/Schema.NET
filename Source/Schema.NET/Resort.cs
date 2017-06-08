namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A resort is a place used for relaxation or recreation, attracting visitors for holidays or vacations...
    /// </summary>
    [DataContract]
    public class Resort : LodgingBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "Resort";
    }
}
