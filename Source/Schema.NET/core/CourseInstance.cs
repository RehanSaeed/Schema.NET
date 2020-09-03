namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An instance of a &lt;a class="localLink" href="https://schema.org/Course"&gt;Course&lt;/a&gt; which is distinct from other instances because it is offered at a different time or location or through different media or modes of study or to a specific section of students.
    /// </summary>
    public partial interface ICourseInstance : IEvent
    {
        /// <summary>
        /// The medium or means of delivery of the course instance or the mode of study, either as a text label (e.g. "online", "onsite" or "blended"; "synchronous" or "asynchronous"; "full-time" or "part-time") or as a URL reference to a term from a controlled vocabulary (e.g. https://ceds.ed.gov/element/001311#Asynchronous ).
        /// </summary>
        Values<string, Uri> CourseMode { get; set; }

        /// <summary>
        /// The amount of work expected of students taking the course, often provided as a figure per week or per month, and may be broken down by type. For example, "2 hours of lectures, 1 hour of lab work and 3 hours of independent study per week".
        /// </summary>
        OneOrMany<string> CourseWorkload { get; set; }

        /// <summary>
        /// A person assigned to instruct or provide instructional assistance for the &lt;a class="localLink" href="https://schema.org/CourseInstance"&gt;CourseInstance&lt;/a&gt;.
        /// </summary>
        OneOrMany<IPerson> Instructor { get; set; }
    }

    /// <summary>
    /// An instance of a &lt;a class="localLink" href="https://schema.org/Course"&gt;Course&lt;/a&gt; which is distinct from other instances because it is offered at a different time or location or through different media or modes of study or to a specific section of students.
    /// </summary>
    [DataContract]
    public partial class CourseInstance : Event, ICourseInstance, IEquatable<CourseInstance>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "CourseInstance";

        /// <summary>
        /// The medium or means of delivery of the course instance or the mode of study, either as a text label (e.g. "online", "onsite" or "blended"; "synchronous" or "asynchronous"; "full-time" or "part-time") or as a URL reference to a term from a controlled vocabulary (e.g. https://ceds.ed.gov/element/001311#Asynchronous ).
        /// </summary>
        [DataMember(Name = "courseMode", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> CourseMode { get; set; }

        /// <summary>
        /// The amount of work expected of students taking the course, often provided as a figure per week or per month, and may be broken down by type. For example, "2 hours of lectures, 1 hour of lab work and 3 hours of independent study per week".
        /// </summary>
        [DataMember(Name = "courseWorkload", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> CourseWorkload { get; set; }

        /// <summary>
        /// A person assigned to instruct or provide instructional assistance for the &lt;a class="localLink" href="https://schema.org/CourseInstance"&gt;CourseInstance&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "instructor", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Instructor { get; set; }

        /// <inheritdoc/>
        public bool Equals(CourseInstance other)
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
                this.CourseMode == other.CourseMode &&
                this.CourseWorkload == other.CourseWorkload &&
                this.Instructor == other.Instructor &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as CourseInstance);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.CourseMode)
            .And(this.CourseWorkload)
            .And(this.Instructor)
            .And(base.GetHashCode());
    }
}
