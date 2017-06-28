namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A vehicle is a device that is designed or used to transport people or cargo over land, water, air, or through space.
    /// </summary>
    [DataContract]
    public partial class Vehicle : Product
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Vehicle";

        /// <summary>
        /// The available volume for cargo or luggage. For automobiles, this is usually the trunk volume.&lt;/p&gt;
        /// &lt;p&gt;Typical unit code(s): LTR for liters, FTQ for cubic foot/feet&lt;/p&gt;
        /// &lt;p&gt;Note: You can use &lt;a class="localLink" href="http://schema.org/minValue"&gt;minValue&lt;/a&gt; and &lt;a class="localLink" href="http://schema.org/maxValue"&gt;maxValue&lt;/a&gt; to indicate ranges.
        /// </summary>
        [DataMember(Name = "cargoVolume", Order = 205)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<QuantitativeValue>? CargoVolume { get; set; }

        /// <summary>
        /// The date of the first registration of the vehicle with the respective public authorities.
        /// </summary>
        [DataMember(Name = "dateVehicleFirstRegistered", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset?>? DateVehicleFirstRegistered { get; set; }

        /// <summary>
        /// The drive wheel configuration, i.e. which roadwheels will receive torque from the vehicle's engine via the drivetrain.
        /// </summary>
        [DataMember(Name = "driveWheelConfiguration", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DriveWheelConfigurationValue?, string>? DriveWheelConfiguration { get; set; }

        /// <summary>
        /// &lt;p&gt;The amount of fuel consumed for traveling a particular distance or temporal duration with the given vehicle (e.g. liters per 100 km).&lt;/p&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Note 1: There are unfortunately no standard unit codes for liters per 100 km.  Use &lt;a class="localLink" href="http://schema.org/unitText"&gt;unitText&lt;/a&gt; to indicate the unit of measurement, e.g. L/100 km.&lt;/li&gt;
        /// &lt;li&gt;Note 2: There are two ways of indicating the fuel consumption, &lt;a class="localLink" href="http://schema.org/fuelConsumption"&gt;fuelConsumption&lt;/a&gt; (e.g. 8 liters per 100 km) and &lt;a class="localLink" href="http://schema.org/fuelEfficiency"&gt;fuelEfficiency&lt;/a&gt; (e.g. 30 miles per gallon). They are reciprocal.&lt;/li&gt;
        /// &lt;li&gt;Note 3: Often, the absolute value is useful only when related to driving speed ("at 80 km/h") or usage pattern ("city traffic"). You can use &lt;a class="localLink" href="http://schema.org/valueReference"&gt;valueReference&lt;/a&gt; to link the value for the fuel consumption to another value.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [DataMember(Name = "fuelConsumption", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<QuantitativeValue>? FuelConsumption { get; set; }

        /// <summary>
        /// &lt;p&gt;The distance traveled per unit of fuel used; most commonly miles per gallon (mpg) or kilometers per liter (km/L).&lt;/p&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Note 1: There are unfortunately no standard unit codes for miles per gallon or kilometers per liter. Use &lt;a class="localLink" href="http://schema.org/unitText"&gt;unitText&lt;/a&gt; to indicate the unit of measurement, e.g. mpg or km/L.&lt;/li&gt;
        /// &lt;li&gt;Note 2: There are two ways of indicating the fuel consumption, &lt;a class="localLink" href="http://schema.org/fuelConsumption"&gt;fuelConsumption&lt;/a&gt; (e.g. 8 liters per 100 km) and &lt;a class="localLink" href="http://schema.org/fuelEfficiency"&gt;fuelEfficiency&lt;/a&gt; (e.g. 30 miles per gallon). They are reciprocal.&lt;/li&gt;
        /// &lt;li&gt;Note 3: Often, the absolute value is useful only when related to driving speed ("at 80 km/h") or usage pattern ("city traffic"). You can use &lt;a class="localLink" href="http://schema.org/valueReference"&gt;valueReference&lt;/a&gt; to link the value for the fuel economy to another value.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [DataMember(Name = "fuelEfficiency", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<QuantitativeValue>? FuelEfficiency { get; set; }

        /// <summary>
        /// The type of fuel suitable for the engine or engines of the vehicle. If the vehicle has only one engine, this property can be attached directly to the vehicle.
        /// </summary>
        [DataMember(Name = "fuelType", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Uri, string>? FuelType { get; set; }

        /// <summary>
        /// A textual description of known damages, both repaired and unrepaired.
        /// </summary>
        [DataMember(Name = "knownVehicleDamages", Order = 211)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? KnownVehicleDamages { get; set; }

        /// <summary>
        /// The total distance travelled by the particular vehicle since its initial production, as read from its odometer.&lt;/p&gt;
        /// &lt;p&gt;Typical unit code(s): KMT for kilometers, SMI for statute miles
        /// </summary>
        [DataMember(Name = "mileageFromOdometer", Order = 212)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<QuantitativeValue>? MileageFromOdometer { get; set; }

        /// <summary>
        /// The number or type of airbags in the vehicle.
        /// </summary>
        [DataMember(Name = "numberOfAirbags", Order = 213)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, int?>? NumberOfAirbags { get; set; }

        /// <summary>
        /// The number of axles.&lt;/p&gt;
        /// &lt;p&gt;Typical unit code(s): C62
        /// </summary>
        [DataMember(Name = "numberOfAxles", Order = 214)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<int?, QuantitativeValue>? NumberOfAxles { get; set; }

        /// <summary>
        /// The number of doors.&lt;/p&gt;
        /// &lt;p&gt;Typical unit code(s): C62
        /// </summary>
        [DataMember(Name = "numberOfDoors", Order = 215)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<QuantitativeValue, int?>? NumberOfDoors { get; set; }

        /// <summary>
        /// The total number of forward gears available for the transmission system of the vehicle.&lt;/p&gt;
        /// &lt;p&gt;Typical unit code(s): C62
        /// </summary>
        [DataMember(Name = "numberOfForwardGears", Order = 216)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<int?, QuantitativeValue>? NumberOfForwardGears { get; set; }

        /// <summary>
        /// The number of owners of the vehicle, including the current one.&lt;/p&gt;
        /// &lt;p&gt;Typical unit code(s): C62
        /// </summary>
        [DataMember(Name = "numberOfPreviousOwners", Order = 217)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<QuantitativeValue, int?>? NumberOfPreviousOwners { get; set; }

        /// <summary>
        /// The date of production of the item, e.g. vehicle.
        /// </summary>
        [DataMember(Name = "productionDate", Order = 218)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<DateTimeOffset?>? ProductionDate { get; set; }

        /// <summary>
        /// The date the item e.g. vehicle was purchased by the current owner.
        /// </summary>
        [DataMember(Name = "purchaseDate", Order = 219)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<DateTimeOffset?>? PurchaseDate { get; set; }

        /// <summary>
        /// The position of the steering wheel or similar device (mostly for cars).
        /// </summary>
        [DataMember(Name = "steeringPosition", Order = 220)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<SteeringPositionValue?>? SteeringPosition { get; set; }

        /// <summary>
        /// A short text indicating the configuration of the vehicle, e.g. '5dr hatchback ST 2.5 MT 225 hp' or 'limited edition'.
        /// </summary>
        [DataMember(Name = "vehicleConfiguration", Order = 221)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? VehicleConfiguration { get; set; }

        /// <summary>
        /// Information about the engine or engines of the vehicle.
        /// </summary>
        [DataMember(Name = "vehicleEngine", Order = 222)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<EngineSpecification>? VehicleEngine { get; set; }

        /// <summary>
        /// The Vehicle Identification Number (VIN) is a unique serial number used by the automotive industry to identify individual motor vehicles.
        /// </summary>
        [DataMember(Name = "vehicleIdentificationNumber", Order = 223)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? VehicleIdentificationNumber { get; set; }

        /// <summary>
        /// The color or color combination of the interior of the vehicle.
        /// </summary>
        [DataMember(Name = "vehicleInteriorColor", Order = 224)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? VehicleInteriorColor { get; set; }

        /// <summary>
        /// The type or material of the interior of the vehicle (e.g. synthetic fabric, leather, wood, etc.). While most interior types are characterized by the material used, an interior type can also be based on vehicle usage or target audience.
        /// </summary>
        [DataMember(Name = "vehicleInteriorType", Order = 225)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? VehicleInteriorType { get; set; }

        /// <summary>
        /// The release date of a vehicle model (often used to differentiate versions of the same make and model).
        /// </summary>
        [DataMember(Name = "vehicleModelDate", Order = 226)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset?>? VehicleModelDate { get; set; }

        /// <summary>
        /// The number of passengers that can be seated in the vehicle, both in terms of the physical space available, and in terms of limitations set by law.&lt;/p&gt;
        /// &lt;p&gt;Typical unit code(s): C62 for persons.
        /// </summary>
        [DataMember(Name = "vehicleSeatingCapacity", Order = 227)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<double?, QuantitativeValue>? VehicleSeatingCapacity { get; set; }

        /// <summary>
        /// Indicates whether the vehicle has been used for special purposes, like commercial rental, driving school, or as a taxi. The legislation in many countries requires this information to be revealed when offering a car for sale.
        /// </summary>
        [DataMember(Name = "vehicleSpecialUsage", Order = 228)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? VehicleSpecialUsage { get; set; }

        /// <summary>
        /// The type of component used for transmitting the power from a rotating power source to the wheels or other relevant component(s) ("gearbox" for cars).
        /// </summary>
        [DataMember(Name = "vehicleTransmission", Order = 229)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Uri, string>? VehicleTransmission { get; set; }
    }
}
