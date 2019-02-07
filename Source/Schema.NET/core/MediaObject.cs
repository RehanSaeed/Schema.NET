namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A media object, such as an image, video, or audio object embedded in a web page or a downloadable dataset i.e. DataDownload. Note that a creative work may have many media objects associated with it on the same web page. For example, a page about a single song (MusicRecording) may have a music video (VideoObject), and a high and low bandwidth audio stream (2 AudioObject's).
    /// </summary>
    [DataContract]
    public partial class MediaObject : CreativeWork
    {
        public interface IAssociatedArticle : IValue {}
        public interface IAssociatedArticle<T> : IAssociatedArticle { new T Value { get; } }
        public class OneOrManyAssociatedArticle : OneOrMany<IAssociatedArticle>
        {
            public OneOrManyAssociatedArticle(IAssociatedArticle item) : base(item) { }
            public OneOrManyAssociatedArticle(IEnumerable<IAssociatedArticle> items) : base(items) { }
            public static implicit operator OneOrManyAssociatedArticle (NewsArticle value) { return new OneOrManyAssociatedArticle (new AssociatedArticleNewsArticle (value)); }
            public static implicit operator OneOrManyAssociatedArticle (NewsArticle[] values) { return new OneOrManyAssociatedArticle (values.Select(v => (IAssociatedArticle) new AssociatedArticleNewsArticle (v))); }
            public static implicit operator OneOrManyAssociatedArticle (List<NewsArticle> values) { return new OneOrManyAssociatedArticle (values.Select(v => (IAssociatedArticle) new AssociatedArticleNewsArticle (v))); }
        }
        public struct AssociatedArticleNewsArticle : IAssociatedArticle<NewsArticle>
        {
            object IValue.Value => this.Value;
            public NewsArticle Value { get; }
            public AssociatedArticleNewsArticle (NewsArticle value) { Value = value; }
            public static implicit operator AssociatedArticleNewsArticle (NewsArticle value) { return new AssociatedArticleNewsArticle (value); }
        }

        public interface IBitrate : IValue {}
        public interface IBitrate<T> : IBitrate { new T Value { get; } }
        public class OneOrManyBitrate : OneOrMany<IBitrate>
        {
            public OneOrManyBitrate(IBitrate item) : base(item) { }
            public OneOrManyBitrate(IEnumerable<IBitrate> items) : base(items) { }
            public static implicit operator OneOrManyBitrate (string value) { return new OneOrManyBitrate (new Bitratestring (value)); }
            public static implicit operator OneOrManyBitrate (string[] values) { return new OneOrManyBitrate (values.Select(v => (IBitrate) new Bitratestring (v))); }
            public static implicit operator OneOrManyBitrate (List<string> values) { return new OneOrManyBitrate (values.Select(v => (IBitrate) new Bitratestring (v))); }
        }
        public struct Bitratestring : IBitrate<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Bitratestring (string value) { Value = value; }
            public static implicit operator Bitratestring (string value) { return new Bitratestring (value); }
        }

        public interface IContentSize : IValue {}
        public interface IContentSize<T> : IContentSize { new T Value { get; } }
        public class OneOrManyContentSize : OneOrMany<IContentSize>
        {
            public OneOrManyContentSize(IContentSize item) : base(item) { }
            public OneOrManyContentSize(IEnumerable<IContentSize> items) : base(items) { }
            public static implicit operator OneOrManyContentSize (string value) { return new OneOrManyContentSize (new ContentSizestring (value)); }
            public static implicit operator OneOrManyContentSize (string[] values) { return new OneOrManyContentSize (values.Select(v => (IContentSize) new ContentSizestring (v))); }
            public static implicit operator OneOrManyContentSize (List<string> values) { return new OneOrManyContentSize (values.Select(v => (IContentSize) new ContentSizestring (v))); }
        }
        public struct ContentSizestring : IContentSize<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public ContentSizestring (string value) { Value = value; }
            public static implicit operator ContentSizestring (string value) { return new ContentSizestring (value); }
        }

        public interface IContentUrl : IValue {}
        public interface IContentUrl<T> : IContentUrl { new T Value { get; } }
        public class OneOrManyContentUrl : OneOrMany<IContentUrl>
        {
            public OneOrManyContentUrl(IContentUrl item) : base(item) { }
            public OneOrManyContentUrl(IEnumerable<IContentUrl> items) : base(items) { }
            public static implicit operator OneOrManyContentUrl (Uri value) { return new OneOrManyContentUrl (new ContentUrlUri (value)); }
            public static implicit operator OneOrManyContentUrl (Uri[] values) { return new OneOrManyContentUrl (values.Select(v => (IContentUrl) new ContentUrlUri (v))); }
            public static implicit operator OneOrManyContentUrl (List<Uri> values) { return new OneOrManyContentUrl (values.Select(v => (IContentUrl) new ContentUrlUri (v))); }
        }
        public struct ContentUrlUri : IContentUrl<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public ContentUrlUri (Uri value) { Value = value; }
            public static implicit operator ContentUrlUri (Uri value) { return new ContentUrlUri (value); }
        }

        public interface IDuration : IValue {}
        public interface IDuration<T> : IDuration { new T Value { get; } }
        public class OneOrManyDuration : OneOrMany<IDuration>
        {
            public OneOrManyDuration(IDuration item) : base(item) { }
            public OneOrManyDuration(IEnumerable<IDuration> items) : base(items) { }
            public static implicit operator OneOrManyDuration (TimeSpan value) { return new OneOrManyDuration (new DurationTimeSpan (value)); }
            public static implicit operator OneOrManyDuration (TimeSpan[] values) { return new OneOrManyDuration (values.Select(v => (IDuration) new DurationTimeSpan (v))); }
            public static implicit operator OneOrManyDuration (List<TimeSpan> values) { return new OneOrManyDuration (values.Select(v => (IDuration) new DurationTimeSpan (v))); }
        }
        public struct DurationTimeSpan : IDuration<TimeSpan>
        {
            object IValue.Value => this.Value;
            public TimeSpan Value { get; }
            public DurationTimeSpan (TimeSpan value) { Value = value; }
            public static implicit operator DurationTimeSpan (TimeSpan value) { return new DurationTimeSpan (value); }
        }

        public interface IEmbedUrl : IValue {}
        public interface IEmbedUrl<T> : IEmbedUrl { new T Value { get; } }
        public class OneOrManyEmbedUrl : OneOrMany<IEmbedUrl>
        {
            public OneOrManyEmbedUrl(IEmbedUrl item) : base(item) { }
            public OneOrManyEmbedUrl(IEnumerable<IEmbedUrl> items) : base(items) { }
            public static implicit operator OneOrManyEmbedUrl (Uri value) { return new OneOrManyEmbedUrl (new EmbedUrlUri (value)); }
            public static implicit operator OneOrManyEmbedUrl (Uri[] values) { return new OneOrManyEmbedUrl (values.Select(v => (IEmbedUrl) new EmbedUrlUri (v))); }
            public static implicit operator OneOrManyEmbedUrl (List<Uri> values) { return new OneOrManyEmbedUrl (values.Select(v => (IEmbedUrl) new EmbedUrlUri (v))); }
        }
        public struct EmbedUrlUri : IEmbedUrl<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public EmbedUrlUri (Uri value) { Value = value; }
            public static implicit operator EmbedUrlUri (Uri value) { return new EmbedUrlUri (value); }
        }

        public interface IEncodesCreativeWork : IValue {}
        public interface IEncodesCreativeWork<T> : IEncodesCreativeWork { new T Value { get; } }
        public class OneOrManyEncodesCreativeWork : OneOrMany<IEncodesCreativeWork>
        {
            public OneOrManyEncodesCreativeWork(IEncodesCreativeWork item) : base(item) { }
            public OneOrManyEncodesCreativeWork(IEnumerable<IEncodesCreativeWork> items) : base(items) { }
            public static implicit operator OneOrManyEncodesCreativeWork (CreativeWork value) { return new OneOrManyEncodesCreativeWork (new EncodesCreativeWorkCreativeWork (value)); }
            public static implicit operator OneOrManyEncodesCreativeWork (CreativeWork[] values) { return new OneOrManyEncodesCreativeWork (values.Select(v => (IEncodesCreativeWork) new EncodesCreativeWorkCreativeWork (v))); }
            public static implicit operator OneOrManyEncodesCreativeWork (List<CreativeWork> values) { return new OneOrManyEncodesCreativeWork (values.Select(v => (IEncodesCreativeWork) new EncodesCreativeWorkCreativeWork (v))); }
        }
        public struct EncodesCreativeWorkCreativeWork : IEncodesCreativeWork<CreativeWork>
        {
            object IValue.Value => this.Value;
            public CreativeWork Value { get; }
            public EncodesCreativeWorkCreativeWork (CreativeWork value) { Value = value; }
            public static implicit operator EncodesCreativeWorkCreativeWork (CreativeWork value) { return new EncodesCreativeWorkCreativeWork (value); }
        }


        public interface IHeight : IValue {}
        public interface IHeight<T> : IHeight { new T Value { get; } }
        public class OneOrManyHeight : OneOrMany<IHeight>
        {
            public OneOrManyHeight(IHeight item) : base(item) { }
            public OneOrManyHeight(IEnumerable<IHeight> items) : base(items) { }
            public static implicit operator OneOrManyHeight (string value) { return new OneOrManyHeight (new Heightstring (value)); }
            public static implicit operator OneOrManyHeight (string[] values) { return new OneOrManyHeight (values.Select(v => (IHeight) new Heightstring (v))); }
            public static implicit operator OneOrManyHeight (List<string> values) { return new OneOrManyHeight (values.Select(v => (IHeight) new Heightstring (v))); }
            public static implicit operator OneOrManyHeight (QuantitativeValue value) { return new OneOrManyHeight (new HeightQuantitativeValue (value)); }
            public static implicit operator OneOrManyHeight (QuantitativeValue[] values) { return new OneOrManyHeight (values.Select(v => (IHeight) new HeightQuantitativeValue (v))); }
            public static implicit operator OneOrManyHeight (List<QuantitativeValue> values) { return new OneOrManyHeight (values.Select(v => (IHeight) new HeightQuantitativeValue (v))); }
            public static implicit operator OneOrManyHeight (int value) { return new OneOrManyHeight (new Heightint (value)); }
            public static implicit operator OneOrManyHeight (int[] values) { return new OneOrManyHeight (values.Select(v => (IHeight) new Heightint (v))); }
            public static implicit operator OneOrManyHeight (List<int> values) { return new OneOrManyHeight (values.Select(v => (IHeight) new Heightint (v))); }
        }
        public struct Heightstring : IHeight<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Heightstring (string value) { Value = value; }
            public static implicit operator Heightstring (string value) { return new Heightstring (value); }
        }
        public struct HeightQuantitativeValue : IHeight<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public HeightQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator HeightQuantitativeValue (QuantitativeValue value) { return new HeightQuantitativeValue (value); }
        }
        public struct Heightint : IHeight<int>
        {
            object IValue.Value => this.Value;
            public int Value { get; }
            public Heightint (int value) { Value = value; }
            public static implicit operator Heightint (int value) { return new Heightint (value); }
        }

        public interface IPlayerType : IValue {}
        public interface IPlayerType<T> : IPlayerType { new T Value { get; } }
        public class OneOrManyPlayerType : OneOrMany<IPlayerType>
        {
            public OneOrManyPlayerType(IPlayerType item) : base(item) { }
            public OneOrManyPlayerType(IEnumerable<IPlayerType> items) : base(items) { }
            public static implicit operator OneOrManyPlayerType (string value) { return new OneOrManyPlayerType (new PlayerTypestring (value)); }
            public static implicit operator OneOrManyPlayerType (string[] values) { return new OneOrManyPlayerType (values.Select(v => (IPlayerType) new PlayerTypestring (v))); }
            public static implicit operator OneOrManyPlayerType (List<string> values) { return new OneOrManyPlayerType (values.Select(v => (IPlayerType) new PlayerTypestring (v))); }
        }
        public struct PlayerTypestring : IPlayerType<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public PlayerTypestring (string value) { Value = value; }
            public static implicit operator PlayerTypestring (string value) { return new PlayerTypestring (value); }
        }

        public interface IProductionCompany : IValue {}
        public interface IProductionCompany<T> : IProductionCompany { new T Value { get; } }
        public class OneOrManyProductionCompany : OneOrMany<IProductionCompany>
        {
            public OneOrManyProductionCompany(IProductionCompany item) : base(item) { }
            public OneOrManyProductionCompany(IEnumerable<IProductionCompany> items) : base(items) { }
            public static implicit operator OneOrManyProductionCompany (Organization value) { return new OneOrManyProductionCompany (new ProductionCompanyOrganization (value)); }
            public static implicit operator OneOrManyProductionCompany (Organization[] values) { return new OneOrManyProductionCompany (values.Select(v => (IProductionCompany) new ProductionCompanyOrganization (v))); }
            public static implicit operator OneOrManyProductionCompany (List<Organization> values) { return new OneOrManyProductionCompany (values.Select(v => (IProductionCompany) new ProductionCompanyOrganization (v))); }
        }
        public struct ProductionCompanyOrganization : IProductionCompany<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public ProductionCompanyOrganization (Organization value) { Value = value; }
            public static implicit operator ProductionCompanyOrganization (Organization value) { return new ProductionCompanyOrganization (value); }
        }

        public interface IRegionsAllowed : IValue {}
        public interface IRegionsAllowed<T> : IRegionsAllowed { new T Value { get; } }
        public class OneOrManyRegionsAllowed : OneOrMany<IRegionsAllowed>
        {
            public OneOrManyRegionsAllowed(IRegionsAllowed item) : base(item) { }
            public OneOrManyRegionsAllowed(IEnumerable<IRegionsAllowed> items) : base(items) { }
            public static implicit operator OneOrManyRegionsAllowed (Place value) { return new OneOrManyRegionsAllowed (new RegionsAllowedPlace (value)); }
            public static implicit operator OneOrManyRegionsAllowed (Place[] values) { return new OneOrManyRegionsAllowed (values.Select(v => (IRegionsAllowed) new RegionsAllowedPlace (v))); }
            public static implicit operator OneOrManyRegionsAllowed (List<Place> values) { return new OneOrManyRegionsAllowed (values.Select(v => (IRegionsAllowed) new RegionsAllowedPlace (v))); }
        }
        public struct RegionsAllowedPlace : IRegionsAllowed<Place>
        {
            object IValue.Value => this.Value;
            public Place Value { get; }
            public RegionsAllowedPlace (Place value) { Value = value; }
            public static implicit operator RegionsAllowedPlace (Place value) { return new RegionsAllowedPlace (value); }
        }

        public interface IRequiresSubscription : IValue {}
        public interface IRequiresSubscription<T> : IRequiresSubscription { new T Value { get; } }
        public class OneOrManyRequiresSubscription : OneOrMany<IRequiresSubscription>
        {
            public OneOrManyRequiresSubscription(IRequiresSubscription item) : base(item) { }
            public OneOrManyRequiresSubscription(IEnumerable<IRequiresSubscription> items) : base(items) { }
            public static implicit operator OneOrManyRequiresSubscription (bool value) { return new OneOrManyRequiresSubscription (new RequiresSubscriptionbool (value)); }
            public static implicit operator OneOrManyRequiresSubscription (bool[] values) { return new OneOrManyRequiresSubscription (values.Select(v => (IRequiresSubscription) new RequiresSubscriptionbool (v))); }
            public static implicit operator OneOrManyRequiresSubscription (List<bool> values) { return new OneOrManyRequiresSubscription (values.Select(v => (IRequiresSubscription) new RequiresSubscriptionbool (v))); }
        }
        public struct RequiresSubscriptionbool : IRequiresSubscription<bool>
        {
            object IValue.Value => this.Value;
            public bool Value { get; }
            public RequiresSubscriptionbool (bool value) { Value = value; }
            public static implicit operator RequiresSubscriptionbool (bool value) { return new RequiresSubscriptionbool (value); }
        }

        public interface IUploadDate : IValue {}
        public interface IUploadDate<T> : IUploadDate { new T Value { get; } }
        public class OneOrManyUploadDate : OneOrMany<IUploadDate>
        {
            public OneOrManyUploadDate(IUploadDate item) : base(item) { }
            public OneOrManyUploadDate(IEnumerable<IUploadDate> items) : base(items) { }
            public static implicit operator OneOrManyUploadDate (DateTimeOffset value) { return new OneOrManyUploadDate (new UploadDateDateTimeOffset (value)); }
            public static implicit operator OneOrManyUploadDate (DateTimeOffset[] values) { return new OneOrManyUploadDate (values.Select(v => (IUploadDate) new UploadDateDateTimeOffset (v))); }
            public static implicit operator OneOrManyUploadDate (List<DateTimeOffset> values) { return new OneOrManyUploadDate (values.Select(v => (IUploadDate) new UploadDateDateTimeOffset (v))); }
        }
        public struct UploadDateDateTimeOffset : IUploadDate<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public UploadDateDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator UploadDateDateTimeOffset (DateTimeOffset value) { return new UploadDateDateTimeOffset (value); }
        }

        public interface IWidth : IValue {}
        public interface IWidth<T> : IWidth { new T Value { get; } }
        public class OneOrManyWidth : OneOrMany<IWidth>
        {
            public OneOrManyWidth(IWidth item) : base(item) { }
            public OneOrManyWidth(IEnumerable<IWidth> items) : base(items) { }
            public static implicit operator OneOrManyWidth (string value) { return new OneOrManyWidth (new Widthstring (value)); }
            public static implicit operator OneOrManyWidth (string[] values) { return new OneOrManyWidth (values.Select(v => (IWidth) new Widthstring (v))); }
            public static implicit operator OneOrManyWidth (List<string> values) { return new OneOrManyWidth (values.Select(v => (IWidth) new Widthstring (v))); }
            public static implicit operator OneOrManyWidth (QuantitativeValue value) { return new OneOrManyWidth (new WidthQuantitativeValue (value)); }
            public static implicit operator OneOrManyWidth (QuantitativeValue[] values) { return new OneOrManyWidth (values.Select(v => (IWidth) new WidthQuantitativeValue (v))); }
            public static implicit operator OneOrManyWidth (List<QuantitativeValue> values) { return new OneOrManyWidth (values.Select(v => (IWidth) new WidthQuantitativeValue (v))); }
            public static implicit operator OneOrManyWidth (int value) { return new OneOrManyWidth (new Widthint (value)); }
            public static implicit operator OneOrManyWidth (int[] values) { return new OneOrManyWidth (values.Select(v => (IWidth) new Widthint (v))); }
            public static implicit operator OneOrManyWidth (List<int> values) { return new OneOrManyWidth (values.Select(v => (IWidth) new Widthint (v))); }
        }
        public struct Widthstring : IWidth<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Widthstring (string value) { Value = value; }
            public static implicit operator Widthstring (string value) { return new Widthstring (value); }
        }
        public struct WidthQuantitativeValue : IWidth<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public WidthQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator WidthQuantitativeValue (QuantitativeValue value) { return new WidthQuantitativeValue (value); }
        }
        public struct Widthint : IWidth<int>
        {
            object IValue.Value => this.Value;
            public int Value { get; }
            public Widthint (int value) { Value = value; }
            public static implicit operator Widthint (int value) { return new Widthint (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MediaObject";

        /// <summary>
        /// A NewsArticle associated with the Media Object.
        /// </summary>
        [DataMember(Name = "associatedArticle", Order = 206)]
        public OneOrManyAssociatedArticle AssociatedArticle { get; set; }

        /// <summary>
        /// The bitrate of the media object.
        /// </summary>
        [DataMember(Name = "bitrate", Order = 207)]
        public OneOrManyBitrate Bitrate { get; set; }

        /// <summary>
        /// File size in (mega/kilo) bytes.
        /// </summary>
        [DataMember(Name = "contentSize", Order = 208)]
        public OneOrManyContentSize ContentSize { get; set; }

        /// <summary>
        /// Actual bytes of the media object, for example the image file or video file.
        /// </summary>
        [DataMember(Name = "contentUrl", Order = 209)]
        public OneOrManyContentUrl ContentUrl { get; set; }

        /// <summary>
        /// The duration of the item (movie, audio recording, event, etc.) in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "duration", Order = 210)]
        public OneOrManyDuration Duration { get; set; }

        /// <summary>
        /// A URL pointing to a player for a specific video. In general, this is the information in the &lt;code&gt;src&lt;/code&gt; element of an &lt;code&gt;embed&lt;/code&gt; tag and should not be the same as the content of the &lt;code&gt;loc&lt;/code&gt; tag.
        /// </summary>
        [DataMember(Name = "embedUrl", Order = 211)]
        public OneOrManyEmbedUrl EmbedUrl { get; set; }

        /// <summary>
        /// The CreativeWork encoded by this media object.
        /// </summary>
        [DataMember(Name = "encodesCreativeWork", Order = 212)]
        public OneOrManyEncodesCreativeWork EncodesCreativeWork { get; set; }

        /// <summary>
        /// Media type typically expressed using a MIME format (see &lt;a href="http://www.iana.org/assignments/media-types/media-types.xhtml"&gt;IANA site&lt;/a&gt; and &lt;a href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Basics_of_HTTP/MIME_types"&gt;MDN reference&lt;/a&gt;) e.g. application/zip for a SoftwareApplication binary, audio/mpeg for .mp3 etc.).&lt;br/&gt;&lt;br/&gt;
        /// In cases where a &lt;a class="localLink" href="http://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt; has several media type representations, &lt;a class="localLink" href="http://schema.org/encoding"&gt;encoding&lt;/a&gt; can be used to indicate each &lt;a class="localLink" href="http://schema.org/MediaObject"&gt;MediaObject&lt;/a&gt; alongside particular &lt;a class="localLink" href="http://schema.org/encodingFormat"&gt;encodingFormat&lt;/a&gt; information.&lt;br/&gt;&lt;br/&gt;
        /// Unregistered or niche encoding and file formats can be indicated instead via the most appropriate URL, e.g. defining Web page or a Wikipedia/Wikidata entry.
        /// </summary>
        [DataMember(Name = "encodingFormat", Order = 213)]
        public override OneOrManyEncodingFormat EncodingFormat { get; set; }

        /// <summary>
        /// The height of the item.
        /// </summary>
        [DataMember(Name = "height", Order = 214)]
        public OneOrManyHeight Height { get; set; }

        /// <summary>
        /// Player type required&amp;#x2014;for example, Flash or Silverlight.
        /// </summary>
        [DataMember(Name = "playerType", Order = 215)]
        public OneOrManyPlayerType PlayerType { get; set; }

        /// <summary>
        /// The production company or studio responsible for the item e.g. series, video game, episode etc.
        /// </summary>
        [DataMember(Name = "productionCompany", Order = 216)]
        public OneOrManyProductionCompany ProductionCompany { get; set; }

        /// <summary>
        /// The regions where the media is allowed. If not specified, then it's assumed to be allowed everywhere. Specify the countries in &lt;a href="http://en.wikipedia.org/wiki/ISO_3166"&gt;ISO 3166 format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "regionsAllowed", Order = 217)]
        public OneOrManyRegionsAllowed RegionsAllowed { get; set; }

        /// <summary>
        /// Indicates if use of the media require a subscription  (either paid or free). Allowed values are &lt;code&gt;true&lt;/code&gt; or &lt;code&gt;false&lt;/code&gt; (note that an earlier version had 'yes', 'no').
        /// </summary>
        [DataMember(Name = "requiresSubscription", Order = 218)]
        public OneOrManyRequiresSubscription RequiresSubscription { get; set; }

        /// <summary>
        /// Date when this media object was uploaded to this site.
        /// </summary>
        [DataMember(Name = "uploadDate", Order = 219)]
        public OneOrManyUploadDate UploadDate { get; set; }

        /// <summary>
        /// The width of the item.
        /// </summary>
        [DataMember(Name = "width", Order = 220)]
        public OneOrManyWidth Width { get; set; }
    }
}
