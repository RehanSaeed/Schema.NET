namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// Any medical test, typically performed for diagnostic purposes.
    /// </summary>
    [DataContract]
    public partial class MedicalTest : MedicalEntity
    {
        public interface IAffectedBy : IValue {}
        public interface IAffectedBy<T> : IAffectedBy { new T Value { get; } }
        public class OneOrManyAffectedBy : OneOrMany<IAffectedBy>
        {
            public OneOrManyAffectedBy(IAffectedBy item) : base(item) { }
            public OneOrManyAffectedBy(IEnumerable<IAffectedBy> items) : base(items) { }
            public static implicit operator OneOrManyAffectedBy (Drug value) { return new OneOrManyAffectedBy (new AffectedByDrug (value)); }
            public static implicit operator OneOrManyAffectedBy (Drug[] values) { return new OneOrManyAffectedBy (values.Select(v => (IAffectedBy) new AffectedByDrug (v))); }
            public static implicit operator OneOrManyAffectedBy (List<Drug> values) { return new OneOrManyAffectedBy (values.Select(v => (IAffectedBy) new AffectedByDrug (v))); }
        }
        public struct AffectedByDrug : IAffectedBy<Drug>
        {
            object IValue.Value => this.Value;
            public Drug Value { get; }
            public AffectedByDrug (Drug value) { Value = value; }
            public static implicit operator AffectedByDrug (Drug value) { return new AffectedByDrug (value); }
        }

        public interface INormalRange : IValue {}
        public interface INormalRange<T> : INormalRange { new T Value { get; } }
        public class OneOrManyNormalRange : OneOrMany<INormalRange>
        {
            public OneOrManyNormalRange(INormalRange item) : base(item) { }
            public OneOrManyNormalRange(IEnumerable<INormalRange> items) : base(items) { }
            public static implicit operator OneOrManyNormalRange (MedicalEnumeration value) { return new OneOrManyNormalRange (new NormalRangeMedicalEnumeration (value)); }
            public static implicit operator OneOrManyNormalRange (MedicalEnumeration[] values) { return new OneOrManyNormalRange (values.Select(v => (INormalRange) new NormalRangeMedicalEnumeration (v))); }
            public static implicit operator OneOrManyNormalRange (List<MedicalEnumeration> values) { return new OneOrManyNormalRange (values.Select(v => (INormalRange) new NormalRangeMedicalEnumeration (v))); }
            public static implicit operator OneOrManyNormalRange (string value) { return new OneOrManyNormalRange (new NormalRangestring (value)); }
            public static implicit operator OneOrManyNormalRange (string[] values) { return new OneOrManyNormalRange (values.Select(v => (INormalRange) new NormalRangestring (v))); }
            public static implicit operator OneOrManyNormalRange (List<string> values) { return new OneOrManyNormalRange (values.Select(v => (INormalRange) new NormalRangestring (v))); }
        }
        public struct NormalRangeMedicalEnumeration : INormalRange<MedicalEnumeration>
        {
            object IValue.Value => this.Value;
            public MedicalEnumeration Value { get; }
            public NormalRangeMedicalEnumeration (MedicalEnumeration value) { Value = value; }
            public static implicit operator NormalRangeMedicalEnumeration (MedicalEnumeration value) { return new NormalRangeMedicalEnumeration (value); }
        }
        public struct NormalRangestring : INormalRange<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public NormalRangestring (string value) { Value = value; }
            public static implicit operator NormalRangestring (string value) { return new NormalRangestring (value); }
        }

        public interface ISignDetected : IValue {}
        public interface ISignDetected<T> : ISignDetected { new T Value { get; } }
        public class OneOrManySignDetected : OneOrMany<ISignDetected>
        {
            public OneOrManySignDetected(ISignDetected item) : base(item) { }
            public OneOrManySignDetected(IEnumerable<ISignDetected> items) : base(items) { }
            public static implicit operator OneOrManySignDetected (MedicalSign value) { return new OneOrManySignDetected (new SignDetectedMedicalSign (value)); }
            public static implicit operator OneOrManySignDetected (MedicalSign[] values) { return new OneOrManySignDetected (values.Select(v => (ISignDetected) new SignDetectedMedicalSign (v))); }
            public static implicit operator OneOrManySignDetected (List<MedicalSign> values) { return new OneOrManySignDetected (values.Select(v => (ISignDetected) new SignDetectedMedicalSign (v))); }
        }
        public struct SignDetectedMedicalSign : ISignDetected<MedicalSign>
        {
            object IValue.Value => this.Value;
            public MedicalSign Value { get; }
            public SignDetectedMedicalSign (MedicalSign value) { Value = value; }
            public static implicit operator SignDetectedMedicalSign (MedicalSign value) { return new SignDetectedMedicalSign (value); }
        }

        public interface IUsedToDiagnose : IValue {}
        public interface IUsedToDiagnose<T> : IUsedToDiagnose { new T Value { get; } }
        public class OneOrManyUsedToDiagnose : OneOrMany<IUsedToDiagnose>
        {
            public OneOrManyUsedToDiagnose(IUsedToDiagnose item) : base(item) { }
            public OneOrManyUsedToDiagnose(IEnumerable<IUsedToDiagnose> items) : base(items) { }
            public static implicit operator OneOrManyUsedToDiagnose (MedicalCondition value) { return new OneOrManyUsedToDiagnose (new UsedToDiagnoseMedicalCondition (value)); }
            public static implicit operator OneOrManyUsedToDiagnose (MedicalCondition[] values) { return new OneOrManyUsedToDiagnose (values.Select(v => (IUsedToDiagnose) new UsedToDiagnoseMedicalCondition (v))); }
            public static implicit operator OneOrManyUsedToDiagnose (List<MedicalCondition> values) { return new OneOrManyUsedToDiagnose (values.Select(v => (IUsedToDiagnose) new UsedToDiagnoseMedicalCondition (v))); }
        }
        public struct UsedToDiagnoseMedicalCondition : IUsedToDiagnose<MedicalCondition>
        {
            object IValue.Value => this.Value;
            public MedicalCondition Value { get; }
            public UsedToDiagnoseMedicalCondition (MedicalCondition value) { Value = value; }
            public static implicit operator UsedToDiagnoseMedicalCondition (MedicalCondition value) { return new UsedToDiagnoseMedicalCondition (value); }
        }

        public interface IUsesDevice : IValue {}
        public interface IUsesDevice<T> : IUsesDevice { new T Value { get; } }
        public class OneOrManyUsesDevice : OneOrMany<IUsesDevice>
        {
            public OneOrManyUsesDevice(IUsesDevice item) : base(item) { }
            public OneOrManyUsesDevice(IEnumerable<IUsesDevice> items) : base(items) { }
            public static implicit operator OneOrManyUsesDevice (MedicalDevice value) { return new OneOrManyUsesDevice (new UsesDeviceMedicalDevice (value)); }
            public static implicit operator OneOrManyUsesDevice (MedicalDevice[] values) { return new OneOrManyUsesDevice (values.Select(v => (IUsesDevice) new UsesDeviceMedicalDevice (v))); }
            public static implicit operator OneOrManyUsesDevice (List<MedicalDevice> values) { return new OneOrManyUsesDevice (values.Select(v => (IUsesDevice) new UsesDeviceMedicalDevice (v))); }
        }
        public struct UsesDeviceMedicalDevice : IUsesDevice<MedicalDevice>
        {
            object IValue.Value => this.Value;
            public MedicalDevice Value { get; }
            public UsesDeviceMedicalDevice (MedicalDevice value) { Value = value; }
            public static implicit operator UsesDeviceMedicalDevice (MedicalDevice value) { return new UsesDeviceMedicalDevice (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalTest";

        /// <summary>
        /// Drugs that affect the test's results.
        /// </summary>
        [DataMember(Name = "affectedBy", Order = 206)]
        public OneOrManyAffectedBy AffectedBy { get; set; }

        /// <summary>
        /// Range of acceptable values for a typical patient, when applicable.
        /// </summary>
        [DataMember(Name = "normalRange", Order = 207)]
        public OneOrManyNormalRange NormalRange { get; set; }

        /// <summary>
        /// A sign detected by the test.
        /// </summary>
        [DataMember(Name = "signDetected", Order = 208)]
        public OneOrManySignDetected SignDetected { get; set; }

        /// <summary>
        /// A condition the test is used to diagnose.
        /// </summary>
        [DataMember(Name = "usedToDiagnose", Order = 209)]
        public OneOrManyUsedToDiagnose UsedToDiagnose { get; set; }

        /// <summary>
        /// Device used to perform the test.
        /// </summary>
        [DataMember(Name = "usesDevice", Order = 210)]
        public OneOrManyUsesDevice UsesDevice { get; set; }
    }
}
