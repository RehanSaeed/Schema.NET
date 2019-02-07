namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// An intangible item that describes an alignment between a learning resource and a node in an educational framework.
    /// </summary>
    [DataContract]
    public partial class AlignmentObject : Intangible
    {
        public interface IAlignmentType : IValue {}
        public interface IAlignmentType<T> : IAlignmentType { new T Value { get; } }
        public class OneOrManyAlignmentType : OneOrMany<IAlignmentType>
        {
            public OneOrManyAlignmentType(IAlignmentType item) : base(item) { }
            public OneOrManyAlignmentType(IEnumerable<IAlignmentType> items) : base(items) { }
            public static implicit operator OneOrManyAlignmentType (string value) { return new OneOrManyAlignmentType (new AlignmentTypestring (value)); }
            public static implicit operator OneOrManyAlignmentType (string[] values) { return new OneOrManyAlignmentType (values.Select(v => (IAlignmentType) new AlignmentTypestring (v))); }
            public static implicit operator OneOrManyAlignmentType (List<string> values) { return new OneOrManyAlignmentType (values.Select(v => (IAlignmentType) new AlignmentTypestring (v))); }
        }
        public struct AlignmentTypestring : IAlignmentType<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public AlignmentTypestring (string value) { Value = value; }
            public static implicit operator AlignmentTypestring (string value) { return new AlignmentTypestring (value); }
        }

        public interface IEducationalFramework : IValue {}
        public interface IEducationalFramework<T> : IEducationalFramework { new T Value { get; } }
        public class OneOrManyEducationalFramework : OneOrMany<IEducationalFramework>
        {
            public OneOrManyEducationalFramework(IEducationalFramework item) : base(item) { }
            public OneOrManyEducationalFramework(IEnumerable<IEducationalFramework> items) : base(items) { }
            public static implicit operator OneOrManyEducationalFramework (string value) { return new OneOrManyEducationalFramework (new EducationalFrameworkstring (value)); }
            public static implicit operator OneOrManyEducationalFramework (string[] values) { return new OneOrManyEducationalFramework (values.Select(v => (IEducationalFramework) new EducationalFrameworkstring (v))); }
            public static implicit operator OneOrManyEducationalFramework (List<string> values) { return new OneOrManyEducationalFramework (values.Select(v => (IEducationalFramework) new EducationalFrameworkstring (v))); }
        }
        public struct EducationalFrameworkstring : IEducationalFramework<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public EducationalFrameworkstring (string value) { Value = value; }
            public static implicit operator EducationalFrameworkstring (string value) { return new EducationalFrameworkstring (value); }
        }

        public interface ITargetDescription : IValue {}
        public interface ITargetDescription<T> : ITargetDescription { new T Value { get; } }
        public class OneOrManyTargetDescription : OneOrMany<ITargetDescription>
        {
            public OneOrManyTargetDescription(ITargetDescription item) : base(item) { }
            public OneOrManyTargetDescription(IEnumerable<ITargetDescription> items) : base(items) { }
            public static implicit operator OneOrManyTargetDescription (string value) { return new OneOrManyTargetDescription (new TargetDescriptionstring (value)); }
            public static implicit operator OneOrManyTargetDescription (string[] values) { return new OneOrManyTargetDescription (values.Select(v => (ITargetDescription) new TargetDescriptionstring (v))); }
            public static implicit operator OneOrManyTargetDescription (List<string> values) { return new OneOrManyTargetDescription (values.Select(v => (ITargetDescription) new TargetDescriptionstring (v))); }
        }
        public struct TargetDescriptionstring : ITargetDescription<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public TargetDescriptionstring (string value) { Value = value; }
            public static implicit operator TargetDescriptionstring (string value) { return new TargetDescriptionstring (value); }
        }

        public interface ITargetName : IValue {}
        public interface ITargetName<T> : ITargetName { new T Value { get; } }
        public class OneOrManyTargetName : OneOrMany<ITargetName>
        {
            public OneOrManyTargetName(ITargetName item) : base(item) { }
            public OneOrManyTargetName(IEnumerable<ITargetName> items) : base(items) { }
            public static implicit operator OneOrManyTargetName (string value) { return new OneOrManyTargetName (new TargetNamestring (value)); }
            public static implicit operator OneOrManyTargetName (string[] values) { return new OneOrManyTargetName (values.Select(v => (ITargetName) new TargetNamestring (v))); }
            public static implicit operator OneOrManyTargetName (List<string> values) { return new OneOrManyTargetName (values.Select(v => (ITargetName) new TargetNamestring (v))); }
        }
        public struct TargetNamestring : ITargetName<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public TargetNamestring (string value) { Value = value; }
            public static implicit operator TargetNamestring (string value) { return new TargetNamestring (value); }
        }

        public interface ITargetUrl : IValue {}
        public interface ITargetUrl<T> : ITargetUrl { new T Value { get; } }
        public class OneOrManyTargetUrl : OneOrMany<ITargetUrl>
        {
            public OneOrManyTargetUrl(ITargetUrl item) : base(item) { }
            public OneOrManyTargetUrl(IEnumerable<ITargetUrl> items) : base(items) { }
            public static implicit operator OneOrManyTargetUrl (Uri value) { return new OneOrManyTargetUrl (new TargetUrlUri (value)); }
            public static implicit operator OneOrManyTargetUrl (Uri[] values) { return new OneOrManyTargetUrl (values.Select(v => (ITargetUrl) new TargetUrlUri (v))); }
            public static implicit operator OneOrManyTargetUrl (List<Uri> values) { return new OneOrManyTargetUrl (values.Select(v => (ITargetUrl) new TargetUrlUri (v))); }
        }
        public struct TargetUrlUri : ITargetUrl<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public TargetUrlUri (Uri value) { Value = value; }
            public static implicit operator TargetUrlUri (Uri value) { return new TargetUrlUri (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AlignmentObject";

        /// <summary>
        /// A category of alignment between the learning resource and the framework node. Recommended values include: 'assesses', 'teaches', 'requires', 'textComplexity', 'readingLevel', 'educationalSubject', and 'educationalLevel'.
        /// </summary>
        [DataMember(Name = "alignmentType", Order = 206)]
        public OneOrManyAlignmentType AlignmentType { get; set; }

        /// <summary>
        /// The framework to which the resource being described is aligned.
        /// </summary>
        [DataMember(Name = "educationalFramework", Order = 207)]
        public OneOrManyEducationalFramework EducationalFramework { get; set; }

        /// <summary>
        /// The description of a node in an established educational framework.
        /// </summary>
        [DataMember(Name = "targetDescription", Order = 208)]
        public OneOrManyTargetDescription TargetDescription { get; set; }

        /// <summary>
        /// The name of a node in an established educational framework.
        /// </summary>
        [DataMember(Name = "targetName", Order = 209)]
        public OneOrManyTargetName TargetName { get; set; }

        /// <summary>
        /// The URL of a node in an established educational framework.
        /// </summary>
        [DataMember(Name = "targetUrl", Order = 210)]
        public OneOrManyTargetUrl TargetUrl { get; set; }
    }
}
