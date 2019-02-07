namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// The most generic type of item.
    /// </summary>
    [DataContract]
    public partial class Thing
    {
        public interface IName : IValue {}
        public interface IName<T> : IName { new T Value { get; } }
        public class OneOrManyName : OneOrMany<IName>
        {
            public OneOrManyName(IName item) : base(item) { }
            public OneOrManyName(IEnumerable<IName> items) : base(items) { }
            public static implicit operator OneOrManyName (string value) { return new OneOrManyName (new Namestring (value)); }
            public static implicit operator OneOrManyName (string[] values) { return new OneOrManyName (values.Select(v => (IName) new Namestring (v))); }
            public static implicit operator OneOrManyName (List<string> values) { return new OneOrManyName (values.Select(v => (IName) new Namestring (v))); }
        }
        public struct Namestring : IName<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Namestring (string value) { Value = value; }
            public static implicit operator Namestring (string value) { return new Namestring (value); }
        }

        public interface IDescription : IValue {}
        public interface IDescription<T> : IDescription { new T Value { get; } }
        public class OneOrManyDescription : OneOrMany<IDescription>
        {
            public OneOrManyDescription(IDescription item) : base(item) { }
            public OneOrManyDescription(IEnumerable<IDescription> items) : base(items) { }
            public static implicit operator OneOrManyDescription (string value) { return new OneOrManyDescription (new Descriptionstring (value)); }
            public static implicit operator OneOrManyDescription (string[] values) { return new OneOrManyDescription (values.Select(v => (IDescription) new Descriptionstring (v))); }
            public static implicit operator OneOrManyDescription (List<string> values) { return new OneOrManyDescription (values.Select(v => (IDescription) new Descriptionstring (v))); }
        }
        public struct Descriptionstring : IDescription<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Descriptionstring (string value) { Value = value; }
            public static implicit operator Descriptionstring (string value) { return new Descriptionstring (value); }
        }

        public interface IAdditionalType : IValue {}
        public interface IAdditionalType<T> : IAdditionalType { new T Value { get; } }
        public class OneOrManyAdditionalType : OneOrMany<IAdditionalType>
        {
            public OneOrManyAdditionalType(IAdditionalType item) : base(item) { }
            public OneOrManyAdditionalType(IEnumerable<IAdditionalType> items) : base(items) { }
            public static implicit operator OneOrManyAdditionalType (Uri value) { return new OneOrManyAdditionalType (new AdditionalTypeUri (value)); }
            public static implicit operator OneOrManyAdditionalType (Uri[] values) { return new OneOrManyAdditionalType (values.Select(v => (IAdditionalType) new AdditionalTypeUri (v))); }
            public static implicit operator OneOrManyAdditionalType (List<Uri> values) { return new OneOrManyAdditionalType (values.Select(v => (IAdditionalType) new AdditionalTypeUri (v))); }
        }
        public struct AdditionalTypeUri : IAdditionalType<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public AdditionalTypeUri (Uri value) { Value = value; }
            public static implicit operator AdditionalTypeUri (Uri value) { return new AdditionalTypeUri (value); }
        }

        public interface IAlternateName : IValue {}
        public interface IAlternateName<T> : IAlternateName { new T Value { get; } }
        public class OneOrManyAlternateName : OneOrMany<IAlternateName>
        {
            public OneOrManyAlternateName(IAlternateName item) : base(item) { }
            public OneOrManyAlternateName(IEnumerable<IAlternateName> items) : base(items) { }
            public static implicit operator OneOrManyAlternateName (string value) { return new OneOrManyAlternateName (new AlternateNamestring (value)); }
            public static implicit operator OneOrManyAlternateName (string[] values) { return new OneOrManyAlternateName (values.Select(v => (IAlternateName) new AlternateNamestring (v))); }
            public static implicit operator OneOrManyAlternateName (List<string> values) { return new OneOrManyAlternateName (values.Select(v => (IAlternateName) new AlternateNamestring (v))); }
        }
        public struct AlternateNamestring : IAlternateName<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public AlternateNamestring (string value) { Value = value; }
            public static implicit operator AlternateNamestring (string value) { return new AlternateNamestring (value); }
        }

        public interface IDisambiguatingDescription : IValue {}
        public interface IDisambiguatingDescription<T> : IDisambiguatingDescription { new T Value { get; } }
        public class OneOrManyDisambiguatingDescription : OneOrMany<IDisambiguatingDescription>
        {
            public OneOrManyDisambiguatingDescription(IDisambiguatingDescription item) : base(item) { }
            public OneOrManyDisambiguatingDescription(IEnumerable<IDisambiguatingDescription> items) : base(items) { }
            public static implicit operator OneOrManyDisambiguatingDescription (string value) { return new OneOrManyDisambiguatingDescription (new DisambiguatingDescriptionstring (value)); }
            public static implicit operator OneOrManyDisambiguatingDescription (string[] values) { return new OneOrManyDisambiguatingDescription (values.Select(v => (IDisambiguatingDescription) new DisambiguatingDescriptionstring (v))); }
            public static implicit operator OneOrManyDisambiguatingDescription (List<string> values) { return new OneOrManyDisambiguatingDescription (values.Select(v => (IDisambiguatingDescription) new DisambiguatingDescriptionstring (v))); }
        }
        public struct DisambiguatingDescriptionstring : IDisambiguatingDescription<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public DisambiguatingDescriptionstring (string value) { Value = value; }
            public static implicit operator DisambiguatingDescriptionstring (string value) { return new DisambiguatingDescriptionstring (value); }
        }

        public interface IIdentifier : IValue {}
        public interface IIdentifier<T> : IIdentifier { new T Value { get; } }
        public class OneOrManyIdentifier : OneOrMany<IIdentifier>
        {
            public OneOrManyIdentifier(IIdentifier item) : base(item) { }
            public OneOrManyIdentifier(IEnumerable<IIdentifier> items) : base(items) { }
            public static implicit operator OneOrManyIdentifier (PropertyValue value) { return new OneOrManyIdentifier (new IdentifierPropertyValue (value)); }
            public static implicit operator OneOrManyIdentifier (PropertyValue[] values) { return new OneOrManyIdentifier (values.Select(v => (IIdentifier) new IdentifierPropertyValue (v))); }
            public static implicit operator OneOrManyIdentifier (List<PropertyValue> values) { return new OneOrManyIdentifier (values.Select(v => (IIdentifier) new IdentifierPropertyValue (v))); }
            public static implicit operator OneOrManyIdentifier (string value) { return new OneOrManyIdentifier (new Identifierstring (value)); }
            public static implicit operator OneOrManyIdentifier (string[] values) { return new OneOrManyIdentifier (values.Select(v => (IIdentifier) new Identifierstring (v))); }
            public static implicit operator OneOrManyIdentifier (List<string> values) { return new OneOrManyIdentifier (values.Select(v => (IIdentifier) new Identifierstring (v))); }
            public static implicit operator OneOrManyIdentifier (Uri value) { return new OneOrManyIdentifier (new IdentifierUri (value)); }
            public static implicit operator OneOrManyIdentifier (Uri[] values) { return new OneOrManyIdentifier (values.Select(v => (IIdentifier) new IdentifierUri (v))); }
            public static implicit operator OneOrManyIdentifier (List<Uri> values) { return new OneOrManyIdentifier (values.Select(v => (IIdentifier) new IdentifierUri (v))); }
        }
        public struct IdentifierPropertyValue : IIdentifier<PropertyValue>
        {
            object IValue.Value => this.Value;
            public PropertyValue Value { get; }
            public IdentifierPropertyValue (PropertyValue value) { Value = value; }
            public static implicit operator IdentifierPropertyValue (PropertyValue value) { return new IdentifierPropertyValue (value); }
        }
        public struct Identifierstring : IIdentifier<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Identifierstring (string value) { Value = value; }
            public static implicit operator Identifierstring (string value) { return new Identifierstring (value); }
        }
        public struct IdentifierUri : IIdentifier<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public IdentifierUri (Uri value) { Value = value; }
            public static implicit operator IdentifierUri (Uri value) { return new IdentifierUri (value); }
        }

        public interface IImage : IValue {}
        public interface IImage<T> : IImage { new T Value { get; } }
        public class OneOrManyImage : OneOrMany<IImage>
        {
            public OneOrManyImage(IImage item) : base(item) { }
            public OneOrManyImage(IEnumerable<IImage> items) : base(items) { }
            public static implicit operator OneOrManyImage (ImageObject value) { return new OneOrManyImage (new ImageImageObject (value)); }
            public static implicit operator OneOrManyImage (ImageObject[] values) { return new OneOrManyImage (values.Select(v => (IImage) new ImageImageObject (v))); }
            public static implicit operator OneOrManyImage (List<ImageObject> values) { return new OneOrManyImage (values.Select(v => (IImage) new ImageImageObject (v))); }
            public static implicit operator OneOrManyImage (Uri value) { return new OneOrManyImage (new ImageUri (value)); }
            public static implicit operator OneOrManyImage (Uri[] values) { return new OneOrManyImage (values.Select(v => (IImage) new ImageUri (v))); }
            public static implicit operator OneOrManyImage (List<Uri> values) { return new OneOrManyImage (values.Select(v => (IImage) new ImageUri (v))); }
        }
        public struct ImageImageObject : IImage<ImageObject>
        {
            object IValue.Value => this.Value;
            public ImageObject Value { get; }
            public ImageImageObject (ImageObject value) { Value = value; }
            public static implicit operator ImageImageObject (ImageObject value) { return new ImageImageObject (value); }
        }
        public struct ImageUri : IImage<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public ImageUri (Uri value) { Value = value; }
            public static implicit operator ImageUri (Uri value) { return new ImageUri (value); }
        }

        public interface IMainEntityOfPage : IValue {}
        public interface IMainEntityOfPage<T> : IMainEntityOfPage { new T Value { get; } }
        public class OneOrManyMainEntityOfPage : OneOrMany<IMainEntityOfPage>
        {
            public OneOrManyMainEntityOfPage(IMainEntityOfPage item) : base(item) { }
            public OneOrManyMainEntityOfPage(IEnumerable<IMainEntityOfPage> items) : base(items) { }
            public static implicit operator OneOrManyMainEntityOfPage (CreativeWork value) { return new OneOrManyMainEntityOfPage (new MainEntityOfPageCreativeWork (value)); }
            public static implicit operator OneOrManyMainEntityOfPage (CreativeWork[] values) { return new OneOrManyMainEntityOfPage (values.Select(v => (IMainEntityOfPage) new MainEntityOfPageCreativeWork (v))); }
            public static implicit operator OneOrManyMainEntityOfPage (List<CreativeWork> values) { return new OneOrManyMainEntityOfPage (values.Select(v => (IMainEntityOfPage) new MainEntityOfPageCreativeWork (v))); }
            public static implicit operator OneOrManyMainEntityOfPage (Uri value) { return new OneOrManyMainEntityOfPage (new MainEntityOfPageUri (value)); }
            public static implicit operator OneOrManyMainEntityOfPage (Uri[] values) { return new OneOrManyMainEntityOfPage (values.Select(v => (IMainEntityOfPage) new MainEntityOfPageUri (v))); }
            public static implicit operator OneOrManyMainEntityOfPage (List<Uri> values) { return new OneOrManyMainEntityOfPage (values.Select(v => (IMainEntityOfPage) new MainEntityOfPageUri (v))); }
        }
        public struct MainEntityOfPageCreativeWork : IMainEntityOfPage<CreativeWork>
        {
            object IValue.Value => this.Value;
            public CreativeWork Value { get; }
            public MainEntityOfPageCreativeWork (CreativeWork value) { Value = value; }
            public static implicit operator MainEntityOfPageCreativeWork (CreativeWork value) { return new MainEntityOfPageCreativeWork (value); }
        }
        public struct MainEntityOfPageUri : IMainEntityOfPage<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public MainEntityOfPageUri (Uri value) { Value = value; }
            public static implicit operator MainEntityOfPageUri (Uri value) { return new MainEntityOfPageUri (value); }
        }

        public interface IPotentialAction : IValue {}
        public interface IPotentialAction<T> : IPotentialAction { new T Value { get; } }
        public class OneOrManyPotentialAction : OneOrMany<IPotentialAction>
        {
            public OneOrManyPotentialAction(IPotentialAction item) : base(item) { }
            public OneOrManyPotentialAction(IEnumerable<IPotentialAction> items) : base(items) { }
            public static implicit operator OneOrManyPotentialAction (Action value) { return new OneOrManyPotentialAction (new PotentialActionAction (value)); }
            public static implicit operator OneOrManyPotentialAction (Action[] values) { return new OneOrManyPotentialAction (values.Select(v => (IPotentialAction) new PotentialActionAction (v))); }
            public static implicit operator OneOrManyPotentialAction (List<Action> values) { return new OneOrManyPotentialAction (values.Select(v => (IPotentialAction) new PotentialActionAction (v))); }
        }
        public struct PotentialActionAction : IPotentialAction<Action>
        {
            object IValue.Value => this.Value;
            public Action Value { get; }
            public PotentialActionAction (Action value) { Value = value; }
            public static implicit operator PotentialActionAction (Action value) { return new PotentialActionAction (value); }
        }

        public interface ISameAs : IValue {}
        public interface ISameAs<T> : ISameAs { new T Value { get; } }
        public class OneOrManySameAs : OneOrMany<ISameAs>
        {
            public OneOrManySameAs(ISameAs item) : base(item) { }
            public OneOrManySameAs(IEnumerable<ISameAs> items) : base(items) { }
            public static implicit operator OneOrManySameAs (Uri value) { return new OneOrManySameAs (new SameAsUri (value)); }
            public static implicit operator OneOrManySameAs (Uri[] values) { return new OneOrManySameAs (values.Select(v => (ISameAs) new SameAsUri (v))); }
            public static implicit operator OneOrManySameAs (List<Uri> values) { return new OneOrManySameAs (values.Select(v => (ISameAs) new SameAsUri (v))); }
        }
        public struct SameAsUri : ISameAs<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public SameAsUri (Uri value) { Value = value; }
            public static implicit operator SameAsUri (Uri value) { return new SameAsUri (value); }
        }

        public interface ISubjectOf : IValue {}
        public interface ISubjectOf<T> : ISubjectOf { new T Value { get; } }
        public class OneOrManySubjectOf : OneOrMany<ISubjectOf>
        {
            public OneOrManySubjectOf(ISubjectOf item) : base(item) { }
            public OneOrManySubjectOf(IEnumerable<ISubjectOf> items) : base(items) { }
            public static implicit operator OneOrManySubjectOf (CreativeWork value) { return new OneOrManySubjectOf (new SubjectOfCreativeWork (value)); }
            public static implicit operator OneOrManySubjectOf (CreativeWork[] values) { return new OneOrManySubjectOf (values.Select(v => (ISubjectOf) new SubjectOfCreativeWork (v))); }
            public static implicit operator OneOrManySubjectOf (List<CreativeWork> values) { return new OneOrManySubjectOf (values.Select(v => (ISubjectOf) new SubjectOfCreativeWork (v))); }
            public static implicit operator OneOrManySubjectOf (Event value) { return new OneOrManySubjectOf (new SubjectOfEvent (value)); }
            public static implicit operator OneOrManySubjectOf (Event[] values) { return new OneOrManySubjectOf (values.Select(v => (ISubjectOf) new SubjectOfEvent (v))); }
            public static implicit operator OneOrManySubjectOf (List<Event> values) { return new OneOrManySubjectOf (values.Select(v => (ISubjectOf) new SubjectOfEvent (v))); }
        }
        public struct SubjectOfCreativeWork : ISubjectOf<CreativeWork>
        {
            object IValue.Value => this.Value;
            public CreativeWork Value { get; }
            public SubjectOfCreativeWork (CreativeWork value) { Value = value; }
            public static implicit operator SubjectOfCreativeWork (CreativeWork value) { return new SubjectOfCreativeWork (value); }
        }
        public struct SubjectOfEvent : ISubjectOf<Event>
        {
            object IValue.Value => this.Value;
            public Event Value { get; }
            public SubjectOfEvent (Event value) { Value = value; }
            public static implicit operator SubjectOfEvent (Event value) { return new SubjectOfEvent (value); }
        }

        public interface IUrl : IValue {}
        public interface IUrl<T> : IUrl { new T Value { get; } }
        public class OneOrManyUrl : OneOrMany<IUrl>
        {
            public OneOrManyUrl(IUrl item) : base(item) { }
            public OneOrManyUrl(IEnumerable<IUrl> items) : base(items) { }
            public static implicit operator OneOrManyUrl (Uri value) { return new OneOrManyUrl (new UrlUri (value)); }
            public static implicit operator OneOrManyUrl (Uri[] values) { return new OneOrManyUrl (values.Select(v => (IUrl) new UrlUri (v))); }
            public static implicit operator OneOrManyUrl (List<Uri> values) { return new OneOrManyUrl (values.Select(v => (IUrl) new UrlUri (v))); }
        }
        public struct UrlUri : IUrl<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public UrlUri (Uri value) { Value = value; }
            public static implicit operator UrlUri (Uri value) { return new UrlUri (value); }
        }

        /// <summary>
        /// Gets the context for the object, specifying that it comes from schema.org.
        /// </summary>
        [DataMember(Name = "@context", Order = 0)]
        public override string Context => "http://schema.org";

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Thing";

        /// <summary>
        /// The name of the item.
        /// </summary>
        [DataMember(Name = "name", Order = 4)]
        public OneOrManyName Name { get; set; }

        /// <summary>
        /// A description of the item.
        /// </summary>
        [DataMember(Name = "description", Order = 5)]
        public OneOrManyDescription Description { get; set; }

        /// <summary>
        /// An additional type for the item, typically used for adding more specific types from external vocabularies in microdata syntax. This is a relationship between something and a class that the thing is in. In RDFa syntax, it is better to use the native RDFa syntax - the 'typeof' attribute - for multiple types. Schema.org tools may have only weaker understanding of extra types, in particular those defined externally.
        /// </summary>
        [DataMember(Name = "additionalType", Order = 8)]
        public OneOrManyAdditionalType AdditionalType { get; set; }

        /// <summary>
        /// An alias for the item.
        /// </summary>
        [DataMember(Name = "alternateName", Order = 9)]
        public OneOrManyAlternateName AlternateName { get; set; }

        /// <summary>
        /// A sub property of description. A short description of the item used to disambiguate from other, similar items. Information from other properties (in particular, name) may be necessary for the description to be useful for disambiguation.
        /// </summary>
        [DataMember(Name = "disambiguatingDescription", Order = 10)]
        public OneOrManyDisambiguatingDescription DisambiguatingDescription { get; set; }

        /// <summary>
        /// The identifier property represents any kind of identifier for any kind of &lt;a class="localLink" href="http://schema.org/Thing"&gt;Thing&lt;/a&gt;, such as ISBNs, GTIN codes, UUIDs etc. Schema.org provides dedicated properties for representing many of these, either as textual strings or as URL (URI) links. See &lt;a href="/docs/datamodel.html#identifierBg"&gt;background notes&lt;/a&gt; for more details.
        /// </summary>
        [DataMember(Name = "identifier", Order = 11)]
        public OneOrManyIdentifier Identifier { get; set; }

        /// <summary>
        /// An image of the item. This can be a &lt;a class="localLink" href="http://schema.org/URL"&gt;URL&lt;/a&gt; or a fully described &lt;a class="localLink" href="http://schema.org/ImageObject"&gt;ImageObject&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "image", Order = 12)]
        public OneOrManyImage Image { get; set; }

        /// <summary>
        /// Indicates a page (or other CreativeWork) for which this thing is the main entity being described. See &lt;a href="/docs/datamodel.html#mainEntityBackground"&gt;background notes&lt;/a&gt; for details.
        /// </summary>
        [DataMember(Name = "mainEntityOfPage", Order = 13)]
        public OneOrManyMainEntityOfPage MainEntityOfPage { get; set; }

        /// <summary>
        /// Indicates a potential Action, which describes an idealized action in which this thing would play an 'object' role.
        /// </summary>
        [DataMember(Name = "potentialAction", Order = 14)]
        public OneOrManyPotentialAction PotentialAction { get; set; }

        /// <summary>
        /// URL of a reference Web page that unambiguously indicates the item's identity. E.g. the URL of the item's Wikipedia page, Wikidata entry, or official website.
        /// </summary>
        [DataMember(Name = "sameAs", Order = 15)]
        public OneOrManySameAs SameAs { get; set; }

        /// <summary>
        /// A CreativeWork or Event about this Thing..
        /// </summary>
        [DataMember(Name = "subjectOf", Order = 16)]
        public OneOrManySubjectOf SubjectOf { get; set; }

        /// <summary>
        /// URL of the item.
        /// </summary>
        [DataMember(Name = "url", Order = 17)]
        public OneOrManyUrl Url { get; set; }
    }
}
