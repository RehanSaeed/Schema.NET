namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// An audio file.
    /// </summary>
    [DataContract]
    public partial class AudioObject : MediaObject
    {
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

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AudioObject";

        /// <summary>
        /// If this MediaObject is an AudioObject or VideoObject, the transcript of that object.
        /// </summary>
        [DataMember(Name = "transcript", Order = 306)]
        public OneOrManyTranscript Transcript { get; set; }
    }
}
