namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A spreadsheet file.
    /// </summary>
    [DataContract]
    public class SpreadsheetDigitalDocument : DigitalDocument
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "SpreadsheetDigitalDocument";
    }
}
