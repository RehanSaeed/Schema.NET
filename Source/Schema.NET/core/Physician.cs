namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A doctor's office.
    /// </summary>
    [DataContract]
    public partial class Physician : MedicalOrganization
    {
        public interface IAvailableService : IValue {}
        public interface IAvailableService<T> : IAvailableService { new T Value { get; } }
        public class OneOrManyAvailableService : OneOrMany<IAvailableService>
        {
            public OneOrManyAvailableService(IAvailableService item) : base(item) { }
            public OneOrManyAvailableService(IEnumerable<IAvailableService> items) : base(items) { }
            public static implicit operator OneOrManyAvailableService (MedicalProcedure value) { return new OneOrManyAvailableService (new AvailableServiceMedicalProcedure (value)); }
            public static implicit operator OneOrManyAvailableService (MedicalProcedure[] values) { return new OneOrManyAvailableService (values.Select(v => (IAvailableService) new AvailableServiceMedicalProcedure (v))); }
            public static implicit operator OneOrManyAvailableService (List<MedicalProcedure> values) { return new OneOrManyAvailableService (values.Select(v => (IAvailableService) new AvailableServiceMedicalProcedure (v))); }
            public static implicit operator OneOrManyAvailableService (MedicalTest value) { return new OneOrManyAvailableService (new AvailableServiceMedicalTest (value)); }
            public static implicit operator OneOrManyAvailableService (MedicalTest[] values) { return new OneOrManyAvailableService (values.Select(v => (IAvailableService) new AvailableServiceMedicalTest (v))); }
            public static implicit operator OneOrManyAvailableService (List<MedicalTest> values) { return new OneOrManyAvailableService (values.Select(v => (IAvailableService) new AvailableServiceMedicalTest (v))); }
            public static implicit operator OneOrManyAvailableService (MedicalTherapy value) { return new OneOrManyAvailableService (new AvailableServiceMedicalTherapy (value)); }
            public static implicit operator OneOrManyAvailableService (MedicalTherapy[] values) { return new OneOrManyAvailableService (values.Select(v => (IAvailableService) new AvailableServiceMedicalTherapy (v))); }
            public static implicit operator OneOrManyAvailableService (List<MedicalTherapy> values) { return new OneOrManyAvailableService (values.Select(v => (IAvailableService) new AvailableServiceMedicalTherapy (v))); }
        }
        public struct AvailableServiceMedicalProcedure : IAvailableService<MedicalProcedure>
        {
            object IValue.Value => this.Value;
            public MedicalProcedure Value { get; }
            public AvailableServiceMedicalProcedure (MedicalProcedure value) { Value = value; }
            public static implicit operator AvailableServiceMedicalProcedure (MedicalProcedure value) { return new AvailableServiceMedicalProcedure (value); }
        }
        public struct AvailableServiceMedicalTest : IAvailableService<MedicalTest>
        {
            object IValue.Value => this.Value;
            public MedicalTest Value { get; }
            public AvailableServiceMedicalTest (MedicalTest value) { Value = value; }
            public static implicit operator AvailableServiceMedicalTest (MedicalTest value) { return new AvailableServiceMedicalTest (value); }
        }
        public struct AvailableServiceMedicalTherapy : IAvailableService<MedicalTherapy>
        {
            object IValue.Value => this.Value;
            public MedicalTherapy Value { get; }
            public AvailableServiceMedicalTherapy (MedicalTherapy value) { Value = value; }
            public static implicit operator AvailableServiceMedicalTherapy (MedicalTherapy value) { return new AvailableServiceMedicalTherapy (value); }
        }

        public interface IHospitalAffiliation : IValue {}
        public interface IHospitalAffiliation<T> : IHospitalAffiliation { new T Value { get; } }
        public class OneOrManyHospitalAffiliation : OneOrMany<IHospitalAffiliation>
        {
            public OneOrManyHospitalAffiliation(IHospitalAffiliation item) : base(item) { }
            public OneOrManyHospitalAffiliation(IEnumerable<IHospitalAffiliation> items) : base(items) { }
            public static implicit operator OneOrManyHospitalAffiliation (Hospital value) { return new OneOrManyHospitalAffiliation (new HospitalAffiliationHospital (value)); }
            public static implicit operator OneOrManyHospitalAffiliation (Hospital[] values) { return new OneOrManyHospitalAffiliation (values.Select(v => (IHospitalAffiliation) new HospitalAffiliationHospital (v))); }
            public static implicit operator OneOrManyHospitalAffiliation (List<Hospital> values) { return new OneOrManyHospitalAffiliation (values.Select(v => (IHospitalAffiliation) new HospitalAffiliationHospital (v))); }
        }
        public struct HospitalAffiliationHospital : IHospitalAffiliation<Hospital>
        {
            object IValue.Value => this.Value;
            public Hospital Value { get; }
            public HospitalAffiliationHospital (Hospital value) { Value = value; }
            public static implicit operator HospitalAffiliationHospital (Hospital value) { return new HospitalAffiliationHospital (value); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Physician";

        /// <summary>
        /// A medical service available from this provider.
        /// </summary>
        [DataMember(Name = "availableService", Order = 306)]
        public OneOrManyAvailableService AvailableService { get; set; }

        /// <summary>
        /// A hospital with which the physician or office is affiliated.
        /// </summary>
        [DataMember(Name = "hospitalAffiliation", Order = 307)]
        public OneOrManyHospitalAffiliation HospitalAffiliation { get; set; }

        /// <summary>
        /// A medical specialty of the provider.
        /// </summary>
        [DataMember(Name = "medicalSpecialty", Order = 308)]
        public override OneOrManyMedicalSpecialty MedicalSpecialty { get; set; }
    }
}
