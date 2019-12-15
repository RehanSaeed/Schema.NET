namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A spreadsheet file.
    /// </summary>
    public partial interface ISpreadsheetDigitalDocument : IDigitalDocument
    {
    }

    /// <summary>
    /// A spreadsheet file.
    /// </summary>
    [DataContract]
    public partial class SpreadsheetDigitalDocument : DigitalDocument, ISpreadsheetDigitalDocument, IEquatable<SpreadsheetDigitalDocument>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SpreadsheetDigitalDocument";

        /// <inheritdoc/>
        public bool Equals(SpreadsheetDigitalDocument other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Type == other.Type &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as SpreadsheetDigitalDocument);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
