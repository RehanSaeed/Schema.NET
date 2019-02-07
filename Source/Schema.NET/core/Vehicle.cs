namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A vehicle is a device that is designed or used to transport people or cargo over land, water, air, or through space.
    /// </summary>
    [DataContract]
    public partial class Vehicle : Product
    {
        public interface IAccelerationTime : IValue {}
        public interface IAccelerationTime<T> : IAccelerationTime { new T Value { get; } }
        public class OneOrManyAccelerationTime : OneOrMany<IAccelerationTime>
        {
            public OneOrManyAccelerationTime(IAccelerationTime item) : base(item) { }
            public OneOrManyAccelerationTime(IEnumerable<IAccelerationTime> items) : base(items) { }
            public static implicit operator OneOrManyAccelerationTime (QuantitativeValue value) { return new OneOrManyAccelerationTime (new AccelerationTimeQuantitativeValue (value)); }
            public static implicit operator OneOrManyAccelerationTime (QuantitativeValue[] values) { return new OneOrManyAccelerationTime (values.Select(v => (IAccelerationTime) new AccelerationTimeQuantitativeValue (v))); }
            public static implicit operator OneOrManyAccelerationTime (List<QuantitativeValue> values) { return new OneOrManyAccelerationTime (values.Select(v => (IAccelerationTime) new AccelerationTimeQuantitativeValue (v))); }
        }
        public struct AccelerationTimeQuantitativeValue : IAccelerationTime<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public AccelerationTimeQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator AccelerationTimeQuantitativeValue (QuantitativeValue value) { return new AccelerationTimeQuantitativeValue (value); }
        }

        public interface IBodyType : IValue {}
        public interface IBodyType<T> : IBodyType { new T Value { get; } }
        public class OneOrManyBodyType : OneOrMany<IBodyType>
        {
            public OneOrManyBodyType(IBodyType item) : base(item) { }
            public OneOrManyBodyType(IEnumerable<IBodyType> items) : base(items) { }
            public static implicit operator OneOrManyBodyType (string value) { return new OneOrManyBodyType (new BodyTypestring (value)); }
            public static implicit operator OneOrManyBodyType (string[] values) { return new OneOrManyBodyType (values.Select(v => (IBodyType) new BodyTypestring (v))); }
            public static implicit operator OneOrManyBodyType (List<string> values) { return new OneOrManyBodyType (values.Select(v => (IBodyType) new BodyTypestring (v))); }
            public static implicit operator OneOrManyBodyType (Uri value) { return new OneOrManyBodyType (new BodyTypeUri (value)); }
            public static implicit operator OneOrManyBodyType (Uri[] values) { return new OneOrManyBodyType (values.Select(v => (IBodyType) new BodyTypeUri (v))); }
            public static implicit operator OneOrManyBodyType (List<Uri> values) { return new OneOrManyBodyType (values.Select(v => (IBodyType) new BodyTypeUri (v))); }
        }
        public struct BodyTypestring : IBodyType<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public BodyTypestring (string value) { Value = value; }
            public static implicit operator BodyTypestring (string value) { return new BodyTypestring (value); }
        }
        public struct BodyTypeUri : IBodyType<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public BodyTypeUri (Uri value) { Value = value; }
            public static implicit operator BodyTypeUri (Uri value) { return new BodyTypeUri (value); }
        }

        public interface ICargoVolume : IValue {}
        public interface ICargoVolume<T> : ICargoVolume { new T Value { get; } }
        public class OneOrManyCargoVolume : OneOrMany<ICargoVolume>
        {
            public OneOrManyCargoVolume(ICargoVolume item) : base(item) { }
            public OneOrManyCargoVolume(IEnumerable<ICargoVolume> items) : base(items) { }
            public static implicit operator OneOrManyCargoVolume (QuantitativeValue value) { return new OneOrManyCargoVolume (new CargoVolumeQuantitativeValue (value)); }
            public static implicit operator OneOrManyCargoVolume (QuantitativeValue[] values) { return new OneOrManyCargoVolume (values.Select(v => (ICargoVolume) new CargoVolumeQuantitativeValue (v))); }
            public static implicit operator OneOrManyCargoVolume (List<QuantitativeValue> values) { return new OneOrManyCargoVolume (values.Select(v => (ICargoVolume) new CargoVolumeQuantitativeValue (v))); }
        }
        public struct CargoVolumeQuantitativeValue : ICargoVolume<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public CargoVolumeQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator CargoVolumeQuantitativeValue (QuantitativeValue value) { return new CargoVolumeQuantitativeValue (value); }
        }

        public interface IDateVehicleFirstRegistered : IValue {}
        public interface IDateVehicleFirstRegistered<T> : IDateVehicleFirstRegistered { new T Value { get; } }
        public class OneOrManyDateVehicleFirstRegistered : OneOrMany<IDateVehicleFirstRegistered>
        {
            public OneOrManyDateVehicleFirstRegistered(IDateVehicleFirstRegistered item) : base(item) { }
            public OneOrManyDateVehicleFirstRegistered(IEnumerable<IDateVehicleFirstRegistered> items) : base(items) { }
            public static implicit operator OneOrManyDateVehicleFirstRegistered (DateTimeOffset value) { return new OneOrManyDateVehicleFirstRegistered (new DateVehicleFirstRegisteredDateTimeOffset (value)); }
            public static implicit operator OneOrManyDateVehicleFirstRegistered (DateTimeOffset[] values) { return new OneOrManyDateVehicleFirstRegistered (values.Select(v => (IDateVehicleFirstRegistered) new DateVehicleFirstRegisteredDateTimeOffset (v))); }
            public static implicit operator OneOrManyDateVehicleFirstRegistered (List<DateTimeOffset> values) { return new OneOrManyDateVehicleFirstRegistered (values.Select(v => (IDateVehicleFirstRegistered) new DateVehicleFirstRegisteredDateTimeOffset (v))); }
        }
        public struct DateVehicleFirstRegisteredDateTimeOffset : IDateVehicleFirstRegistered<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public DateVehicleFirstRegisteredDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator DateVehicleFirstRegisteredDateTimeOffset (DateTimeOffset value) { return new DateVehicleFirstRegisteredDateTimeOffset (value); }
        }

        public interface IDriveWheelConfiguration : IValue {}
        public interface IDriveWheelConfiguration<T> : IDriveWheelConfiguration { new T Value { get; } }
        public class OneOrManyDriveWheelConfiguration : OneOrMany<IDriveWheelConfiguration>
        {
            public OneOrManyDriveWheelConfiguration(IDriveWheelConfiguration item) : base(item) { }
            public OneOrManyDriveWheelConfiguration(IEnumerable<IDriveWheelConfiguration> items) : base(items) { }
            public static implicit operator OneOrManyDriveWheelConfiguration (DriveWheelConfigurationValue value) { return new OneOrManyDriveWheelConfiguration (new DriveWheelConfigurationDriveWheelConfigurationValue (value)); }
            public static implicit operator OneOrManyDriveWheelConfiguration (DriveWheelConfigurationValue[] values) { return new OneOrManyDriveWheelConfiguration (values.Select(v => (IDriveWheelConfiguration) new DriveWheelConfigurationDriveWheelConfigurationValue (v))); }
            public static implicit operator OneOrManyDriveWheelConfiguration (List<DriveWheelConfigurationValue> values) { return new OneOrManyDriveWheelConfiguration (values.Select(v => (IDriveWheelConfiguration) new DriveWheelConfigurationDriveWheelConfigurationValue (v))); }
            public static implicit operator OneOrManyDriveWheelConfiguration (string value) { return new OneOrManyDriveWheelConfiguration (new DriveWheelConfigurationstring (value)); }
            public static implicit operator OneOrManyDriveWheelConfiguration (string[] values) { return new OneOrManyDriveWheelConfiguration (values.Select(v => (IDriveWheelConfiguration) new DriveWheelConfigurationstring (v))); }
            public static implicit operator OneOrManyDriveWheelConfiguration (List<string> values) { return new OneOrManyDriveWheelConfiguration (values.Select(v => (IDriveWheelConfiguration) new DriveWheelConfigurationstring (v))); }
        }
        public struct DriveWheelConfigurationDriveWheelConfigurationValue : IDriveWheelConfiguration<DriveWheelConfigurationValue>
        {
            object IValue.Value => this.Value;
            public DriveWheelConfigurationValue Value { get; }
            public DriveWheelConfigurationDriveWheelConfigurationValue (DriveWheelConfigurationValue value) { Value = value; }
            public static implicit operator DriveWheelConfigurationDriveWheelConfigurationValue (DriveWheelConfigurationValue value) { return new DriveWheelConfigurationDriveWheelConfigurationValue (value); }
        }
        public struct DriveWheelConfigurationstring : IDriveWheelConfiguration<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public DriveWheelConfigurationstring (string value) { Value = value; }
            public static implicit operator DriveWheelConfigurationstring (string value) { return new DriveWheelConfigurationstring (value); }
        }

        public interface IEmissionsCO2 : IValue {}
        public interface IEmissionsCO2<T> : IEmissionsCO2 { new T Value { get; } }
        public class OneOrManyEmissionsCO2 : OneOrMany<IEmissionsCO2>
        {
            public OneOrManyEmissionsCO2(IEmissionsCO2 item) : base(item) { }
            public OneOrManyEmissionsCO2(IEnumerable<IEmissionsCO2> items) : base(items) { }
            public static implicit operator OneOrManyEmissionsCO2 (double value) { return new OneOrManyEmissionsCO2 (new EmissionsCO2double (value)); }
            public static implicit operator OneOrManyEmissionsCO2 (double[] values) { return new OneOrManyEmissionsCO2 (values.Select(v => (IEmissionsCO2) new EmissionsCO2double (v))); }
            public static implicit operator OneOrManyEmissionsCO2 (List<double> values) { return new OneOrManyEmissionsCO2 (values.Select(v => (IEmissionsCO2) new EmissionsCO2double (v))); }
        }
        public struct EmissionsCO2double : IEmissionsCO2<double>
        {
            object IValue.Value => this.Value;
            public double Value { get; }
            public EmissionsCO2double (double value) { Value = value; }
            public static implicit operator EmissionsCO2double (double value) { return new EmissionsCO2double (value); }
        }

        public interface IFuelCapacity : IValue {}
        public interface IFuelCapacity<T> : IFuelCapacity { new T Value { get; } }
        public class OneOrManyFuelCapacity : OneOrMany<IFuelCapacity>
        {
            public OneOrManyFuelCapacity(IFuelCapacity item) : base(item) { }
            public OneOrManyFuelCapacity(IEnumerable<IFuelCapacity> items) : base(items) { }
            public static implicit operator OneOrManyFuelCapacity (QuantitativeValue value) { return new OneOrManyFuelCapacity (new FuelCapacityQuantitativeValue (value)); }
            public static implicit operator OneOrManyFuelCapacity (QuantitativeValue[] values) { return new OneOrManyFuelCapacity (values.Select(v => (IFuelCapacity) new FuelCapacityQuantitativeValue (v))); }
            public static implicit operator OneOrManyFuelCapacity (List<QuantitativeValue> values) { return new OneOrManyFuelCapacity (values.Select(v => (IFuelCapacity) new FuelCapacityQuantitativeValue (v))); }
        }
        public struct FuelCapacityQuantitativeValue : IFuelCapacity<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public FuelCapacityQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator FuelCapacityQuantitativeValue (QuantitativeValue value) { return new FuelCapacityQuantitativeValue (value); }
        }

        public interface IFuelConsumption : IValue {}
        public interface IFuelConsumption<T> : IFuelConsumption { new T Value { get; } }
        public class OneOrManyFuelConsumption : OneOrMany<IFuelConsumption>
        {
            public OneOrManyFuelConsumption(IFuelConsumption item) : base(item) { }
            public OneOrManyFuelConsumption(IEnumerable<IFuelConsumption> items) : base(items) { }
            public static implicit operator OneOrManyFuelConsumption (QuantitativeValue value) { return new OneOrManyFuelConsumption (new FuelConsumptionQuantitativeValue (value)); }
            public static implicit operator OneOrManyFuelConsumption (QuantitativeValue[] values) { return new OneOrManyFuelConsumption (values.Select(v => (IFuelConsumption) new FuelConsumptionQuantitativeValue (v))); }
            public static implicit operator OneOrManyFuelConsumption (List<QuantitativeValue> values) { return new OneOrManyFuelConsumption (values.Select(v => (IFuelConsumption) new FuelConsumptionQuantitativeValue (v))); }
        }
        public struct FuelConsumptionQuantitativeValue : IFuelConsumption<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public FuelConsumptionQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator FuelConsumptionQuantitativeValue (QuantitativeValue value) { return new FuelConsumptionQuantitativeValue (value); }
        }

        public interface IFuelEfficiency : IValue {}
        public interface IFuelEfficiency<T> : IFuelEfficiency { new T Value { get; } }
        public class OneOrManyFuelEfficiency : OneOrMany<IFuelEfficiency>
        {
            public OneOrManyFuelEfficiency(IFuelEfficiency item) : base(item) { }
            public OneOrManyFuelEfficiency(IEnumerable<IFuelEfficiency> items) : base(items) { }
            public static implicit operator OneOrManyFuelEfficiency (QuantitativeValue value) { return new OneOrManyFuelEfficiency (new FuelEfficiencyQuantitativeValue (value)); }
            public static implicit operator OneOrManyFuelEfficiency (QuantitativeValue[] values) { return new OneOrManyFuelEfficiency (values.Select(v => (IFuelEfficiency) new FuelEfficiencyQuantitativeValue (v))); }
            public static implicit operator OneOrManyFuelEfficiency (List<QuantitativeValue> values) { return new OneOrManyFuelEfficiency (values.Select(v => (IFuelEfficiency) new FuelEfficiencyQuantitativeValue (v))); }
        }
        public struct FuelEfficiencyQuantitativeValue : IFuelEfficiency<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public FuelEfficiencyQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator FuelEfficiencyQuantitativeValue (QuantitativeValue value) { return new FuelEfficiencyQuantitativeValue (value); }
        }

        public interface IFuelType : IValue {}
        public interface IFuelType<T> : IFuelType { new T Value { get; } }
        public class OneOrManyFuelType : OneOrMany<IFuelType>
        {
            public OneOrManyFuelType(IFuelType item) : base(item) { }
            public OneOrManyFuelType(IEnumerable<IFuelType> items) : base(items) { }
            public static implicit operator OneOrManyFuelType (string value) { return new OneOrManyFuelType (new FuelTypestring (value)); }
            public static implicit operator OneOrManyFuelType (string[] values) { return new OneOrManyFuelType (values.Select(v => (IFuelType) new FuelTypestring (v))); }
            public static implicit operator OneOrManyFuelType (List<string> values) { return new OneOrManyFuelType (values.Select(v => (IFuelType) new FuelTypestring (v))); }
            public static implicit operator OneOrManyFuelType (Uri value) { return new OneOrManyFuelType (new FuelTypeUri (value)); }
            public static implicit operator OneOrManyFuelType (Uri[] values) { return new OneOrManyFuelType (values.Select(v => (IFuelType) new FuelTypeUri (v))); }
            public static implicit operator OneOrManyFuelType (List<Uri> values) { return new OneOrManyFuelType (values.Select(v => (IFuelType) new FuelTypeUri (v))); }
        }
        public struct FuelTypestring : IFuelType<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public FuelTypestring (string value) { Value = value; }
            public static implicit operator FuelTypestring (string value) { return new FuelTypestring (value); }
        }
        public struct FuelTypeUri : IFuelType<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public FuelTypeUri (Uri value) { Value = value; }
            public static implicit operator FuelTypeUri (Uri value) { return new FuelTypeUri (value); }
        }

        public interface IKnownVehicleDamages : IValue {}
        public interface IKnownVehicleDamages<T> : IKnownVehicleDamages { new T Value { get; } }
        public class OneOrManyKnownVehicleDamages : OneOrMany<IKnownVehicleDamages>
        {
            public OneOrManyKnownVehicleDamages(IKnownVehicleDamages item) : base(item) { }
            public OneOrManyKnownVehicleDamages(IEnumerable<IKnownVehicleDamages> items) : base(items) { }
            public static implicit operator OneOrManyKnownVehicleDamages (string value) { return new OneOrManyKnownVehicleDamages (new KnownVehicleDamagesstring (value)); }
            public static implicit operator OneOrManyKnownVehicleDamages (string[] values) { return new OneOrManyKnownVehicleDamages (values.Select(v => (IKnownVehicleDamages) new KnownVehicleDamagesstring (v))); }
            public static implicit operator OneOrManyKnownVehicleDamages (List<string> values) { return new OneOrManyKnownVehicleDamages (values.Select(v => (IKnownVehicleDamages) new KnownVehicleDamagesstring (v))); }
        }
        public struct KnownVehicleDamagesstring : IKnownVehicleDamages<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public KnownVehicleDamagesstring (string value) { Value = value; }
            public static implicit operator KnownVehicleDamagesstring (string value) { return new KnownVehicleDamagesstring (value); }
        }

        public interface IMeetsEmissionStandard : IValue {}
        public interface IMeetsEmissionStandard<T> : IMeetsEmissionStandard { new T Value { get; } }
        public class OneOrManyMeetsEmissionStandard : OneOrMany<IMeetsEmissionStandard>
        {
            public OneOrManyMeetsEmissionStandard(IMeetsEmissionStandard item) : base(item) { }
            public OneOrManyMeetsEmissionStandard(IEnumerable<IMeetsEmissionStandard> items) : base(items) { }
            public static implicit operator OneOrManyMeetsEmissionStandard (string value) { return new OneOrManyMeetsEmissionStandard (new MeetsEmissionStandardstring (value)); }
            public static implicit operator OneOrManyMeetsEmissionStandard (string[] values) { return new OneOrManyMeetsEmissionStandard (values.Select(v => (IMeetsEmissionStandard) new MeetsEmissionStandardstring (v))); }
            public static implicit operator OneOrManyMeetsEmissionStandard (List<string> values) { return new OneOrManyMeetsEmissionStandard (values.Select(v => (IMeetsEmissionStandard) new MeetsEmissionStandardstring (v))); }
            public static implicit operator OneOrManyMeetsEmissionStandard (Uri value) { return new OneOrManyMeetsEmissionStandard (new MeetsEmissionStandardUri (value)); }
            public static implicit operator OneOrManyMeetsEmissionStandard (Uri[] values) { return new OneOrManyMeetsEmissionStandard (values.Select(v => (IMeetsEmissionStandard) new MeetsEmissionStandardUri (v))); }
            public static implicit operator OneOrManyMeetsEmissionStandard (List<Uri> values) { return new OneOrManyMeetsEmissionStandard (values.Select(v => (IMeetsEmissionStandard) new MeetsEmissionStandardUri (v))); }
        }
        public struct MeetsEmissionStandardstring : IMeetsEmissionStandard<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public MeetsEmissionStandardstring (string value) { Value = value; }
            public static implicit operator MeetsEmissionStandardstring (string value) { return new MeetsEmissionStandardstring (value); }
        }
        public struct MeetsEmissionStandardUri : IMeetsEmissionStandard<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public MeetsEmissionStandardUri (Uri value) { Value = value; }
            public static implicit operator MeetsEmissionStandardUri (Uri value) { return new MeetsEmissionStandardUri (value); }
        }

        public interface IMileageFromOdometer : IValue {}
        public interface IMileageFromOdometer<T> : IMileageFromOdometer { new T Value { get; } }
        public class OneOrManyMileageFromOdometer : OneOrMany<IMileageFromOdometer>
        {
            public OneOrManyMileageFromOdometer(IMileageFromOdometer item) : base(item) { }
            public OneOrManyMileageFromOdometer(IEnumerable<IMileageFromOdometer> items) : base(items) { }
            public static implicit operator OneOrManyMileageFromOdometer (QuantitativeValue value) { return new OneOrManyMileageFromOdometer (new MileageFromOdometerQuantitativeValue (value)); }
            public static implicit operator OneOrManyMileageFromOdometer (QuantitativeValue[] values) { return new OneOrManyMileageFromOdometer (values.Select(v => (IMileageFromOdometer) new MileageFromOdometerQuantitativeValue (v))); }
            public static implicit operator OneOrManyMileageFromOdometer (List<QuantitativeValue> values) { return new OneOrManyMileageFromOdometer (values.Select(v => (IMileageFromOdometer) new MileageFromOdometerQuantitativeValue (v))); }
        }
        public struct MileageFromOdometerQuantitativeValue : IMileageFromOdometer<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public MileageFromOdometerQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator MileageFromOdometerQuantitativeValue (QuantitativeValue value) { return new MileageFromOdometerQuantitativeValue (value); }
        }

        public interface IModelDate : IValue {}
        public interface IModelDate<T> : IModelDate { new T Value { get; } }
        public class OneOrManyModelDate : OneOrMany<IModelDate>
        {
            public OneOrManyModelDate(IModelDate item) : base(item) { }
            public OneOrManyModelDate(IEnumerable<IModelDate> items) : base(items) { }
            public static implicit operator OneOrManyModelDate (DateTimeOffset value) { return new OneOrManyModelDate (new ModelDateDateTimeOffset (value)); }
            public static implicit operator OneOrManyModelDate (DateTimeOffset[] values) { return new OneOrManyModelDate (values.Select(v => (IModelDate) new ModelDateDateTimeOffset (v))); }
            public static implicit operator OneOrManyModelDate (List<DateTimeOffset> values) { return new OneOrManyModelDate (values.Select(v => (IModelDate) new ModelDateDateTimeOffset (v))); }
        }
        public struct ModelDateDateTimeOffset : IModelDate<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public ModelDateDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator ModelDateDateTimeOffset (DateTimeOffset value) { return new ModelDateDateTimeOffset (value); }
        }

        public interface INumberOfAirbags : IValue {}
        public interface INumberOfAirbags<T> : INumberOfAirbags { new T Value { get; } }
        public class OneOrManyNumberOfAirbags : OneOrMany<INumberOfAirbags>
        {
            public OneOrManyNumberOfAirbags(INumberOfAirbags item) : base(item) { }
            public OneOrManyNumberOfAirbags(IEnumerable<INumberOfAirbags> items) : base(items) { }
            public static implicit operator OneOrManyNumberOfAirbags (int value) { return new OneOrManyNumberOfAirbags (new NumberOfAirbagsint (value)); }
            public static implicit operator OneOrManyNumberOfAirbags (int[] values) { return new OneOrManyNumberOfAirbags (values.Select(v => (INumberOfAirbags) new NumberOfAirbagsint (v))); }
            public static implicit operator OneOrManyNumberOfAirbags (List<int> values) { return new OneOrManyNumberOfAirbags (values.Select(v => (INumberOfAirbags) new NumberOfAirbagsint (v))); }
            public static implicit operator OneOrManyNumberOfAirbags (string value) { return new OneOrManyNumberOfAirbags (new NumberOfAirbagsstring (value)); }
            public static implicit operator OneOrManyNumberOfAirbags (string[] values) { return new OneOrManyNumberOfAirbags (values.Select(v => (INumberOfAirbags) new NumberOfAirbagsstring (v))); }
            public static implicit operator OneOrManyNumberOfAirbags (List<string> values) { return new OneOrManyNumberOfAirbags (values.Select(v => (INumberOfAirbags) new NumberOfAirbagsstring (v))); }
        }
        public struct NumberOfAirbagsint : INumberOfAirbags<int>
        {
            object IValue.Value => this.Value;
            public int Value { get; }
            public NumberOfAirbagsint (int value) { Value = value; }
            public static implicit operator NumberOfAirbagsint (int value) { return new NumberOfAirbagsint (value); }
        }
        public struct NumberOfAirbagsstring : INumberOfAirbags<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public NumberOfAirbagsstring (string value) { Value = value; }
            public static implicit operator NumberOfAirbagsstring (string value) { return new NumberOfAirbagsstring (value); }
        }

        public interface INumberOfAxles : IValue {}
        public interface INumberOfAxles<T> : INumberOfAxles { new T Value { get; } }
        public class OneOrManyNumberOfAxles : OneOrMany<INumberOfAxles>
        {
            public OneOrManyNumberOfAxles(INumberOfAxles item) : base(item) { }
            public OneOrManyNumberOfAxles(IEnumerable<INumberOfAxles> items) : base(items) { }
            public static implicit operator OneOrManyNumberOfAxles (int value) { return new OneOrManyNumberOfAxles (new NumberOfAxlesint (value)); }
            public static implicit operator OneOrManyNumberOfAxles (int[] values) { return new OneOrManyNumberOfAxles (values.Select(v => (INumberOfAxles) new NumberOfAxlesint (v))); }
            public static implicit operator OneOrManyNumberOfAxles (List<int> values) { return new OneOrManyNumberOfAxles (values.Select(v => (INumberOfAxles) new NumberOfAxlesint (v))); }
            public static implicit operator OneOrManyNumberOfAxles (QuantitativeValue value) { return new OneOrManyNumberOfAxles (new NumberOfAxlesQuantitativeValue (value)); }
            public static implicit operator OneOrManyNumberOfAxles (QuantitativeValue[] values) { return new OneOrManyNumberOfAxles (values.Select(v => (INumberOfAxles) new NumberOfAxlesQuantitativeValue (v))); }
            public static implicit operator OneOrManyNumberOfAxles (List<QuantitativeValue> values) { return new OneOrManyNumberOfAxles (values.Select(v => (INumberOfAxles) new NumberOfAxlesQuantitativeValue (v))); }
        }
        public struct NumberOfAxlesint : INumberOfAxles<int>
        {
            object IValue.Value => this.Value;
            public int Value { get; }
            public NumberOfAxlesint (int value) { Value = value; }
            public static implicit operator NumberOfAxlesint (int value) { return new NumberOfAxlesint (value); }
        }
        public struct NumberOfAxlesQuantitativeValue : INumberOfAxles<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public NumberOfAxlesQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator NumberOfAxlesQuantitativeValue (QuantitativeValue value) { return new NumberOfAxlesQuantitativeValue (value); }
        }

        public interface INumberOfDoors : IValue {}
        public interface INumberOfDoors<T> : INumberOfDoors { new T Value { get; } }
        public class OneOrManyNumberOfDoors : OneOrMany<INumberOfDoors>
        {
            public OneOrManyNumberOfDoors(INumberOfDoors item) : base(item) { }
            public OneOrManyNumberOfDoors(IEnumerable<INumberOfDoors> items) : base(items) { }
            public static implicit operator OneOrManyNumberOfDoors (int value) { return new OneOrManyNumberOfDoors (new NumberOfDoorsint (value)); }
            public static implicit operator OneOrManyNumberOfDoors (int[] values) { return new OneOrManyNumberOfDoors (values.Select(v => (INumberOfDoors) new NumberOfDoorsint (v))); }
            public static implicit operator OneOrManyNumberOfDoors (List<int> values) { return new OneOrManyNumberOfDoors (values.Select(v => (INumberOfDoors) new NumberOfDoorsint (v))); }
            public static implicit operator OneOrManyNumberOfDoors (QuantitativeValue value) { return new OneOrManyNumberOfDoors (new NumberOfDoorsQuantitativeValue (value)); }
            public static implicit operator OneOrManyNumberOfDoors (QuantitativeValue[] values) { return new OneOrManyNumberOfDoors (values.Select(v => (INumberOfDoors) new NumberOfDoorsQuantitativeValue (v))); }
            public static implicit operator OneOrManyNumberOfDoors (List<QuantitativeValue> values) { return new OneOrManyNumberOfDoors (values.Select(v => (INumberOfDoors) new NumberOfDoorsQuantitativeValue (v))); }
        }
        public struct NumberOfDoorsint : INumberOfDoors<int>
        {
            object IValue.Value => this.Value;
            public int Value { get; }
            public NumberOfDoorsint (int value) { Value = value; }
            public static implicit operator NumberOfDoorsint (int value) { return new NumberOfDoorsint (value); }
        }
        public struct NumberOfDoorsQuantitativeValue : INumberOfDoors<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public NumberOfDoorsQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator NumberOfDoorsQuantitativeValue (QuantitativeValue value) { return new NumberOfDoorsQuantitativeValue (value); }
        }

        public interface INumberOfForwardGears : IValue {}
        public interface INumberOfForwardGears<T> : INumberOfForwardGears { new T Value { get; } }
        public class OneOrManyNumberOfForwardGears : OneOrMany<INumberOfForwardGears>
        {
            public OneOrManyNumberOfForwardGears(INumberOfForwardGears item) : base(item) { }
            public OneOrManyNumberOfForwardGears(IEnumerable<INumberOfForwardGears> items) : base(items) { }
            public static implicit operator OneOrManyNumberOfForwardGears (int value) { return new OneOrManyNumberOfForwardGears (new NumberOfForwardGearsint (value)); }
            public static implicit operator OneOrManyNumberOfForwardGears (int[] values) { return new OneOrManyNumberOfForwardGears (values.Select(v => (INumberOfForwardGears) new NumberOfForwardGearsint (v))); }
            public static implicit operator OneOrManyNumberOfForwardGears (List<int> values) { return new OneOrManyNumberOfForwardGears (values.Select(v => (INumberOfForwardGears) new NumberOfForwardGearsint (v))); }
            public static implicit operator OneOrManyNumberOfForwardGears (QuantitativeValue value) { return new OneOrManyNumberOfForwardGears (new NumberOfForwardGearsQuantitativeValue (value)); }
            public static implicit operator OneOrManyNumberOfForwardGears (QuantitativeValue[] values) { return new OneOrManyNumberOfForwardGears (values.Select(v => (INumberOfForwardGears) new NumberOfForwardGearsQuantitativeValue (v))); }
            public static implicit operator OneOrManyNumberOfForwardGears (List<QuantitativeValue> values) { return new OneOrManyNumberOfForwardGears (values.Select(v => (INumberOfForwardGears) new NumberOfForwardGearsQuantitativeValue (v))); }
        }
        public struct NumberOfForwardGearsint : INumberOfForwardGears<int>
        {
            object IValue.Value => this.Value;
            public int Value { get; }
            public NumberOfForwardGearsint (int value) { Value = value; }
            public static implicit operator NumberOfForwardGearsint (int value) { return new NumberOfForwardGearsint (value); }
        }
        public struct NumberOfForwardGearsQuantitativeValue : INumberOfForwardGears<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public NumberOfForwardGearsQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator NumberOfForwardGearsQuantitativeValue (QuantitativeValue value) { return new NumberOfForwardGearsQuantitativeValue (value); }
        }

        public interface INumberOfPreviousOwners : IValue {}
        public interface INumberOfPreviousOwners<T> : INumberOfPreviousOwners { new T Value { get; } }
        public class OneOrManyNumberOfPreviousOwners : OneOrMany<INumberOfPreviousOwners>
        {
            public OneOrManyNumberOfPreviousOwners(INumberOfPreviousOwners item) : base(item) { }
            public OneOrManyNumberOfPreviousOwners(IEnumerable<INumberOfPreviousOwners> items) : base(items) { }
            public static implicit operator OneOrManyNumberOfPreviousOwners (int value) { return new OneOrManyNumberOfPreviousOwners (new NumberOfPreviousOwnersint (value)); }
            public static implicit operator OneOrManyNumberOfPreviousOwners (int[] values) { return new OneOrManyNumberOfPreviousOwners (values.Select(v => (INumberOfPreviousOwners) new NumberOfPreviousOwnersint (v))); }
            public static implicit operator OneOrManyNumberOfPreviousOwners (List<int> values) { return new OneOrManyNumberOfPreviousOwners (values.Select(v => (INumberOfPreviousOwners) new NumberOfPreviousOwnersint (v))); }
            public static implicit operator OneOrManyNumberOfPreviousOwners (QuantitativeValue value) { return new OneOrManyNumberOfPreviousOwners (new NumberOfPreviousOwnersQuantitativeValue (value)); }
            public static implicit operator OneOrManyNumberOfPreviousOwners (QuantitativeValue[] values) { return new OneOrManyNumberOfPreviousOwners (values.Select(v => (INumberOfPreviousOwners) new NumberOfPreviousOwnersQuantitativeValue (v))); }
            public static implicit operator OneOrManyNumberOfPreviousOwners (List<QuantitativeValue> values) { return new OneOrManyNumberOfPreviousOwners (values.Select(v => (INumberOfPreviousOwners) new NumberOfPreviousOwnersQuantitativeValue (v))); }
        }
        public struct NumberOfPreviousOwnersint : INumberOfPreviousOwners<int>
        {
            object IValue.Value => this.Value;
            public int Value { get; }
            public NumberOfPreviousOwnersint (int value) { Value = value; }
            public static implicit operator NumberOfPreviousOwnersint (int value) { return new NumberOfPreviousOwnersint (value); }
        }
        public struct NumberOfPreviousOwnersQuantitativeValue : INumberOfPreviousOwners<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public NumberOfPreviousOwnersQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator NumberOfPreviousOwnersQuantitativeValue (QuantitativeValue value) { return new NumberOfPreviousOwnersQuantitativeValue (value); }
        }

        public interface IPayload : IValue {}
        public interface IPayload<T> : IPayload { new T Value { get; } }
        public class OneOrManyPayload : OneOrMany<IPayload>
        {
            public OneOrManyPayload(IPayload item) : base(item) { }
            public OneOrManyPayload(IEnumerable<IPayload> items) : base(items) { }
            public static implicit operator OneOrManyPayload (QuantitativeValue value) { return new OneOrManyPayload (new PayloadQuantitativeValue (value)); }
            public static implicit operator OneOrManyPayload (QuantitativeValue[] values) { return new OneOrManyPayload (values.Select(v => (IPayload) new PayloadQuantitativeValue (v))); }
            public static implicit operator OneOrManyPayload (List<QuantitativeValue> values) { return new OneOrManyPayload (values.Select(v => (IPayload) new PayloadQuantitativeValue (v))); }
        }
        public struct PayloadQuantitativeValue : IPayload<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public PayloadQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator PayloadQuantitativeValue (QuantitativeValue value) { return new PayloadQuantitativeValue (value); }
        }



        public interface ISeatingCapacity : IValue {}
        public interface ISeatingCapacity<T> : ISeatingCapacity { new T Value { get; } }
        public class OneOrManySeatingCapacity : OneOrMany<ISeatingCapacity>
        {
            public OneOrManySeatingCapacity(ISeatingCapacity item) : base(item) { }
            public OneOrManySeatingCapacity(IEnumerable<ISeatingCapacity> items) : base(items) { }
            public static implicit operator OneOrManySeatingCapacity (double value) { return new OneOrManySeatingCapacity (new SeatingCapacitydouble (value)); }
            public static implicit operator OneOrManySeatingCapacity (double[] values) { return new OneOrManySeatingCapacity (values.Select(v => (ISeatingCapacity) new SeatingCapacitydouble (v))); }
            public static implicit operator OneOrManySeatingCapacity (List<double> values) { return new OneOrManySeatingCapacity (values.Select(v => (ISeatingCapacity) new SeatingCapacitydouble (v))); }
            public static implicit operator OneOrManySeatingCapacity (QuantitativeValue value) { return new OneOrManySeatingCapacity (new SeatingCapacityQuantitativeValue (value)); }
            public static implicit operator OneOrManySeatingCapacity (QuantitativeValue[] values) { return new OneOrManySeatingCapacity (values.Select(v => (ISeatingCapacity) new SeatingCapacityQuantitativeValue (v))); }
            public static implicit operator OneOrManySeatingCapacity (List<QuantitativeValue> values) { return new OneOrManySeatingCapacity (values.Select(v => (ISeatingCapacity) new SeatingCapacityQuantitativeValue (v))); }
        }
        public struct SeatingCapacitydouble : ISeatingCapacity<double>
        {
            object IValue.Value => this.Value;
            public double Value { get; }
            public SeatingCapacitydouble (double value) { Value = value; }
            public static implicit operator SeatingCapacitydouble (double value) { return new SeatingCapacitydouble (value); }
        }
        public struct SeatingCapacityQuantitativeValue : ISeatingCapacity<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public SeatingCapacityQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator SeatingCapacityQuantitativeValue (QuantitativeValue value) { return new SeatingCapacityQuantitativeValue (value); }
        }

        public interface ISpeed : IValue {}
        public interface ISpeed<T> : ISpeed { new T Value { get; } }
        public class OneOrManySpeed : OneOrMany<ISpeed>
        {
            public OneOrManySpeed(ISpeed item) : base(item) { }
            public OneOrManySpeed(IEnumerable<ISpeed> items) : base(items) { }
            public static implicit operator OneOrManySpeed (QuantitativeValue value) { return new OneOrManySpeed (new SpeedQuantitativeValue (value)); }
            public static implicit operator OneOrManySpeed (QuantitativeValue[] values) { return new OneOrManySpeed (values.Select(v => (ISpeed) new SpeedQuantitativeValue (v))); }
            public static implicit operator OneOrManySpeed (List<QuantitativeValue> values) { return new OneOrManySpeed (values.Select(v => (ISpeed) new SpeedQuantitativeValue (v))); }
        }
        public struct SpeedQuantitativeValue : ISpeed<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public SpeedQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator SpeedQuantitativeValue (QuantitativeValue value) { return new SpeedQuantitativeValue (value); }
        }

        public interface ISteeringPosition : IValue {}
        public interface ISteeringPosition<T> : ISteeringPosition { new T Value { get; } }
        public class OneOrManySteeringPosition : OneOrMany<ISteeringPosition>
        {
            public OneOrManySteeringPosition(ISteeringPosition item) : base(item) { }
            public OneOrManySteeringPosition(IEnumerable<ISteeringPosition> items) : base(items) { }
            public static implicit operator OneOrManySteeringPosition (SteeringPositionValue value) { return new OneOrManySteeringPosition (new SteeringPositionSteeringPositionValue (value)); }
            public static implicit operator OneOrManySteeringPosition (SteeringPositionValue[] values) { return new OneOrManySteeringPosition (values.Select(v => (ISteeringPosition) new SteeringPositionSteeringPositionValue (v))); }
            public static implicit operator OneOrManySteeringPosition (List<SteeringPositionValue> values) { return new OneOrManySteeringPosition (values.Select(v => (ISteeringPosition) new SteeringPositionSteeringPositionValue (v))); }
        }
        public struct SteeringPositionSteeringPositionValue : ISteeringPosition<SteeringPositionValue>
        {
            object IValue.Value => this.Value;
            public SteeringPositionValue Value { get; }
            public SteeringPositionSteeringPositionValue (SteeringPositionValue value) { Value = value; }
            public static implicit operator SteeringPositionSteeringPositionValue (SteeringPositionValue value) { return new SteeringPositionSteeringPositionValue (value); }
        }

        public interface ITongueWeight : IValue {}
        public interface ITongueWeight<T> : ITongueWeight { new T Value { get; } }
        public class OneOrManyTongueWeight : OneOrMany<ITongueWeight>
        {
            public OneOrManyTongueWeight(ITongueWeight item) : base(item) { }
            public OneOrManyTongueWeight(IEnumerable<ITongueWeight> items) : base(items) { }
            public static implicit operator OneOrManyTongueWeight (QuantitativeValue value) { return new OneOrManyTongueWeight (new TongueWeightQuantitativeValue (value)); }
            public static implicit operator OneOrManyTongueWeight (QuantitativeValue[] values) { return new OneOrManyTongueWeight (values.Select(v => (ITongueWeight) new TongueWeightQuantitativeValue (v))); }
            public static implicit operator OneOrManyTongueWeight (List<QuantitativeValue> values) { return new OneOrManyTongueWeight (values.Select(v => (ITongueWeight) new TongueWeightQuantitativeValue (v))); }
        }
        public struct TongueWeightQuantitativeValue : ITongueWeight<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public TongueWeightQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator TongueWeightQuantitativeValue (QuantitativeValue value) { return new TongueWeightQuantitativeValue (value); }
        }

        public interface ITrailerWeight : IValue {}
        public interface ITrailerWeight<T> : ITrailerWeight { new T Value { get; } }
        public class OneOrManyTrailerWeight : OneOrMany<ITrailerWeight>
        {
            public OneOrManyTrailerWeight(ITrailerWeight item) : base(item) { }
            public OneOrManyTrailerWeight(IEnumerable<ITrailerWeight> items) : base(items) { }
            public static implicit operator OneOrManyTrailerWeight (QuantitativeValue value) { return new OneOrManyTrailerWeight (new TrailerWeightQuantitativeValue (value)); }
            public static implicit operator OneOrManyTrailerWeight (QuantitativeValue[] values) { return new OneOrManyTrailerWeight (values.Select(v => (ITrailerWeight) new TrailerWeightQuantitativeValue (v))); }
            public static implicit operator OneOrManyTrailerWeight (List<QuantitativeValue> values) { return new OneOrManyTrailerWeight (values.Select(v => (ITrailerWeight) new TrailerWeightQuantitativeValue (v))); }
        }
        public struct TrailerWeightQuantitativeValue : ITrailerWeight<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public TrailerWeightQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator TrailerWeightQuantitativeValue (QuantitativeValue value) { return new TrailerWeightQuantitativeValue (value); }
        }

        public interface IVehicleConfiguration : IValue {}
        public interface IVehicleConfiguration<T> : IVehicleConfiguration { new T Value { get; } }
        public class OneOrManyVehicleConfiguration : OneOrMany<IVehicleConfiguration>
        {
            public OneOrManyVehicleConfiguration(IVehicleConfiguration item) : base(item) { }
            public OneOrManyVehicleConfiguration(IEnumerable<IVehicleConfiguration> items) : base(items) { }
            public static implicit operator OneOrManyVehicleConfiguration (string value) { return new OneOrManyVehicleConfiguration (new VehicleConfigurationstring (value)); }
            public static implicit operator OneOrManyVehicleConfiguration (string[] values) { return new OneOrManyVehicleConfiguration (values.Select(v => (IVehicleConfiguration) new VehicleConfigurationstring (v))); }
            public static implicit operator OneOrManyVehicleConfiguration (List<string> values) { return new OneOrManyVehicleConfiguration (values.Select(v => (IVehicleConfiguration) new VehicleConfigurationstring (v))); }
        }
        public struct VehicleConfigurationstring : IVehicleConfiguration<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public VehicleConfigurationstring (string value) { Value = value; }
            public static implicit operator VehicleConfigurationstring (string value) { return new VehicleConfigurationstring (value); }
        }

        public interface IVehicleEngine : IValue {}
        public interface IVehicleEngine<T> : IVehicleEngine { new T Value { get; } }
        public class OneOrManyVehicleEngine : OneOrMany<IVehicleEngine>
        {
            public OneOrManyVehicleEngine(IVehicleEngine item) : base(item) { }
            public OneOrManyVehicleEngine(IEnumerable<IVehicleEngine> items) : base(items) { }
            public static implicit operator OneOrManyVehicleEngine (EngineSpecification value) { return new OneOrManyVehicleEngine (new VehicleEngineEngineSpecification (value)); }
            public static implicit operator OneOrManyVehicleEngine (EngineSpecification[] values) { return new OneOrManyVehicleEngine (values.Select(v => (IVehicleEngine) new VehicleEngineEngineSpecification (v))); }
            public static implicit operator OneOrManyVehicleEngine (List<EngineSpecification> values) { return new OneOrManyVehicleEngine (values.Select(v => (IVehicleEngine) new VehicleEngineEngineSpecification (v))); }
        }
        public struct VehicleEngineEngineSpecification : IVehicleEngine<EngineSpecification>
        {
            object IValue.Value => this.Value;
            public EngineSpecification Value { get; }
            public VehicleEngineEngineSpecification (EngineSpecification value) { Value = value; }
            public static implicit operator VehicleEngineEngineSpecification (EngineSpecification value) { return new VehicleEngineEngineSpecification (value); }
        }

        public interface IVehicleIdentificationNumber : IValue {}
        public interface IVehicleIdentificationNumber<T> : IVehicleIdentificationNumber { new T Value { get; } }
        public class OneOrManyVehicleIdentificationNumber : OneOrMany<IVehicleIdentificationNumber>
        {
            public OneOrManyVehicleIdentificationNumber(IVehicleIdentificationNumber item) : base(item) { }
            public OneOrManyVehicleIdentificationNumber(IEnumerable<IVehicleIdentificationNumber> items) : base(items) { }
            public static implicit operator OneOrManyVehicleIdentificationNumber (string value) { return new OneOrManyVehicleIdentificationNumber (new VehicleIdentificationNumberstring (value)); }
            public static implicit operator OneOrManyVehicleIdentificationNumber (string[] values) { return new OneOrManyVehicleIdentificationNumber (values.Select(v => (IVehicleIdentificationNumber) new VehicleIdentificationNumberstring (v))); }
            public static implicit operator OneOrManyVehicleIdentificationNumber (List<string> values) { return new OneOrManyVehicleIdentificationNumber (values.Select(v => (IVehicleIdentificationNumber) new VehicleIdentificationNumberstring (v))); }
        }
        public struct VehicleIdentificationNumberstring : IVehicleIdentificationNumber<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public VehicleIdentificationNumberstring (string value) { Value = value; }
            public static implicit operator VehicleIdentificationNumberstring (string value) { return new VehicleIdentificationNumberstring (value); }
        }

        public interface IVehicleInteriorColor : IValue {}
        public interface IVehicleInteriorColor<T> : IVehicleInteriorColor { new T Value { get; } }
        public class OneOrManyVehicleInteriorColor : OneOrMany<IVehicleInteriorColor>
        {
            public OneOrManyVehicleInteriorColor(IVehicleInteriorColor item) : base(item) { }
            public OneOrManyVehicleInteriorColor(IEnumerable<IVehicleInteriorColor> items) : base(items) { }
            public static implicit operator OneOrManyVehicleInteriorColor (string value) { return new OneOrManyVehicleInteriorColor (new VehicleInteriorColorstring (value)); }
            public static implicit operator OneOrManyVehicleInteriorColor (string[] values) { return new OneOrManyVehicleInteriorColor (values.Select(v => (IVehicleInteriorColor) new VehicleInteriorColorstring (v))); }
            public static implicit operator OneOrManyVehicleInteriorColor (List<string> values) { return new OneOrManyVehicleInteriorColor (values.Select(v => (IVehicleInteriorColor) new VehicleInteriorColorstring (v))); }
        }
        public struct VehicleInteriorColorstring : IVehicleInteriorColor<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public VehicleInteriorColorstring (string value) { Value = value; }
            public static implicit operator VehicleInteriorColorstring (string value) { return new VehicleInteriorColorstring (value); }
        }

        public interface IVehicleInteriorType : IValue {}
        public interface IVehicleInteriorType<T> : IVehicleInteriorType { new T Value { get; } }
        public class OneOrManyVehicleInteriorType : OneOrMany<IVehicleInteriorType>
        {
            public OneOrManyVehicleInteriorType(IVehicleInteriorType item) : base(item) { }
            public OneOrManyVehicleInteriorType(IEnumerable<IVehicleInteriorType> items) : base(items) { }
            public static implicit operator OneOrManyVehicleInteriorType (string value) { return new OneOrManyVehicleInteriorType (new VehicleInteriorTypestring (value)); }
            public static implicit operator OneOrManyVehicleInteriorType (string[] values) { return new OneOrManyVehicleInteriorType (values.Select(v => (IVehicleInteriorType) new VehicleInteriorTypestring (v))); }
            public static implicit operator OneOrManyVehicleInteriorType (List<string> values) { return new OneOrManyVehicleInteriorType (values.Select(v => (IVehicleInteriorType) new VehicleInteriorTypestring (v))); }
        }
        public struct VehicleInteriorTypestring : IVehicleInteriorType<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public VehicleInteriorTypestring (string value) { Value = value; }
            public static implicit operator VehicleInteriorTypestring (string value) { return new VehicleInteriorTypestring (value); }
        }

        public interface IVehicleModelDate : IValue {}
        public interface IVehicleModelDate<T> : IVehicleModelDate { new T Value { get; } }
        public class OneOrManyVehicleModelDate : OneOrMany<IVehicleModelDate>
        {
            public OneOrManyVehicleModelDate(IVehicleModelDate item) : base(item) { }
            public OneOrManyVehicleModelDate(IEnumerable<IVehicleModelDate> items) : base(items) { }
            public static implicit operator OneOrManyVehicleModelDate (DateTimeOffset value) { return new OneOrManyVehicleModelDate (new VehicleModelDateDateTimeOffset (value)); }
            public static implicit operator OneOrManyVehicleModelDate (DateTimeOffset[] values) { return new OneOrManyVehicleModelDate (values.Select(v => (IVehicleModelDate) new VehicleModelDateDateTimeOffset (v))); }
            public static implicit operator OneOrManyVehicleModelDate (List<DateTimeOffset> values) { return new OneOrManyVehicleModelDate (values.Select(v => (IVehicleModelDate) new VehicleModelDateDateTimeOffset (v))); }
        }
        public struct VehicleModelDateDateTimeOffset : IVehicleModelDate<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public VehicleModelDateDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator VehicleModelDateDateTimeOffset (DateTimeOffset value) { return new VehicleModelDateDateTimeOffset (value); }
        }

        public interface IVehicleSeatingCapacity : IValue {}
        public interface IVehicleSeatingCapacity<T> : IVehicleSeatingCapacity { new T Value { get; } }
        public class OneOrManyVehicleSeatingCapacity : OneOrMany<IVehicleSeatingCapacity>
        {
            public OneOrManyVehicleSeatingCapacity(IVehicleSeatingCapacity item) : base(item) { }
            public OneOrManyVehicleSeatingCapacity(IEnumerable<IVehicleSeatingCapacity> items) : base(items) { }
            public static implicit operator OneOrManyVehicleSeatingCapacity (double value) { return new OneOrManyVehicleSeatingCapacity (new VehicleSeatingCapacitydouble (value)); }
            public static implicit operator OneOrManyVehicleSeatingCapacity (double[] values) { return new OneOrManyVehicleSeatingCapacity (values.Select(v => (IVehicleSeatingCapacity) new VehicleSeatingCapacitydouble (v))); }
            public static implicit operator OneOrManyVehicleSeatingCapacity (List<double> values) { return new OneOrManyVehicleSeatingCapacity (values.Select(v => (IVehicleSeatingCapacity) new VehicleSeatingCapacitydouble (v))); }
            public static implicit operator OneOrManyVehicleSeatingCapacity (QuantitativeValue value) { return new OneOrManyVehicleSeatingCapacity (new VehicleSeatingCapacityQuantitativeValue (value)); }
            public static implicit operator OneOrManyVehicleSeatingCapacity (QuantitativeValue[] values) { return new OneOrManyVehicleSeatingCapacity (values.Select(v => (IVehicleSeatingCapacity) new VehicleSeatingCapacityQuantitativeValue (v))); }
            public static implicit operator OneOrManyVehicleSeatingCapacity (List<QuantitativeValue> values) { return new OneOrManyVehicleSeatingCapacity (values.Select(v => (IVehicleSeatingCapacity) new VehicleSeatingCapacityQuantitativeValue (v))); }
        }
        public struct VehicleSeatingCapacitydouble : IVehicleSeatingCapacity<double>
        {
            object IValue.Value => this.Value;
            public double Value { get; }
            public VehicleSeatingCapacitydouble (double value) { Value = value; }
            public static implicit operator VehicleSeatingCapacitydouble (double value) { return new VehicleSeatingCapacitydouble (value); }
        }
        public struct VehicleSeatingCapacityQuantitativeValue : IVehicleSeatingCapacity<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public VehicleSeatingCapacityQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator VehicleSeatingCapacityQuantitativeValue (QuantitativeValue value) { return new VehicleSeatingCapacityQuantitativeValue (value); }
        }

        public interface IVehicleSpecialUsage : IValue {}
        public interface IVehicleSpecialUsage<T> : IVehicleSpecialUsage { new T Value { get; } }
        public class OneOrManyVehicleSpecialUsage : OneOrMany<IVehicleSpecialUsage>
        {
            public OneOrManyVehicleSpecialUsage(IVehicleSpecialUsage item) : base(item) { }
            public OneOrManyVehicleSpecialUsage(IEnumerable<IVehicleSpecialUsage> items) : base(items) { }
            public static implicit operator OneOrManyVehicleSpecialUsage (string value) { return new OneOrManyVehicleSpecialUsage (new VehicleSpecialUsagestring (value)); }
            public static implicit operator OneOrManyVehicleSpecialUsage (string[] values) { return new OneOrManyVehicleSpecialUsage (values.Select(v => (IVehicleSpecialUsage) new VehicleSpecialUsagestring (v))); }
            public static implicit operator OneOrManyVehicleSpecialUsage (List<string> values) { return new OneOrManyVehicleSpecialUsage (values.Select(v => (IVehicleSpecialUsage) new VehicleSpecialUsagestring (v))); }
        }
        public struct VehicleSpecialUsagestring : IVehicleSpecialUsage<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public VehicleSpecialUsagestring (string value) { Value = value; }
            public static implicit operator VehicleSpecialUsagestring (string value) { return new VehicleSpecialUsagestring (value); }
        }

        public interface IVehicleTransmission : IValue {}
        public interface IVehicleTransmission<T> : IVehicleTransmission { new T Value { get; } }
        public class OneOrManyVehicleTransmission : OneOrMany<IVehicleTransmission>
        {
            public OneOrManyVehicleTransmission(IVehicleTransmission item) : base(item) { }
            public OneOrManyVehicleTransmission(IEnumerable<IVehicleTransmission> items) : base(items) { }
            public static implicit operator OneOrManyVehicleTransmission (string value) { return new OneOrManyVehicleTransmission (new VehicleTransmissionstring (value)); }
            public static implicit operator OneOrManyVehicleTransmission (string[] values) { return new OneOrManyVehicleTransmission (values.Select(v => (IVehicleTransmission) new VehicleTransmissionstring (v))); }
            public static implicit operator OneOrManyVehicleTransmission (List<string> values) { return new OneOrManyVehicleTransmission (values.Select(v => (IVehicleTransmission) new VehicleTransmissionstring (v))); }
            public static implicit operator OneOrManyVehicleTransmission (Uri value) { return new OneOrManyVehicleTransmission (new VehicleTransmissionUri (value)); }
            public static implicit operator OneOrManyVehicleTransmission (Uri[] values) { return new OneOrManyVehicleTransmission (values.Select(v => (IVehicleTransmission) new VehicleTransmissionUri (v))); }
            public static implicit operator OneOrManyVehicleTransmission (List<Uri> values) { return new OneOrManyVehicleTransmission (values.Select(v => (IVehicleTransmission) new VehicleTransmissionUri (v))); }
        }
        public struct VehicleTransmissionstring : IVehicleTransmission<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public VehicleTransmissionstring (string value) { Value = value; }
            public static implicit operator VehicleTransmissionstring (string value) { return new VehicleTransmissionstring (value); }
        }
        public struct VehicleTransmissionUri : IVehicleTransmission<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public VehicleTransmissionUri (Uri value) { Value = value; }
            public static implicit operator VehicleTransmissionUri (Uri value) { return new VehicleTransmissionUri (value); }
        }

        public interface IWeightTotal : IValue {}
        public interface IWeightTotal<T> : IWeightTotal { new T Value { get; } }
        public class OneOrManyWeightTotal : OneOrMany<IWeightTotal>
        {
            public OneOrManyWeightTotal(IWeightTotal item) : base(item) { }
            public OneOrManyWeightTotal(IEnumerable<IWeightTotal> items) : base(items) { }
            public static implicit operator OneOrManyWeightTotal (QuantitativeValue value) { return new OneOrManyWeightTotal (new WeightTotalQuantitativeValue (value)); }
            public static implicit operator OneOrManyWeightTotal (QuantitativeValue[] values) { return new OneOrManyWeightTotal (values.Select(v => (IWeightTotal) new WeightTotalQuantitativeValue (v))); }
            public static implicit operator OneOrManyWeightTotal (List<QuantitativeValue> values) { return new OneOrManyWeightTotal (values.Select(v => (IWeightTotal) new WeightTotalQuantitativeValue (v))); }
        }
        public struct WeightTotalQuantitativeValue : IWeightTotal<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public WeightTotalQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator WeightTotalQuantitativeValue (QuantitativeValue value) { return new WeightTotalQuantitativeValue (value); }
        }

        public interface IWheelbase : IValue {}
        public interface IWheelbase<T> : IWheelbase { new T Value { get; } }
        public class OneOrManyWheelbase : OneOrMany<IWheelbase>
        {
            public OneOrManyWheelbase(IWheelbase item) : base(item) { }
            public OneOrManyWheelbase(IEnumerable<IWheelbase> items) : base(items) { }
            public static implicit operator OneOrManyWheelbase (QuantitativeValue value) { return new OneOrManyWheelbase (new WheelbaseQuantitativeValue (value)); }
            public static implicit operator OneOrManyWheelbase (QuantitativeValue[] values) { return new OneOrManyWheelbase (values.Select(v => (IWheelbase) new WheelbaseQuantitativeValue (v))); }
            public static implicit operator OneOrManyWheelbase (List<QuantitativeValue> values) { return new OneOrManyWheelbase (values.Select(v => (IWheelbase) new WheelbaseQuantitativeValue (v))); }
        }
        public struct WheelbaseQuantitativeValue : IWheelbase<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public WheelbaseQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator WheelbaseQuantitativeValue (QuantitativeValue value) { return new WheelbaseQuantitativeValue (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Vehicle";

        /// <summary>
        /// The time needed to accelerate the vehicle from a given start velocity to a given target velocity.&lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): SEC for seconds&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Note: There are unfortunately no standard unit codes for seconds/0..100 km/h or seconds/0..60 mph. Simply use "SEC" for seconds and indicate the velocities in the &lt;a class="localLink" href="http://schema.org/name"&gt;name&lt;/a&gt; of the &lt;a class="localLink" href="http://schema.org/QuantitativeValue"&gt;QuantitativeValue&lt;/a&gt;, or use &lt;a class="localLink" href="http://schema.org/valueReference"&gt;valueReference&lt;/a&gt; with a &lt;a class="localLink" href="http://schema.org/QuantitativeValue"&gt;QuantitativeValue&lt;/a&gt; of 0..60 mph or 0..100 km/h to specify the reference speeds.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [DataMember(Name = "accelerationTime", Order = 206)]
        public OneOrManyAccelerationTime AccelerationTime { get; set; }

        /// <summary>
        /// Indicates the design and body style of the vehicle (e.g. station wagon, hatchback, etc.).
        /// </summary>
        [DataMember(Name = "bodyType", Order = 207)]
        public OneOrManyBodyType BodyType { get; set; }

        /// <summary>
        /// The available volume for cargo or luggage. For automobiles, this is usually the trunk volume.&lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): LTR for liters, FTQ for cubic foot/feet&lt;br/&gt;&lt;br/&gt;
        /// Note: You can use &lt;a class="localLink" href="http://schema.org/minValue"&gt;minValue&lt;/a&gt; and &lt;a class="localLink" href="http://schema.org/maxValue"&gt;maxValue&lt;/a&gt; to indicate ranges.
        /// </summary>
        [DataMember(Name = "cargoVolume", Order = 208)]
        public OneOrManyCargoVolume CargoVolume { get; set; }

        /// <summary>
        /// The date of the first registration of the vehicle with the respective public authorities.
        /// </summary>
        [DataMember(Name = "dateVehicleFirstRegistered", Order = 209)]
        public OneOrManyDateVehicleFirstRegistered DateVehicleFirstRegistered { get; set; }

        /// <summary>
        /// The drive wheel configuration, i.e. which roadwheels will receive torque from the vehicle's engine via the drivetrain.
        /// </summary>
        [DataMember(Name = "driveWheelConfiguration", Order = 210)]
        public OneOrManyDriveWheelConfiguration DriveWheelConfiguration { get; set; }

        /// <summary>
        /// The CO2 emissions in g/km. When used in combination with a QuantitativeValue, put "g/km" into the unitText property of that value, since there is no UN/CEFACT Common Code for "g/km".
        /// </summary>
        [DataMember(Name = "emissionsCO2", Order = 211)]
        public OneOrManyEmissionsCO2 EmissionsCO2 { get; set; }

        /// <summary>
        /// The capacity of the fuel tank or in the case of electric cars, the battery. If there are multiple components for storage, this should indicate the total of all storage of the same type.&lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): LTR for liters, GLL of US gallons, GLI for UK / imperial gallons, AMH for ampere-hours (for electrical vehicles).
        /// </summary>
        [DataMember(Name = "fuelCapacity", Order = 212)]
        public OneOrManyFuelCapacity FuelCapacity { get; set; }

        /// <summary>
        /// The amount of fuel consumed for traveling a particular distance or temporal duration with the given vehicle (e.g. liters per 100 km).&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Note 1: There are unfortunately no standard unit codes for liters per 100 km.  Use &lt;a class="localLink" href="http://schema.org/unitText"&gt;unitText&lt;/a&gt; to indicate the unit of measurement, e.g. L/100 km.&lt;/li&gt;
        /// &lt;li&gt;Note 2: There are two ways of indicating the fuel consumption, &lt;a class="localLink" href="http://schema.org/fuelConsumption"&gt;fuelConsumption&lt;/a&gt; (e.g. 8 liters per 100 km) and &lt;a class="localLink" href="http://schema.org/fuelEfficiency"&gt;fuelEfficiency&lt;/a&gt; (e.g. 30 miles per gallon). They are reciprocal.&lt;/li&gt;
        /// &lt;li&gt;Note 3: Often, the absolute value is useful only when related to driving speed ("at 80 km/h") or usage pattern ("city traffic"). You can use &lt;a class="localLink" href="http://schema.org/valueReference"&gt;valueReference&lt;/a&gt; to link the value for the fuel consumption to another value.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [DataMember(Name = "fuelConsumption", Order = 213)]
        public OneOrManyFuelConsumption FuelConsumption { get; set; }

        /// <summary>
        /// The distance traveled per unit of fuel used; most commonly miles per gallon (mpg) or kilometers per liter (km/L).&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Note 1: There are unfortunately no standard unit codes for miles per gallon or kilometers per liter. Use &lt;a class="localLink" href="http://schema.org/unitText"&gt;unitText&lt;/a&gt; to indicate the unit of measurement, e.g. mpg or km/L.&lt;/li&gt;
        /// &lt;li&gt;Note 2: There are two ways of indicating the fuel consumption, &lt;a class="localLink" href="http://schema.org/fuelConsumption"&gt;fuelConsumption&lt;/a&gt; (e.g. 8 liters per 100 km) and &lt;a class="localLink" href="http://schema.org/fuelEfficiency"&gt;fuelEfficiency&lt;/a&gt; (e.g. 30 miles per gallon). They are reciprocal.&lt;/li&gt;
        /// &lt;li&gt;Note 3: Often, the absolute value is useful only when related to driving speed ("at 80 km/h") or usage pattern ("city traffic"). You can use &lt;a class="localLink" href="http://schema.org/valueReference"&gt;valueReference&lt;/a&gt; to link the value for the fuel economy to another value.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [DataMember(Name = "fuelEfficiency", Order = 214)]
        public OneOrManyFuelEfficiency FuelEfficiency { get; set; }

        /// <summary>
        /// The type of fuel suitable for the engine or engines of the vehicle. If the vehicle has only one engine, this property can be attached directly to the vehicle.
        /// </summary>
        [DataMember(Name = "fuelType", Order = 215)]
        public OneOrManyFuelType FuelType { get; set; }

        /// <summary>
        /// A textual description of known damages, both repaired and unrepaired.
        /// </summary>
        [DataMember(Name = "knownVehicleDamages", Order = 216)]
        public OneOrManyKnownVehicleDamages KnownVehicleDamages { get; set; }

        /// <summary>
        /// Indicates that the vehicle meets the respective emission standard.
        /// </summary>
        [DataMember(Name = "meetsEmissionStandard", Order = 217)]
        public OneOrManyMeetsEmissionStandard MeetsEmissionStandard { get; set; }

        /// <summary>
        /// The total distance travelled by the particular vehicle since its initial production, as read from its odometer.&lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): KMT for kilometers, SMI for statute miles
        /// </summary>
        [DataMember(Name = "mileageFromOdometer", Order = 218)]
        public OneOrManyMileageFromOdometer MileageFromOdometer { get; set; }

        /// <summary>
        /// The release date of a vehicle model (often used to differentiate versions of the same make and model).
        /// </summary>
        [DataMember(Name = "modelDate", Order = 219)]
        public OneOrManyModelDate ModelDate { get; set; }

        /// <summary>
        /// The number or type of airbags in the vehicle.
        /// </summary>
        [DataMember(Name = "numberOfAirbags", Order = 220)]
        public OneOrManyNumberOfAirbags NumberOfAirbags { get; set; }

        /// <summary>
        /// The number of axles.&lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): C62
        /// </summary>
        [DataMember(Name = "numberOfAxles", Order = 221)]
        public OneOrManyNumberOfAxles NumberOfAxles { get; set; }

        /// <summary>
        /// The number of doors.&lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): C62
        /// </summary>
        [DataMember(Name = "numberOfDoors", Order = 222)]
        public OneOrManyNumberOfDoors NumberOfDoors { get; set; }

        /// <summary>
        /// The total number of forward gears available for the transmission system of the vehicle.&lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): C62
        /// </summary>
        [DataMember(Name = "numberOfForwardGears", Order = 223)]
        public OneOrManyNumberOfForwardGears NumberOfForwardGears { get; set; }

        /// <summary>
        /// The number of owners of the vehicle, including the current one.&lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): C62
        /// </summary>
        [DataMember(Name = "numberOfPreviousOwners", Order = 224)]
        public OneOrManyNumberOfPreviousOwners NumberOfPreviousOwners { get; set; }

        /// <summary>
        /// The permitted weight of passengers and cargo, EXCLUDING the weight of the empty vehicle.&lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): KGM for kilogram, LBR for pound&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Note 1: Many databases specify the permitted TOTAL weight instead, which is the sum of &lt;a class="localLink" href="http://schema.org/weight"&gt;weight&lt;/a&gt; and &lt;a class="localLink" href="http://schema.org/payload"&gt;payload&lt;/a&gt;&lt;/li&gt;
        /// &lt;li&gt;Note 2: You can indicate additional information in the &lt;a class="localLink" href="http://schema.org/name"&gt;name&lt;/a&gt; of the &lt;a class="localLink" href="http://schema.org/QuantitativeValue"&gt;QuantitativeValue&lt;/a&gt; node.&lt;/li&gt;
        /// &lt;li&gt;Note 3: You may also link to a &lt;a class="localLink" href="http://schema.org/QualitativeValue"&gt;QualitativeValue&lt;/a&gt; node that provides additional information using &lt;a class="localLink" href="http://schema.org/valueReference"&gt;valueReference&lt;/a&gt;.&lt;/li&gt;
        /// &lt;li&gt;Note 4: Note that you can use &lt;a class="localLink" href="http://schema.org/minValue"&gt;minValue&lt;/a&gt; and &lt;a class="localLink" href="http://schema.org/maxValue"&gt;maxValue&lt;/a&gt; to indicate ranges.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [DataMember(Name = "payload", Order = 225)]
        public OneOrManyPayload Payload { get; set; }

        /// <summary>
        /// The date of production of the item, e.g. vehicle.
        /// </summary>
        [DataMember(Name = "productionDate", Order = 226)]
        public override OneOrManyProductionDate ProductionDate { get; set; }

        /// <summary>
        /// The date the item e.g. vehicle was purchased by the current owner.
        /// </summary>
        [DataMember(Name = "purchaseDate", Order = 227)]
        public override OneOrManyPurchaseDate PurchaseDate { get; set; }

        /// <summary>
        /// The number of persons that can be seated (e.g. in a vehicle), both in terms of the physical space available, and in terms of limitations set by law.&lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): C62 for persons
        /// </summary>
        [DataMember(Name = "seatingCapacity", Order = 228)]
        public OneOrManySeatingCapacity SeatingCapacity { get; set; }

        /// <summary>
        /// The speed range of the vehicle. If the vehicle is powered by an engine, the upper limit of the speed range (indicated by &lt;a class="localLink" href="http://schema.org/maxValue"&gt;maxValue&lt;/a&gt; should be the maximum speed achievable under regular conditions.&lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): KMH for km/h, HM for mile per hour (0.447 04 m/s), KNT for knot&lt;br/&gt;&lt;br/&gt;
        /// *Note 1: Use &lt;a class="localLink" href="http://schema.org/minValue"&gt;minValue&lt;/a&gt; and &lt;a class="localLink" href="http://schema.org/maxValue"&gt;maxValue&lt;/a&gt; to indicate the range. Typically, the minimal value is zero.
        /// * Note 2: There are many different ways of measuring the speed range. You can link to information about how the given value has been determined using the &lt;a class="localLink" href="http://schema.org/valueReference"&gt;valueReference&lt;/a&gt; property.
        /// </summary>
        [DataMember(Name = "speed", Order = 229)]
        public OneOrManySpeed Speed { get; set; }

        /// <summary>
        /// The position of the steering wheel or similar device (mostly for cars).
        /// </summary>
        [DataMember(Name = "steeringPosition", Order = 230)]
        public OneOrManySteeringPosition SteeringPosition { get; set; }

        /// <summary>
        /// The permitted vertical load (TWR) of a trailer attached to the vehicle. Also referred to as Tongue Load Rating (TLR) or Vertical Load Rating (VLR)&lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): KGM for kilogram, LBR for pound&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Note 1: You can indicate additional information in the &lt;a class="localLink" href="http://schema.org/name"&gt;name&lt;/a&gt; of the &lt;a class="localLink" href="http://schema.org/QuantitativeValue"&gt;QuantitativeValue&lt;/a&gt; node.&lt;/li&gt;
        /// &lt;li&gt;Note 2: You may also link to a &lt;a class="localLink" href="http://schema.org/QualitativeValue"&gt;QualitativeValue&lt;/a&gt; node that provides additional information using &lt;a class="localLink" href="http://schema.org/valueReference"&gt;valueReference&lt;/a&gt;.&lt;/li&gt;
        /// &lt;li&gt;Note 3: Note that you can use &lt;a class="localLink" href="http://schema.org/minValue"&gt;minValue&lt;/a&gt; and &lt;a class="localLink" href="http://schema.org/maxValue"&gt;maxValue&lt;/a&gt; to indicate ranges.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [DataMember(Name = "tongueWeight", Order = 231)]
        public OneOrManyTongueWeight TongueWeight { get; set; }

        /// <summary>
        /// The permitted weight of a trailer attached to the vehicle.&lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): KGM for kilogram, LBR for pound
        /// * Note 1: You can indicate additional information in the &lt;a class="localLink" href="http://schema.org/name"&gt;name&lt;/a&gt; of the &lt;a class="localLink" href="http://schema.org/QuantitativeValue"&gt;QuantitativeValue&lt;/a&gt; node.
        /// * Note 2: You may also link to a &lt;a class="localLink" href="http://schema.org/QualitativeValue"&gt;QualitativeValue&lt;/a&gt; node that provides additional information using &lt;a class="localLink" href="http://schema.org/valueReference"&gt;valueReference&lt;/a&gt;.
        /// * Note 3: Note that you can use &lt;a class="localLink" href="http://schema.org/minValue"&gt;minValue&lt;/a&gt; and &lt;a class="localLink" href="http://schema.org/maxValue"&gt;maxValue&lt;/a&gt; to indicate ranges.
        /// </summary>
        [DataMember(Name = "trailerWeight", Order = 232)]
        public OneOrManyTrailerWeight TrailerWeight { get; set; }

        /// <summary>
        /// A short text indicating the configuration of the vehicle, e.g. '5dr hatchback ST 2.5 MT 225 hp' or 'limited edition'.
        /// </summary>
        [DataMember(Name = "vehicleConfiguration", Order = 233)]
        public OneOrManyVehicleConfiguration VehicleConfiguration { get; set; }

        /// <summary>
        /// Information about the engine or engines of the vehicle.
        /// </summary>
        [DataMember(Name = "vehicleEngine", Order = 234)]
        public OneOrManyVehicleEngine VehicleEngine { get; set; }

        /// <summary>
        /// The Vehicle Identification Number (VIN) is a unique serial number used by the automotive industry to identify individual motor vehicles.
        /// </summary>
        [DataMember(Name = "vehicleIdentificationNumber", Order = 235)]
        public OneOrManyVehicleIdentificationNumber VehicleIdentificationNumber { get; set; }

        /// <summary>
        /// The color or color combination of the interior of the vehicle.
        /// </summary>
        [DataMember(Name = "vehicleInteriorColor", Order = 236)]
        public OneOrManyVehicleInteriorColor VehicleInteriorColor { get; set; }

        /// <summary>
        /// The type or material of the interior of the vehicle (e.g. synthetic fabric, leather, wood, etc.). While most interior types are characterized by the material used, an interior type can also be based on vehicle usage or target audience.
        /// </summary>
        [DataMember(Name = "vehicleInteriorType", Order = 237)]
        public OneOrManyVehicleInteriorType VehicleInteriorType { get; set; }

        /// <summary>
        /// The release date of a vehicle model (often used to differentiate versions of the same make and model).
        /// </summary>
        [DataMember(Name = "vehicleModelDate", Order = 238)]
        public OneOrManyVehicleModelDate VehicleModelDate { get; set; }

        /// <summary>
        /// The number of passengers that can be seated in the vehicle, both in terms of the physical space available, and in terms of limitations set by law.&lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): C62 for persons.
        /// </summary>
        [DataMember(Name = "vehicleSeatingCapacity", Order = 239)]
        public OneOrManyVehicleSeatingCapacity VehicleSeatingCapacity { get; set; }

        /// <summary>
        /// Indicates whether the vehicle has been used for special purposes, like commercial rental, driving school, or as a taxi. The legislation in many countries requires this information to be revealed when offering a car for sale.
        /// </summary>
        [DataMember(Name = "vehicleSpecialUsage", Order = 240)]
        public OneOrManyVehicleSpecialUsage VehicleSpecialUsage { get; set; }

        /// <summary>
        /// The type of component used for transmitting the power from a rotating power source to the wheels or other relevant component(s) ("gearbox" for cars).
        /// </summary>
        [DataMember(Name = "vehicleTransmission", Order = 241)]
        public OneOrManyVehicleTransmission VehicleTransmission { get; set; }

        /// <summary>
        /// The permitted total weight of the loaded vehicle, including passengers and cargo and the weight of the empty vehicle.&lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): KGM for kilogram, LBR for pound&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Note 1: You can indicate additional information in the &lt;a class="localLink" href="http://schema.org/name"&gt;name&lt;/a&gt; of the &lt;a class="localLink" href="http://schema.org/QuantitativeValue"&gt;QuantitativeValue&lt;/a&gt; node.&lt;/li&gt;
        /// &lt;li&gt;Note 2: You may also link to a &lt;a class="localLink" href="http://schema.org/QualitativeValue"&gt;QualitativeValue&lt;/a&gt; node that provides additional information using &lt;a class="localLink" href="http://schema.org/valueReference"&gt;valueReference&lt;/a&gt;.&lt;/li&gt;
        /// &lt;li&gt;Note 3: Note that you can use &lt;a class="localLink" href="http://schema.org/minValue"&gt;minValue&lt;/a&gt; and &lt;a class="localLink" href="http://schema.org/maxValue"&gt;maxValue&lt;/a&gt; to indicate ranges.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [DataMember(Name = "weightTotal", Order = 242)]
        public OneOrManyWeightTotal WeightTotal { get; set; }

        /// <summary>
        /// The distance between the centers of the front and rear wheels.&lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): CMT for centimeters, MTR for meters, INH for inches, FOT for foot/feet
        /// </summary>
        [DataMember(Name = "wheelbase", Order = 243)]
        public OneOrManyWheelbase Wheelbase { get; set; }
    }
}
