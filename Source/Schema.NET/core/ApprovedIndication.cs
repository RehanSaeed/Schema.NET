namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An indication for a medical therapy that has been formally specified or approved by a regulatory body that regulates use of the therapy; for example, the US FDA approves indications for most drugs in the US.
    /// </summary>
    public partial interface IApprovedIndication : IMedicalIndication
    {
    }

    /// <summary>
    /// An indication for a medical therapy that has been formally specified or approved by a regulatory body that regulates use of the therapy; for example, the US FDA approves indications for most drugs in the US.
    /// </summary>
    [DataContract]
    public partial class ApprovedIndication : MedicalIndication, IApprovedIndication, IEquatable<ApprovedIndication>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ApprovedIndication";
    }
}
