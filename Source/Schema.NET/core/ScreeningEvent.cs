namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A screening of a movie or other video.
    /// </summary>
    [DataContract]
    public partial class ScreeningEvent : Event
    {
        public interface ISubtitleLanguage : IValue {}
        public interface ISubtitleLanguage<T> : ISubtitleLanguage { new T Value { get; } }
        public class OneOrManySubtitleLanguage : OneOrMany<ISubtitleLanguage>
        {
            public OneOrManySubtitleLanguage(ISubtitleLanguage item) : base(item) { }
            public OneOrManySubtitleLanguage(IEnumerable<ISubtitleLanguage> items) : base(items) { }
            public static implicit operator OneOrManySubtitleLanguage (Language value) { return new OneOrManySubtitleLanguage (new SubtitleLanguageLanguage (value)); }
            public static implicit operator OneOrManySubtitleLanguage (Language[] values) { return new OneOrManySubtitleLanguage (values.Select(v => (ISubtitleLanguage) new SubtitleLanguageLanguage (v))); }
            public static implicit operator OneOrManySubtitleLanguage (List<Language> values) { return new OneOrManySubtitleLanguage (values.Select(v => (ISubtitleLanguage) new SubtitleLanguageLanguage (v))); }
            public static implicit operator OneOrManySubtitleLanguage (string value) { return new OneOrManySubtitleLanguage (new SubtitleLanguagestring (value)); }
            public static implicit operator OneOrManySubtitleLanguage (string[] values) { return new OneOrManySubtitleLanguage (values.Select(v => (ISubtitleLanguage) new SubtitleLanguagestring (v))); }
            public static implicit operator OneOrManySubtitleLanguage (List<string> values) { return new OneOrManySubtitleLanguage (values.Select(v => (ISubtitleLanguage) new SubtitleLanguagestring (v))); }
        }
        public struct SubtitleLanguageLanguage : ISubtitleLanguage<Language>
        {
            object IValue.Value => this.Value;
            public Language Value { get; }
            public SubtitleLanguageLanguage (Language value) { Value = value; }
            public static implicit operator SubtitleLanguageLanguage (Language value) { return new SubtitleLanguageLanguage (value); }
        }
        public struct SubtitleLanguagestring : ISubtitleLanguage<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public SubtitleLanguagestring (string value) { Value = value; }
            public static implicit operator SubtitleLanguagestring (string value) { return new SubtitleLanguagestring (value); }
        }

        public interface IVideoFormat : IValue {}
        public interface IVideoFormat<T> : IVideoFormat { new T Value { get; } }
        public class OneOrManyVideoFormat : OneOrMany<IVideoFormat>
        {
            public OneOrManyVideoFormat(IVideoFormat item) : base(item) { }
            public OneOrManyVideoFormat(IEnumerable<IVideoFormat> items) : base(items) { }
            public static implicit operator OneOrManyVideoFormat (string value) { return new OneOrManyVideoFormat (new VideoFormatstring (value)); }
            public static implicit operator OneOrManyVideoFormat (string[] values) { return new OneOrManyVideoFormat (values.Select(v => (IVideoFormat) new VideoFormatstring (v))); }
            public static implicit operator OneOrManyVideoFormat (List<string> values) { return new OneOrManyVideoFormat (values.Select(v => (IVideoFormat) new VideoFormatstring (v))); }
        }
        public struct VideoFormatstring : IVideoFormat<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public VideoFormatstring (string value) { Value = value; }
            public static implicit operator VideoFormatstring (string value) { return new VideoFormatstring (value); }
        }

        public interface IWorkPresented : IValue {}
        public interface IWorkPresented<T> : IWorkPresented { new T Value { get; } }
        public class OneOrManyWorkPresented : OneOrMany<IWorkPresented>
        {
            public OneOrManyWorkPresented(IWorkPresented item) : base(item) { }
            public OneOrManyWorkPresented(IEnumerable<IWorkPresented> items) : base(items) { }
            public static implicit operator OneOrManyWorkPresented (Movie value) { return new OneOrManyWorkPresented (new WorkPresentedMovie (value)); }
            public static implicit operator OneOrManyWorkPresented (Movie[] values) { return new OneOrManyWorkPresented (values.Select(v => (IWorkPresented) new WorkPresentedMovie (v))); }
            public static implicit operator OneOrManyWorkPresented (List<Movie> values) { return new OneOrManyWorkPresented (values.Select(v => (IWorkPresented) new WorkPresentedMovie (v))); }
        }
        public struct WorkPresentedMovie : IWorkPresented<Movie>
        {
            object IValue.Value => this.Value;
            public Movie Value { get; }
            public WorkPresentedMovie (Movie value) { Value = value; }
            public static implicit operator WorkPresentedMovie (Movie value) { return new WorkPresentedMovie (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ScreeningEvent";

        /// <summary>
        /// Languages in which subtitles/captions are available, in &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "subtitleLanguage", Order = 206)]
        public OneOrManySubtitleLanguage SubtitleLanguage { get; set; }

        /// <summary>
        /// The type of screening or video broadcast used (e.g. IMAX, 3D, SD, HD, etc.).
        /// </summary>
        [DataMember(Name = "videoFormat", Order = 207)]
        public OneOrManyVideoFormat VideoFormat { get; set; }

        /// <summary>
        /// The movie presented during this event.
        /// </summary>
        [DataMember(Name = "workPresented", Order = 208)]
        public OneOrManyWorkPresented WorkPresented { get; set; }
    }
}
