namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A video file.
    /// </summary>
    [DataContract]
    public partial class VideoObject : MediaObject
    {
        public interface IActor : IValue {}
        public interface IActor<T> : IActor { new T Value { get; } }
        public class OneOrManyActor : OneOrMany<IActor>
        {
            public OneOrManyActor(IActor item) : base(item) { }
            public OneOrManyActor(IEnumerable<IActor> items) : base(items) { }
            public static implicit operator OneOrManyActor (Person value) { return new OneOrManyActor (new ActorPerson (value)); }
            public static implicit operator OneOrManyActor (Person[] values) { return new OneOrManyActor (values.Select(v => (IActor) new ActorPerson (v))); }
            public static implicit operator OneOrManyActor (List<Person> values) { return new OneOrManyActor (values.Select(v => (IActor) new ActorPerson (v))); }
        }
        public struct ActorPerson : IActor<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public ActorPerson (Person value) { Value = value; }
            public static implicit operator ActorPerson (Person value) { return new ActorPerson (value); }
        }

        public interface ICaption : IValue {}
        public interface ICaption<T> : ICaption { new T Value { get; } }
        public class OneOrManyCaption : OneOrMany<ICaption>
        {
            public OneOrManyCaption(ICaption item) : base(item) { }
            public OneOrManyCaption(IEnumerable<ICaption> items) : base(items) { }
            public static implicit operator OneOrManyCaption (string value) { return new OneOrManyCaption (new Captionstring (value)); }
            public static implicit operator OneOrManyCaption (string[] values) { return new OneOrManyCaption (values.Select(v => (ICaption) new Captionstring (v))); }
            public static implicit operator OneOrManyCaption (List<string> values) { return new OneOrManyCaption (values.Select(v => (ICaption) new Captionstring (v))); }
        }
        public struct Captionstring : ICaption<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Captionstring (string value) { Value = value; }
            public static implicit operator Captionstring (string value) { return new Captionstring (value); }
        }

        public interface IDirector : IValue {}
        public interface IDirector<T> : IDirector { new T Value { get; } }
        public class OneOrManyDirector : OneOrMany<IDirector>
        {
            public OneOrManyDirector(IDirector item) : base(item) { }
            public OneOrManyDirector(IEnumerable<IDirector> items) : base(items) { }
            public static implicit operator OneOrManyDirector (Person value) { return new OneOrManyDirector (new DirectorPerson (value)); }
            public static implicit operator OneOrManyDirector (Person[] values) { return new OneOrManyDirector (values.Select(v => (IDirector) new DirectorPerson (v))); }
            public static implicit operator OneOrManyDirector (List<Person> values) { return new OneOrManyDirector (values.Select(v => (IDirector) new DirectorPerson (v))); }
        }
        public struct DirectorPerson : IDirector<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public DirectorPerson (Person value) { Value = value; }
            public static implicit operator DirectorPerson (Person value) { return new DirectorPerson (value); }
        }

        public interface IMusicBy : IValue {}
        public interface IMusicBy<T> : IMusicBy { new T Value { get; } }
        public class OneOrManyMusicBy : OneOrMany<IMusicBy>
        {
            public OneOrManyMusicBy(IMusicBy item) : base(item) { }
            public OneOrManyMusicBy(IEnumerable<IMusicBy> items) : base(items) { }
            public static implicit operator OneOrManyMusicBy (MusicGroup value) { return new OneOrManyMusicBy (new MusicByMusicGroup (value)); }
            public static implicit operator OneOrManyMusicBy (MusicGroup[] values) { return new OneOrManyMusicBy (values.Select(v => (IMusicBy) new MusicByMusicGroup (v))); }
            public static implicit operator OneOrManyMusicBy (List<MusicGroup> values) { return new OneOrManyMusicBy (values.Select(v => (IMusicBy) new MusicByMusicGroup (v))); }
            public static implicit operator OneOrManyMusicBy (Person value) { return new OneOrManyMusicBy (new MusicByPerson (value)); }
            public static implicit operator OneOrManyMusicBy (Person[] values) { return new OneOrManyMusicBy (values.Select(v => (IMusicBy) new MusicByPerson (v))); }
            public static implicit operator OneOrManyMusicBy (List<Person> values) { return new OneOrManyMusicBy (values.Select(v => (IMusicBy) new MusicByPerson (v))); }
        }
        public struct MusicByMusicGroup : IMusicBy<MusicGroup>
        {
            object IValue.Value => this.Value;
            public MusicGroup Value { get; }
            public MusicByMusicGroup (MusicGroup value) { Value = value; }
            public static implicit operator MusicByMusicGroup (MusicGroup value) { return new MusicByMusicGroup (value); }
        }
        public struct MusicByPerson : IMusicBy<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public MusicByPerson (Person value) { Value = value; }
            public static implicit operator MusicByPerson (Person value) { return new MusicByPerson (value); }
        }

        public interface IThumbnail : IValue {}
        public interface IThumbnail<T> : IThumbnail { new T Value { get; } }
        public class OneOrManyThumbnail : OneOrMany<IThumbnail>
        {
            public OneOrManyThumbnail(IThumbnail item) : base(item) { }
            public OneOrManyThumbnail(IEnumerable<IThumbnail> items) : base(items) { }
            public static implicit operator OneOrManyThumbnail (ImageObject value) { return new OneOrManyThumbnail (new ThumbnailImageObject (value)); }
            public static implicit operator OneOrManyThumbnail (ImageObject[] values) { return new OneOrManyThumbnail (values.Select(v => (IThumbnail) new ThumbnailImageObject (v))); }
            public static implicit operator OneOrManyThumbnail (List<ImageObject> values) { return new OneOrManyThumbnail (values.Select(v => (IThumbnail) new ThumbnailImageObject (v))); }
        }
        public struct ThumbnailImageObject : IThumbnail<ImageObject>
        {
            object IValue.Value => this.Value;
            public ImageObject Value { get; }
            public ThumbnailImageObject (ImageObject value) { Value = value; }
            public static implicit operator ThumbnailImageObject (ImageObject value) { return new ThumbnailImageObject (value); }
        }

        public interface ITranscript : IValue {}
        public interface ITranscript<T> : ITranscript { new T Value { get; } }
        public class OneOrManyTranscript : OneOrMany<ITranscript>
        {
            public OneOrManyTranscript(ITranscript item) : base(item) { }
            public OneOrManyTranscript(IEnumerable<ITranscript> items) : base(items) { }
            public static implicit operator OneOrManyTranscript (string value) { return new OneOrManyTranscript (new Transcriptstring (value)); }
            public static implicit operator OneOrManyTranscript (string[] values) { return new OneOrManyTranscript (values.Select(v => (ITranscript) new Transcriptstring (v))); }
            public static implicit operator OneOrManyTranscript (List<string> values) { return new OneOrManyTranscript (values.Select(v => (ITranscript) new Transcriptstring (v))); }
        }
        public struct Transcriptstring : ITranscript<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Transcriptstring (string value) { Value = value; }
            public static implicit operator Transcriptstring (string value) { return new Transcriptstring (value); }
        }

        public interface IVideoFrameSize : IValue {}
        public interface IVideoFrameSize<T> : IVideoFrameSize { new T Value { get; } }
        public class OneOrManyVideoFrameSize : OneOrMany<IVideoFrameSize>
        {
            public OneOrManyVideoFrameSize(IVideoFrameSize item) : base(item) { }
            public OneOrManyVideoFrameSize(IEnumerable<IVideoFrameSize> items) : base(items) { }
            public static implicit operator OneOrManyVideoFrameSize (string value) { return new OneOrManyVideoFrameSize (new VideoFrameSizestring (value)); }
            public static implicit operator OneOrManyVideoFrameSize (string[] values) { return new OneOrManyVideoFrameSize (values.Select(v => (IVideoFrameSize) new VideoFrameSizestring (v))); }
            public static implicit operator OneOrManyVideoFrameSize (List<string> values) { return new OneOrManyVideoFrameSize (values.Select(v => (IVideoFrameSize) new VideoFrameSizestring (v))); }
        }
        public struct VideoFrameSizestring : IVideoFrameSize<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public VideoFrameSizestring (string value) { Value = value; }
            public static implicit operator VideoFrameSizestring (string value) { return new VideoFrameSizestring (value); }
        }

        public interface IVideoQuality : IValue {}
        public interface IVideoQuality<T> : IVideoQuality { new T Value { get; } }
        public class OneOrManyVideoQuality : OneOrMany<IVideoQuality>
        {
            public OneOrManyVideoQuality(IVideoQuality item) : base(item) { }
            public OneOrManyVideoQuality(IEnumerable<IVideoQuality> items) : base(items) { }
            public static implicit operator OneOrManyVideoQuality (string value) { return new OneOrManyVideoQuality (new VideoQualitystring (value)); }
            public static implicit operator OneOrManyVideoQuality (string[] values) { return new OneOrManyVideoQuality (values.Select(v => (IVideoQuality) new VideoQualitystring (v))); }
            public static implicit operator OneOrManyVideoQuality (List<string> values) { return new OneOrManyVideoQuality (values.Select(v => (IVideoQuality) new VideoQualitystring (v))); }
        }
        public struct VideoQualitystring : IVideoQuality<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public VideoQualitystring (string value) { Value = value; }
            public static implicit operator VideoQualitystring (string value) { return new VideoQualitystring (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "VideoObject";

        /// <summary>
        /// An actor, e.g. in tv, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "actor", Order = 306)]
        public OneOrManyActor Actor { get; set; }

        /// <summary>
        /// The caption for this object.
        /// </summary>
        [DataMember(Name = "caption", Order = 307)]
        public OneOrManyCaption Caption { get; set; }

        /// <summary>
        /// A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "director", Order = 308)]
        public OneOrManyDirector Director { get; set; }

        /// <summary>
        /// The composer of the soundtrack.
        /// </summary>
        [DataMember(Name = "musicBy", Order = 309)]
        public OneOrManyMusicBy MusicBy { get; set; }

        /// <summary>
        /// Thumbnail image for an image or video.
        /// </summary>
        [DataMember(Name = "thumbnail", Order = 310)]
        public OneOrManyThumbnail Thumbnail { get; set; }

        /// <summary>
        /// If this MediaObject is an AudioObject or VideoObject, the transcript of that object.
        /// </summary>
        [DataMember(Name = "transcript", Order = 311)]
        public OneOrManyTranscript Transcript { get; set; }

        /// <summary>
        /// The frame size of the video.
        /// </summary>
        [DataMember(Name = "videoFrameSize", Order = 312)]
        public OneOrManyVideoFrameSize VideoFrameSize { get; set; }

        /// <summary>
        /// The quality of the video.
        /// </summary>
        [DataMember(Name = "videoQuality", Order = 313)]
        public OneOrManyVideoQuality VideoQuality { get; set; }
    }
}
