using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// An instance of a &lt;a class="localLink" href="http://schema.org/Course"&gt;Course&lt;/a&gt; which is distinct from other instances because it is offered at a different time or location or through different media or modes of study or to a specific section of students.
    /// </summary>
    [DataContract]
    public partial class CourseInstance : Event
    {
        public interface ICourseMode : IWrapper { }
        public interface ICourseMode<T> : ICourseMode { new T Data { get; set; } }
        public class CourseModestring : ICourseMode<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public CourseModestring () { }
            public CourseModestring (string data) { Data = data; }
            public static implicit operator CourseModestring (string data) { return new CourseModestring (data); }
        }

        public class CourseModeUri : ICourseMode<Uri>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Uri) value; } }
            public virtual Uri Data { get; set; }
            public CourseModeUri () { }
            public CourseModeUri (Uri data) { Data = data; }
            public static implicit operator CourseModeUri (Uri data) { return new CourseModeUri (data); }
        }


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
        public Values<ICourseMode>? CourseMode { get; set; } //string, Uri

        /// <summary>
        /// A person assigned to instruct or provide instructional assistance for the &lt;a class="localLink" href="http://schema.org/CourseInstance"&gt;CourseInstance&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "instructor", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person>? Instructor { get; set; } 
    }
}
