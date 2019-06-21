namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The base JSON-LD object.
    /// See https://json-ld.org/spec/latest/json-ld
    /// </summary>
    [DataContract]
    public class JsonLdObject
    {
        /// <summary>
        /// Gets the context used to define the short-hand names that are used throughout a JSON-LD document.
        /// These short-hand names are called terms and help developers to express specific identifiers in a compact
        /// manner.
        /// When two people communicate with one another, the conversation takes place in a shared environment,
        /// typically called "the context of the conversation". This shared context allows the individuals to use
        /// shortcut terms, like the first name of a mutual friend, to communicate more quickly but without losing
        /// accuracy. A context in JSON-LD works in the same way. It allows two applications to use shortcut terms to
        /// communicate with one another more efficiently, but without losing accuracy.
        /// Simply speaking, a context is used to map terms to IRIs. Terms are case sensitive and any valid string that
        /// is not a reserved JSON-LD keyword can be used as a term.
        /// </summary>
        [DataMember(Name = "@context", Order = 0)]
        [JsonConverter(typeof(ContextJsonConverter))]
        public virtual JsonLdContext Context { get; internal set; } = new JsonLdContext();

        /// <summary>
        /// Gets or sets the type, used to uniquely identify things that are being described in the document with IRIs
        /// or blank node identifiers.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public virtual string Type { get; }

        /// <summary>
        /// Gets or sets the identifier used to uniquely identify things that are being described in the document with
        /// IRIs or blank node identifiers.
        /// To be able to externally reference nodes in a graph, it is important that nodes have an identifier. IRIs
        /// are a fundamental concept of Linked Data, for nodes to be truly linked, dereferencing the identifier should
        /// result in a representation of that node.This may allow an application to retrieve further information about
        /// a node. In JSON-LD, a node is identified using the @id keyword:
        /// </summary>
        [DataMember(Name = "@id", Order = 2)]
        public virtual Uri Id { get; set; }
    }
}
