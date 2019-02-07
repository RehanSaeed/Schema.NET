namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// The legal availability status of a medical drug.
    /// </summary>
    [DataContract]
    public partial class DrugLegalStatus : MedicalIntangible
    {
        public interface IApplicableLocation : IValue {}
        public interface IApplicableLocation<T> : IApplicableLocation { new T Value { get; } }
        public class OneOrManyApplicableLocation : OneOrMany<IApplicableLocation>
        {
            public OneOrManyApplicableLocation(IApplicableLocation item) : base(item) { }
            public OneOrManyApplicableLocation(IEnumerable<IApplicableLocation> items) : base(items) { }
            public static implicit operator OneOrManyApplicableLocation (AdministrativeArea value) { return new OneOrManyApplicableLocation (new ApplicableLocationAdministrativeArea (value)); }
            public static implicit operator OneOrManyApplicableLocation (AdministrativeArea[] values) { return new OneOrManyApplicableLocation (values.Select(v => (IApplicableLocation) new ApplicableLocationAdministrativeArea (v))); }
            public static implicit operator OneOrManyApplicableLocation (List<AdministrativeArea> values) { return new OneOrManyApplicableLocation (values.Select(v => (IApplicableLocation) new ApplicableLocationAdministrativeArea (v))); }
        }
        public struct ApplicableLocationAdministrativeArea : IApplicableLocation<AdministrativeArea>
        {
            object IValue.Value => this.Value;
            public AdministrativeArea Value { get; }
            public ApplicableLocationAdministrativeArea (AdministrativeArea value) { Value = value; }
            public static implicit operator ApplicableLocationAdministrativeArea (AdministrativeArea value) { return new ApplicableLocationAdministrativeArea (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DrugLegalStatus";

        /// <summary>
        /// The location in which the status applies.
        /// </summary>
        [DataMember(Name = "applicableLocation", Order = 306)]
        public OneOrManyApplicableLocation ApplicableLocation { get; set; }
    }
}
