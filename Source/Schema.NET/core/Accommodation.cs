namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// An accommodation is a place that can accommodate human beings, e.g. a hotel room, a camping pitch, or a meeting room. Many accommodations are for overnight stays, but this is not a mandatory requirement.
    /// For more specific types of accommodations not defined in schema.org, one can use additionalType with external vocabularies.
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    /// </summary>
    [DataContract]
    public partial class Accommodation : Place
    {

        public interface IFloorSize : IValue {}
        public interface IFloorSize<T> : IFloorSize { new T Value { get; } }
        public class OneOrManyFloorSize : OneOrMany<IFloorSize>
        {
            public OneOrManyFloorSize(IFloorSize item) : base(item) { }
            public OneOrManyFloorSize(IEnumerable<IFloorSize> items) : base(items) { }
            public static implicit operator OneOrManyFloorSize (QuantitativeValue value) { return new OneOrManyFloorSize (new FloorSizeQuantitativeValue (value)); }
            public static implicit operator OneOrManyFloorSize (QuantitativeValue[] values) { return new OneOrManyFloorSize (values.Select(v => (IFloorSize) new FloorSizeQuantitativeValue (v))); }
            public static implicit operator OneOrManyFloorSize (List<QuantitativeValue> values) { return new OneOrManyFloorSize (values.Select(v => (IFloorSize) new FloorSizeQuantitativeValue (v))); }
        }
        public struct FloorSizeQuantitativeValue : IFloorSize<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public FloorSizeQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator FloorSizeQuantitativeValue (QuantitativeValue value) { return new FloorSizeQuantitativeValue (value); }
        }

        public interface INumberOfRooms : IValue {}
        public interface INumberOfRooms<T> : INumberOfRooms { new T Value { get; } }
        public class OneOrManyNumberOfRooms : OneOrMany<INumberOfRooms>
        {
            public OneOrManyNumberOfRooms(INumberOfRooms item) : base(item) { }
            public OneOrManyNumberOfRooms(IEnumerable<INumberOfRooms> items) : base(items) { }
            public static implicit operator OneOrManyNumberOfRooms (int value) { return new OneOrManyNumberOfRooms (new NumberOfRoomsint (value)); }
            public static implicit operator OneOrManyNumberOfRooms (int[] values) { return new OneOrManyNumberOfRooms (values.Select(v => (INumberOfRooms) new NumberOfRoomsint (v))); }
            public static implicit operator OneOrManyNumberOfRooms (List<int> values) { return new OneOrManyNumberOfRooms (values.Select(v => (INumberOfRooms) new NumberOfRoomsint (v))); }
            public static implicit operator OneOrManyNumberOfRooms (QuantitativeValue value) { return new OneOrManyNumberOfRooms (new NumberOfRoomsQuantitativeValue (value)); }
            public static implicit operator OneOrManyNumberOfRooms (QuantitativeValue[] values) { return new OneOrManyNumberOfRooms (values.Select(v => (INumberOfRooms) new NumberOfRoomsQuantitativeValue (v))); }
            public static implicit operator OneOrManyNumberOfRooms (List<QuantitativeValue> values) { return new OneOrManyNumberOfRooms (values.Select(v => (INumberOfRooms) new NumberOfRoomsQuantitativeValue (v))); }
        }
        public struct NumberOfRoomsint : INumberOfRooms<int>
        {
            object IValue.Value => this.Value;
            public int Value { get; }
            public NumberOfRoomsint (int value) { Value = value; }
            public static implicit operator NumberOfRoomsint (int value) { return new NumberOfRoomsint (value); }
        }
        public struct NumberOfRoomsQuantitativeValue : INumberOfRooms<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public NumberOfRoomsQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator NumberOfRoomsQuantitativeValue (QuantitativeValue value) { return new NumberOfRoomsQuantitativeValue (value); }
        }

        public interface IPermittedUsage : IValue {}
        public interface IPermittedUsage<T> : IPermittedUsage { new T Value { get; } }
        public class OneOrManyPermittedUsage : OneOrMany<IPermittedUsage>
        {
            public OneOrManyPermittedUsage(IPermittedUsage item) : base(item) { }
            public OneOrManyPermittedUsage(IEnumerable<IPermittedUsage> items) : base(items) { }
            public static implicit operator OneOrManyPermittedUsage (string value) { return new OneOrManyPermittedUsage (new PermittedUsagestring (value)); }
            public static implicit operator OneOrManyPermittedUsage (string[] values) { return new OneOrManyPermittedUsage (values.Select(v => (IPermittedUsage) new PermittedUsagestring (v))); }
            public static implicit operator OneOrManyPermittedUsage (List<string> values) { return new OneOrManyPermittedUsage (values.Select(v => (IPermittedUsage) new PermittedUsagestring (v))); }
        }
        public struct PermittedUsagestring : IPermittedUsage<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public PermittedUsagestring (string value) { Value = value; }
            public static implicit operator PermittedUsagestring (string value) { return new PermittedUsagestring (value); }
        }

        public interface IPetsAllowed : IValue {}
        public interface IPetsAllowed<T> : IPetsAllowed { new T Value { get; } }
        public class OneOrManyPetsAllowed : OneOrMany<IPetsAllowed>
        {
            public OneOrManyPetsAllowed(IPetsAllowed item) : base(item) { }
            public OneOrManyPetsAllowed(IEnumerable<IPetsAllowed> items) : base(items) { }
            public static implicit operator OneOrManyPetsAllowed (bool value) { return new OneOrManyPetsAllowed (new PetsAllowedbool (value)); }
            public static implicit operator OneOrManyPetsAllowed (bool[] values) { return new OneOrManyPetsAllowed (values.Select(v => (IPetsAllowed) new PetsAllowedbool (v))); }
            public static implicit operator OneOrManyPetsAllowed (List<bool> values) { return new OneOrManyPetsAllowed (values.Select(v => (IPetsAllowed) new PetsAllowedbool (v))); }
            public static implicit operator OneOrManyPetsAllowed (string value) { return new OneOrManyPetsAllowed (new PetsAllowedstring (value)); }
            public static implicit operator OneOrManyPetsAllowed (string[] values) { return new OneOrManyPetsAllowed (values.Select(v => (IPetsAllowed) new PetsAllowedstring (v))); }
            public static implicit operator OneOrManyPetsAllowed (List<string> values) { return new OneOrManyPetsAllowed (values.Select(v => (IPetsAllowed) new PetsAllowedstring (v))); }
        }
        public struct PetsAllowedbool : IPetsAllowed<bool>
        {
            object IValue.Value => this.Value;
            public bool Value { get; }
            public PetsAllowedbool (bool value) { Value = value; }
            public static implicit operator PetsAllowedbool (bool value) { return new PetsAllowedbool (value); }
        }
        public struct PetsAllowedstring : IPetsAllowed<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public PetsAllowedstring (string value) { Value = value; }
            public static implicit operator PetsAllowedstring (string value) { return new PetsAllowedstring (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Accommodation";

        /// <summary>
        /// An amenity feature (e.g. a characteristic or service) of the Accommodation. This generic property does not make a statement about whether the feature is included in an offer for the main accommodation or available at extra costs.
        /// </summary>
        [DataMember(Name = "amenityFeature", Order = 206)]
        public override OneOrManyAmenityFeature AmenityFeature { get; set; }

        /// <summary>
        /// The size of the accommodation, e.g. in square meter or squarefoot.
        /// Typical unit code(s): MTK for square meter, FTK for square foot, or YDK for square yard
        /// </summary>
        [DataMember(Name = "floorSize", Order = 207)]
        public OneOrManyFloorSize FloorSize { get; set; }

        /// <summary>
        /// The number of rooms (excluding bathrooms and closets) of the accommodation or lodging business.
        /// Typical unit code(s): ROM for room or C62 for no unit. The type of room can be put in the unitText property of the QuantitativeValue.
        /// </summary>
        [DataMember(Name = "numberOfRooms", Order = 208)]
        public virtual OneOrManyNumberOfRooms NumberOfRooms { get; set; }

        /// <summary>
        /// Indications regarding the permitted usage of the accommodation.
        /// </summary>
        [DataMember(Name = "permittedUsage", Order = 209)]
        public OneOrManyPermittedUsage PermittedUsage { get; set; }

        /// <summary>
        /// Indicates whether pets are allowed to enter the accommodation or lodging business. More detailed information can be put in a text value.
        /// </summary>
        [DataMember(Name = "petsAllowed", Order = 210)]
        public OneOrManyPetsAllowed PetsAllowed { get; set; }
    }
}
