namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A web page. Every web page is implicitly assumed to be declared to be of type WebPage, so the various properties about that webpage, such as &lt;code&gt;breadcrumb&lt;/code&gt; may be used. We recommend explicit declaration if these properties are specified, but if they are found outside of an itemscope, they will be assumed to be about the page.
    /// </summary>
    [DataContract]
    public partial class WebPage : CreativeWork
    {
        public interface IBreadcrumb : IValue {}
        public interface IBreadcrumb<T> : IBreadcrumb { new T Value { get; } }
        public class OneOrManyBreadcrumb : OneOrMany<IBreadcrumb>
        {
            public OneOrManyBreadcrumb(IBreadcrumb item) : base(item) { }
            public OneOrManyBreadcrumb(IEnumerable<IBreadcrumb> items) : base(items) { }
            public static implicit operator OneOrManyBreadcrumb (BreadcrumbList value) { return new OneOrManyBreadcrumb (new BreadcrumbBreadcrumbList (value)); }
            public static implicit operator OneOrManyBreadcrumb (BreadcrumbList[] values) { return new OneOrManyBreadcrumb (values.Select(v => (IBreadcrumb) new BreadcrumbBreadcrumbList (v))); }
            public static implicit operator OneOrManyBreadcrumb (List<BreadcrumbList> values) { return new OneOrManyBreadcrumb (values.Select(v => (IBreadcrumb) new BreadcrumbBreadcrumbList (v))); }
            public static implicit operator OneOrManyBreadcrumb (string value) { return new OneOrManyBreadcrumb (new Breadcrumbstring (value)); }
            public static implicit operator OneOrManyBreadcrumb (string[] values) { return new OneOrManyBreadcrumb (values.Select(v => (IBreadcrumb) new Breadcrumbstring (v))); }
            public static implicit operator OneOrManyBreadcrumb (List<string> values) { return new OneOrManyBreadcrumb (values.Select(v => (IBreadcrumb) new Breadcrumbstring (v))); }
        }
        public struct BreadcrumbBreadcrumbList : IBreadcrumb<BreadcrumbList>
        {
            object IValue.Value => this.Value;
            public BreadcrumbList Value { get; }
            public BreadcrumbBreadcrumbList (BreadcrumbList value) { Value = value; }
            public static implicit operator BreadcrumbBreadcrumbList (BreadcrumbList value) { return new BreadcrumbBreadcrumbList (value); }
        }
        public struct Breadcrumbstring : IBreadcrumb<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Breadcrumbstring (string value) { Value = value; }
            public static implicit operator Breadcrumbstring (string value) { return new Breadcrumbstring (value); }
        }

        public interface ILastReviewed : IValue {}
        public interface ILastReviewed<T> : ILastReviewed { new T Value { get; } }
        public class OneOrManyLastReviewed : OneOrMany<ILastReviewed>
        {
            public OneOrManyLastReviewed(ILastReviewed item) : base(item) { }
            public OneOrManyLastReviewed(IEnumerable<ILastReviewed> items) : base(items) { }
            public static implicit operator OneOrManyLastReviewed (DateTimeOffset value) { return new OneOrManyLastReviewed (new LastReviewedDateTimeOffset (value)); }
            public static implicit operator OneOrManyLastReviewed (DateTimeOffset[] values) { return new OneOrManyLastReviewed (values.Select(v => (ILastReviewed) new LastReviewedDateTimeOffset (v))); }
            public static implicit operator OneOrManyLastReviewed (List<DateTimeOffset> values) { return new OneOrManyLastReviewed (values.Select(v => (ILastReviewed) new LastReviewedDateTimeOffset (v))); }
        }
        public struct LastReviewedDateTimeOffset : ILastReviewed<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public LastReviewedDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator LastReviewedDateTimeOffset (DateTimeOffset value) { return new LastReviewedDateTimeOffset (value); }
        }

        public interface IMainContentOfPage : IValue {}
        public interface IMainContentOfPage<T> : IMainContentOfPage { new T Value { get; } }
        public class OneOrManyMainContentOfPage : OneOrMany<IMainContentOfPage>
        {
            public OneOrManyMainContentOfPage(IMainContentOfPage item) : base(item) { }
            public OneOrManyMainContentOfPage(IEnumerable<IMainContentOfPage> items) : base(items) { }
            public static implicit operator OneOrManyMainContentOfPage (WebPageElement value) { return new OneOrManyMainContentOfPage (new MainContentOfPageWebPageElement (value)); }
            public static implicit operator OneOrManyMainContentOfPage (WebPageElement[] values) { return new OneOrManyMainContentOfPage (values.Select(v => (IMainContentOfPage) new MainContentOfPageWebPageElement (v))); }
            public static implicit operator OneOrManyMainContentOfPage (List<WebPageElement> values) { return new OneOrManyMainContentOfPage (values.Select(v => (IMainContentOfPage) new MainContentOfPageWebPageElement (v))); }
        }
        public struct MainContentOfPageWebPageElement : IMainContentOfPage<WebPageElement>
        {
            object IValue.Value => this.Value;
            public WebPageElement Value { get; }
            public MainContentOfPageWebPageElement (WebPageElement value) { Value = value; }
            public static implicit operator MainContentOfPageWebPageElement (WebPageElement value) { return new MainContentOfPageWebPageElement (value); }
        }

        public interface IPrimaryImageOfPage : IValue {}
        public interface IPrimaryImageOfPage<T> : IPrimaryImageOfPage { new T Value { get; } }
        public class OneOrManyPrimaryImageOfPage : OneOrMany<IPrimaryImageOfPage>
        {
            public OneOrManyPrimaryImageOfPage(IPrimaryImageOfPage item) : base(item) { }
            public OneOrManyPrimaryImageOfPage(IEnumerable<IPrimaryImageOfPage> items) : base(items) { }
            public static implicit operator OneOrManyPrimaryImageOfPage (ImageObject value) { return new OneOrManyPrimaryImageOfPage (new PrimaryImageOfPageImageObject (value)); }
            public static implicit operator OneOrManyPrimaryImageOfPage (ImageObject[] values) { return new OneOrManyPrimaryImageOfPage (values.Select(v => (IPrimaryImageOfPage) new PrimaryImageOfPageImageObject (v))); }
            public static implicit operator OneOrManyPrimaryImageOfPage (List<ImageObject> values) { return new OneOrManyPrimaryImageOfPage (values.Select(v => (IPrimaryImageOfPage) new PrimaryImageOfPageImageObject (v))); }
        }
        public struct PrimaryImageOfPageImageObject : IPrimaryImageOfPage<ImageObject>
        {
            object IValue.Value => this.Value;
            public ImageObject Value { get; }
            public PrimaryImageOfPageImageObject (ImageObject value) { Value = value; }
            public static implicit operator PrimaryImageOfPageImageObject (ImageObject value) { return new PrimaryImageOfPageImageObject (value); }
        }

        public interface IRelatedLink : IValue {}
        public interface IRelatedLink<T> : IRelatedLink { new T Value { get; } }
        public class OneOrManyRelatedLink : OneOrMany<IRelatedLink>
        {
            public OneOrManyRelatedLink(IRelatedLink item) : base(item) { }
            public OneOrManyRelatedLink(IEnumerable<IRelatedLink> items) : base(items) { }
            public static implicit operator OneOrManyRelatedLink (Uri value) { return new OneOrManyRelatedLink (new RelatedLinkUri (value)); }
            public static implicit operator OneOrManyRelatedLink (Uri[] values) { return new OneOrManyRelatedLink (values.Select(v => (IRelatedLink) new RelatedLinkUri (v))); }
            public static implicit operator OneOrManyRelatedLink (List<Uri> values) { return new OneOrManyRelatedLink (values.Select(v => (IRelatedLink) new RelatedLinkUri (v))); }
        }
        public struct RelatedLinkUri : IRelatedLink<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public RelatedLinkUri (Uri value) { Value = value; }
            public static implicit operator RelatedLinkUri (Uri value) { return new RelatedLinkUri (value); }
        }

        public interface IReviewedBy : IValue {}
        public interface IReviewedBy<T> : IReviewedBy { new T Value { get; } }
        public class OneOrManyReviewedBy : OneOrMany<IReviewedBy>
        {
            public OneOrManyReviewedBy(IReviewedBy item) : base(item) { }
            public OneOrManyReviewedBy(IEnumerable<IReviewedBy> items) : base(items) { }
            public static implicit operator OneOrManyReviewedBy (Organization value) { return new OneOrManyReviewedBy (new ReviewedByOrganization (value)); }
            public static implicit operator OneOrManyReviewedBy (Organization[] values) { return new OneOrManyReviewedBy (values.Select(v => (IReviewedBy) new ReviewedByOrganization (v))); }
            public static implicit operator OneOrManyReviewedBy (List<Organization> values) { return new OneOrManyReviewedBy (values.Select(v => (IReviewedBy) new ReviewedByOrganization (v))); }
            public static implicit operator OneOrManyReviewedBy (Person value) { return new OneOrManyReviewedBy (new ReviewedByPerson (value)); }
            public static implicit operator OneOrManyReviewedBy (Person[] values) { return new OneOrManyReviewedBy (values.Select(v => (IReviewedBy) new ReviewedByPerson (v))); }
            public static implicit operator OneOrManyReviewedBy (List<Person> values) { return new OneOrManyReviewedBy (values.Select(v => (IReviewedBy) new ReviewedByPerson (v))); }
        }
        public struct ReviewedByOrganization : IReviewedBy<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public ReviewedByOrganization (Organization value) { Value = value; }
            public static implicit operator ReviewedByOrganization (Organization value) { return new ReviewedByOrganization (value); }
        }
        public struct ReviewedByPerson : IReviewedBy<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public ReviewedByPerson (Person value) { Value = value; }
            public static implicit operator ReviewedByPerson (Person value) { return new ReviewedByPerson (value); }
        }

        public interface ISignificantLink : IValue {}
        public interface ISignificantLink<T> : ISignificantLink { new T Value { get; } }
        public class OneOrManySignificantLink : OneOrMany<ISignificantLink>
        {
            public OneOrManySignificantLink(ISignificantLink item) : base(item) { }
            public OneOrManySignificantLink(IEnumerable<ISignificantLink> items) : base(items) { }
            public static implicit operator OneOrManySignificantLink (Uri value) { return new OneOrManySignificantLink (new SignificantLinkUri (value)); }
            public static implicit operator OneOrManySignificantLink (Uri[] values) { return new OneOrManySignificantLink (values.Select(v => (ISignificantLink) new SignificantLinkUri (v))); }
            public static implicit operator OneOrManySignificantLink (List<Uri> values) { return new OneOrManySignificantLink (values.Select(v => (ISignificantLink) new SignificantLinkUri (v))); }
        }
        public struct SignificantLinkUri : ISignificantLink<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public SignificantLinkUri (Uri value) { Value = value; }
            public static implicit operator SignificantLinkUri (Uri value) { return new SignificantLinkUri (value); }
        }

        public interface ISpeakable : IValue {}
        public interface ISpeakable<T> : ISpeakable { new T Value { get; } }
        public class OneOrManySpeakable : OneOrMany<ISpeakable>
        {
            public OneOrManySpeakable(ISpeakable item) : base(item) { }
            public OneOrManySpeakable(IEnumerable<ISpeakable> items) : base(items) { }
            public static implicit operator OneOrManySpeakable (Uri value) { return new OneOrManySpeakable (new SpeakableUri (value)); }
            public static implicit operator OneOrManySpeakable (Uri[] values) { return new OneOrManySpeakable (values.Select(v => (ISpeakable) new SpeakableUri (v))); }
            public static implicit operator OneOrManySpeakable (List<Uri> values) { return new OneOrManySpeakable (values.Select(v => (ISpeakable) new SpeakableUri (v))); }
        }
        public struct SpeakableUri : ISpeakable<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public SpeakableUri (Uri value) { Value = value; }
            public static implicit operator SpeakableUri (Uri value) { return new SpeakableUri (value); }
        }

        public interface ISpecialty : IValue {}
        public interface ISpecialty<T> : ISpecialty { new T Value { get; } }
        public class OneOrManySpecialty : OneOrMany<ISpecialty>
        {
            public OneOrManySpecialty(ISpecialty item) : base(item) { }
            public OneOrManySpecialty(IEnumerable<ISpecialty> items) : base(items) { }
            public static implicit operator OneOrManySpecialty (Specialty value) { return new OneOrManySpecialty (new SpecialtySpecialty (value)); }
            public static implicit operator OneOrManySpecialty (Specialty[] values) { return new OneOrManySpecialty (values.Select(v => (ISpecialty) new SpecialtySpecialty (v))); }
            public static implicit operator OneOrManySpecialty (List<Specialty> values) { return new OneOrManySpecialty (values.Select(v => (ISpecialty) new SpecialtySpecialty (v))); }
        }
        public struct SpecialtySpecialty : ISpecialty<Specialty>
        {
            object IValue.Value => this.Value;
            public Specialty Value { get; }
            public SpecialtySpecialty (Specialty value) { Value = value; }
            public static implicit operator SpecialtySpecialty (Specialty value) { return new SpecialtySpecialty (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "WebPage";

        /// <summary>
        /// A set of links that can help a user understand and navigate a website hierarchy.
        /// </summary>
        [DataMember(Name = "breadcrumb", Order = 206)]
        public OneOrManyBreadcrumb Breadcrumb { get; set; }

        /// <summary>
        /// Date on which the content on this web page was last reviewed for accuracy and/or completeness.
        /// </summary>
        [DataMember(Name = "lastReviewed", Order = 207)]
        public OneOrManyLastReviewed LastReviewed { get; set; }

        /// <summary>
        /// Indicates if this web page element is the main subject of the page.
        /// </summary>
        [DataMember(Name = "mainContentOfPage", Order = 208)]
        public OneOrManyMainContentOfPage MainContentOfPage { get; set; }

        /// <summary>
        /// Indicates the main image on the page.
        /// </summary>
        [DataMember(Name = "primaryImageOfPage", Order = 209)]
        public OneOrManyPrimaryImageOfPage PrimaryImageOfPage { get; set; }

        /// <summary>
        /// A link related to this web page, for example to other related web pages.
        /// </summary>
        [DataMember(Name = "relatedLink", Order = 210)]
        public OneOrManyRelatedLink RelatedLink { get; set; }

        /// <summary>
        /// People or organizations that have reviewed the content on this web page for accuracy and/or completeness.
        /// </summary>
        [DataMember(Name = "reviewedBy", Order = 211)]
        public OneOrManyReviewedBy ReviewedBy { get; set; }

        /// <summary>
        /// One of the more significant URLs on the page. Typically, these are the non-navigation links that are clicked on the most.
        /// </summary>
        [DataMember(Name = "significantLink", Order = 212)]
        public OneOrManySignificantLink SignificantLink { get; set; }

        /// <summary>
        /// Indicates sections of a Web page that are particularly 'speakable' in the sense of being highlighted as being especially appropriate for text-to-speech conversion. Other sections of a page may also be usefully spoken in particular circumstances; the 'speakable' property serves to indicate the parts most likely to be generally useful for speech.&lt;br/&gt;&lt;br/&gt;
        /// The &lt;em&gt;speakable&lt;/em&gt; property can be repeated an arbitrary number of times, with three kinds of possible 'content-locator' values:&lt;br/&gt;&lt;br/&gt;
        /// 1.) &lt;em&gt;id-value&lt;/em&gt; URL references - uses &lt;em&gt;id-value&lt;/em&gt; of an element in the page being annotated. The simplest use of &lt;em&gt;speakable&lt;/em&gt; has (potentially relative) URL values, referencing identified sections of the document concerned.&lt;br/&gt;&lt;br/&gt;
        /// 2.) CSS Selectors - addresses content in the annotated page, eg. via class attribute. Use the &lt;a class="localLink" href="http://schema.org/cssSelector"&gt;cssSelector&lt;/a&gt; property.&lt;br/&gt;&lt;br/&gt;
        /// 3.)  XPaths - addresses content via XPaths (assuming an XML view of the content). Use the &lt;a class="localLink" href="http://schema.org/xpath"&gt;xpath&lt;/a&gt; property.&lt;br/&gt;&lt;br/&gt;
        /// For more sophisticated markup of speakable sections beyond simple ID references, either CSS selectors or XPath expressions to pick out document section(s) as speakable. For this
        /// we define a supporting type, &lt;a class="localLink" href="http://schema.org/SpeakableSpecification"&gt;SpeakableSpecification&lt;/a&gt;  which is defined to be a possible value of the &lt;em&gt;speakable&lt;/em&gt; property.
        /// </summary>
        [DataMember(Name = "speakable", Order = 213)]
        public OneOrManySpeakable Speakable { get; set; }

        /// <summary>
        /// One of the domain specialities to which this web page's content applies.
        /// </summary>
        [DataMember(Name = "specialty", Order = 214)]
        public OneOrManySpecialty Specialty { get; set; }
    }
}
