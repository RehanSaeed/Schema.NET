namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An instance of a &lt;a class="localLink" href="http://schema.org/Course"&gt;Course&lt;/a&gt; which is distinct from other instances because it is offered at a different time or location or through different media or modes of study or to a specific section of students.
    /// </summary>
    [DataContract]
    public partial class CourseInstance : Event
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
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, Uri>? CourseMode { get; set; }

        /// <summary>
        /// A person assigned to instruct or provide instructional assistance for the &lt;a class="localLink" href="http://schema.org/CourseInstance"&gt;CourseInstance&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "instructor", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<Person>? Instructor { get; set; }
    }
}
