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
        /// &lt;p&gt;The time needed to accelerate the vehicle from a given start velocity to a given target velocity.&lt;/p&gt;
        /// &lt;p&gt;Typical unit code(s): SEC for seconds&lt;/p&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Note: There are unfortunately no standard unit codes for seconds/0..100 km/h or seconds/0..60 mph. Simply use "SEC" for seconds and indicate the velocities in the &lt;a class="localLink" href="http://schema.org/name"&gt;name&lt;/a&gt; of the &lt;a class="localLink" href="http://schema.org/QuantitativeValue"&gt;QuantitativeValue&lt;/a&gt;, or use &lt;a class="localLink" href="http://schema.org/valueReference"&gt;valueReference&lt;/a&gt; with a &lt;a class="localLink" href="http://schema.org/QuantitativeValue"&gt;QuantitativeValue&lt;/a&gt; of 0..60 mph or 0..100 km/h to specify the reference speeds.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [DataMember(Name = "accelerationTime", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<QuantitativeValue>? AccelerationTime { get; set; }

        /// <summary>
        /// Indicates the design and body style of the vehicle (e.g. station wagon, hatchback, etc.).
        /// </summary>
        [DataMember(Name = "bodyType", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, Uri>? BodyType { get; set; }

        /// <summary>
        /// The available volume for cargo or luggage. For automobiles, this is usually the trunk volume.&lt;/p&gt;
        /// &lt;p&gt;Typical unit code(s): LTR for liters, FTQ for cubic foot/feet&lt;/p&gt;
        /// &lt;p&gt;Note: You can use &lt;a class="localLink" href="http://schema.org/minValue"&gt;minValue&lt;/a&gt; and &lt;a class="localLink" href="http://schema.org/maxValue"&gt;maxValue&lt;/a&gt; to indicate ranges.
        /// </summary>
        [DataMember(Name = "cargoVolume", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<QuantitativeValue>? CargoVolume { get; set; }

        /// <summary>
        /// The date of the first registration of the vehicle with the respective public authorities.
        /// </summary>
        [DataMember(Name = "dateVehicleFirstRegistered", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset?>? DateVehicleFirstRegistered { get; set; }

        /// <summary>
        /// The drive wheel configuration, i.e. which roadwheels will receive torque from the vehicle's engine via the drivetrain.
        /// </summary>
        [DataMember(Name = "driveWheelConfiguration", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DriveWheelConfigurationValue?, string>? DriveWheelConfiguration { get; set; }

        /// <summary>
        /// The CO2 emissions in g/km. When used in combination with a QuantitativeValue, put "g/km" into the unitText property of that value, since there is no UN/CEFACT Common Code for "g/km".
        /// </summary>
        [DataMember(Name = "emissionsCO2", Order = 211)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<double?>? EmissionsCO2 { get; set; }

        /// <summary>
        /// The capacity of the fuel tank or in the case of electric cars, the battery. If there are multiple components for storage, this should indicate the total of all storage of the same type.&lt;/p&gt;
        /// &lt;p&gt;Typical unit code(s): LTR for liters, GLL of US gallons, GLI for UK / imperial gallons, AMH for ampere-hours (for electrical vehicles).
        /// </summary>
        [DataMember(Name = "fuelCapacity", Order = 212)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<QuantitativeValue>? FuelCapacity { get; set; }

        /// <summary>
        /// &lt;p&gt;The amount of fuel consumed for traveling a particular distance or temporal duration with the given vehicle (e.g. liters per 100 km).&lt;/p&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Note 1: There are unfortunately no standard unit codes for liters per 100 km.  Use &lt;a class="localLink" href="http://schema.org/unitText"&gt;unitText&lt;/a&gt; to indicate the unit of measurement, e.g. L/100 km.&lt;/li&gt;
        /// &lt;li&gt;Note 2: There are two ways of indicating the fuel consumption, &lt;a class="localLink" href="http://schema.org/fuelConsumption"&gt;fuelConsumption&lt;/a&gt; (e.g. 8 liters per 100 km) and &lt;a class="localLink" href="http://schema.org/fuelEfficiency"&gt;fuelEfficiency&lt;/a&gt; (e.g. 30 miles per gallon). They are reciprocal.&lt;/li&gt;
        /// &lt;li&gt;Note 3: Often, the absolute value is useful only when related to driving speed ("at 80 km/h") or usage pattern ("city traffic"). You can use &lt;a class="localLink" href="http://schema.org/valueReference"&gt;valueReference&lt;/a&gt; to link the value for the fuel consumption to another value.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [DataMember(Name = "fuelConsumption", Order = 213)]
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
        [DataMember(Name = "fuelEfficiency", Order = 214)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<QuantitativeValue>? FuelEfficiency { get; set; }

        /// <summary>
        /// The type of fuel suitable for the engine or engines of the vehicle. If the vehicle has only one engine, this property can be attached directly to the vehicle.
        /// </summary>
        [DataMember(Name = "fuelType", Order = 215)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, Uri>? FuelType { get; set; }

        /// <summary>
        /// A textual description of known damages, both repaired and unrepaired.
        /// </summary>
        [DataMember(Name = "knownVehicleDamages", Order = 216)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? KnownVehicleDamages { get; set; }

        /// <summary>
        /// Indicates that the vehicle meets the respective emission standard.
        /// </summary>
        [DataMember(Name = "meetsEmissionStandard", Order = 217)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, Uri>? MeetsEmissionStandard { get; set; }

        /// <summary>
        /// The total distance travelled by the particular vehicle since its initial production, as read from its odometer.&lt;/p&gt;
        /// &lt;p&gt;Typical unit code(s): KMT for kilometers, SMI for statute miles
        /// </summary>
        [DataMember(Name = "mileageFromOdometer", Order = 218)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<QuantitativeValue>? MileageFromOdometer { get; set; }

        /// <summary>
        /// The release date of a vehicle model (often used to differentiate versions of the same make and model).
        /// </summary>
        [DataMember(Name = "modelDate", Order = 219)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset?>? ModelDate { get; set; }

        /// <summary>
        /// The number or type of airbags in the vehicle.
        /// </summary>
        [DataMember(Name = "numberOfAirbags", Order = 220)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<int?, string>? NumberOfAirbags { get; set; }

        /// <summary>
        /// The number of axles.&lt;/p&gt;
        /// &lt;p&gt;Typical unit code(s): C62
        /// </summary>
        [DataMember(Name = "numberOfAxles", Order = 221)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<int?, QuantitativeValue>? NumberOfAxles { get; set; }

        /// <summary>
        /// The number of doors.&lt;/p&gt;
        /// &lt;p&gt;Typical unit code(s): C62
        /// </summary>
        [DataMember(Name = "numberOfDoors", Order = 222)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<int?, QuantitativeValue>? NumberOfDoors { get; set; }

        /// <summary>
        /// The total number of forward gears available for the transmission system of the vehicle.&lt;/p&gt;
        /// &lt;p&gt;Typical unit code(s): C62
        /// </summary>
        [DataMember(Name = "numberOfForwardGears", Order = 223)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<int?, QuantitativeValue>? NumberOfForwardGears { get; set; }

        /// <summary>
        /// The number of owners of the vehicle, including the current one.&lt;/p&gt;
        /// &lt;p&gt;Typical unit code(s): C62
        /// </summary>
        [DataMember(Name = "numberOfPreviousOwners", Order = 224)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<int?, QuantitativeValue>? NumberOfPreviousOwners { get; set; }

        /// <summary>
        /// &lt;p&gt;The permitted weight of passengers and cargo, EXCLUDING the weight of the empty vehicle.&lt;/p&gt;
        /// &lt;p&gt;Typical unit code(s): KGM for kilogram, LBR for pound&lt;/p&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Note 1: Many databases specify the permitted TOTAL weight instead, which is the sum of &lt;a class="localLink" href="http://schema.org/weight"&gt;weight&lt;/a&gt; and &lt;a class="localLink" href="http://schema.org/payload"&gt;payload&lt;/a&gt;&lt;/li&gt;
        /// &lt;li&gt;Note 2: You can indicate additional information in the &lt;a class="localLink" href="http://schema.org/name"&gt;name&lt;/a&gt; of the &lt;a class="localLink" href="http://schema.org/QuantitativeValue"&gt;QuantitativeValue&lt;/a&gt; node.&lt;/li&gt;
        /// &lt;li&gt;Note 3: You may also link to a &lt;a class="localLink" href="http://schema.org/QualitativeValue"&gt;QualitativeValue&lt;/a&gt; node that provides additional information using &lt;a class="localLink" href="http://schema.org/valueReference"&gt;valueReference&lt;/a&gt;.&lt;/li&gt;
        /// &lt;li&gt;Note 4: Note that you can use &lt;a class="localLink" href="http://schema.org/minValue"&gt;minValue&lt;/a&gt; and &lt;a class="localLink" href="http://schema.org/maxValue"&gt;maxValue&lt;/a&gt; to indicate ranges.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [DataMember(Name = "payload", Order = 225)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<QuantitativeValue>? Payload { get; set; }

        /// <summary>
        /// The date of production of the item, e.g. vehicle.
        /// </summary>
        [DataMember(Name = "productionDate", Order = 226)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<DateTimeOffset?>? ProductionDate { get; set; }

        /// <summary>
        /// The date the item e.g. vehicle was purchased by the current owner.
        /// </summary>
        [DataMember(Name = "purchaseDate", Order = 227)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<DateTimeOffset?>? PurchaseDate { get; set; }

        /// <summary>
        /// The number of persons that can be seated (e.g. in a vehicle), both in terms of the physical space available, and in terms of limitations set by law.&lt;/p&gt;
        /// &lt;p&gt;Typical unit code(s): C62 for persons
        /// </summary>
        [DataMember(Name = "seatingCapacity", Order = 228)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<double?, QuantitativeValue>? SeatingCapacity { get; set; }

        /// <summary>
        /// The speed range of the vehicle. If the vehicle is powered by an engine, the upper limit of the speed range (indicated by &lt;a class="localLink" href="http://schema.org/maxValue"&gt;maxValue&lt;/a&gt; should be the maximum speed achievable under regular conditions.&lt;/p&gt;
        /// &lt;p&gt;Typical unit code(s): KMH for km/h, HM for mile per hour (0.447 04 m/s), KNT for knot&lt;/p&gt;
        /// &lt;p&gt;*Note 1: Use &lt;a class="localLink" href="http://schema.org/minValue"&gt;minValue&lt;/a&gt; and &lt;a class="localLink" href="http://schema.org/maxValue"&gt;maxValue&lt;/a&gt; to indicate the range. Typically, the minimal value is zero.
        /// * Note 2: There are many different ways of measuring the speed range. You can link to information about how the given value has been determined using the &lt;a class="localLink" href="http://schema.org/valueReference"&gt;valueReference&lt;/a&gt; property.
        /// </summary>
        [DataMember(Name = "speed", Order = 229)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<QuantitativeValue>? Speed { get; set; }

        /// <summary>
        /// The position of the steering wheel or similar device (mostly for cars).
        /// </summary>
        [DataMember(Name = "steeringPosition", Order = 230)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<SteeringPositionValue?>? SteeringPosition { get; set; }

        /// <summary>
        /// &lt;p&gt;The permitted vertical load (TWR) of a trailer attached to the vehicle. Also referred to as Tongue Load Rating (TLR) or Vertical Load Rating (VLR)&lt;/p&gt;
        /// &lt;p&gt;Typical unit code(s): KGM for kilogram, LBR for pound&lt;/p&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Note 1: You can indicate additional information in the &lt;a class="localLink" href="http://schema.org/name"&gt;name&lt;/a&gt; of the &lt;a class="localLink" href="http://schema.org/QuantitativeValue"&gt;QuantitativeValue&lt;/a&gt; node.&lt;/li&gt;
        /// &lt;li&gt;Note 2: You may also link to a &lt;a class="localLink" href="http://schema.org/QualitativeValue"&gt;QualitativeValue&lt;/a&gt; node that provides additional information using &lt;a class="localLink" href="http://schema.org/valueReference"&gt;valueReference&lt;/a&gt;.&lt;/li&gt;
        /// &lt;li&gt;Note 3: Note that you can use &lt;a class="localLink" href="http://schema.org/minValue"&gt;minValue&lt;/a&gt; and &lt;a class="localLink" href="http://schema.org/maxValue"&gt;maxValue&lt;/a&gt; to indicate ranges.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [DataMember(Name = "tongueWeight", Order = 231)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<QuantitativeValue>? TongueWeight { get; set; }

        /// <summary>
        /// The permitted weight of a trailer attached to the vehicle.&lt;/p&gt;
        /// &lt;p&gt;Typical unit code(s): KGM for kilogram, LBR for pound
        /// * Note 1: You can indicate additional information in the &lt;a class="localLink" href="http://schema.org/name"&gt;name&lt;/a&gt; of the &lt;a class="localLink" href="http://schema.org/QuantitativeValue"&gt;QuantitativeValue&lt;/a&gt; node.
        /// * Note 2: You may also link to a &lt;a class="localLink" href="http://schema.org/QualitativeValue"&gt;QualitativeValue&lt;/a&gt; node that provides additional information using &lt;a class="localLink" href="http://schema.org/valueReference"&gt;valueReference&lt;/a&gt;.
        /// * Note 3: Note that you can use &lt;a class="localLink" href="http://schema.org/minValue"&gt;minValue&lt;/a&gt; and &lt;a class="localLink" href="http://schema.org/maxValue"&gt;maxValue&lt;/a&gt; to indicate ranges.
        /// </summary>
        [DataMember(Name = "trailerWeight", Order = 232)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<QuantitativeValue>? TrailerWeight { get; set; }

        /// <summary>
        /// A short text indicating the configuration of the vehicle, e.g. '5dr hatchback ST 2.5 MT 225 hp' or 'limited edition'.
        /// </summary>
        [DataMember(Name = "vehicleConfiguration", Order = 233)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? VehicleConfiguration { get; set; }

        /// <summary>
        /// Information about the engine or engines of the vehicle.
        /// </summary>
        [DataMember(Name = "vehicleEngine", Order = 234)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<EngineSpecification>? VehicleEngine { get; set; }

        /// <summary>
        /// The Vehicle Identification Number (VIN) is a unique serial number used by the automotive industry to identify individual motor vehicles.
        /// </summary>
        [DataMember(Name = "vehicleIdentificationNumber", Order = 235)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? VehicleIdentificationNumber { get; set; }

        /// <summary>
        /// The color or color combination of the interior of the vehicle.
        /// </summary>
        [DataMember(Name = "vehicleInteriorColor", Order = 236)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? VehicleInteriorColor { get; set; }

        /// <summary>
        /// The type or material of the interior of the vehicle (e.g. synthetic fabric, leather, wood, etc.). While most interior types are characterized by the material used, an interior type can also be based on vehicle usage or target audience.
        /// </summary>
        [DataMember(Name = "vehicleInteriorType", Order = 237)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? VehicleInteriorType { get; set; }

        /// <summary>
        /// The release date of a vehicle model (often used to differentiate versions of the same make and model).
        /// </summary>
        [DataMember(Name = "vehicleModelDate", Order = 238)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset?>? VehicleModelDate { get; set; }

        /// <summary>
        /// The number of passengers that can be seated in the vehicle, both in terms of the physical space available, and in terms of limitations set by law.&lt;/p&gt;
        /// &lt;p&gt;Typical unit code(s): C62 for persons.
        /// </summary>
        [DataMember(Name = "vehicleSeatingCapacity", Order = 239)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<double?, QuantitativeValue>? VehicleSeatingCapacity { get; set; }

        /// <summary>
        /// Indicates whether the vehicle has been used for special purposes, like commercial rental, driving school, or as a taxi. The legislation in many countries requires this information to be revealed when offering a car for sale.
        /// </summary>
        [DataMember(Name = "vehicleSpecialUsage", Order = 240)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? VehicleSpecialUsage { get; set; }

        /// <summary>
        /// The type of component used for transmitting the power from a rotating power source to the wheels or other relevant component(s) ("gearbox" for cars).
        /// </summary>
        [DataMember(Name = "vehicleTransmission", Order = 241)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, Uri>? VehicleTransmission { get; set; }

        /// <summary>
        /// &lt;p&gt;The permitted total weight of the loaded vehicle, including passengers and cargo and the weight of the empty vehicle.&lt;/p&gt;
        /// &lt;p&gt;Typical unit code(s): KGM for kilogram, LBR for pound&lt;/p&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Note 1: You can indicate additional information in the &lt;a class="localLink" href="http://schema.org/name"&gt;name&lt;/a&gt; of the &lt;a class="localLink" href="http://schema.org/QuantitativeValue"&gt;QuantitativeValue&lt;/a&gt; node.&lt;/li&gt;
        /// &lt;li&gt;Note 2: You may also link to a &lt;a class="localLink" href="http://schema.org/QualitativeValue"&gt;QualitativeValue&lt;/a&gt; node that provides additional information using &lt;a class="localLink" href="http://schema.org/valueReference"&gt;valueReference&lt;/a&gt;.&lt;/li&gt;
        /// &lt;li&gt;Note 3: Note that you can use &lt;a class="localLink" href="http://schema.org/minValue"&gt;minValue&lt;/a&gt; and &lt;a class="localLink" href="http://schema.org/maxValue"&gt;maxValue&lt;/a&gt; to indicate ranges.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [DataMember(Name = "weightTotal", Order = 242)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<QuantitativeValue>? WeightTotal { get; set; }

        /// <summary>
        /// The distance between the centers of the front and rear wheels.&lt;/p&gt;
        /// &lt;p&gt;Typical unit code(s): CMT for centimeters, MTR for meters, INH for inches, FOT for foot/feet
        /// </summary>
        [DataMember(Name = "wheelbase", Order = 243)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<QuantitativeValue>? Wheelbase { get; set; }
    }
}
