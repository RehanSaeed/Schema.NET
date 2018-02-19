using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A common pathway for the electrochemical nerve impulses that are transmitted along each of the axons.
    /// </summary>
    [DataContract]
    public partial class Nerve : AnatomicalStructure
    {
        public interface ISensoryUnit : IWrapper { }
        public interface ISensoryUnit<T> : ISensoryUnit { new T Data { get; set; } }
        public class SensoryUnitAnatomicalStructure : ISensoryUnit<AnatomicalStructure>
        {
            object IWrapper.Data { get { return Data; } set { Data = (AnatomicalStructure) value; } }
            public virtual AnatomicalStructure Data { get; set; }
            public SensoryUnitAnatomicalStructure () { }
            public SensoryUnitAnatomicalStructure (AnatomicalStructure data) { Data = data; }
            public static implicit operator SensoryUnitAnatomicalStructure (AnatomicalStructure data) { return new SensoryUnitAnatomicalStructure (data); }
        }

        public class SensoryUnitSuperficialAnatomy : ISensoryUnit<SuperficialAnatomy>
        {
            object IWrapper.Data { get { return Data; } set { Data = (SuperficialAnatomy) value; } }
            public virtual SuperficialAnatomy Data { get; set; }
            public SensoryUnitSuperficialAnatomy () { }
            public SensoryUnitSuperficialAnatomy (SuperficialAnatomy data) { Data = data; }
            public static implicit operator SensoryUnitSuperficialAnatomy (SuperficialAnatomy data) { return new SensoryUnitSuperficialAnatomy (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Nerve";

        /// <summary>
        /// The neurological pathway extension that involves muscle control.
        /// </summary>
        [DataMember(Name = "nerveMotor", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Muscle>? NerveMotor { get; set; } 

        /// <summary>
        /// The neurological pathway extension that inputs and sends information to the brain or spinal cord.
        /// </summary>
        [DataMember(Name = "sensoryUnit", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ISensoryUnit>? SensoryUnit { get; set; } //AnatomicalStructure, SuperficialAnatomy

        /// <summary>
        /// The neurological pathway that originates the neurons.
        /// </summary>
        [DataMember(Name = "sourcedFrom", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<BrainStructure>? SourcedFrom { get; set; } 
    }
}
