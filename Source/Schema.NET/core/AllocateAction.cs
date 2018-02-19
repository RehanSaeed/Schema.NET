using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// The act of organizing tasks/objects/events by associating resources to it.
    /// </summary>
    [DataContract]
    public partial class AllocateAction : OrganizeAction
    {
        public interface IPurpose : IWrapper { }
        public interface IPurpose<T> : IPurpose { new T Data { get; set; } }
        public class PurposeMedicalDevicePurpose : IPurpose<MedicalDevicePurpose>
        {
            object IWrapper.Data { get { return Data; } set { Data = (MedicalDevicePurpose) value; } }
            public virtual MedicalDevicePurpose Data { get; set; }
            public PurposeMedicalDevicePurpose () { }
            public PurposeMedicalDevicePurpose (MedicalDevicePurpose data) { Data = data; }
            public static implicit operator PurposeMedicalDevicePurpose (MedicalDevicePurpose data) { return new PurposeMedicalDevicePurpose (data); }
        }

        public class PurposeThing : IPurpose<Thing>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Thing) value; } }
            public virtual Thing Data { get; set; }
            public PurposeThing () { }
            public PurposeThing (Thing data) { Data = data; }
            public static implicit operator PurposeThing (Thing data) { return new PurposeThing (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AllocateAction";

        /// <summary>
        /// A goal towards an action is taken. Can be concrete or abstract.
        /// </summary>
        [DataMember(Name = "purpose", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IPurpose>? Purpose { get; set; } //MedicalDevicePurpose?, Thing
    }
}
