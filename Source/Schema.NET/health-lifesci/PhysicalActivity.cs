using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// Any bodily activity that enhances or maintains physical fitness and overall health and wellness. Includes activity that is part of daily living and routine, structured exercise, and exercise prescribed as part of a medical treatment or recovery plan.
    /// </summary>
    [DataContract]
    public partial class PhysicalActivity : LifestyleModification
    {
        public interface IAssociatedAnatomy : IWrapper { }
        public interface IAssociatedAnatomy<T> : IAssociatedAnatomy { new T Data { get; set; } }
        public class AssociatedAnatomyAnatomicalStructure : IAssociatedAnatomy<AnatomicalStructure>
        {
            object IWrapper.Data { get { return Data; } set { Data = (AnatomicalStructure) value; } }
            public virtual AnatomicalStructure Data { get; set; }
            public AssociatedAnatomyAnatomicalStructure () { }
            public AssociatedAnatomyAnatomicalStructure (AnatomicalStructure data) { Data = data; }
            public static implicit operator AssociatedAnatomyAnatomicalStructure (AnatomicalStructure data) { return new AssociatedAnatomyAnatomicalStructure (data); }
        }

        public class AssociatedAnatomyAnatomicalSystem : IAssociatedAnatomy<AnatomicalSystem>
        {
            object IWrapper.Data { get { return Data; } set { Data = (AnatomicalSystem) value; } }
            public virtual AnatomicalSystem Data { get; set; }
            public AssociatedAnatomyAnatomicalSystem () { }
            public AssociatedAnatomyAnatomicalSystem (AnatomicalSystem data) { Data = data; }
            public static implicit operator AssociatedAnatomyAnatomicalSystem (AnatomicalSystem data) { return new AssociatedAnatomyAnatomicalSystem (data); }
        }

        public class AssociatedAnatomySuperficialAnatomy : IAssociatedAnatomy<SuperficialAnatomy>
        {
            object IWrapper.Data { get { return Data; } set { Data = (SuperficialAnatomy) value; } }
            public virtual SuperficialAnatomy Data { get; set; }
            public AssociatedAnatomySuperficialAnatomy () { }
            public AssociatedAnatomySuperficialAnatomy (SuperficialAnatomy data) { Data = data; }
            public static implicit operator AssociatedAnatomySuperficialAnatomy (SuperficialAnatomy data) { return new AssociatedAnatomySuperficialAnatomy (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PhysicalActivity";

        /// <summary>
        /// The anatomy of the underlying organ system or structures associated with this entity.
        /// </summary>
        [DataMember(Name = "associatedAnatomy", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IAssociatedAnatomy>? AssociatedAnatomy { get; set; } //AnatomicalStructure, AnatomicalSystem, SuperficialAnatomy

        /// <summary>
        /// The characteristics of associated patients, such as age, gender, race etc.
        /// </summary>
        [DataMember(Name = "epidemiology", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Epidemiology { get; set; } 

        /// <summary>
        /// Changes in the normal mechanical, physical, and biochemical functions that are associated with this activity or condition.
        /// </summary>
        [DataMember(Name = "pathophysiology", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Pathophysiology { get; set; } 
    }
}
