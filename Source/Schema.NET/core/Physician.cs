using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A doctor's office.
    /// </summary>
    [DataContract]
    public partial class Physician : MedicalOrganization
    {
        public interface IAvailableService : IWrapper { }
        public interface IAvailableService<T> : IAvailableService { new T Data { get; set; } }
        public class AvailableServiceMedicalProcedure : IAvailableService<MedicalProcedure>
        {
            object IWrapper.Data { get { return Data; } set { Data = (MedicalProcedure) value; } }
            public virtual MedicalProcedure Data { get; set; }
            public AvailableServiceMedicalProcedure () { }
            public AvailableServiceMedicalProcedure (MedicalProcedure data) { Data = data; }
            public static implicit operator AvailableServiceMedicalProcedure (MedicalProcedure data) { return new AvailableServiceMedicalProcedure (data); }
        }

        public class AvailableServiceMedicalTest : IAvailableService<MedicalTest>
        {
            object IWrapper.Data { get { return Data; } set { Data = (MedicalTest) value; } }
            public virtual MedicalTest Data { get; set; }
            public AvailableServiceMedicalTest () { }
            public AvailableServiceMedicalTest (MedicalTest data) { Data = data; }
            public static implicit operator AvailableServiceMedicalTest (MedicalTest data) { return new AvailableServiceMedicalTest (data); }
        }

        public class AvailableServiceMedicalTherapy : IAvailableService<MedicalTherapy>
        {
            object IWrapper.Data { get { return Data; } set { Data = (MedicalTherapy) value; } }
            public virtual MedicalTherapy Data { get; set; }
            public AvailableServiceMedicalTherapy () { }
            public AvailableServiceMedicalTherapy (MedicalTherapy data) { Data = data; }
            public static implicit operator AvailableServiceMedicalTherapy (MedicalTherapy data) { return new AvailableServiceMedicalTherapy (data); }
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
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IAvailableService>? AvailableService { get; set; } //MedicalProcedure, MedicalTest, MedicalTherapy

        /// <summary>
        /// A hospital with which the physician or office is affiliated.
        /// </summary>
        [DataMember(Name = "hospitalAffiliation", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Hospital>? HospitalAffiliation { get; set; } 

        /// <summary>
        /// A medical specialty of the provider.
        /// </summary>
        [DataMember(Name = "medicalSpecialty", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<MedicalSpecialty>? MedicalSpecialty { get; set; } 
    }
}
