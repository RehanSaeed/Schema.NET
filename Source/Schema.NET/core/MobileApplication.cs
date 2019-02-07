namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A software application designed specifically to work well on a mobile device such as a telephone.
    /// </summary>
    [DataContract]
    public partial class MobileApplication : SoftwareApplication
    {
        public interface ICarrierRequirements : IValue {}
        public interface ICarrierRequirements<T> : ICarrierRequirements { new T Value { get; } }
        public class OneOrManyCarrierRequirements : OneOrMany<ICarrierRequirements>
        {
            public OneOrManyCarrierRequirements(ICarrierRequirements item) : base(item) { }
            public OneOrManyCarrierRequirements(IEnumerable<ICarrierRequirements> items) : base(items) { }
            public static implicit operator OneOrManyCarrierRequirements (string value) { return new OneOrManyCarrierRequirements (new CarrierRequirementsstring (value)); }
            public static implicit operator OneOrManyCarrierRequirements (string[] values) { return new OneOrManyCarrierRequirements (values.Select(v => (ICarrierRequirements) new CarrierRequirementsstring (v))); }
            public static implicit operator OneOrManyCarrierRequirements (List<string> values) { return new OneOrManyCarrierRequirements (values.Select(v => (ICarrierRequirements) new CarrierRequirementsstring (v))); }
        }
        public struct CarrierRequirementsstring : ICarrierRequirements<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public CarrierRequirementsstring (string value) { Value = value; }
            public static implicit operator CarrierRequirementsstring (string value) { return new CarrierRequirementsstring (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MobileApplication";

        /// <summary>
        /// Specifies specific carrier(s) requirements for the application (e.g. an application may only work on a specific carrier network).
        /// </summary>
        [DataMember(Name = "carrierRequirements", Order = 306)]
        public OneOrManyCarrierRequirements CarrierRequirements { get; set; }
    }
}
