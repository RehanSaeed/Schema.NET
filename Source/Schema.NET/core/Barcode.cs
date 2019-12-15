namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An image of a visual machine-readable code such as a barcode or QR code.
    /// </summary>
    public partial interface IBarcode : IImageObject
    {
    }

    /// <summary>
    /// An image of a visual machine-readable code such as a barcode or QR code.
    /// </summary>
    [DataContract]
    public partial class Barcode : ImageObject, IBarcode, IEquatable<Barcode>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Barcode";

        /// <inheritdoc/>
        public bool Equals(Barcode other)
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
        public override bool Equals(object obj) => this.Equals(obj as Barcode);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
