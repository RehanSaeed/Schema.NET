namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A single, identifiable product instance (e.g. a laptop with a particular serial number).
    /// </summary>
    [DataContract]
    public partial class IndividualProduct : Product
    {
        public interface ISerialNumber : IValue {}
        public interface ISerialNumber<T> : ISerialNumber { new T Value { get; } }
        public class OneOrManySerialNumber : OneOrMany<ISerialNumber>
        {
            public OneOrManySerialNumber(ISerialNumber item) : base(item) { }
            public OneOrManySerialNumber(IEnumerable<ISerialNumber> items) : base(items) { }
            public static implicit operator OneOrManySerialNumber (string value) { return new OneOrManySerialNumber (new SerialNumberstring (value)); }
            public static implicit operator OneOrManySerialNumber (string[] values) { return new OneOrManySerialNumber (values.Select(v => (ISerialNumber) new SerialNumberstring (v))); }
            public static implicit operator OneOrManySerialNumber (List<string> values) { return new OneOrManySerialNumber (values.Select(v => (ISerialNumber) new SerialNumberstring (v))); }
        }
        public struct SerialNumberstring : ISerialNumber<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public SerialNumberstring (string value) { Value = value; }
            public static implicit operator SerialNumberstring (string value) { return new SerialNumberstring (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "IndividualProduct";

        /// <summary>
        /// The serial number or any alphanumeric identifier of a particular product. When attached to an offer, it is a shortcut for the serial number of the product included in the offer.
        /// </summary>
        [DataMember(Name = "serialNumber", Order = 206)]
        public OneOrManySerialNumber SerialNumber { get; set; }
    }
}
