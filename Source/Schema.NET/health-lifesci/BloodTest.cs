namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A medical test performed on a sample of a patient's blood.
    /// </summary>
    public partial interface IBloodTest : IMedicalTest
    {
    }

    /// <summary>
    /// A medical test performed on a sample of a patient's blood.
    /// </summary>
    [DataContract]
    public partial class BloodTest : MedicalTest, IBloodTest
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BloodTest";
    }
}
