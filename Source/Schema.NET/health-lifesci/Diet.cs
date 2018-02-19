using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A strategy of regulating the intake of food to achieve or maintain a specific health-related goal.
    /// </summary>
    [DataContract]
    public partial class Diet : CreativeWorkAndLifestyleModification
    {
        public interface IEndorsers : IWrapper { }
        public interface IEndorsers<T> : IEndorsers { new T Data { get; set; } }
        public class EndorsersOrganization : IEndorsers<Organization>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Organization) value; } }
            public virtual Organization Data { get; set; }
            public EndorsersOrganization () { }
            public EndorsersOrganization (Organization data) { Data = data; }
            public static implicit operator EndorsersOrganization (Organization data) { return new EndorsersOrganization (data); }
        }

        public class EndorsersPerson : IEndorsers<Person>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Person) value; } }
            public virtual Person Data { get; set; }
            public EndorsersPerson () { }
            public EndorsersPerson (Person data) { Data = data; }
            public static implicit operator EndorsersPerson (Person data) { return new EndorsersPerson (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Diet";

        /// <summary>
        /// Nutritional information specific to the dietary plan. May include dietary recommendations on what foods to avoid, what foods to consume, and specific alterations/deviations from the USDA or other regulatory body's approved dietary guidelines.
        /// </summary>
        [DataMember(Name = "dietFeatures", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? DietFeatures { get; set; } 

        /// <summary>
        /// People or organizations that endorse the plan.
        /// </summary>
        [DataMember(Name = "endorsers", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IEndorsers>? Endorsers { get; set; } //Organization, Person

        /// <summary>
        /// Medical expert advice related to the plan.
        /// </summary>
        [DataMember(Name = "expertConsiderations", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? ExpertConsiderations { get; set; } 

        /// <summary>
        /// Descriptive information establishing the overarching theory/philosophy of the plan. May include the rationale for the name, the population where the plan first came to prominence, etc.
        /// </summary>
        [DataMember(Name = "overview", Order = 309)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Overview { get; set; } 

        /// <summary>
        /// Specific physiologic benefits associated to the plan.
        /// </summary>
        [DataMember(Name = "physiologicalBenefits", Order = 310)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? PhysiologicalBenefits { get; set; } 

        /// <summary>
        /// Specific physiologic risks associated to the diet plan.
        /// </summary>
        [DataMember(Name = "risks", Order = 311)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Risks { get; set; } 
    }
}
