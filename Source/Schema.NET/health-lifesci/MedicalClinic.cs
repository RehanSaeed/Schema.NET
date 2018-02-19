using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A facility, often associated with a hospital or medical school, that is devoted to the specific diagnosis and/or healthcare. Previously limited to outpatients but with evolution it may be open to inpatients as well.
    /// </summary>
    [DataContract]
    public partial class MedicalClinic : MedicalBusinessAndMedicalOrganization
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
        public override string Type => "MedicalClinic";

        /// <summary>
        /// A medical service available from this provider.
        /// </summary>
        [DataMember(Name = "availableService", Order = 406)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IAvailableService>? AvailableService { get; set; } //MedicalProcedure, MedicalTest, MedicalTherapy

        /// <summary>
        /// A medical specialty of the provider.
        /// </summary>
        [DataMember(Name = "medicalSpecialty", Order = 407)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<MedicalSpecialty>? MedicalSpecialty { get; set; } 
    }
}
