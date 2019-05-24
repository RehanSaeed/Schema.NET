namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Any collection of tests commonly ordered together.
    /// </summary>
    public partial interface IMedicalTestPanel : IMedicalTest
    {
        /// <summary>
        /// A component test of the panel.
        /// </summary>
        OneOrMany<IMedicalTest> SubTest { get; set; }
    }

    /// <summary>
    /// Any collection of tests commonly ordered together.
    /// </summary>
    [DataContract]
    public partial class MedicalTestPanel : MedicalTest, IMedicalTestPanel
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalTestPanel";

        /// <summary>
        /// A component test of the panel.
        /// </summary>
        [DataMember(Name = "subTest", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMedicalTest> SubTest { get; set; }
    }
}
