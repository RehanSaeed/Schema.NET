namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An audiobook.
    /// </summary>
    public partial interface IAudiobook : IAudioObjectAndBook
    {
        /// <summary>
        /// A person who reads (performs) the audiobook.
        /// </summary>
        OneOrMany<IPerson> ReadBy { get; set; }
    }

    /// <summary>
    /// An audiobook.
    /// </summary>
    [DataContract]
    public partial class Audiobook : AudioObjectAndBook, IAudiobook, IEquatable<Audiobook>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Audiobook";

        /// <summary>
        /// The duration of the item (movie, audio recording, event, etc.) in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "duration", Order = 406)]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesJsonConverter))]
        public override OneOrMany<TimeSpan?> Duration { get; set; }

        /// <summary>
        /// A person who reads (performs) the audiobook.
        /// </summary>
        [DataMember(Name = "readBy", Order = 407)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> ReadBy { get; set; }

        /// <inheritdoc/>
        public bool Equals(Audiobook other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Type == other.Type &&
                this.Duration == other.Duration &&
                this.ReadBy == other.ReadBy &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as Audiobook);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.Duration)
            .And(this.ReadBy)
            .And(base.GetHashCode());
    }
}
