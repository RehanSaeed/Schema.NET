namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// An electronic file or document.
    /// </summary>
    [DataContract]
    public partial class DigitalDocument : CreativeWork
    {
        public interface IHasDigitalDocumentPermission : IValue {}
        public interface IHasDigitalDocumentPermission<T> : IHasDigitalDocumentPermission { new T Value { get; } }
        public class OneOrManyHasDigitalDocumentPermission : OneOrMany<IHasDigitalDocumentPermission>
        {
            public OneOrManyHasDigitalDocumentPermission(IHasDigitalDocumentPermission item) : base(item) { }
            public OneOrManyHasDigitalDocumentPermission(IEnumerable<IHasDigitalDocumentPermission> items) : base(items) { }
            public static implicit operator OneOrManyHasDigitalDocumentPermission (DigitalDocumentPermission value) { return new OneOrManyHasDigitalDocumentPermission (new HasDigitalDocumentPermissionDigitalDocumentPermission (value)); }
            public static implicit operator OneOrManyHasDigitalDocumentPermission (DigitalDocumentPermission[] values) { return new OneOrManyHasDigitalDocumentPermission (values.Select(v => (IHasDigitalDocumentPermission) new HasDigitalDocumentPermissionDigitalDocumentPermission (v))); }
            public static implicit operator OneOrManyHasDigitalDocumentPermission (List<DigitalDocumentPermission> values) { return new OneOrManyHasDigitalDocumentPermission (values.Select(v => (IHasDigitalDocumentPermission) new HasDigitalDocumentPermissionDigitalDocumentPermission (v))); }
        }
        public struct HasDigitalDocumentPermissionDigitalDocumentPermission : IHasDigitalDocumentPermission<DigitalDocumentPermission>
        {
            object IValue.Value => this.Value;
            public DigitalDocumentPermission Value { get; }
            public HasDigitalDocumentPermissionDigitalDocumentPermission (DigitalDocumentPermission value) { Value = value; }
            public static implicit operator HasDigitalDocumentPermissionDigitalDocumentPermission (DigitalDocumentPermission value) { return new HasDigitalDocumentPermissionDigitalDocumentPermission (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DigitalDocument";

        /// <summary>
        /// A permission related to the access to this document (e.g. permission to read or write an electronic document). For a public document, specify a grantee with an Audience with audienceType equal to "public".
        /// </summary>
        [DataMember(Name = "hasDigitalDocumentPermission", Order = 206)]
        public OneOrManyHasDigitalDocumentPermission HasDigitalDocumentPermission { get; set; }
    }
}
