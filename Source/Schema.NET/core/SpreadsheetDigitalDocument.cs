namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A spreadsheet file.
    /// </summary>
    [DataContract]
    public partial class SpreadsheetDigitalDocument : DigitalDocument
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SpreadsheetDigitalDocument";
    }
}
