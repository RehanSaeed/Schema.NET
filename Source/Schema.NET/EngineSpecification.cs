namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Information about the engine of the vehicle. A vehicle can have multiple engines represented by multiple engine specification entities.
    /// </summary>
    [DataContract]
    public class EngineSpecification : StructuredValue
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "EngineSpecification";

        /// <summary>
        /// The type of fuel suitable for the engine or engines of the vehicle. If the vehicle has only one engine, this property can be attached directly to the vehicle.
        /// </summary>
        [DataMember(Name = "fuelType")]
        public object FuelType { get; protected set; }

        /// <summary>
        /// The type of fuel suitable for the engine or engines of the vehicle. If the vehicle has only one engine, this property can be attached directly to the vehicle.
        /// </summary>
        [IgnoreDataMember]
        public QualitativeValue FuelTypeQualitativeValue
        {
            get => this.FuelType as QualitativeValue;
            set => this.FuelType = value;
        }

        /// <summary>
        /// The type of fuel suitable for the engine or engines of the vehicle. If the vehicle has only one engine, this property can be attached directly to the vehicle.
        /// </summary>
        [IgnoreDataMember]
        public Uri FuelTypeURL
        {
            get => this.FuelType as Uri;
            set => this.FuelType = value;
        }

        /// <summary>
        /// The type of fuel suitable for the engine or engines of the vehicle. If the vehicle has only one engine, this property can be attached directly to the vehicle.
        /// </summary>
        [IgnoreDataMember]
        public string FuelTypeText
        {
            get => this.FuelType as string;
            set => this.FuelType = value;
        }
    }
}
