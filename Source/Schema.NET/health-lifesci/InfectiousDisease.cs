namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// An infectious disease is a clinically evident human disease resulting from the presence of pathogenic microbial agents, like pathogenic viruses, pathogenic bacteria, fungi, protozoa, multicellular parasites, and prions. To be considered an infectious disease, such pathogens are known to be able to cause this disease.
    /// </summary>
    [DataContract]
    public partial class InfectiousDisease : MedicalCondition
    {
        public interface IInfectiousAgent : IValue {}
        public interface IInfectiousAgent<T> : IInfectiousAgent { new T Value { get; } }
        public class OneOrManyInfectiousAgent : OneOrMany<IInfectiousAgent>
        {
            public OneOrManyInfectiousAgent(IInfectiousAgent item) : base(item) { }
            public OneOrManyInfectiousAgent(IEnumerable<IInfectiousAgent> items) : base(items) { }
            public static implicit operator OneOrManyInfectiousAgent (string value) { return new OneOrManyInfectiousAgent (new InfectiousAgentstring (value)); }
            public static implicit operator OneOrManyInfectiousAgent (string[] values) { return new OneOrManyInfectiousAgent (values.Select(v => (IInfectiousAgent) new InfectiousAgentstring (v))); }
            public static implicit operator OneOrManyInfectiousAgent (List<string> values) { return new OneOrManyInfectiousAgent (values.Select(v => (IInfectiousAgent) new InfectiousAgentstring (v))); }
        }
        public struct InfectiousAgentstring : IInfectiousAgent<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public InfectiousAgentstring (string value) { Value = value; }
            public static implicit operator InfectiousAgentstring (string value) { return new InfectiousAgentstring (value); }
        }

        public interface IInfectiousAgentClass : IValue {}
        public interface IInfectiousAgentClass<T> : IInfectiousAgentClass { new T Value { get; } }
        public class OneOrManyInfectiousAgentClass : OneOrMany<IInfectiousAgentClass>
        {
            public OneOrManyInfectiousAgentClass(IInfectiousAgentClass item) : base(item) { }
            public OneOrManyInfectiousAgentClass(IEnumerable<IInfectiousAgentClass> items) : base(items) { }
            public static implicit operator OneOrManyInfectiousAgentClass (InfectiousAgentClass value) { return new OneOrManyInfectiousAgentClass (new InfectiousAgentClassInfectiousAgentClass (value)); }
            public static implicit operator OneOrManyInfectiousAgentClass (InfectiousAgentClass[] values) { return new OneOrManyInfectiousAgentClass (values.Select(v => (IInfectiousAgentClass) new InfectiousAgentClassInfectiousAgentClass (v))); }
            public static implicit operator OneOrManyInfectiousAgentClass (List<InfectiousAgentClass> values) { return new OneOrManyInfectiousAgentClass (values.Select(v => (IInfectiousAgentClass) new InfectiousAgentClassInfectiousAgentClass (v))); }
        }
        public struct InfectiousAgentClassInfectiousAgentClass : IInfectiousAgentClass<InfectiousAgentClass>
        {
            object IValue.Value => this.Value;
            public InfectiousAgentClass Value { get; }
            public InfectiousAgentClassInfectiousAgentClass (InfectiousAgentClass value) { Value = value; }
            public static implicit operator InfectiousAgentClassInfectiousAgentClass (InfectiousAgentClass value) { return new InfectiousAgentClassInfectiousAgentClass (value); }
        }

        public interface ITransmissionMethod : IValue {}
        public interface ITransmissionMethod<T> : ITransmissionMethod { new T Value { get; } }
        public class OneOrManyTransmissionMethod : OneOrMany<ITransmissionMethod>
        {
            public OneOrManyTransmissionMethod(ITransmissionMethod item) : base(item) { }
            public OneOrManyTransmissionMethod(IEnumerable<ITransmissionMethod> items) : base(items) { }
            public static implicit operator OneOrManyTransmissionMethod (string value) { return new OneOrManyTransmissionMethod (new TransmissionMethodstring (value)); }
            public static implicit operator OneOrManyTransmissionMethod (string[] values) { return new OneOrManyTransmissionMethod (values.Select(v => (ITransmissionMethod) new TransmissionMethodstring (v))); }
            public static implicit operator OneOrManyTransmissionMethod (List<string> values) { return new OneOrManyTransmissionMethod (values.Select(v => (ITransmissionMethod) new TransmissionMethodstring (v))); }
        }
        public struct TransmissionMethodstring : ITransmissionMethod<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public TransmissionMethodstring (string value) { Value = value; }
            public static implicit operator TransmissionMethodstring (string value) { return new TransmissionMethodstring (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "InfectiousDisease";

        /// <summary>
        /// The actual infectious agent, such as a specific bacterium.
        /// </summary>
        [DataMember(Name = "infectiousAgent", Order = 306)]
        public OneOrManyInfectiousAgent InfectiousAgent { get; set; }

        /// <summary>
        /// The class of infectious agent (bacteria, prion, etc.) that causes the disease.
        /// </summary>
        [DataMember(Name = "infectiousAgentClass", Order = 307)]
        public OneOrManyInfectiousAgentClass InfectiousAgentClass { get; set; }

        /// <summary>
        /// How the disease spreads, either as a route or vector, for example 'direct contact', 'Aedes aegypti', etc.
        /// </summary>
        [DataMember(Name = "transmissionMethod", Order = 308)]
        public OneOrManyTransmissionMethod TransmissionMethod { get; set; }
    }
}
