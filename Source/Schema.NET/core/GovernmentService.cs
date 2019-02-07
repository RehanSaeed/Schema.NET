namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A service provided by a government organization, e.g. food stamps, veterans benefits, etc.
    /// </summary>
    [DataContract]
    public partial class GovernmentService : Service
    {
        public interface IServiceOperator : IValue {}
        public interface IServiceOperator<T> : IServiceOperator { new T Value { get; } }
        public class OneOrManyServiceOperator : OneOrMany<IServiceOperator>
        {
            public OneOrManyServiceOperator(IServiceOperator item) : base(item) { }
            public OneOrManyServiceOperator(IEnumerable<IServiceOperator> items) : base(items) { }
            public static implicit operator OneOrManyServiceOperator (Organization value) { return new OneOrManyServiceOperator (new ServiceOperatorOrganization (value)); }
            public static implicit operator OneOrManyServiceOperator (Organization[] values) { return new OneOrManyServiceOperator (values.Select(v => (IServiceOperator) new ServiceOperatorOrganization (v))); }
            public static implicit operator OneOrManyServiceOperator (List<Organization> values) { return new OneOrManyServiceOperator (values.Select(v => (IServiceOperator) new ServiceOperatorOrganization (v))); }
        }
        public struct ServiceOperatorOrganization : IServiceOperator<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public ServiceOperatorOrganization (Organization value) { Value = value; }
            public static implicit operator ServiceOperatorOrganization (Organization value) { return new ServiceOperatorOrganization (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "GovernmentService";

        /// <summary>
        /// The operating organization, if different from the provider.  This enables the representation of services that are provided by an organization, but operated by another organization like a subcontractor.
        /// </summary>
        [DataMember(Name = "serviceOperator", Order = 306)]
        public OneOrManyServiceOperator ServiceOperator { get; set; }
    }
}
