using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// Any medical test, typically performed for diagnostic purposes.
    /// </summary>
    [DataContract]
    public partial class MedicalTest : MedicalEntity
    {
        public interface INormalRange : IWrapper { }
        public interface INormalRange<T> : INormalRange { new T Data { get; set; } }
        public class NormalRangeMedicalEnumeration : INormalRange<MedicalEnumeration>
        {
            object IWrapper.Data { get { return Data; } set { Data = (MedicalEnumeration) value; } }
            public virtual MedicalEnumeration Data { get; set; }
            public NormalRangeMedicalEnumeration () { }
            public NormalRangeMedicalEnumeration (MedicalEnumeration data) { Data = data; }
            public static implicit operator NormalRangeMedicalEnumeration (MedicalEnumeration data) { return new NormalRangeMedicalEnumeration (data); }
        }

        public class NormalRangestring : INormalRange<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public NormalRangestring () { }
            public NormalRangestring (string data) { Data = data; }
            public static implicit operator NormalRangestring (string data) { return new NormalRangestring (data); }
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
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Drug>? AffectedBy { get; set; } 

        /// <summary>
        /// Range of acceptable values for a typical patient, when applicable.
        /// </summary>
        [DataMember(Name = "normalRange", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<INormalRange>? NormalRange { get; set; } //MedicalEnumeration?, string

        /// <summary>
        /// A sign detected by the test.
        /// </summary>
        [DataMember(Name = "signDetected", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MedicalSign>? SignDetected { get; set; } 

        /// <summary>
        /// A condition the test is used to diagnose.
        /// </summary>
        [DataMember(Name = "usedToDiagnose", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MedicalCondition>? UsedToDiagnose { get; set; } 

        /// <summary>
        /// Device used to perform the test.
        /// </summary>
        [DataMember(Name = "usesDevice", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MedicalDevice>? UsesDevice { get; set; } 
    }
}
