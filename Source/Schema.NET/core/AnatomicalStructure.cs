namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Any part of the human body, typically a component of an anatomical system. Organs, tissues, and cells are all anatomical structures.
    /// </summary>
    public partial interface IAnatomicalStructure : IMedicalEntity
    {
        /// <summary>
        /// If applicable, a description of the pathophysiology associated with the anatomical system, including potential abnormal changes in the mechanical, physical, and biochemical functions of the system.
        /// </summary>
        OneOrMany<string> AssociatedPathophysiology { get; set; }

        /// <summary>
        /// Location in the body of the anatomical structure.
        /// </summary>
        OneOrMany<string> BodyLocation { get; set; }

        /// <summary>
        /// Other anatomical structures to which this structure is connected.
        /// </summary>
        OneOrMany<IAnatomicalStructure, AnatomicalStructure> ConnectedTo { get; set; }

        /// <summary>
        /// An image containing a diagram that illustrates the structure and/or its component substructures and/or connections with other structures.
        /// </summary>
        OneOrMany<IImageObject, ImageObject> Diagram { get; set; }

        /// <summary>
        /// Function of the anatomical structure.
        /// </summary>
        OneOrMany<string> Function { get; set; }

        /// <summary>
        /// The anatomical or organ system that this structure is part of.
        /// </summary>
        OneOrMany<IAnatomicalSystem, AnatomicalSystem> PartOfSystem { get; set; }

        /// <summary>
        /// A medical condition associated with this anatomy.
        /// </summary>
        OneOrMany<IMedicalCondition, MedicalCondition> RelatedCondition { get; set; }

        /// <summary>
        /// A medical therapy related to this anatomy.
        /// </summary>
        OneOrMany<IMedicalTherapy, MedicalTherapy> RelatedTherapy { get; set; }

        /// <summary>
        /// Component (sub-)structure(s) that comprise this anatomical structure.
        /// </summary>
        OneOrMany<IAnatomicalStructure, AnatomicalStructure> SubStructure { get; set; }
    }

    /// <summary>
    /// Any part of the human body, typically a component of an anatomical system. Organs, tissues, and cells are all anatomical structures.
    /// </summary>
    [DataContract]
    public partial class AnatomicalStructure : MedicalEntity, IAnatomicalStructure
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AnatomicalStructure";

        /// <summary>
        /// If applicable, a description of the pathophysiology associated with the anatomical system, including potential abnormal changes in the mechanical, physical, and biochemical functions of the system.
        /// </summary>
        [DataMember(Name = "associatedPathophysiology", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> AssociatedPathophysiology { get; set; }

        /// <summary>
        /// Location in the body of the anatomical structure.
        /// </summary>
        [DataMember(Name = "bodyLocation", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> BodyLocation { get; set; }

        /// <summary>
        /// Other anatomical structures to which this structure is connected.
        /// </summary>
        [DataMember(Name = "connectedTo", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IAnatomicalStructure, AnatomicalStructure> ConnectedTo { get; set; }

        /// <summary>
        /// An image containing a diagram that illustrates the structure and/or its component substructures and/or connections with other structures.
        /// </summary>
        [DataMember(Name = "diagram", Order = 209)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IImageObject, ImageObject> Diagram { get; set; }

        /// <summary>
        /// Function of the anatomical structure.
        /// </summary>
        [DataMember(Name = "function", Order = 210)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Function { get; set; }

        /// <summary>
        /// The anatomical or organ system that this structure is part of.
        /// </summary>
        [DataMember(Name = "partOfSystem", Order = 211)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IAnatomicalSystem, AnatomicalSystem> PartOfSystem { get; set; }

        /// <summary>
        /// A medical condition associated with this anatomy.
        /// </summary>
        [DataMember(Name = "relatedCondition", Order = 212)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMedicalCondition, MedicalCondition> RelatedCondition { get; set; }

        /// <summary>
        /// A medical therapy related to this anatomy.
        /// </summary>
        [DataMember(Name = "relatedTherapy", Order = 213)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMedicalTherapy, MedicalTherapy> RelatedTherapy { get; set; }

        /// <summary>
        /// Component (sub-)structure(s) that comprise this anatomical structure.
        /// </summary>
        [DataMember(Name = "subStructure", Order = 214)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IAnatomicalStructure, AnatomicalStructure> SubStructure { get; set; }
    }
}
