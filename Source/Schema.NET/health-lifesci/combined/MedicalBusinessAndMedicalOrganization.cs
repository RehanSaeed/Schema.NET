namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// See MedicalBusiness, MedicalOrganization for more information.
    /// </summary>
    [DataContract]
    public abstract partial class MedicalBusinessAndMedicalOrganization : LocalBusinessAndOrganization
    {
        public interface IHealthPlanNetworkId : IValue {}
        public interface IHealthPlanNetworkId<T> : IHealthPlanNetworkId { new T Value { get; } }
        public class OneOrManyHealthPlanNetworkId : OneOrMany<IHealthPlanNetworkId>
        {
            public OneOrManyHealthPlanNetworkId(IHealthPlanNetworkId item) : base(item) { }
            public OneOrManyHealthPlanNetworkId(IEnumerable<IHealthPlanNetworkId> items) : base(items) { }
            public static implicit operator OneOrManyHealthPlanNetworkId (string value) { return new OneOrManyHealthPlanNetworkId (new HealthPlanNetworkIdstring (value)); }
            public static implicit operator OneOrManyHealthPlanNetworkId (string[] values) { return new OneOrManyHealthPlanNetworkId (values.Select(v => (IHealthPlanNetworkId) new HealthPlanNetworkIdstring (v))); }
            public static implicit operator OneOrManyHealthPlanNetworkId (List<string> values) { return new OneOrManyHealthPlanNetworkId (values.Select(v => (IHealthPlanNetworkId) new HealthPlanNetworkIdstring (v))); }
        }
        public struct HealthPlanNetworkIdstring : IHealthPlanNetworkId<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public HealthPlanNetworkIdstring (string value) { Value = value; }
            public static implicit operator HealthPlanNetworkIdstring (string value) { return new HealthPlanNetworkIdstring (value); }
        }

        public interface IIsAcceptingNewPatients : IValue {}
        public interface IIsAcceptingNewPatients<T> : IIsAcceptingNewPatients { new T Value { get; } }
        public class OneOrManyIsAcceptingNewPatients : OneOrMany<IIsAcceptingNewPatients>
        {
            public OneOrManyIsAcceptingNewPatients(IIsAcceptingNewPatients item) : base(item) { }
            public OneOrManyIsAcceptingNewPatients(IEnumerable<IIsAcceptingNewPatients> items) : base(items) { }
            public static implicit operator OneOrManyIsAcceptingNewPatients (bool value) { return new OneOrManyIsAcceptingNewPatients (new IsAcceptingNewPatientsbool (value)); }
            public static implicit operator OneOrManyIsAcceptingNewPatients (bool[] values) { return new OneOrManyIsAcceptingNewPatients (values.Select(v => (IIsAcceptingNewPatients) new IsAcceptingNewPatientsbool (v))); }
            public static implicit operator OneOrManyIsAcceptingNewPatients (List<bool> values) { return new OneOrManyIsAcceptingNewPatients (values.Select(v => (IIsAcceptingNewPatients) new IsAcceptingNewPatientsbool (v))); }
        }
        public struct IsAcceptingNewPatientsbool : IIsAcceptingNewPatients<bool>
        {
            object IValue.Value => this.Value;
            public bool Value { get; }
            public IsAcceptingNewPatientsbool (bool value) { Value = value; }
            public static implicit operator IsAcceptingNewPatientsbool (bool value) { return new IsAcceptingNewPatientsbool (value); }
        }

        public interface IMedicalSpecialty : IValue {}
        public interface IMedicalSpecialty<T> : IMedicalSpecialty { new T Value { get; } }
        public class OneOrManyMedicalSpecialty : OneOrMany<IMedicalSpecialty>
        {
            public OneOrManyMedicalSpecialty(IMedicalSpecialty item) : base(item) { }
            public OneOrManyMedicalSpecialty(IEnumerable<IMedicalSpecialty> items) : base(items) { }
            public static implicit operator OneOrManyMedicalSpecialty (MedicalSpecialty value) { return new OneOrManyMedicalSpecialty (new MedicalSpecialtyMedicalSpecialty (value)); }
            public static implicit operator OneOrManyMedicalSpecialty (MedicalSpecialty[] values) { return new OneOrManyMedicalSpecialty (values.Select(v => (IMedicalSpecialty) new MedicalSpecialtyMedicalSpecialty (v))); }
            public static implicit operator OneOrManyMedicalSpecialty (List<MedicalSpecialty> values) { return new OneOrManyMedicalSpecialty (values.Select(v => (IMedicalSpecialty) new MedicalSpecialtyMedicalSpecialty (v))); }
        }
        public struct MedicalSpecialtyMedicalSpecialty : IMedicalSpecialty<MedicalSpecialty>
        {
            object IValue.Value => this.Value;
            public MedicalSpecialty Value { get; }
            public MedicalSpecialtyMedicalSpecialty (MedicalSpecialty value) { Value = value; }
            public static implicit operator MedicalSpecialtyMedicalSpecialty (MedicalSpecialty value) { return new MedicalSpecialtyMedicalSpecialty (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalBusinessAndMedicalOrganization";

        /// <summary>
        /// Name or unique ID of network. (Networks are often reused across different insurance plans).
        /// </summary>
        [DataMember(Name = "healthPlanNetworkId", Order = 306)]
        public OneOrManyHealthPlanNetworkId HealthPlanNetworkId { get; set; }

        /// <summary>
        /// Whether the provider is accepting new patients.
        /// </summary>
        [DataMember(Name = "isAcceptingNewPatients", Order = 307)]
        public OneOrManyIsAcceptingNewPatients IsAcceptingNewPatients { get; set; }

        /// <summary>
        /// A medical specialty of the provider.
        /// </summary>
        [DataMember(Name = "medicalSpecialty", Order = 308)]
        public virtual OneOrManyMedicalSpecialty MedicalSpecialty { get; set; }
    }
}
