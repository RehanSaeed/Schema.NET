namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A vehicle is a device that is designed or used to transport people or cargo over land, water, air, or through space.
    /// </summary>
    public partial interface IVehicle : IProduct
    {
        /// <summary>
        /// The time needed to accelerate the vehicle from a given start velocity to a given target velocity.&lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): SEC for seconds&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Note: There are unfortunately no standard unit codes for seconds/0..100 km/h or seconds/0..60 mph. Simply use "SEC" for seconds and indicate the velocities in the &lt;a class="localLink" href="https://schema.org/name"&gt;name&lt;/a&gt; of the &lt;a class="localLink" href="https://schema.org/QuantitativeValue"&gt;QuantitativeValue&lt;/a&gt;, or use &lt;a class="localLink" href="https://schema.org/valueReference"&gt;valueReference&lt;/a&gt; with a &lt;a class="localLink" href="https://schema.org/QuantitativeValue"&gt;QuantitativeValue&lt;/a&gt; of 0..60 mph or 0..100 km/h to specify the reference speeds.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        OneOrMany<IQuantitativeValue> AccelerationTime { get; set; }

        /// <summary>
        /// Indicates the design and body style of the vehicle (e.g. station wagon, hatchback, etc.).
        /// </summary>
        Values<string, Uri> BodyType { get; set; }

        /// <summary>
        /// A &lt;a href="https://en.wikipedia.org/wiki/Call_sign"&gt;callsign&lt;/a&gt;, as used in broadcasting and radio communications to identify people, radio and TV stations, or vehicles.
        /// </summary>
        OneOrMany<string> CallSign { get; set; }

        /// <summary>
        /// The available volume for cargo or luggage. For automobiles, this is usually the trunk volume.&lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): LTR for liters, FTQ for cubic foot/feet&lt;br/&gt;&lt;br/&gt;
        /// Note: You can use &lt;a class="localLink" href="https://schema.org/minValue"&gt;minValue&lt;/a&gt; and &lt;a class="localLink" href="https://schema.org/maxValue"&gt;maxValue&lt;/a&gt; to indicate ranges.
        /// </summary>
        OneOrMany<IQuantitativeValue> CargoVolume { get; set; }

        /// <summary>
        /// The date of the first registration of the vehicle with the respective public authorities.
        /// </summary>
        Values<int?, DateTime?> DateVehicleFirstRegistered { get; set; }

        /// <summary>
        /// The drive wheel configuration, i.e. which roadwheels will receive torque from the vehicle's engine via the drivetrain.
        /// </summary>
        Values<DriveWheelConfigurationValue?, string> DriveWheelConfiguration { get; set; }

        /// <summary>
        /// The CO2 emissions in g/km. When used in combination with a QuantitativeValue, put "g/km" into the unitText property of that value, since there is no UN/CEFACT Common Code for "g/km".
        /// </summary>
        OneOrMany<double?> EmissionsCO2 { get; set; }

        /// <summary>
        /// The capacity of the fuel tank or in the case of electric cars, the battery. If there are multiple components for storage, this should indicate the total of all storage of the same type.&lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): LTR for liters, GLL of US gallons, GLI for UK / imperial gallons, AMH for ampere-hours (for electrical vehicles).
        /// </summary>
        OneOrMany<IQuantitativeValue> FuelCapacity { get; set; }

        /// <summary>
        /// The amount of fuel consumed for traveling a particular distance or temporal duration with the given vehicle (e.g. liters per 100 km).&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Note 1: There are unfortunately no standard unit codes for liters per 100 km.  Use &lt;a class="localLink" href="https://schema.org/unitText"&gt;unitText&lt;/a&gt; to indicate the unit of measurement, e.g. L/100 km.&lt;/li&gt;
        /// &lt;li&gt;Note 2: There are two ways of indicating the fuel consumption, &lt;a class="localLink" href="https://schema.org/fuelConsumption"&gt;fuelConsumption&lt;/a&gt; (e.g. 8 liters per 100 km) and &lt;a class="localLink" href="https://schema.org/fuelEfficiency"&gt;fuelEfficiency&lt;/a&gt; (e.g. 30 miles per gallon). They are reciprocal.&lt;/li&gt;
        /// &lt;li&gt;Note 3: Often, the absolute value is useful only when related to driving speed ("at 80 km/h") or usage pattern ("city traffic"). You can use &lt;a class="localLink" href="https://schema.org/valueReference"&gt;valueReference&lt;/a&gt; to link the value for the fuel consumption to another value.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        OneOrMany<IQuantitativeValue> FuelConsumption { get; set; }

        /// <summary>
        /// The distance traveled per unit of fuel used; most commonly miles per gallon (mpg) or kilometers per liter (km/L).&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Note 1: There are unfortunately no standard unit codes for miles per gallon or kilometers per liter. Use &lt;a class="localLink" href="https://schema.org/unitText"&gt;unitText&lt;/a&gt; to indicate the unit of measurement, e.g. mpg or km/L.&lt;/li&gt;
        /// &lt;li&gt;Note 2: There are two ways of indicating the fuel consumption, &lt;a class="localLink" href="https://schema.org/fuelConsumption"&gt;fuelConsumption&lt;/a&gt; (e.g. 8 liters per 100 km) and &lt;a class="localLink" href="https://schema.org/fuelEfficiency"&gt;fuelEfficiency&lt;/a&gt; (e.g. 30 miles per gallon). They are reciprocal.&lt;/li&gt;
        /// &lt;li&gt;Note 3: Often, the absolute value is useful only when related to driving speed ("at 80 km/h") or usage pattern ("city traffic"). You can use &lt;a class="localLink" href="https://schema.org/valueReference"&gt;valueReference&lt;/a&gt; to link the value for the fuel economy to another value.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        OneOrMany<IQuantitativeValue> FuelEfficiency { get; set; }

        /// <summary>
        /// The type of fuel suitable for the engine or engines of the vehicle. If the vehicle has only one engine, this property can be attached directly to the vehicle.
        /// </summary>
        Values<string, Uri> FuelType { get; set; }

        /// <summary>
        /// A textual description of known damages, both repaired and unrepaired.
        /// </summary>
        OneOrMany<string> KnownVehicleDamages { get; set; }

        /// <summary>
        /// Indicates that the vehicle meets the respective emission standard.
        /// </summary>
        Values<string, Uri> MeetsEmissionStandard { get; set; }

        /// <summary>
        /// The total distance travelled by the particular vehicle since its initial production, as read from its odometer.&lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): KMT for kilometers, SMI for statute miles
        /// </summary>
        OneOrMany<IQuantitativeValue> MileageFromOdometer { get; set; }

        /// <summary>
        /// The release date of a vehicle model (often used to differentiate versions of the same make and model).
        /// </summary>
        Values<int?, DateTime?> ModelDate { get; set; }

        /// <summary>
        /// The number or type of airbags in the vehicle.
        /// </summary>
        Values<int?, string> NumberOfAirbags { get; set; }

        /// <summary>
        /// The number of axles.&lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): C62
        /// </summary>
        Values<int?, IQuantitativeValue> NumberOfAxles { get; set; }

        /// <summary>
        /// The number of doors.&lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): C62
        /// </summary>
        Values<int?, IQuantitativeValue> NumberOfDoors { get; set; }

        /// <summary>
        /// The total number of forward gears available for the transmission system of the vehicle.&lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): C62
        /// </summary>
        Values<int?, IQuantitativeValue> NumberOfForwardGears { get; set; }

        /// <summary>
        /// The number of owners of the vehicle, including the current one.&lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): C62
        /// </summary>
        Values<int?, IQuantitativeValue> NumberOfPreviousOwners { get; set; }

        /// <summary>
        /// The permitted weight of passengers and cargo, EXCLUDING the weight of the empty vehicle.&lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): KGM for kilogram, LBR for pound&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Note 1: Many databases specify the permitted TOTAL weight instead, which is the sum of &lt;a class="localLink" href="https://schema.org/weight"&gt;weight&lt;/a&gt; and &lt;a class="localLink" href="https://schema.org/payload"&gt;payload&lt;/a&gt;&lt;/li&gt;
        /// &lt;li&gt;Note 2: You can indicate additional information in the &lt;a class="localLink" href="https://schema.org/name"&gt;name&lt;/a&gt; of the &lt;a class="localLink" href="https://schema.org/QuantitativeValue"&gt;QuantitativeValue&lt;/a&gt; node.&lt;/li&gt;
        /// &lt;li&gt;Note 3: You may also link to a &lt;a class="localLink" href="https://schema.org/QualitativeValue"&gt;QualitativeValue&lt;/a&gt; node that provides additional information using &lt;a class="localLink" href="https://schema.org/valueReference"&gt;valueReference&lt;/a&gt;.&lt;/li&gt;
        /// &lt;li&gt;Note 4: Note that you can use &lt;a class="localLink" href="https://schema.org/minValue"&gt;minValue&lt;/a&gt; and &lt;a class="localLink" href="https://schema.org/maxValue"&gt;maxValue&lt;/a&gt; to indicate ranges.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        OneOrMany<IQuantitativeValue> Payload { get; set; }

        /// <summary>
        /// The number of persons that can be seated (e.g. in a vehicle), both in terms of the physical space available, and in terms of limitations set by law.&lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): C62 for persons
        /// </summary>
        Values<double?, IQuantitativeValue> SeatingCapacity { get; set; }

        /// <summary>
        /// The speed range of the vehicle. If the vehicle is powered by an engine, the upper limit of the speed range (indicated by &lt;a class="localLink" href="https://schema.org/maxValue"&gt;maxValue&lt;/a&gt; should be the maximum speed achievable under regular conditions.&lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): KMH for km/h, HM for mile per hour (0.447 04 m/s), KNT for knot&lt;br/&gt;&lt;br/&gt;
        /// *Note 1: Use &lt;a class="localLink" href="https://schema.org/minValue"&gt;minValue&lt;/a&gt; and &lt;a class="localLink" href="https://schema.org/maxValue"&gt;maxValue&lt;/a&gt; to indicate the range. Typically, the minimal value is zero.
        /// * Note 2: There are many different ways of measuring the speed range. You can link to information about how the given value has been determined using the &lt;a class="localLink" href="https://schema.org/valueReference"&gt;valueReference&lt;/a&gt; property.
        /// </summary>
        OneOrMany<IQuantitativeValue> Speed { get; set; }

        /// <summary>
        /// The position of the steering wheel or similar device (mostly for cars).
        /// </summary>
        OneOrMany<SteeringPositionValue?> SteeringPosition { get; set; }

        /// <summary>
        /// This is a StupidProperty! - for testing only
        /// </summary>
        OneOrMany<IQuantitativeValue> StupidProperty { get; set; }

        /// <summary>
        /// The permitted vertical load (TWR) of a trailer attached to the vehicle. Also referred to as Tongue Load Rating (TLR) or Vertical Load Rating (VLR)&lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): KGM for kilogram, LBR for pound&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Note 1: You can indicate additional information in the &lt;a class="localLink" href="https://schema.org/name"&gt;name&lt;/a&gt; of the &lt;a class="localLink" href="https://schema.org/QuantitativeValue"&gt;QuantitativeValue&lt;/a&gt; node.&lt;/li&gt;
        /// &lt;li&gt;Note 2: You may also link to a &lt;a class="localLink" href="https://schema.org/QualitativeValue"&gt;QualitativeValue&lt;/a&gt; node that provides additional information using &lt;a class="localLink" href="https://schema.org/valueReference"&gt;valueReference&lt;/a&gt;.&lt;/li&gt;
        /// &lt;li&gt;Note 3: Note that you can use &lt;a class="localLink" href="https://schema.org/minValue"&gt;minValue&lt;/a&gt; and &lt;a class="localLink" href="https://schema.org/maxValue"&gt;maxValue&lt;/a&gt; to indicate ranges.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        OneOrMany<IQuantitativeValue> TongueWeight { get; set; }

        /// <summary>
        /// The permitted weight of a trailer attached to the vehicle.&lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): KGM for kilogram, LBR for pound
        /// * Note 1: You can indicate additional information in the &lt;a class="localLink" href="https://schema.org/name"&gt;name&lt;/a&gt; of the &lt;a class="localLink" href="https://schema.org/QuantitativeValue"&gt;QuantitativeValue&lt;/a&gt; node.
        /// * Note 2: You may also link to a &lt;a class="localLink" href="https://schema.org/QualitativeValue"&gt;QualitativeValue&lt;/a&gt; node that provides additional information using &lt;a class="localLink" href="https://schema.org/valueReference"&gt;valueReference&lt;/a&gt;.
        /// * Note 3: Note that you can use &lt;a class="localLink" href="https://schema.org/minValue"&gt;minValue&lt;/a&gt; and &lt;a class="localLink" href="https://schema.org/maxValue"&gt;maxValue&lt;/a&gt; to indicate ranges.
        /// </summary>
        OneOrMany<IQuantitativeValue> TrailerWeight { get; set; }

        /// <summary>
        /// A short text indicating the configuration of the vehicle, e.g. '5dr hatchback ST 2.5 MT 225 hp' or 'limited edition'.
        /// </summary>
        OneOrMany<string> VehicleConfiguration { get; set; }

        /// <summary>
        /// Information about the engine or engines of the vehicle.
        /// </summary>
        OneOrMany<IEngineSpecification> VehicleEngine { get; set; }

        /// <summary>
        /// The Vehicle Identification Number (VIN) is a unique serial number used by the automotive industry to identify individual motor vehicles.
        /// </summary>
        OneOrMany<string> VehicleIdentificationNumber { get; set; }

        /// <summary>
        /// The color or color combination of the interior of the vehicle.
        /// </summary>
        OneOrMany<string> VehicleInteriorColor { get; set; }

        /// <summary>
        /// The type or material of the interior of the vehicle (e.g. synthetic fabric, leather, wood, etc.). While most interior types are characterized by the material used, an interior type can also be based on vehicle usage or target audience.
        /// </summary>
        OneOrMany<string> VehicleInteriorType { get; set; }

        /// <summary>
        /// The release date of a vehicle model (often used to differentiate versions of the same make and model).
        /// </summary>
        Values<int?, DateTime?> VehicleModelDate { get; set; }

        /// <summary>
        /// The number of passengers that can be seated in the vehicle, both in terms of the physical space available, and in terms of limitations set by law.&lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): C62 for persons.
        /// </summary>
        Values<double?, IQuantitativeValue> VehicleSeatingCapacity { get; set; }

        /// <summary>
        /// Indicates whether the vehicle has been used for special purposes, like commercial rental, driving school, or as a taxi. The legislation in many countries requires this information to be revealed when offering a car for sale.
        /// </summary>
        Values<CarUsageType?, string> VehicleSpecialUsage { get; set; }

        /// <summary>
        /// The type of component used for transmitting the power from a rotating power source to the wheels or other relevant component(s) ("gearbox" for cars).
        /// </summary>
        Values<string, Uri> VehicleTransmission { get; set; }

        /// <summary>
        /// The permitted total weight of the loaded vehicle, including passengers and cargo and the weight of the empty vehicle.&lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): KGM for kilogram, LBR for pound&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Note 1: You can indicate additional information in the &lt;a class="localLink" href="https://schema.org/name"&gt;name&lt;/a&gt; of the &lt;a class="localLink" href="https://schema.org/QuantitativeValue"&gt;QuantitativeValue&lt;/a&gt; node.&lt;/li&gt;
        /// &lt;li&gt;Note 2: You may also link to a &lt;a class="localLink" href="https://schema.org/QualitativeValue"&gt;QualitativeValue&lt;/a&gt; node that provides additional information using &lt;a class="localLink" href="https://schema.org/valueReference"&gt;valueReference&lt;/a&gt;.&lt;/li&gt;
        /// &lt;li&gt;Note 3: Note that you can use &lt;a class="localLink" href="https://schema.org/minValue"&gt;minValue&lt;/a&gt; and &lt;a class="localLink" href="https://schema.org/maxValue"&gt;maxValue&lt;/a&gt; to indicate ranges.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        OneOrMany<IQuantitativeValue> WeightTotal { get; set; }

        /// <summary>
        /// The distance between the centers of the front and rear wheels.&lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): CMT for centimeters, MTR for meters, INH for inches, FOT for foot/feet
        /// </summary>
        OneOrMany<IQuantitativeValue> Wheelbase { get; set; }
    }

    /// <summary>
    /// A vehicle is a device that is designed or used to transport people or cargo over land, water, air, or through space.
    /// </summary>
    [DataContract]
    public partial class Vehicle : Product, IVehicle, IEquatable<Vehicle>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Vehicle";

        /// <summary>
        /// The time needed to accelerate the vehicle from a given start velocity to a given target velocity.&lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): SEC for seconds&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Note: There are unfortunately no standard unit codes for seconds/0..100 km/h or seconds/0..60 mph. Simply use "SEC" for seconds and indicate the velocities in the &lt;a class="localLink" href="https://schema.org/name"&gt;name&lt;/a&gt; of the &lt;a class="localLink" href="https://schema.org/QuantitativeValue"&gt;QuantitativeValue&lt;/a&gt;, or use &lt;a class="localLink" href="https://schema.org/valueReference"&gt;valueReference&lt;/a&gt; with a &lt;a class="localLink" href="https://schema.org/QuantitativeValue"&gt;QuantitativeValue&lt;/a&gt; of 0..60 mph or 0..100 km/h to specify the reference speeds.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [DataMember(Name = "accelerationTime", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuantitativeValue> AccelerationTime { get; set; }

        /// <summary>
        /// Indicates the design and body style of the vehicle (e.g. station wagon, hatchback, etc.).
        /// </summary>
        [DataMember(Name = "bodyType", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> BodyType { get; set; }

        /// <summary>
        /// A &lt;a href="https://en.wikipedia.org/wiki/Call_sign"&gt;callsign&lt;/a&gt;, as used in broadcasting and radio communications to identify people, radio and TV stations, or vehicles.
        /// </summary>
        [DataMember(Name = "callSign", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> CallSign { get; set; }

        /// <summary>
        /// The available volume for cargo or luggage. For automobiles, this is usually the trunk volume.&lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): LTR for liters, FTQ for cubic foot/feet&lt;br/&gt;&lt;br/&gt;
        /// Note: You can use &lt;a class="localLink" href="https://schema.org/minValue"&gt;minValue&lt;/a&gt; and &lt;a class="localLink" href="https://schema.org/maxValue"&gt;maxValue&lt;/a&gt; to indicate ranges.
        /// </summary>
        [DataMember(Name = "cargoVolume", Order = 209)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuantitativeValue> CargoVolume { get; set; }

        /// <summary>
        /// The date of the first registration of the vehicle with the respective public authorities.
        /// </summary>
        [DataMember(Name = "dateVehicleFirstRegistered", Order = 210)]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?> DateVehicleFirstRegistered { get; set; }

        /// <summary>
        /// The drive wheel configuration, i.e. which roadwheels will receive torque from the vehicle's engine via the drivetrain.
        /// </summary>
        [DataMember(Name = "driveWheelConfiguration", Order = 211)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<DriveWheelConfigurationValue?, string> DriveWheelConfiguration { get; set; }

        /// <summary>
        /// The CO2 emissions in g/km. When used in combination with a QuantitativeValue, put "g/km" into the unitText property of that value, since there is no UN/CEFACT Common Code for "g/km".
        /// </summary>
        [DataMember(Name = "emissionsCO2", Order = 212)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<double?> EmissionsCO2 { get; set; }

        /// <summary>
        /// The capacity of the fuel tank or in the case of electric cars, the battery. If there are multiple components for storage, this should indicate the total of all storage of the same type.&lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): LTR for liters, GLL of US gallons, GLI for UK / imperial gallons, AMH for ampere-hours (for electrical vehicles).
        /// </summary>
        [DataMember(Name = "fuelCapacity", Order = 213)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuantitativeValue> FuelCapacity { get; set; }

        /// <summary>
        /// The amount of fuel consumed for traveling a particular distance or temporal duration with the given vehicle (e.g. liters per 100 km).&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Note 1: There are unfortunately no standard unit codes for liters per 100 km.  Use &lt;a class="localLink" href="https://schema.org/unitText"&gt;unitText&lt;/a&gt; to indicate the unit of measurement, e.g. L/100 km.&lt;/li&gt;
        /// &lt;li&gt;Note 2: There are two ways of indicating the fuel consumption, &lt;a class="localLink" href="https://schema.org/fuelConsumption"&gt;fuelConsumption&lt;/a&gt; (e.g. 8 liters per 100 km) and &lt;a class="localLink" href="https://schema.org/fuelEfficiency"&gt;fuelEfficiency&lt;/a&gt; (e.g. 30 miles per gallon). They are reciprocal.&lt;/li&gt;
        /// &lt;li&gt;Note 3: Often, the absolute value is useful only when related to driving speed ("at 80 km/h") or usage pattern ("city traffic"). You can use &lt;a class="localLink" href="https://schema.org/valueReference"&gt;valueReference&lt;/a&gt; to link the value for the fuel consumption to another value.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [DataMember(Name = "fuelConsumption", Order = 214)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuantitativeValue> FuelConsumption { get; set; }

        /// <summary>
        /// The distance traveled per unit of fuel used; most commonly miles per gallon (mpg) or kilometers per liter (km/L).&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Note 1: There are unfortunately no standard unit codes for miles per gallon or kilometers per liter. Use &lt;a class="localLink" href="https://schema.org/unitText"&gt;unitText&lt;/a&gt; to indicate the unit of measurement, e.g. mpg or km/L.&lt;/li&gt;
        /// &lt;li&gt;Note 2: There are two ways of indicating the fuel consumption, &lt;a class="localLink" href="https://schema.org/fuelConsumption"&gt;fuelConsumption&lt;/a&gt; (e.g. 8 liters per 100 km) and &lt;a class="localLink" href="https://schema.org/fuelEfficiency"&gt;fuelEfficiency&lt;/a&gt; (e.g. 30 miles per gallon). They are reciprocal.&lt;/li&gt;
        /// &lt;li&gt;Note 3: Often, the absolute value is useful only when related to driving speed ("at 80 km/h") or usage pattern ("city traffic"). You can use &lt;a class="localLink" href="https://schema.org/valueReference"&gt;valueReference&lt;/a&gt; to link the value for the fuel economy to another value.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [DataMember(Name = "fuelEfficiency", Order = 215)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuantitativeValue> FuelEfficiency { get; set; }

        /// <summary>
        /// The type of fuel suitable for the engine or engines of the vehicle. If the vehicle has only one engine, this property can be attached directly to the vehicle.
        /// </summary>
        [DataMember(Name = "fuelType", Order = 216)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> FuelType { get; set; }

        /// <summary>
        /// A textual description of known damages, both repaired and unrepaired.
        /// </summary>
        [DataMember(Name = "knownVehicleDamages", Order = 217)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> KnownVehicleDamages { get; set; }

        /// <summary>
        /// Indicates that the vehicle meets the respective emission standard.
        /// </summary>
        [DataMember(Name = "meetsEmissionStandard", Order = 218)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> MeetsEmissionStandard { get; set; }

        /// <summary>
        /// The total distance travelled by the particular vehicle since its initial production, as read from its odometer.&lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): KMT for kilometers, SMI for statute miles
        /// </summary>
        [DataMember(Name = "mileageFromOdometer", Order = 219)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuantitativeValue> MileageFromOdometer { get; set; }

        /// <summary>
        /// The release date of a vehicle model (often used to differentiate versions of the same make and model).
        /// </summary>
        [DataMember(Name = "modelDate", Order = 220)]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?> ModelDate { get; set; }

        /// <summary>
        /// The number or type of airbags in the vehicle.
        /// </summary>
        [DataMember(Name = "numberOfAirbags", Order = 221)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<int?, string> NumberOfAirbags { get; set; }

        /// <summary>
        /// The number of axles.&lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): C62
        /// </summary>
        [DataMember(Name = "numberOfAxles", Order = 222)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<int?, IQuantitativeValue> NumberOfAxles { get; set; }

        /// <summary>
        /// The number of doors.&lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): C62
        /// </summary>
        [DataMember(Name = "numberOfDoors", Order = 223)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<int?, IQuantitativeValue> NumberOfDoors { get; set; }

        /// <summary>
        /// The total number of forward gears available for the transmission system of the vehicle.&lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): C62
        /// </summary>
        [DataMember(Name = "numberOfForwardGears", Order = 224)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<int?, IQuantitativeValue> NumberOfForwardGears { get; set; }

        /// <summary>
        /// The number of owners of the vehicle, including the current one.&lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): C62
        /// </summary>
        [DataMember(Name = "numberOfPreviousOwners", Order = 225)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<int?, IQuantitativeValue> NumberOfPreviousOwners { get; set; }

        /// <summary>
        /// The permitted weight of passengers and cargo, EXCLUDING the weight of the empty vehicle.&lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): KGM for kilogram, LBR for pound&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Note 1: Many databases specify the permitted TOTAL weight instead, which is the sum of &lt;a class="localLink" href="https://schema.org/weight"&gt;weight&lt;/a&gt; and &lt;a class="localLink" href="https://schema.org/payload"&gt;payload&lt;/a&gt;&lt;/li&gt;
        /// &lt;li&gt;Note 2: You can indicate additional information in the &lt;a class="localLink" href="https://schema.org/name"&gt;name&lt;/a&gt; of the &lt;a class="localLink" href="https://schema.org/QuantitativeValue"&gt;QuantitativeValue&lt;/a&gt; node.&lt;/li&gt;
        /// &lt;li&gt;Note 3: You may also link to a &lt;a class="localLink" href="https://schema.org/QualitativeValue"&gt;QualitativeValue&lt;/a&gt; node that provides additional information using &lt;a class="localLink" href="https://schema.org/valueReference"&gt;valueReference&lt;/a&gt;.&lt;/li&gt;
        /// &lt;li&gt;Note 4: Note that you can use &lt;a class="localLink" href="https://schema.org/minValue"&gt;minValue&lt;/a&gt; and &lt;a class="localLink" href="https://schema.org/maxValue"&gt;maxValue&lt;/a&gt; to indicate ranges.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [DataMember(Name = "payload", Order = 226)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuantitativeValue> Payload { get; set; }

        /// <summary>
        /// The date of production of the item, e.g. vehicle.
        /// </summary>
        [DataMember(Name = "productionDate", Order = 227)]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public override Values<int?, DateTime?> ProductionDate { get; set; }

        /// <summary>
        /// The date the item e.g. vehicle was purchased by the current owner.
        /// </summary>
        [DataMember(Name = "purchaseDate", Order = 228)]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public override Values<int?, DateTime?> PurchaseDate { get; set; }

        /// <summary>
        /// The number of persons that can be seated (e.g. in a vehicle), both in terms of the physical space available, and in terms of limitations set by law.&lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): C62 for persons
        /// </summary>
        [DataMember(Name = "seatingCapacity", Order = 229)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<double?, IQuantitativeValue> SeatingCapacity { get; set; }

        /// <summary>
        /// The speed range of the vehicle. If the vehicle is powered by an engine, the upper limit of the speed range (indicated by &lt;a class="localLink" href="https://schema.org/maxValue"&gt;maxValue&lt;/a&gt; should be the maximum speed achievable under regular conditions.&lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): KMH for km/h, HM for mile per hour (0.447 04 m/s), KNT for knot&lt;br/&gt;&lt;br/&gt;
        /// *Note 1: Use &lt;a class="localLink" href="https://schema.org/minValue"&gt;minValue&lt;/a&gt; and &lt;a class="localLink" href="https://schema.org/maxValue"&gt;maxValue&lt;/a&gt; to indicate the range. Typically, the minimal value is zero.
        /// * Note 2: There are many different ways of measuring the speed range. You can link to information about how the given value has been determined using the &lt;a class="localLink" href="https://schema.org/valueReference"&gt;valueReference&lt;/a&gt; property.
        /// </summary>
        [DataMember(Name = "speed", Order = 230)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuantitativeValue> Speed { get; set; }

        /// <summary>
        /// The position of the steering wheel or similar device (mostly for cars).
        /// </summary>
        [DataMember(Name = "steeringPosition", Order = 231)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<SteeringPositionValue?> SteeringPosition { get; set; }

        /// <summary>
        /// This is a StupidProperty! - for testing only
        /// </summary>
        [DataMember(Name = "stupidProperty", Order = 232)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuantitativeValue> StupidProperty { get; set; }

        /// <summary>
        /// The permitted vertical load (TWR) of a trailer attached to the vehicle. Also referred to as Tongue Load Rating (TLR) or Vertical Load Rating (VLR)&lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): KGM for kilogram, LBR for pound&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Note 1: You can indicate additional information in the &lt;a class="localLink" href="https://schema.org/name"&gt;name&lt;/a&gt; of the &lt;a class="localLink" href="https://schema.org/QuantitativeValue"&gt;QuantitativeValue&lt;/a&gt; node.&lt;/li&gt;
        /// &lt;li&gt;Note 2: You may also link to a &lt;a class="localLink" href="https://schema.org/QualitativeValue"&gt;QualitativeValue&lt;/a&gt; node that provides additional information using &lt;a class="localLink" href="https://schema.org/valueReference"&gt;valueReference&lt;/a&gt;.&lt;/li&gt;
        /// &lt;li&gt;Note 3: Note that you can use &lt;a class="localLink" href="https://schema.org/minValue"&gt;minValue&lt;/a&gt; and &lt;a class="localLink" href="https://schema.org/maxValue"&gt;maxValue&lt;/a&gt; to indicate ranges.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [DataMember(Name = "tongueWeight", Order = 233)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuantitativeValue> TongueWeight { get; set; }

        /// <summary>
        /// The permitted weight of a trailer attached to the vehicle.&lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): KGM for kilogram, LBR for pound
        /// * Note 1: You can indicate additional information in the &lt;a class="localLink" href="https://schema.org/name"&gt;name&lt;/a&gt; of the &lt;a class="localLink" href="https://schema.org/QuantitativeValue"&gt;QuantitativeValue&lt;/a&gt; node.
        /// * Note 2: You may also link to a &lt;a class="localLink" href="https://schema.org/QualitativeValue"&gt;QualitativeValue&lt;/a&gt; node that provides additional information using &lt;a class="localLink" href="https://schema.org/valueReference"&gt;valueReference&lt;/a&gt;.
        /// * Note 3: Note that you can use &lt;a class="localLink" href="https://schema.org/minValue"&gt;minValue&lt;/a&gt; and &lt;a class="localLink" href="https://schema.org/maxValue"&gt;maxValue&lt;/a&gt; to indicate ranges.
        /// </summary>
        [DataMember(Name = "trailerWeight", Order = 234)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuantitativeValue> TrailerWeight { get; set; }

        /// <summary>
        /// A short text indicating the configuration of the vehicle, e.g. '5dr hatchback ST 2.5 MT 225 hp' or 'limited edition'.
        /// </summary>
        [DataMember(Name = "vehicleConfiguration", Order = 235)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> VehicleConfiguration { get; set; }

        /// <summary>
        /// Information about the engine or engines of the vehicle.
        /// </summary>
        [DataMember(Name = "vehicleEngine", Order = 236)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IEngineSpecification> VehicleEngine { get; set; }

        /// <summary>
        /// The Vehicle Identification Number (VIN) is a unique serial number used by the automotive industry to identify individual motor vehicles.
        /// </summary>
        [DataMember(Name = "vehicleIdentificationNumber", Order = 237)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> VehicleIdentificationNumber { get; set; }

        /// <summary>
        /// The color or color combination of the interior of the vehicle.
        /// </summary>
        [DataMember(Name = "vehicleInteriorColor", Order = 238)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> VehicleInteriorColor { get; set; }

        /// <summary>
        /// The type or material of the interior of the vehicle (e.g. synthetic fabric, leather, wood, etc.). While most interior types are characterized by the material used, an interior type can also be based on vehicle usage or target audience.
        /// </summary>
        [DataMember(Name = "vehicleInteriorType", Order = 239)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> VehicleInteriorType { get; set; }

        /// <summary>
        /// The release date of a vehicle model (often used to differentiate versions of the same make and model).
        /// </summary>
        [DataMember(Name = "vehicleModelDate", Order = 240)]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?> VehicleModelDate { get; set; }

        /// <summary>
        /// The number of passengers that can be seated in the vehicle, both in terms of the physical space available, and in terms of limitations set by law.&lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): C62 for persons.
        /// </summary>
        [DataMember(Name = "vehicleSeatingCapacity", Order = 241)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<double?, IQuantitativeValue> VehicleSeatingCapacity { get; set; }

        /// <summary>
        /// Indicates whether the vehicle has been used for special purposes, like commercial rental, driving school, or as a taxi. The legislation in many countries requires this information to be revealed when offering a car for sale.
        /// </summary>
        [DataMember(Name = "vehicleSpecialUsage", Order = 242)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<CarUsageType?, string> VehicleSpecialUsage { get; set; }

        /// <summary>
        /// The type of component used for transmitting the power from a rotating power source to the wheels or other relevant component(s) ("gearbox" for cars).
        /// </summary>
        [DataMember(Name = "vehicleTransmission", Order = 243)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> VehicleTransmission { get; set; }

        /// <summary>
        /// The permitted total weight of the loaded vehicle, including passengers and cargo and the weight of the empty vehicle.&lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): KGM for kilogram, LBR for pound&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Note 1: You can indicate additional information in the &lt;a class="localLink" href="https://schema.org/name"&gt;name&lt;/a&gt; of the &lt;a class="localLink" href="https://schema.org/QuantitativeValue"&gt;QuantitativeValue&lt;/a&gt; node.&lt;/li&gt;
        /// &lt;li&gt;Note 2: You may also link to a &lt;a class="localLink" href="https://schema.org/QualitativeValue"&gt;QualitativeValue&lt;/a&gt; node that provides additional information using &lt;a class="localLink" href="https://schema.org/valueReference"&gt;valueReference&lt;/a&gt;.&lt;/li&gt;
        /// &lt;li&gt;Note 3: Note that you can use &lt;a class="localLink" href="https://schema.org/minValue"&gt;minValue&lt;/a&gt; and &lt;a class="localLink" href="https://schema.org/maxValue"&gt;maxValue&lt;/a&gt; to indicate ranges.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [DataMember(Name = "weightTotal", Order = 244)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuantitativeValue> WeightTotal { get; set; }

        /// <summary>
        /// The distance between the centers of the front and rear wheels.&lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): CMT for centimeters, MTR for meters, INH for inches, FOT for foot/feet
        /// </summary>
        [DataMember(Name = "wheelbase", Order = 245)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuantitativeValue> Wheelbase { get; set; }

        /// <inheritdoc/>
        public bool Equals(Vehicle other)
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
                this.AccelerationTime == other.AccelerationTime &&
                this.BodyType == other.BodyType &&
                this.CallSign == other.CallSign &&
                this.CargoVolume == other.CargoVolume &&
                this.DateVehicleFirstRegistered == other.DateVehicleFirstRegistered &&
                this.DriveWheelConfiguration == other.DriveWheelConfiguration &&
                this.EmissionsCO2 == other.EmissionsCO2 &&
                this.FuelCapacity == other.FuelCapacity &&
                this.FuelConsumption == other.FuelConsumption &&
                this.FuelEfficiency == other.FuelEfficiency &&
                this.FuelType == other.FuelType &&
                this.KnownVehicleDamages == other.KnownVehicleDamages &&
                this.MeetsEmissionStandard == other.MeetsEmissionStandard &&
                this.MileageFromOdometer == other.MileageFromOdometer &&
                this.ModelDate == other.ModelDate &&
                this.NumberOfAirbags == other.NumberOfAirbags &&
                this.NumberOfAxles == other.NumberOfAxles &&
                this.NumberOfDoors == other.NumberOfDoors &&
                this.NumberOfForwardGears == other.NumberOfForwardGears &&
                this.NumberOfPreviousOwners == other.NumberOfPreviousOwners &&
                this.Payload == other.Payload &&
                this.ProductionDate == other.ProductionDate &&
                this.PurchaseDate == other.PurchaseDate &&
                this.SeatingCapacity == other.SeatingCapacity &&
                this.Speed == other.Speed &&
                this.SteeringPosition == other.SteeringPosition &&
                this.StupidProperty == other.StupidProperty &&
                this.TongueWeight == other.TongueWeight &&
                this.TrailerWeight == other.TrailerWeight &&
                this.VehicleConfiguration == other.VehicleConfiguration &&
                this.VehicleEngine == other.VehicleEngine &&
                this.VehicleIdentificationNumber == other.VehicleIdentificationNumber &&
                this.VehicleInteriorColor == other.VehicleInteriorColor &&
                this.VehicleInteriorType == other.VehicleInteriorType &&
                this.VehicleModelDate == other.VehicleModelDate &&
                this.VehicleSeatingCapacity == other.VehicleSeatingCapacity &&
                this.VehicleSpecialUsage == other.VehicleSpecialUsage &&
                this.VehicleTransmission == other.VehicleTransmission &&
                this.WeightTotal == other.WeightTotal &&
                this.Wheelbase == other.Wheelbase &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as Vehicle);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.AccelerationTime)
            .And(this.BodyType)
            .And(this.CallSign)
            .And(this.CargoVolume)
            .And(this.DateVehicleFirstRegistered)
            .And(this.DriveWheelConfiguration)
            .And(this.EmissionsCO2)
            .And(this.FuelCapacity)
            .And(this.FuelConsumption)
            .And(this.FuelEfficiency)
            .And(this.FuelType)
            .And(this.KnownVehicleDamages)
            .And(this.MeetsEmissionStandard)
            .And(this.MileageFromOdometer)
            .And(this.ModelDate)
            .And(this.NumberOfAirbags)
            .And(this.NumberOfAxles)
            .And(this.NumberOfDoors)
            .And(this.NumberOfForwardGears)
            .And(this.NumberOfPreviousOwners)
            .And(this.Payload)
            .And(this.ProductionDate)
            .And(this.PurchaseDate)
            .And(this.SeatingCapacity)
            .And(this.Speed)
            .And(this.SteeringPosition)
            .And(this.StupidProperty)
            .And(this.TongueWeight)
            .And(this.TrailerWeight)
            .And(this.VehicleConfiguration)
            .And(this.VehicleEngine)
            .And(this.VehicleIdentificationNumber)
            .And(this.VehicleInteriorColor)
            .And(this.VehicleInteriorType)
            .And(this.VehicleModelDate)
            .And(this.VehicleSeatingCapacity)
            .And(this.VehicleSpecialUsage)
            .And(this.VehicleTransmission)
            .And(this.WeightTotal)
            .And(this.Wheelbase)
            .And(base.GetHashCode());
    }
}
