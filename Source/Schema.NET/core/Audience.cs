namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// Intended audience for an item, i.e. the group for whom the item was created.
    /// </summary>
    [DataContract]
    public partial class Audience : Intangible
    {
        public interface IAudienceType : IValue {}
        public interface IAudienceType<T> : IAudienceType { new T Value { get; } }
        public class OneOrManyAudienceType : OneOrMany<IAudienceType>
        {
            public OneOrManyAudienceType(IAudienceType item) : base(item) { }
            public OneOrManyAudienceType(IEnumerable<IAudienceType> items) : base(items) { }
            public static implicit operator OneOrManyAudienceType (string value) { return new OneOrManyAudienceType (new AudienceTypestring (value)); }
            public static implicit operator OneOrManyAudienceType (string[] values) { return new OneOrManyAudienceType (values.Select(v => (IAudienceType) new AudienceTypestring (v))); }
            public static implicit operator OneOrManyAudienceType (List<string> values) { return new OneOrManyAudienceType (values.Select(v => (IAudienceType) new AudienceTypestring (v))); }
        }
        public struct AudienceTypestring : IAudienceType<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public AudienceTypestring (string value) { Value = value; }
            public static implicit operator AudienceTypestring (string value) { return new AudienceTypestring (value); }
        }

        public interface IGeographicArea : IValue {}
        public interface IGeographicArea<T> : IGeographicArea { new T Value { get; } }
        public class OneOrManyGeographicArea : OneOrMany<IGeographicArea>
        {
            public OneOrManyGeographicArea(IGeographicArea item) : base(item) { }
            public OneOrManyGeographicArea(IEnumerable<IGeographicArea> items) : base(items) { }
            public static implicit operator OneOrManyGeographicArea (AdministrativeArea value) { return new OneOrManyGeographicArea (new GeographicAreaAdministrativeArea (value)); }
            public static implicit operator OneOrManyGeographicArea (AdministrativeArea[] values) { return new OneOrManyGeographicArea (values.Select(v => (IGeographicArea) new GeographicAreaAdministrativeArea (v))); }
            public static implicit operator OneOrManyGeographicArea (List<AdministrativeArea> values) { return new OneOrManyGeographicArea (values.Select(v => (IGeographicArea) new GeographicAreaAdministrativeArea (v))); }
        }
        public struct GeographicAreaAdministrativeArea : IGeographicArea<AdministrativeArea>
        {
            object IValue.Value => this.Value;
            public AdministrativeArea Value { get; }
            public GeographicAreaAdministrativeArea (AdministrativeArea value) { Value = value; }
            public static implicit operator GeographicAreaAdministrativeArea (AdministrativeArea value) { return new GeographicAreaAdministrativeArea (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Audience";

        /// <summary>
        /// The target group associated with a given audience (e.g. veterans, car owners, musicians, etc.).
        /// </summary>
        [DataMember(Name = "audienceType", Order = 206)]
        public OneOrManyAudienceType AudienceType { get; set; }

        /// <summary>
        /// The geographic area associated with the audience.
        /// </summary>
        [DataMember(Name = "geographicArea", Order = 207)]
        public OneOrManyGeographicArea GeographicArea { get; set; }
    }
}
