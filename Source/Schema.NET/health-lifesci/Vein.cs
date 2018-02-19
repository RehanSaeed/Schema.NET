using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A type of blood vessel that specifically carries blood to the heart.
    /// </summary>
    [DataContract]
    public partial class Vein : Vessel
    {
        public interface IRegionDrained : IWrapper { }
        public interface IRegionDrained<T> : IRegionDrained { new T Data { get; set; } }
        public class RegionDrainedAnatomicalStructure : IRegionDrained<AnatomicalStructure>
        {
            object IWrapper.Data { get { return Data; } set { Data = (AnatomicalStructure) value; } }
            public virtual AnatomicalStructure Data { get; set; }
            public RegionDrainedAnatomicalStructure () { }
            public RegionDrainedAnatomicalStructure (AnatomicalStructure data) { Data = data; }
            public static implicit operator RegionDrainedAnatomicalStructure (AnatomicalStructure data) { return new RegionDrainedAnatomicalStructure (data); }
        }

        public class RegionDrainedAnatomicalSystem : IRegionDrained<AnatomicalSystem>
        {
            object IWrapper.Data { get { return Data; } set { Data = (AnatomicalSystem) value; } }
            public virtual AnatomicalSystem Data { get; set; }
            public RegionDrainedAnatomicalSystem () { }
            public RegionDrainedAnatomicalSystem (AnatomicalSystem data) { Data = data; }
            public static implicit operator RegionDrainedAnatomicalSystem (AnatomicalSystem data) { return new RegionDrainedAnatomicalSystem (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Vein";

        /// <summary>
        /// The vasculature that the vein drains into.
        /// </summary>
        [DataMember(Name = "drainsTo", Order = 406)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Vessel>? DrainsTo { get; set; } 

        /// <summary>
        /// The anatomical or organ system drained by this vessel; generally refers to a specific part of an organ.
        /// </summary>
        [DataMember(Name = "regionDrained", Order = 407)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IRegionDrained>? RegionDrained { get; set; } //AnatomicalStructure, AnatomicalSystem

        /// <summary>
        /// The anatomical or organ system that the vein flows into; a larger structure that the vein connects to.
        /// </summary>
        [DataMember(Name = "tributary", Order = 408)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<AnatomicalStructure>? Tributary { get; set; } 
    }
}
