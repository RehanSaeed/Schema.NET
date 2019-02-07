namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// An entity holding detailed information about the available bed types, e.g. the quantity of twin beds for a hotel room. For the single case of just one bed of a certain type, you can use bed directly with a text. See also &lt;a class="localLink" href="http://schema.org/BedType"&gt;BedType&lt;/a&gt; (under development).
    /// </summary>
    [DataContract]
    public partial class BedDetails : Intangible
    {
        public interface INumberOfBeds : IValue {}
        public interface INumberOfBeds<T> : INumberOfBeds { new T Value { get; } }
        public class OneOrManyNumberOfBeds : OneOrMany<INumberOfBeds>
        {
            public OneOrManyNumberOfBeds(INumberOfBeds item) : base(item) { }
            public OneOrManyNumberOfBeds(IEnumerable<INumberOfBeds> items) : base(items) { }
            public static implicit operator OneOrManyNumberOfBeds (int value) { return new OneOrManyNumberOfBeds (new NumberOfBedsint (value)); }
            public static implicit operator OneOrManyNumberOfBeds (int[] values) { return new OneOrManyNumberOfBeds (values.Select(v => (INumberOfBeds) new NumberOfBedsint (v))); }
            public static implicit operator OneOrManyNumberOfBeds (List<int> values) { return new OneOrManyNumberOfBeds (values.Select(v => (INumberOfBeds) new NumberOfBedsint (v))); }
        }
        public struct NumberOfBedsint : INumberOfBeds<int>
        {
            object IValue.Value => this.Value;
            public int Value { get; }
            public NumberOfBedsint (int value) { Value = value; }
            public static implicit operator NumberOfBedsint (int value) { return new NumberOfBedsint (value); }
        }

        public interface ITypeOfBed : IValue {}
        public interface ITypeOfBed<T> : ITypeOfBed { new T Value { get; } }
        public class OneOrManyTypeOfBed : OneOrMany<ITypeOfBed>
        {
            public OneOrManyTypeOfBed(ITypeOfBed item) : base(item) { }
            public OneOrManyTypeOfBed(IEnumerable<ITypeOfBed> items) : base(items) { }
            public static implicit operator OneOrManyTypeOfBed (string value) { return new OneOrManyTypeOfBed (new TypeOfBedstring (value)); }
            public static implicit operator OneOrManyTypeOfBed (string[] values) { return new OneOrManyTypeOfBed (values.Select(v => (ITypeOfBed) new TypeOfBedstring (v))); }
            public static implicit operator OneOrManyTypeOfBed (List<string> values) { return new OneOrManyTypeOfBed (values.Select(v => (ITypeOfBed) new TypeOfBedstring (v))); }
        }
        public struct TypeOfBedstring : ITypeOfBed<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public TypeOfBedstring (string value) { Value = value; }
            public static implicit operator TypeOfBedstring (string value) { return new TypeOfBedstring (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BedDetails";

        /// <summary>
        /// The quantity of the given bed type available in the HotelRoom, Suite, House, or Apartment.
        /// </summary>
        [DataMember(Name = "numberOfBeds", Order = 206)]
        public OneOrManyNumberOfBeds NumberOfBeds { get; set; }

        /// <summary>
        /// The type of bed to which the BedDetail refers, i.e. the type of bed available in the quantity indicated by quantity.
        /// </summary>
        [DataMember(Name = "typeOfBed", Order = 207)]
        public OneOrManyTypeOfBed TypeOfBed { get; set; }
    }
}
