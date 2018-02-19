using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// The anatomical location at which two or more bones make contact.
    /// </summary>
    [DataContract]
    public partial class Joint : AnatomicalStructure
    {
        public interface IFunctionalClass : IWrapper { }
        public interface IFunctionalClass<T> : IFunctionalClass { new T Data { get; set; } }
        public class FunctionalClassMedicalEntity : IFunctionalClass<MedicalEntity>
        {
            object IWrapper.Data { get { return Data; } set { Data = (MedicalEntity) value; } }
            public virtual MedicalEntity Data { get; set; }
            public FunctionalClassMedicalEntity () { }
            public FunctionalClassMedicalEntity (MedicalEntity data) { Data = data; }
            public static implicit operator FunctionalClassMedicalEntity (MedicalEntity data) { return new FunctionalClassMedicalEntity (data); }
        }

        public class FunctionalClassstring : IFunctionalClass<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public FunctionalClassstring () { }
            public FunctionalClassstring (string data) { Data = data; }
            public static implicit operator FunctionalClassstring (string data) { return new FunctionalClassstring (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Joint";

        /// <summary>
        /// The biomechanical properties of the bone.
        /// </summary>
        [DataMember(Name = "biomechnicalClass", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? BiomechnicalClass { get; set; } 

        /// <summary>
        /// The degree of mobility the joint allows.
        /// </summary>
        [DataMember(Name = "functionalClass", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IFunctionalClass>? FunctionalClass { get; set; } //MedicalEntity, string

        /// <summary>
        /// The name given to how bone physically connects to each other.
        /// </summary>
        [DataMember(Name = "structuralClass", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? StructuralClass { get; set; } 
    }
}
